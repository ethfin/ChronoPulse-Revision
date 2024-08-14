Imports System.IO
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.Diagnostics

Public Class frmGames

    Private trackingTimer As Timer
    Private trackedApps As New Dictionary(Of String, DateTime)
    Private totalElapsedTimes As New Dictionary(Of String, TimeSpan)

    Private Sub frmGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure ListView
        ListViewApps.View = View.LargeIcon
        ListViewApps.LargeImageList = ImageList

        ' Configure ListViewTrackApp
        ListViewTrackApp.View = View.Details
        ListViewTrackApp.Columns.Add("Application", 250)
        ListViewTrackApp.Columns.Add("Elapsed Time", 200)
        ListViewTrackApp.Columns.Add("Last Used", 250) ' Add Last Used column

        ' Load saved game paths from the database
        LoadGamePaths()

        ' Load existing app usage records
        LoadAppUsageRecords()

        ' Initialize and start the tracking timer
        trackingTimer = New Timer()
        AddHandler trackingTimer.Tick, AddressOf UpdateTrackedApps
        trackingTimer.Interval = 1000 ' 1 second
        trackingTimer.Start()
    End Sub

    Private Sub LoadAppUsageRecords()
        Dim query As String = "SELECT ApplicationName, ElapsedTime, LastUsed FROM app_usage WHERE UserID = @UserID"
        Using connection As MySqlConnection = Common.createDBConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", AccountData.UserID)

                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim appName As String = reader("ApplicationName").ToString()
                        Dim elapsedTimeInSeconds As Integer = Convert.ToInt32(reader("ElapsedTime"))
                        Dim lastUsed As DateTime = Convert.ToDateTime(reader("LastUsed"))

                        Dim elapsedTime As TimeSpan = TimeSpan.FromSeconds(elapsedTimeInSeconds)

                        ' Add the record to the ListViewTrackApp
                        Dim trackItem As New ListViewItem(appName)
                        trackItem.SubItems.Add(elapsedTime.ToString("hh\:mm\:ss"))
                        trackItem.SubItems.Add(lastUsed.ToString("yyyy-MM-dd HH:mm:ss"))
                        ListViewTrackApp.Items.Add(trackItem)

                        ' Add the record to the dictionaries
                        totalElapsedTimes(appName) = elapsedTime
                        trackedApps(appName) = lastUsed
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub btnAddFiles_Click(sender As Object, e As EventArgs) Handles btnAddFiles.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Executable Files|*.exe"
            openFileDialog.Multiselect = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                For Each filePath In openFileDialog.FileNames
                    ' Check if the application already exists in the ListView
                    Dim exists As Boolean = False
                    For Each item As ListViewItem In ListViewApps.Items
                        If item.Tag.ToString() = filePath Then
                            exists = True
                            Exit For
                        End If
                    Next

                    If Not exists Then
                        ' Extract icon from the .exe file
                        Dim icon As Icon = Icon.ExtractAssociatedIcon(filePath)
                        ImageList.Images.Add(icon)

                        ' Add file path and icon to ListView
                        Dim item As New ListViewItem(Path.GetFileName(filePath))
                        item.ImageIndex = ImageList.Images.Count - 1
                        item.Tag = filePath
                        ListViewApps.Items.Add(item)

                        ' Save the game path to the database
                        SaveGamePath(Path.GetFileName(filePath), filePath)
                    End If
                Next
            End If
        End Using
    End Sub

    Private Sub SaveGamePath(gameName As String, exePath As String)
        Dim query As String = "INSERT INTO game_paths (UserID, game_name, exe_path, date_added) VALUES (@UserID, @GameName, @ExePath, @DateAdded)"
        Using connection As MySqlConnection = Common.createDBConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", AccountData.UserID)
                command.Parameters.AddWithValue("@GameName", gameName)
                command.Parameters.AddWithValue("@ExePath", exePath)
                command.Parameters.AddWithValue("@DateAdded", DateTime.Now)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub LoadGamePaths()
        Dim query As String = "SELECT game_name, exe_path FROM game_paths WHERE UserID = @UserID"
        Using connection As MySqlConnection = Common.createDBConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", AccountData.UserID)

                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim gameName As String = reader("game_name").ToString()
                        Dim exePath As String = reader("exe_path").ToString()

                        ' Extract icon from the .exe file
                        Dim icon As Icon = Icon.ExtractAssociatedIcon(exePath)
                        ImageList.Images.Add(icon)

                        ' Add file path and icon to ListView
                        Dim item As New ListViewItem(Path.GetFileNameWithoutExtension(gameName))
                        item.ImageIndex = ImageList.Images.Count - 1
                        item.Tag = exePath
                        ListViewApps.Items.Add(item)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnDeleteFiles_Click(sender As Object, e As EventArgs) Handles btnDeleteFiles.Click
        If ListViewApps.SelectedItems.Count > 0 Then
            For Each selectedItem As ListViewItem In ListViewApps.SelectedItems
                Dim exePath As String = selectedItem.Tag.ToString()

                ' Remove the item from the ListView
                ListViewApps.Items.Remove(selectedItem)

                ' Delete the game path from the database
                DeleteGamePath(exePath)
            Next
        End If
    End Sub

    Private Sub DeleteGamePath(exePath As String)
        Dim query As String = "DELETE FROM game_paths WHERE UserID = @UserID AND exe_path = @ExePath"
        Using connection As MySqlConnection = Common.createDBConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", AccountData.UserID)
                command.Parameters.AddWithValue("@ExePath", exePath)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub UpdateTrackedApps(sender As Object, e As EventArgs)
        For Each item As ListViewItem In ListViewApps.Items
            Dim exePath As String = item.Tag.ToString()
            Dim processName As String = Path.GetFileNameWithoutExtension(exePath)

            Dim runningProcess As Process = Process.GetProcessesByName(processName).FirstOrDefault()
            If runningProcess IsNot Nothing Then
                If Not trackedApps.ContainsKey(processName) Then
                    trackedApps(processName) = DateTime.Now
                End If

                Dim elapsedTime As TimeSpan = DateTime.Now - trackedApps(processName)
                If totalElapsedTimes.ContainsKey(processName) Then
                    totalElapsedTimes(processName) += elapsedTime
                Else
                    totalElapsedTimes(processName) = elapsedTime
                End If

                Dim trackItem As ListViewItem = ListViewTrackApp.Items.Cast(Of ListViewItem)().FirstOrDefault(Function(i) i.Text = processName)
                If trackItem Is Nothing Then
                    trackItem = New ListViewItem(processName)
                    trackItem.SubItems.Add(totalElapsedTimes(processName).ToString("hh\:mm\:ss"))
                    trackItem.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) ' Add Last Used time
                    ListViewTrackApp.Items.Add(trackItem)
                Else
                    trackItem.SubItems(1).Text = totalElapsedTimes(processName).ToString("hh\:mm\:ss")
                    trackItem.SubItems(2).Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ' Update Last Used time
                End If

                trackedApps(processName) = DateTime.Now
            Else
                If trackedApps.ContainsKey(processName) Then
                    ' Update the database with the elapsed time and last used time
                    If AppUsageExists(AccountData.UserID, processName) Then
                        UpdateAppUsage(AccountData.UserID, processName, totalElapsedTimes(processName), trackedApps(processName))
                    Else
                        InsertAppUsage(AccountData.UserID, processName, totalElapsedTimes(processName), trackedApps(processName))
                    End If

                    ' Remove the application from the trackedApps dictionary
                    trackedApps.Remove(processName)
                End If
            End If
        Next
    End Sub

    Private Sub InsertAppUsage(userID As String, appName As String, elapsedTime As TimeSpan, lastUsed As DateTime)
        Dim elapsedTimeInSeconds As Integer = Convert.ToInt32(elapsedTime.TotalSeconds)
        Dim query As String = "INSERT INTO app_usage (UserID, ApplicationName, ElapsedTime, LastUsed) VALUES (@UserID, @AppName, @ElapsedTime, @LastUsed)"

        If Not String.IsNullOrEmpty(userID) Then
            Using connection As MySqlConnection = Common.createDBConnection()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)
                    command.Parameters.AddWithValue("@AppName", appName)
                    command.Parameters.AddWithValue("@ElapsedTime", elapsedTimeInSeconds)
                    command.Parameters.AddWithValue("@LastUsed", lastUsed)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            ' Cancel the operation
            Return
        End If
    End Sub

    Private Sub UpdateAppUsage(userID As String, appName As String, elapsedTime As TimeSpan, lastUsed As DateTime)
        Dim elapsedTimeInSeconds As Integer = Convert.ToInt32(elapsedTime.TotalSeconds)
        Dim query As String = "UPDATE app_usage SET ElapsedTime = @ElapsedTime, LastUsed = @LastUsed WHERE UserID = @UserID AND ApplicationName = @AppName"

        ' Check if UserID is accessible and not empty
        If Not String.IsNullOrEmpty(userID) Then
            Using connection As MySqlConnection = Common.createDBConnection()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)
                    command.Parameters.AddWithValue("@AppName", appName)
                    command.Parameters.AddWithValue("@ElapsedTime", elapsedTimeInSeconds)
                    command.Parameters.AddWithValue("@LastUsed", lastUsed)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            ' Cancel the operation
            Return
        End If
    End Sub


    Private Function AppUsageExists(userID As String, appName As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM app_usage WHERE UserID = @UserID AND ApplicationName = @AppName"
        Using connection As MySqlConnection = Common.createDBConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@AppName", appName)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub ListViewApps_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewApps.MouseClick
        If e.Button = MouseButtons.Right Then
            ListViewAppsContext.Show(ListViewApps, e.Location)
        End If
    End Sub

    Private Sub AddApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddApplicationToolStripMenuItem.Click
        ' Add your code here to handle the "Add Application" option
        ' For example, you can open a file dialog to select an application and add it to the ListViewApps
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Executable Files|*.exe"
            openFileDialog.Multiselect = False

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName

                ' Check if the application already exists in the ListView
                Dim exists As Boolean = False
                For Each item As ListViewItem In ListViewApps.Items
                    If item.Tag.ToString() = filePath Then
                        exists = True
                        Exit For
                    End If
                Next

                If Not exists Then
                    ' Extract icon from the .exe file
                    Dim icon As Icon = Icon.ExtractAssociatedIcon(filePath)
                    ImageList.Images.Add(icon)

                    ' Add file path and icon to ListView
                    Dim item As New ListViewItem(Path.GetFileName(filePath))
                    item.ImageIndex = ImageList.Images.Count - 1
                    item.Tag = filePath
                    ListViewApps.Items.Add(item)

                    ' Save the game path to the database
                    SaveGamePath(Path.GetFileName(filePath), filePath)
                End If
            End If
        End Using
    End Sub

    Private Sub DeleteApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteApplicationToolStripMenuItem.Click
        ' Add your code here to handle the "Delete Application" option
        ' For example, you can remove the selected application from the ListViewApps and delete its game path from the database
        If ListViewApps.SelectedItems.Count > 0 Then
            For Each selectedItem As ListViewItem In ListViewApps.SelectedItems
                Dim exePath As String = selectedItem.Tag.ToString()

                ' Remove the item from the ListView
                ListViewApps.Items.Remove(selectedItem)

                ' Delete the game path from the database
                DeleteGamePath(exePath)
            Next
        End If
    End Sub
End Class
