Imports System.Text.RegularExpressions

Public Class frmSignupDetails
    Private Sub lnklblSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Function emailValid() As Boolean
        ' Using regular expressions to check if the email is valid
        Dim emailPattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"

        If Regex.IsMatch(txtEmail.Text, emailPattern) Then
            HideError()
            txtEmail.BorderColor = Color.FromArgb(213, 218, 223)
            Return True
        Else
            ShowError("Please enter a valid email")
            txtEmail.BorderColor = Color.Red
            Return False
        End If
    End Function

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        emailValid()
    End Sub

    Private Function ComparePasswords() As Boolean
        Dim password As String = txtPassword.Text
        Dim verifyPassword As String = txtVerifyPassword.Text

        ' Check if passwords match
        If password <> verifyPassword Then
            ShowError("Passwords do not match.")
            txtPassword.BorderColor = Color.Red
            txtVerifyPassword.BorderColor = Color.Red
            Return False
        Else
            HideError()
            txtPassword.BorderColor = Color.FromArgb(213, 218, 223)
            txtVerifyPassword.BorderColor = Color.FromArgb(213, 218, 223)
        End If

        ' Check if password is strong
        Dim passwordPattern As String = "^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"
        If Not Regex.IsMatch(password, passwordPattern) Then
            ShowError("Password must be at least 8 characters long, contain at least one special character, and one number.")
            txtPassword.BorderColor = Color.Red
            txtVerifyPassword.BorderColor = Color.Red
            Return False
        End If

        Return True
    End Function

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        ComparePasswords()
    End Sub

    Private Sub txtVerifyPassword_Leave(sender As Object, e As EventArgs) Handles txtVerifyPassword.Leave
        ComparePasswords()
    End Sub

    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        Dim passwordChar As Char = If(cbxShowPassword.Checked, "", "*")
        txtPassword.PasswordChar = passwordChar
        txtVerifyPassword.PasswordChar = passwordChar
    End Sub

    Private Sub ShowError(message As String)
        lblErrorMsg.Text = message
        lblErrorMsg.ForeColor = Color.Red
        lblErrorMsg.Visible = True
    End Sub

    Private Sub HideError()
        lblErrorMsg.Hide()
    End Sub
End Class