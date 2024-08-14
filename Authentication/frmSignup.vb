Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class frmSignup

    'function to load other forms into pnlContainer
    Public Sub LoadForm(ByVal form As Form)
        ' Check if the form is already open
        If pnlSignUpProgress.Controls.Count > 0 Then
            pnlSignUpProgress.Controls.RemoveAt(0)
        End If
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        pnlSignUpProgress.Controls.Add(form)
        pnlSignUpProgress.Tag = form
        form.Show()
    End Sub

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
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlLoginContainer.MouseDown, pnlSignUpProgress.MouseDown, pnlLogin.MouseDown
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            frmLogin.Close()
        End If
    End Sub

    Private Sub frmSignup_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadForm(frmSignupDetails)
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub lnklblGoBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblGoBack.LinkClicked
        LoadForm(frmSignupDetails)
        frmSignupSecurity.Close()
        btnNext.Visible = True
        btnSignup.Visible = False
        lnklblGoBack.Visible = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If ValidateInputFieldsDetails() AndAlso emailValid() Then
            LoadForm(frmSignupSecurity)
            btnNext.Visible = False
            btnSignup.Visible = True
            lnklblGoBack.Visible = True
        End If
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If ValidateInputFieldsSecurity() AndAlso SecurityQuestionNotEmptyCombobox() AndAlso CompareAnswersQ1() AndAlso CompareAnswersQ2() Then
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmLogin.Show()
            frmSignupDetails.Close()
            frmSignupSecurity.Close()
            Me.Close()
        End If
    End Sub

    Private Function ValidateInputFieldsDetails() As Boolean
        ' Check if any of the fields are empty
        If String.IsNullOrWhiteSpace(frmSignupDetails.txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtVerifyPassword.Text) Then

            frmSignupDetails.lblErrorMsg.Text = "Please fill in all fields."
            frmSignupDetails.lblErrorMsg.Visible = True
            frmSignupDetails.lblErrorMsg.ForeColor = Color.Red
            Return False
        End If

        ' Compare passwords
        If Not ComparePasswords() Then
            Return False
        End If

        Return True
    End Function

    Private Function ValidateInputFieldsSecurity() As Boolean
        ' Check if any of the fields are empty
        If String.IsNullOrWhiteSpace(frmSignupDetails.txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupDetails.txtVerifyPassword.Text) Then

            frmSignupDetails.lblErrorMsg.Text = "Please fill in all fields."
            frmSignupDetails.lblErrorMsg.Visible = True
            frmSignupDetails.lblErrorMsg.ForeColor = Color.Red
            Return False
        End If

        ' Compare passwords
        If Not CompareAnswersQ1() AndAlso CompareAnswersQ2() Then
            Return False
        End If

        Return True
    End Function

    Private Function ComparePasswords() As Boolean
        Dim password As String = frmSignupDetails.txtPassword.Text
        Dim verifyPassword As String = frmSignupDetails.txtVerifyPassword.Text

        ' Check if passwords match
        If password <> verifyPassword Then
            frmSignupDetails.lblErrorMsg.Text = "Passwords do not match."
            frmSignupDetails.lblErrorMsg.Visible = True
            frmSignupDetails.lblErrorMsg.ForeColor = Color.Red
            frmSignupDetails.txtPassword.BorderColor = Color.Red
            frmSignupDetails.txtVerifyPassword.BorderColor = Color.Red
            Return False
        End If

        ' Check if password is strong
        Dim passwordPattern As String = "^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"
        If Not Regex.IsMatch(password, passwordPattern) Then
            frmSignupDetails.lblErrorMsg.Text = "Password must be at least 8 characters long, contain at least one special character, and one number."
            frmSignupDetails.lblErrorMsg.Visible = True
            frmSignupDetails.lblErrorMsg.ForeColor = Color.Red
            frmSignupDetails.txtPassword.BorderColor = Color.Red
            frmSignupDetails.txtVerifyPassword.BorderColor = Color.Red
            Return False
        End If

        Return True
    End Function

    Private Function CompareAnswersQ1() As Boolean
        If String.IsNullOrWhiteSpace(frmSignupSecurity.txtSQAnswer1.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupSecurity.txtSQVAnswer1.Text) Then
            Return False
        End If

        If frmSignupSecurity.txtSQAnswer1.Text = frmSignupSecurity.txtSQVAnswer1.Text Then
            frmSignupSecurity.lblErrorMsg.Hide()
            frmSignupSecurity.txtSQAnswer1.BorderColor = Color.FromArgb(213, 218, 223)
            frmSignupSecurity.txtSQVAnswer1.BorderColor = Color.FromArgb(213, 218, 223)
            Return True
        Else
            frmSignupSecurity.lblErrorMsg.Text = "Answers do not match."
            frmSignupSecurity.lblErrorMsg.Visible = True
            frmSignupSecurity.lblErrorMsg.ForeColor = Color.Red
            frmSignupSecurity.txtSQAnswer1.BorderColor = Color.Red
            frmSignupSecurity.txtSQVAnswer1.BorderColor = Color.Red
            Return False
        End If
    End Function

    Private Function CompareAnswersQ2() As Boolean
        If String.IsNullOrWhiteSpace(frmSignupSecurity.txtSQAnswer2.Text) OrElse
           String.IsNullOrWhiteSpace(frmSignupSecurity.txtSQVAnswer2.Text) Then
            Return False
        End If

        If frmSignupSecurity.txtSQAnswer2.Text = frmSignupSecurity.txtSQVAnswer2.Text Then
            frmSignupSecurity.lblErrorMsg.Hide()
            frmSignupSecurity.txtSQAnswer2.BorderColor = Color.FromArgb(213, 218, 223)
            frmSignupSecurity.txtSQVAnswer2.BorderColor = Color.FromArgb(213, 218, 223)
            Return True
        Else
            frmSignupSecurity.lblErrorMsg.Text = "Answers do not match."
            frmSignupSecurity.lblErrorMsg.Visible = True
            frmSignupSecurity.lblErrorMsg.ForeColor = Color.Red
            frmSignupSecurity.txtSQAnswer2.BorderColor = Color.Red
            frmSignupSecurity.txtSQVAnswer2.BorderColor = Color.Red
            Return False
        End If
    End Function

    Private Function SecurityQuestionNotEmptyCombobox() As Boolean
        If frmSignupSecurity.cmbQuestion1.SelectedIndex = -1 OrElse
           frmSignupSecurity.cmbQuestion2.SelectedIndex = -1 Then

            frmSignupSecurity.lblErrorMsg.Text = "Please select a security question."
            frmSignupSecurity.lblErrorMsg.Visible = True
            frmSignupSecurity.lblErrorMsg.ForeColor = Color.Red
            Return False
        End If

        Return True
    End Function

    Function emailValid() As Boolean
        ' Using regular expressions to check if the email is valid
        Dim emailPattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"

        If String.IsNullOrWhiteSpace(frmSignupDetails.txtEmail.Text) Then
            frmSignupDetails.lblErrorMsg.Text = "Please fill in all fields."
            frmSignupDetails.lblErrorMsg.ForeColor = Color.Red
            frmSignupDetails.txtEmail.BorderColor = Color.Red
            frmSignupDetails.lblErrorMsg.Show() ' Show the email error label
            Return False
        End If

        If Regex.IsMatch(frmSignupDetails.txtEmail.Text, emailPattern) Then
            frmSignupDetails.lblErrorMsg.Hide() ' Hide the email error label
            Return True
        Else
            frmSignupDetails.lblErrorMsg.Text = "Please enter a valid email"
            frmSignupDetails.lblErrorMsg.ForeColor = Color.Red
            frmSignupDetails.txtEmail.BorderColor = Color.Red
            frmSignupDetails.lblErrorMsg.Show() ' Show the email error label
            Return False
        End If
    End Function
End Class
