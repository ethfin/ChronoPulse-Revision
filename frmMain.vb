Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmMain

    Private myDBConnection As MySqlConnection

    'function to load other forms into pnlContainer
    Private Sub LoadForm(ByVal form As Form)
        ' Check if the form is already open
        If pnlContainer.Controls.Count > 0 Then
            pnlContainer.Controls.RemoveAt(0)
        End If
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(form)
        pnlContainer.Tag = form
        form.Show()
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If myDBConnection IsNot Nothing AndAlso myDBConnection.State = ConnectionState.Open Then
            myDBConnection.Close()
        End If
    End Sub

    Private isRestoringFromTray As Boolean = False

    ' Constants for handling window dragging
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    ' Import the SendMessage function from user32.dll
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    ' Import the ReleaseCapture function from user32.dll
    <DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    ' The MouseDown event for the panel to initiate the form dragging
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMenu.MouseDown, pbxLogo.MouseDown, pnlTop.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the lblUsername text to the username stored in AccountData
        lblUsername.Text = AccountData.Username
        ' Add round corners by 10 to btnLogout
        btnLogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogout.Width, btnLogout.Height, 10, 10))
        ' Lock the minimum resize of the form to (800, 500)
        Me.MinimumSize = New Size(800, 500)
        ' Set the default form to load as frmDashboard
        LoadForm(New frmDashboard)

        ' Load user experience data
        If Not String.IsNullOrEmpty(AccountData.UserID) Then
            UserExperience.LoadUserExperience(AccountData.UserID)
            UpdateExperienceBar()
        End If

        ' Load and display leaderboard
        LoadLeaderboard()

        ' Create and configure the ContextMenuStrip
        Dim contextMenu As New ContextMenuStrip()
        Dim showMenuItem As New ToolStripMenuItem("Show")
        Dim closeMenuItem As New ToolStripMenuItem("Close")

        AddHandler showMenuItem.Click, AddressOf ShowMenuItem_Click
        AddHandler closeMenuItem.Click, AddressOf CloseMenuItem_Click

        contextMenu.Items.AddRange(New ToolStripItem() {showMenuItem, closeMenuItem})
        NotifyIcon1.ContextMenuStrip = contextMenu
        UpdateUserProfileImage()
        chkToggleHide.Checked = GetHideNameSetting(AccountData.UserID)
        lblUsername.Text = If(chkToggleHide.Checked, "Anonymous", AccountData.Username)
    End Sub

    Private Sub chkToggleHide_CheckedChanged(sender As Object, e As EventArgs) Handles chkToggleHide.CheckedChanged
        Dim hideName As Boolean = chkToggleHide.Checked
        UpdateHideNameInLeaderboard(AccountData.UserID, hideName)
        lblUsername.Text = If(hideName, "Anonymous", AccountData.Username)
        LoadLeaderboard()
    End Sub

    Private Function GetHideNameSetting(userID As Integer) As Boolean
        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "SELECT HideNameInLeaderboard FROM dbaccounts WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", userID)
                    Return Convert.ToBoolean(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving hide name setting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub UpdateHideNameInLeaderboard(userID As Integer, hideName As Boolean)
        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "UPDATE dbaccounts SET HideNameInLeaderboard = @HideName WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@HideName", hideName)
                    cmd.Parameters.AddWithValue("@UserID", userID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating hide name setting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-- System Tray Icon --
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Minimize to system tray instead of closing
        e.Cancel = True
        Me.Hide()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        ' Restore the form when the NotifyIcon is double-clicked
        Me.Show()
    End Sub

    Private Sub ShowMenuItem_Click(sender As Object, e As EventArgs)
        ' Restore the form when the "Show" menu item is clicked
        Me.Show()
    End Sub

    Private Sub CloseMenuItem_Click(sender As Object, e As EventArgs)
        ' Prompt for confirmation before closing the application
        Dim confirmExit As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmExit = DialogResult.Yes Then
            AccountData.Clear()
            NotifyIcon1.Visible = False
            Me.Close()
            frmLogin.Close()
        End If
    End Sub
    '-- End System Tray Icon --

    Public Sub UpdateExperienceBar()
        prgExperience.Value = CInt(UserExperience.GetProgressToNextLevel() * 100)
        lblLevel.Text = $"Level {UserExperience.CurrentLevel}"
        UpdateUserProfileImage()
    End Sub

    Private Sub UpdateUserProfileImage()
        Select Case UserExperience.CurrentLevel
            Case 1
                pbxUser.Image = My.Resources.pic1
            Case 2
                pbxUser.Image = My.Resources.pic2
            Case 3
                pbxUser.Image = My.Resources.pic3
            Case 4
                pbxUser.Image = My.Resources.pic4
            Case 5
                pbxUser.Image = My.Resources.pic5
            Case 6
                pbxUser.Image = My.Resources.pic6
            Case 7
                pbxUser.Image = My.Resources.pic7
            Case 8
                pbxUser.Image = My.Resources.pic8
            Case 9
                pbxUser.Image = My.Resources.pic9
            Case 10
                pbxUser.Image = My.Resources.pic10
                ' Add more cases as needed for additional levels
            Case Else
                pbxUser.Image = My.Resources.user_white ' Default image if level is not specified
        End Select
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Prompt for confirmation before logging out
        Dim confirmLogout As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmLogout = DialogResult.Yes Then
            ' Clear the AccountData
            AccountData.Clear()
            NotifyIcon1.Visible = False
            frmLogin.Show()
            frmLogin.loginAttempts = 0
            Me.Hide()
        End If
    End Sub

    Private Sub LoadLeaderboard()
        ' Clear existing controls in leaderboard panel
        pnlLeaderboard.Controls.Clear()

        ' Add a title label for the leaderboard
        Dim lblTitle As New Label()
        lblTitle.Text = "Leaderboard"
        lblTitle.Font = New Font("Pixelify Sans", 15.75, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.AutoSize = False
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.Size = New Size(pnlLeaderboard.Width - 10, 30)
        pnlLeaderboard.Controls.Add(lblTitle)

        ' Create a FlowLayoutPanel for the leaderboard
        Dim flpLeaderboard As New FlowLayoutPanel()
        flpLeaderboard.FlowDirection = FlowDirection.TopDown
        flpLeaderboard.WrapContents = False
        flpLeaderboard.AutoScroll = True
        flpLeaderboard.HorizontalScroll.Enabled = False
        flpLeaderboard.HorizontalScroll.Visible = False
        flpLeaderboard.Size = New Size(pnlLeaderboard.Width - 10, pnlLeaderboard.Height - 40)
        flpLeaderboard.Location = New Point(5, 35)
        pnlLeaderboard.Controls.Add(flpLeaderboard)

        ' Get top users from the database (max 10)
        Dim topUsers As List(Of Tuple(Of String, Integer, Integer, Boolean)) = GetTopUsers(10)

        ' Display each user in the leaderboard
        For i As Integer = 0 To topUsers.Count - 1
            ' Create a panel for each user entry using Guna2Panel for better styling
            Dim userPanel As New Guna.UI2.WinForms.Guna2Panel()
            userPanel.Size = New Size(flpLeaderboard.Width - 30, 40)
            userPanel.FillColor = Color.FromArgb(6, 8, 31)
            userPanel.BorderColor = If(i = 0, Color.Gold, If(i = 1, Color.Silver, If(i = 2, Color.SandyBrown, Color.FromArgb(64, 64, 64))))
            userPanel.BorderThickness = 1
            userPanel.BorderRadius = 10
            userPanel.Margin = New Padding(5, 3, 5, 3)

            ' Create a small profile picture box based on level
            Dim pbxUserIcon As New Guna.UI2.WinForms.Guna2CirclePictureBox()
            pbxUserIcon.Size = New Size(26, 26)
            pbxUserIcon.Location = New Point(8, 7)
            pbxUserIcon.SizeMode = PictureBoxSizeMode.Zoom

            ' Set profile picture based on user level
            Select Case topUsers(i).Item2
                Case 1 To 10
                    pbxUserIcon.Image = My.Resources.ResourceManager.GetObject($"pic{topUsers(i).Item2}")
                Case Else
                    pbxUserIcon.Image = My.Resources.user_white
            End Select

            ' Add rank indicator (1st, 2nd, 3rd, etc.)
            'Dim lblRank As New Guna.UI2.WinForms.Guna2HtmlLabel()
            'lblRank.Text = $"#{i + 1}"
            'lblRank.ForeColor = If(i = 0, Color.Gold, If(i = 1, Color.Silver, If(i = 2, Color.SandyBrown, Color.White)))
            'lblRank.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            'lblRank.Location = New Point(userPanel.Width - 30, 5)
            'lblRank.AutoSize = True

            ' Username label with gradient effect
            Dim lblUsername As New Guna.UI2.WinForms.Guna2HtmlLabel()
            lblUsername.Text = If(topUsers(i).Item4, "Anonymous", topUsers(i).Item1)
            lblUsername.ForeColor = Color.White
            lblUsername.Location = New Point(40, 5)
            lblUsername.AutoSize = True
            lblUsername.MaximumSize = New Size(90, 20)

            ' Progress bar for experience visualization
            Dim prgXP As New Guna.UI2.WinForms.Guna2ProgressBar()
            prgXP.Value = 100  ' Full for visual effect
            prgXP.FillColor = Color.FromArgb(20, 20, 40)
            prgXP.ProgressColor = If(i = 0, Color.Gold, If(i = 1, Color.Silver, Color.FromArgb(0, 120, 215)))
            prgXP.ProgressColor2 = Color.FromArgb(0, 180, 255)
            prgXP.BorderRadius = 5
            prgXP.Location = New Point(40, 25)
            prgXP.Size = New Size(userPanel.Width - 50, 8)

            ' Level label with custom styling
            Dim lblLevel As New Guna.UI2.WinForms.Guna2HtmlLabel()
            lblLevel.Text = "Lvl " & topUsers(i).Item2.ToString()
            lblLevel.ForeColor = Color.Aqua
            lblLevel.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
            lblLevel.Location = New Point(userPanel.Width - 40, 5)
            lblLevel.AutoSize = True

            ' Add effects on hover
            AddHandler userPanel.MouseEnter, Sub(sender, e)
                                                 userPanel.FillColor = Color.FromArgb(10, 15, 40)
                                             End Sub

            AddHandler userPanel.MouseLeave, Sub(sender, e)
                                                 userPanel.FillColor = Color.FromArgb(6, 8, 31)
                                             End Sub

            ' Assemble panel
            userPanel.Controls.Add(pbxUserIcon)
            userPanel.Controls.Add(lblUsername)
            'userPanel.Controls.Add(lblRank)
            userPanel.Controls.Add(lblLevel)
            userPanel.Controls.Add(prgXP)

            ' Add panel to leaderboard
            flpLeaderboard.Controls.Add(userPanel)
        Next

        ' Add message if no users found
        If topUsers.Count = 0 Then
            Dim lblNoUsers As New Label()
            lblNoUsers.Text = "No users found"
            lblNoUsers.ForeColor = Color.White
            lblNoUsers.AutoSize = False
            lblNoUsers.TextAlign = ContentAlignment.MiddleCenter
            lblNoUsers.Size = New Size(flpLeaderboard.Width - 10, 30)
            flpLeaderboard.Controls.Add(lblNoUsers)
        End If
    End Sub


    ' Function to get top users from the database
    Private Function GetTopUsers(ByVal limit As Integer) As List(Of Tuple(Of String, Integer, Integer, Boolean))
        Dim topUsers As New List(Of Tuple(Of String, Integer, Integer, Boolean))

        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                ' Updated query to use dbaccounts table and include HideNameInLeaderboard column
                Dim query As String = "SELECT a.Username, e.Level, e.Experience, a.HideNameInLeaderboard " &
                                  "FROM user_experience e " &
                                  "INNER JOIN dbaccounts a ON e.UserID = a.UserID " &
                                  "ORDER BY e.Level DESC, e.Experience DESC " &
                                  "LIMIT @Limit"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Limit", limit)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim username As String = reader.GetString("Username")
                            Dim level As Integer = reader.GetInt32("Level")
                            Dim experience As Integer = reader.GetInt32("Experience")
                            Dim hideName As Boolean = reader.GetBoolean("HideNameInLeaderboard")

                            ' Add to list
                            topUsers.Add(New Tuple(Of String, Integer, Integer, Boolean)(username, level, experience, hideName))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Log or display error message
            MessageBox.Show("Error loading leaderboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return topUsers
    End Function

    <DllImport("Gdi32.dll")>
    Private Shared Function CreateRoundRectRgn(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cx As Integer, ByVal cy As Integer) As IntPtr
    End Function

    Private Sub btnDashboard_MouseHover(sender As Object, e As EventArgs) Handles btnDashboard.MouseHover
        ToolTip.SetToolTip(btnDashboard, "Dashboard")
    End Sub

    Private Sub btnGames_MouseHover(sender As Object, e As EventArgs) Handles btnAI.MouseHover
        ToolTip.SetToolTip(btnAI, "AI Chatbot")
    End Sub

    Private Sub btnExpenses_MouseHover(sender As Object, e As EventArgs) Handles btnExpenses.MouseHover
        ToolTip.SetToolTip(btnExpenses, "Expenses")
    End Sub

    Private Sub btnIncome_MouseHover(sender As Object, e As EventArgs) Handles btnIncome.MouseHover
        ToolTip.SetToolTip(btnIncome, "Income")
    End Sub

    Private Sub btnBudget_MouseHover(sender As Object, e As EventArgs)
        'ToolTip.SetToolTip(btnBudget, "Budget")
    End Sub

    Private Sub btnSavings_MouseHover(sender As Object, e As EventArgs)
        'ToolTip.SetToolTip(btnSavings, "Savings")
    End Sub

    Private Sub pbxUser_Click(sender As Object, e As EventArgs) Handles pbxUser.Click
        cmsDropDown.Show(pbxUser, New Point(0, pbxUser.Height))
    End Sub

    'Private Sub cmsTheme_Click(sender As Object, e As EventArgs)
    '    ckbxTheme.Checked = Not ckbxTheme.Checked
    'End Sub

    Private Sub cmsLogout_Click(sender As Object, e As EventArgs) Handles cmsLogout.Click
        ' Prompt for confirmation before logging out
        Dim confirmLogout As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmLogout = DialogResult.Yes Then
            ' Clear the AccountData
            AccountData.Clear()
            frmLogin.Show()
            frmLogin.loginAttempts = 0
            Me.Hide()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        'change form to dashboard
        LoadForm(New frmDashboard)
    End Sub

    Private Sub btnGames_Click(sender As Object, e As EventArgs) Handles btnAI.Click
        LoadForm(New frmAI)
    End Sub

    Private Sub btnExpenses_Click(sender As Object, e As EventArgs) Handles btnExpenses.Click
        LoadForm(New frmExpenses)
    End Sub

    Private Sub btnIncome_Click(sender As Object, e As EventArgs) Handles btnIncome.Click
        LoadForm(New frmIncome)
    End Sub

    Private Sub btnSavings_Click(sender As Object, e As EventArgs)
        'LoadForm(New frmSavings)
    End Sub

    Private Sub btnBudget_Click(sender As Object, e As EventArgs)
        'LoadForm(New frmBudgeting)
    End Sub

    Private Sub btnOCR_Click(sender As Object, e As EventArgs) Handles btnOCR.Click
        LoadForm(New frmOCR)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        LoadForm(New frmDemo)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Minimize to system tray instead of closing
        Me.Hide()
        NotifyIcon1.Visible = True
    End Sub

    ' Prevent window from being maximized using Windows + Up arrow key
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32() = SC_MAXIMIZE Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LoadForm(New frmQuests)
    End Sub
End Class
