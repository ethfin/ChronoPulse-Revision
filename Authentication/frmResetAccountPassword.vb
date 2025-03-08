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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
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
        Dim parentForm As Form = Me.FindForm()

        ' Show the login form
        Dim loginForm As New frmLogin()
        loginForm.Show()

        ' Close the entire reset account form chain
        If parentForm IsNot Nothing AndAlso TypeOf parentForm Is frmResetAccount Then
            parentForm.Close()
        End If
    End Sub
End Class