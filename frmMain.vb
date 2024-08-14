Imports System.Runtime.InteropServices

Public Class frmMain

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
        ' Set the default form to load as frmDashboard
        LoadForm(New frmDashboard)

        ' Create and configure the ContextMenuStrip
        Dim contextMenu As New ContextMenuStrip()
        Dim showMenuItem As New ToolStripMenuItem("Show")
        Dim closeMenuItem As New ToolStripMenuItem("Close")

        AddHandler showMenuItem.Click, AddressOf ShowMenuItem_Click
        AddHandler closeMenuItem.Click, AddressOf CloseMenuItem_Click

        contextMenu.Items.AddRange(New ToolStripItem() {showMenuItem, closeMenuItem})
        NotifyIcon1.ContextMenuStrip = contextMenu
    End Sub

    ' Backup code for closing the application
    'Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    ' Ask for confirmation before closing the application
    '    Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '    If result = DialogResult.No Then
    '        e.Cancel = True ' Cancel the form closing event
    '    End If
    '    If result = DialogResult.Yes Then
    '        frmLogin.Close() ' Close the application
    '    End If
    'End Sub

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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        'change form to dashboard
        LoadForm(New frmDashboard)
    End Sub

    Private Sub btnGames_Click(sender As Object, e As EventArgs) Handles btnGames.Click
        LoadForm(New frmGames)
    End Sub
End Class
