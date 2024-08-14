Imports System.IO
Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmGames

    Private Sub frmGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure ListView
        ListViewApps.View = View.LargeIcon
        ListViewApps.LargeImageList = ImageList

        ' Load saved game paths from the database
        LoadGamePaths()
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
                        Dim item As New ListViewItem(gameName)
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
End Class