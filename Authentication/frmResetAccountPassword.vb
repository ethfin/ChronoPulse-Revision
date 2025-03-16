' In frmResetAccountPassword.vb
Imports MySql.Data.MySqlClient
Imports Common

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

        If newPass = confirmPass Then
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
        Else
            MessageBox.Show("Passwords do not match.")
        End If
    End Sub

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
End Class