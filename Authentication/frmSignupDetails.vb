Imports System.Text.RegularExpressions

Public Class frmSignupDetails
    Private Sub lnklblSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        frmLogin.Show()
        Me.Close()
    End Sub

    Function emailValid() As Boolean
        ' Using regular expressions to check if the email is valid
        Dim emailPattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"

        If Regex.IsMatch(txtEmail.Text, emailPattern) Then
            lblErrorMsg.Hide() ' Hide the email error label
            txtEmail.BorderColor = Color.FromArgb(213, 218, 223)
            Return True
        Else
            lblErrorMsg.Text = "Please enter a valid email"
            lblErrorMsg.ForeColor = Color.Red
            txtEmail.BorderColor = Color.Red
            lblErrorMsg.Show() ' Show the email error label
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
            lblErrorMsg.Text = "Passwords do not match."
            lblErrorMsg.Visible = True
            lblErrorMsg.ForeColor = Color.Red
            txtPassword.BorderColor = Color.Red
            txtVerifyPassword.BorderColor = Color.Red
            Return False
        Else
            lblErrorMsg.Hide()
            txtPassword.BorderColor = Color.FromArgb(213, 218, 223)
            txtVerifyPassword.BorderColor = Color.FromArgb(213, 218, 223)
        End If

        ' Check if password is strong
        Dim passwordPattern As String = "^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"
        If Not Regex.IsMatch(password, passwordPattern) Then
            lblErrorMsg.Text = "Password must be at least 8 characters long, contain at least one special character, and one number."
            lblErrorMsg.Visible = True
            lblErrorMsg.ForeColor = Color.Red
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
        If cbxShowPassword.Checked Then
            txtPassword.PasswordChar = ""
            txtVerifyPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
            txtVerifyPassword.PasswordChar = "*"
        End If
    End Sub
End Class