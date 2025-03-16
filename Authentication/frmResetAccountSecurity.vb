Imports MySql.Data.MySqlClient
Imports Common

Public Class frmResetAccountSecurity

    Private storedAnswer1 As String
    Private storedAnswer2 As String

    Private Sub frmResetAccountSecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userEmail As String = lblWelcome1.Text.Trim()

        Using conn As MySqlConnection = createDBConnection()
            conn.Open()
            Using cmd As New MySqlCommand("SELECT SecurityQuestion1, SecurityAnswer1, SecurityQuestion2, SecurityAnswer2 
                                           FROM dbaccounts 
                                           WHERE Email = @Email", conn)
                cmd.Parameters.AddWithValue("@Email", userEmail)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        cmbSQ1.Text = reader("SecurityQuestion1").ToString()
                        cmbSQ2.Text = reader("SecurityQuestion2").ToString()
                        storedAnswer1 = reader("SecurityAnswer1").ToString()
                        storedAnswer2 = reader("SecurityAnswer2").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Validate that the answer for Question 1 is entered in the correct textboxes
        If String.IsNullOrWhiteSpace(txtSQA1.Text) OrElse String.IsNullOrWhiteSpace(txtSQA1Verify.Text) Then
            lblError.Text = "Please enter the answer for Question 1 in the correct fields."
            lblError.ForeColor = Color.Red
            lblError.Show()
            Return
        End If

        ' Validate that first question's answers match each other
        If txtSQA1.Text.Trim() <> txtSQA1Verify.Text.Trim() Then
            lblError.Text = "Security Answer 1 mismatch."
            lblError.ForeColor = Color.Red
            lblError.Show()
            Return
        End If

        ' Validate that the answer for Question 2 is entered in the correct textboxes
        If String.IsNullOrWhiteSpace(txtSQA2.Text) OrElse String.IsNullOrWhiteSpace(txtSQA2Verify.Text) Then
            lblError.Text = "Please enter the answer for Question 2 in the correct fields."
            lblError.ForeColor = Color.Red
            lblError.Show()
            Return
        End If

        ' Validate that second question's answers match each other
        If txtSQA2.Text.Trim() <> txtSQA2Verify.Text.Trim() Then
            lblError.Text = "Security Answer 2 mismatch."
            lblError.ForeColor = Color.Red
            lblError.Show()
            Return
        End If

        ' Verify that Question 1's answer matches the stored answer for Question 1
        ' and Question 2's answer matches the stored answer for Question 2
        If txtSQA1.Text.Trim() = storedAnswer1 AndAlso txtSQA2.Text.Trim() = storedAnswer2 Then
            lblError.Text = "Answers are correct. Security verified!"
            lblError.ForeColor = Color.Green
            lblError.Show()

            Dim parentForm As frmResetAccount = CType(Me.ParentForm, frmResetAccount)
            parentForm.NavigateToNextStep(Me)
        Else
            ' Check if answers might be switched
            If (txtSQA1.Text.Trim() = storedAnswer2 OrElse txtSQA2.Text.Trim() = storedAnswer1) Then
                lblError.Text = "Answers appear to be in the wrong fields. Please check which answer belongs to which question."
                lblError.ForeColor = Color.Red
                lblError.Show()
            Else
                lblError.Text = "Incorrect answers. Please try again."
                lblError.ForeColor = Color.Red
                lblError.Show()
            End If
        End If
    End Sub


End Class
