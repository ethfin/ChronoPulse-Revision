Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class frmResetAccount
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
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlResetContainer.MouseDown, pnlLogin.MouseDown
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

    Private Sub frmResetAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        LoadStep(New frmResetAccountEmail)
    End Sub

    Private Sub lnklblGoBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblGoBack.LinkClicked
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub LoadStep(ByVal form As Form)
        ' Check if the form is already open
        If pnlResetAccountProgress.Controls.Count > 0 Then
            pnlResetAccountProgress.Controls.RemoveAt(0)
        End If
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        pnlResetAccountProgress.Controls.Add(form)
        pnlResetAccountProgress.Tag = form
        form.Show()
    End Sub

    Public Sub NavigateToNextStep(currentForm As Form)
        If TypeOf currentForm Is frmResetAccountEmail Then
            ' Get the email from the email form
            Dim emailForm As frmResetAccountEmail = DirectCast(currentForm, frmResetAccountEmail)

            ' Create new security form instance and set the email
            Dim securityForm As New frmResetAccountSecurity()
            securityForm.lblWelcome1.Text = emailForm.UserEmail

            ' Load the security form into the panel
            LoadStep(securityForm)
        ElseIf TypeOf currentForm Is frmResetAccountSecurity Then
            ' Create the password form and pass the email
            Dim securityForm As frmResetAccountSecurity = DirectCast(currentForm, frmResetAccountSecurity)
            Dim passwordForm As New frmResetAccountPassword()

            ' Pass the email from the security form to the password form
            passwordForm.UserEmail = securityForm.lblWelcome1.Text

            ' Navigate to password form
            LoadStep(passwordForm)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class