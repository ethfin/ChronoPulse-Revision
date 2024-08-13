Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmLogin
    Inherits Form

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
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlLoginContainer.MouseDown, pbxBackground.MouseDown, pbxLogo.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim path As New GraphicsPath()
        Dim radius As Integer = 50
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        Me.Region = New Region(path)
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        txtUsername.Select()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            AccountData.Clear()
            Me.Close()
        End If
    End Sub

    Public loginAttempts As Integer = 0
    Private lastInvalidAttemptTime As DateTime
    Private loginTimer As Timer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Clear AccountData
        AccountData.Clear()

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            'use lblErrorMsg to display error message
            lblErrorMsg.Text = "Please enter username and password."
            lblErrorMsg.ForeColor = Color.Red
            txtUsername.BorderColor = Color.Red
            txtPassword.BorderColor = Color.Red
            Return
        End If

        Using myDBConnection As MySqlConnection = createDBConnection()
            myDBConnection.Open()

            Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(query, myDBConnection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                ' Store the username and userID in AccountData
                AccountData.Username = username
                AccountData.UserID = GetUserID(username)

                Dim frmMain As New frmMain()
                frmMain.Show()
                txtUsername.Clear()
                txtPassword.Clear()
                Me.Hide()
            Else
                loginAttempts += 1
                lastInvalidAttemptTime = DateTime.Now

                If loginAttempts >= 5 Then
                    btnLogin.Enabled = False
                    lblErrorMsg.Text = "Please try again in about 30 seconds."
                    lblErrorMsg.ForeColor = Color.Red
                    loginTimer = New Timer()
                    loginTimer.Interval = 30000 ' 1 minute
                    AddHandler loginTimer.Tick, AddressOf EnableLoginButton
                    loginTimer.Start()
                Else
                    'use lblErrorMsg to display error message
                    lblErrorMsg.Text = "Invalid username or password. Please try again."
                    lblErrorMsg.ForeColor = Color.Red
                    txtUsername.BorderColor = Color.Red
                    txtPassword.BorderColor = Color.Red
                End If
            End If
        End Using
    End Sub

    Private Sub EnableLoginButton(sender As Object, e As EventArgs)
        btnLogin.Enabled = True
        lblErrorMsg.Text = ""
        loginTimer.Stop()
        loginTimer.Dispose()
    End Sub

    Private Function GetUserID(username As String) As Integer
        Using myDBConnection As MySqlConnection = createDBConnection()
            myDBConnection.Open()

            Dim query As String = "SELECT userID FROM dbaccounts WHERE username = @username"
            Dim cmd As New MySqlCommand(query, myDBConnection)
            cmd.Parameters.AddWithValue("@username", username)

            Dim userID As Integer = CInt(cmd.ExecuteScalar())

            Return userID
        End Using
    End Function

    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        If cbxShowPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub lnklblSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSignup.LinkClicked
        ' Open the signup form
        Dim frmSignup As New frmSignup()
        frmSignup.Show()
        txtUsername.Clear()
        txtPassword.Clear()
        Me.Hide()
    End Sub

    Private Sub lnklblResetAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblResetAccount.LinkClicked
        ' Open the reset account form
        Dim frmResetAccount As New frmResetAccount()
        frmResetAccount.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        txtUsername.BorderColor = Color.FromArgb(213, 218, 223)
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.BorderColor = Color.FromArgb(213, 218, 223)
    End Sub
End Class