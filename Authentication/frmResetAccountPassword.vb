Imports MySql.Data.MySqlClient
Imports Common
Imports System.Text.RegularExpressions

Public Class frmResetAccountPassword
    Private _userEmail As String  ' Changed variable name to avoid conflict

    ' Fixed property implementation
    Public Property UserEmail As String
        Get
            Return _userEmail  ' Return the private field
        End Get
        Set(value As String)
            _userEmail = value  ' Set the private field
        End Set
    End Property

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim newPass As String = txtPassword.Text.Trim()
        Dim confirmPass As String = txtVerifyPassword.Text.Trim()

        If String.IsNullOrEmpty(_userEmail) Then
            MessageBox.Show("Email information is missing. Please start over.")
            Return
        End If

        If ComparePasswords(newPass, confirmPass) Then
            Using conn As MySqlConnection = createDBConnection()
                conn.Open()
                Dim query As String = "UPDATE dbaccounts SET Password = @Password WHERE Email = @Email"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Password", newPass)
                    cmd.Parameters.AddWithValue("@Email", _userEmail)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Password updated successfully.")

                        ' Navigate back to login form
                        ReturnToLogin()

                        ' Close the form
                        Me.Close()
                    Else
                        MessageBox.Show("Failed to update password. Email not found.")
                    End If
                End Using
            End Using
        End If
    End Sub

    Private Function ComparePasswords(password As String, verifyPassword As String) As Boolean
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

    ' Add a method to handle returning to the login form
    Private Sub ReturnToLogin()
        ' Find the parent reset account form
        Dim parentForm As frmResetAccount = TryCast(Me.ParentForm, frmResetAccount)

        ' Close the entire reset account form chain
        If parentForm IsNot Nothing Then
            parentForm.Close()
        End If

        ' Show the login form
        Dim loginForm As New frmLogin()
        loginForm.Show()
    End Sub

    ' Add event handlers for the Show Password checkboxes
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        End If
    End Sub

    Private Sub chkShowPassword2_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword2.CheckedChanged
        If chkShowPassword2.Checked Then
            txtVerifyPassword.PasswordChar = ControlChars.NullChar
        Else
            txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        End If
    End Sub

    Private Sub ShowError(message As String)
        lblError1.Text = message
        lblError1.ForeColor = Color.Red
        lblError1.Visible = True
    End Sub

    Private Sub HideError()
        lblError1.Hide()
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        ComparePasswords(txtPassword.Text, txtVerifyPassword.Text)
    End Sub

    Private Sub txtVerifyPassword_Leave(sender As Object, e As EventArgs) Handles txtVerifyPassword.Leave
        ComparePasswords(txtPassword.Text, txtVerifyPassword.Text)
    End Sub
End Class