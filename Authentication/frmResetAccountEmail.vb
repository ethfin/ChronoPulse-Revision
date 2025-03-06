Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmResetAccountEmail

    Public ReadOnly Property UserEmail As String
        Get
            Return txtEmail.Text
        End Get
    End Property

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If ValidateInputFields() AndAlso CheckExistingUser(txtEmail.Text) Then
            Dim parentForm As frmResetAccount = CType(Me.ParentForm, frmResetAccount)
            parentForm.NavigateToNextStep(Me)
        End If
    End Sub

    Private Function ValidateInputFields() As Boolean
        ' Check if the email field is empty
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please fill in the email field.")
            Return False
        End If

        ' Validate the email format
        If Not emailValid() Then
            MessageBox.Show("Please enter a valid email.")
            Return False
        End If

        ' If all validations pass
        Return True
    End Function

    Private Function emailValid() As Boolean
        ' Using regular expressions to check if the email is valid
        Dim emailPattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"

        If Regex.IsMatch(txtEmail.Text, emailPattern) Then
            lblErrorEmail.Text = "Valid Input"
            lblErrorEmail.ForeColor = Color.Green
            lblErrorEmail.Show() ' Show the email error label
            Return True
        Else
            lblErrorEmail.Text = "Please enter a valid email"
            lblErrorEmail.ForeColor = Color.Red
            lblErrorEmail.Show() ' Show the email error label
            Return False
        End If
    End Function

    Private Function CheckExistingUser(email As String) As Boolean
        ' Use the createDBConnection method from Common.vb to get the database connection
        Dim connection As MySqlConnection = Common.createDBConnection()

        ' SQL query to check if the email already exists
        Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE email = @Email"

        ' Create a MySqlCommand object with the query and connection
        Using command As New MySqlCommand(query, connection)
            ' Add parameters to the query to prevent SQL injection
            command.Parameters.AddWithValue("@Email", email)

            ' Open the database connection
            connection.Open()

            ' Execute the query and get the result
            Dim count As Integer = CInt(command.ExecuteScalar())

            ' Check if the count is greater than 0, indicating that the email already exists
            If count > 0 Then
                lblErrorEmail.Text = "Email exists."
                lblErrorEmail.ForeColor = Color.Green
                lblErrorEmail.Show()
                connection.Close()
                Return True
            Else
                lblErrorEmail.Text = "Email does not exist."
                lblErrorEmail.ForeColor = Color.Red
                lblErrorEmail.Show()
                connection.Close()
                Return False
            End If
        End Using
    End Function

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        emailValid()
    End Sub
End Class