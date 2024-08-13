Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmMain

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

    ' Override the window procedure to handle custom window messages
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32() = SC_MAXIMIZE Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub

    ' The MouseDown event for the panel to initiate the form dragging
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, pnlMenu.MouseDown, pbxLogo.MouseDown
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
        ' Remove the 3D effect from the button
        btnLogout.FlatAppearance.BorderSize = 0
        ' Lock the minimum resize of the form to (800, 500)
        Me.MinimumSize = New Size(800, 500)
        ' Load the user expenses
        LoadUserExpenses()
    End Sub

    Private Sub LoadUserExpenses()
        Dim query As String = "SELECT Item AS ITEM, Cost AS COST, Category AS CATEGORY, Description AS DESCRIPTION, DATE_FORMAT(date, '%m/%d/%Y') AS DATE FROM user_expenses WHERE UserID = @UserID"
        Dim dt As New DataTable()

        Using conn As MySqlConnection = Common.createDBConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID) ' Assuming Username is the UserID
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using

        dgvExpenses.DataSource = dt
        dgvExpenses.AllowUserToAddRows = False
        dgvExpenses.CellBorderStyle = DataGridViewCellBorderStyle.None
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask for confirmation before closing the application
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True ' Cancel the form closing event
        End If
        If result = DialogResult.Yes Then
            frmLogin.Close() ' Close the application
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
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

    Private Sub ckbxTheme_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxTheme.CheckedChanged
        ' Toggle the theme based on the checkbox state
        If ckbxTheme.Checked Then
            ' Set the dark theme
            SetDarkTheme()
        Else
            ' Set the light theme
            SetLightTheme()
        End If
    End Sub

    Private Sub SetDarkTheme()
        ' Set the background color to dark
        Me.BackColor = Color.FromArgb(20, 20, 22)
        pnlContainer.BackColor = Color.FromArgb(20, 20, 22)
        pnlHeader.BackColor = Color.FromArgb(20, 20, 22)
        pnlMenu.BackColor = Color.FromArgb(20, 20, 22)
        ' Set the text color to light
        lblUsername.ForeColor = Color.FromArgb(255, 255, 255)
        lblCurrentPanel.ForeColor = Color.FromArgb(255, 255, 255)
        ' Set the Logo to a different image
        pbxLogo.Image = My.Resources.ChronoPulse_Logo_Light
        pbxUser.Image = My.Resources.user_white
        btnDashboard.Image = My.Resources.dashboard_blue
        btnGames.Image = My.Resources.game_controller_blue
    End Sub

    Private Sub SetLightTheme()
        ' Set the background color to dark
        Me.BackColor = Color.GhostWhite
        pnlContainer.BackColor = Color.GhostWhite
        pnlHeader.BackColor = Color.GhostWhite
        pnlMenu.BackColor = Color.GhostWhite
        ' Set the text color to light
        lblUsername.ForeColor = Color.Black
        lblCurrentPanel.ForeColor = Color.Black
        ' Set the Logo to a different image
        pbxLogo.Image = My.Resources.ChronoPulse_Logo_Dark
        pbxUser.Image = My.Resources.user
        btnDashboard.Image = My.Resources.dashboard
        btnGames.Image = My.Resources.game_controller
    End Sub

    <DllImport("Gdi32.dll")>
    Private Shared Function CreateRoundRectRgn(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cx As Integer, ByVal cy As Integer) As IntPtr
    End Function

    Private Sub btnDashboard_MouseHover(sender As Object, e As EventArgs) Handles btnDashboard.MouseHover
        ToolTip.SetToolTip(btnDashboard, "Dashboard")
    End Sub

    Private Sub btnGames_MouseHover(sender As Object, e As EventArgs) Handles btnGames.MouseHover
        ToolTip.SetToolTip(btnGames, "Games")
    End Sub

    Private Sub pbxUser_Click(sender As Object, e As EventArgs) Handles pbxUser.Click
        cmsDropDown.Show(pbxUser, New Point(0, pbxUser.Height))
    End Sub

    Private Sub cmsTheme_Click(sender As Object, e As EventArgs) Handles cmsTheme.Click
        ckbxTheme.Checked = Not ckbxTheme.Checked
    End Sub

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
End Class
