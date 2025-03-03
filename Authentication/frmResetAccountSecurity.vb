Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmResetAccountSecurity
    Private prevSelectedIndex1 As Integer = -1
    Private prevSelectedIndex2 As Integer = -1 ' Added a separate variable for cmbSecurityQ2

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND Then
            If m.WParam.ToInt32() = SC_MAXIMIZE Then
                Return
            End If
        End If

        MyBase.WndProc(m)
    End Sub

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub lblWelcome1_Click(sender As Object, e As EventArgs) Handles lblWelcome1.Click

    End Sub

    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        If cbxShowPassword.Checked Then
            txtSQA1.PasswordChar = ""
            txtSQA1Verify.PasswordChar = ""
        Else
            txtSQA1.PasswordChar = "*"
            txtSQA1Verify.PasswordChar = "*"
        End If
    End Sub

    Private Sub cbxShowPassword2_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword2.CheckedChanged
        If cbxShowPassword2.Checked Then
            txtSQA2.PasswordChar = ""
            txtSQA2Verify.PasswordChar = ""
        Else
            txtSQA2.PasswordChar = "*"
            txtSQA2Verify.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtSQA1Verify_TextChanged(sender As Object, e As EventArgs) Handles txtSQA1Verify.TextChanged
        compareAnswer1()
    End Sub

    Private Sub txtSQA1_TextChanged(sender As Object, e As EventArgs) Handles txtSQA1.TextChanged
        compareAnswer3()
    End Sub

    Function compareAnswer1() As Boolean
        If txtSQA1.Text = txtSQA1Verify.Text Then
            If ValidateSecurity(txtSQA1.Text) Then
                txtSQA1.BorderColor = Color.Green
                txtSQA1Verify.BorderColor = Color.Green
                lblError.ForeColor = Color.Green
                lblError.Text = "Answer for Security Question 1 are the same"
                Return True
            Else
                txtSQA1.Text = txtSQA1Verify.Text
                txtSQA1.BorderColor = Color.Red
                txtSQA1Verify.BorderColor = Color.Red
                lblError.ForeColor = Color.Red
                lblError.Text = "Fill in the the following fields"
                lblError.Show()
                Return False
            End If
        Else
            txtSQA1.BorderColor = Color.Red
            txtSQA1Verify.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "Answer for Security Question 1 are different"
            Return False
        End If
        lblError.Show()
    End Function

    Function compareAnswer3() As Boolean
        If txtSQA1Verify.Text = txtSQA1.Text Then
            If ValidateSecurity(txtSQA1Verify.Text) Then
                txtSQA1.BorderColor = Color.Green
                txtSQA1Verify.BorderColor = Color.Green
                lblError.ForeColor = Color.Green
                lblError.Text = "Answer for Security Question 1 are the same"
                Return True
            Else
                txtSQA1Verify.Text = txtSQA1.Text
                txtSQA1.BorderColor = Color.Red
                txtSQA1Verify.BorderColor = Color.Red
                lblError.ForeColor = Color.Red
                lblError.Text = "Fill in the the following fields"
                lblError.Show()
                Return False
            End If
        Else
            txtSQA1.BorderColor = Color.Red
            txtSQA1Verify.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "Answer for Security Question 1 are different"
            Return False
        End If
        lblError.Show()
    End Function

    Private Sub txtSQA2Verify_TextChanged(sender As Object, e As EventArgs) Handles txtSQA2Verify.TextChanged
        compareAnswer2()
    End Sub

    Private Sub txtSQA2_TextChanged(sender As Object, e As EventArgs) Handles txtSQA2.TextChanged
        compareAnswer4()
    End Sub

    Function compareAnswer2() As Boolean
        If txtSQA2.Text = txtSQA2Verify.Text Then
            If ValidateSecurity(txtSQA2.Text) Then
                txtSQA2.BorderColor = Color.Green
                txtSQA2Verify.BorderColor = Color.Green
                lblError2.ForeColor = Color.Green
                lblError2.Text = "Answer for Security Question 2 are the same"
                Return True
            Else
                txtSQA2.Text = txtSQA2Verify.Text
                txtSQA2.BorderColor = Color.Red
                txtSQA2Verify.BorderColor = Color.Red
                lblError2.ForeColor = Color.Red
                lblError2.Text = "Fill in the the following fields"
                lblError2.Show()
                Return False
            End If
        Else
            txtSQA2.BorderColor = Color.Red
            txtSQA2Verify.BorderColor = Color.Red
            lblError2.ForeColor = Color.Red
            lblError2.Text = "Answer for Security Question 2 are different"
            Return False
        End If
        lblError2.Show()
    End Function

    Function compareAnswer4() As Boolean
        If txtSQA2Verify.Text = txtSQA2.Text Then
            If ValidateSecurity(txtSQA2.Text) Then
                txtSQA2.BorderColor = Color.Green
                txtSQA2Verify.BorderColor = Color.Green
                lblError2.ForeColor = Color.Green
                lblError2.Text = "Answer for Security Question 2 are the same"
                Return True
            Else
                txtSQA2Verify.Text = txtSQA2.Text
                txtSQA2.BorderColor = Color.Red
                txtSQA2Verify.BorderColor = Color.Red
                lblError2.ForeColor = Color.Red
                lblError2.Text = "Fill in the the following fields"
                lblError2.Show()
                Return False
            End If
        Else
            txtSQA2.BorderColor = Color.Red
            txtSQA2Verify.BorderColor = Color.Red
            lblError2.ForeColor = Color.Red
            lblError2.Text = "Answer for Security Question 2 are different"
            Return False
        End If
        lblError2.Show()
    End Function

    Function ValidateSecurity(ByVal pwd As String) As Boolean
        If Len(pwd) < 1 Then
            Return False
        End If
        Return True
    End Function

    Private Function ValidateInputFields() As Boolean
        If String.IsNullOrWhiteSpace(txtSQA1.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA1Verify.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA2.Text) OrElse
           String.IsNullOrWhiteSpace(txtSQA2Verify.Text) Then

            MessageBox.Show("Please fill in all fields.")
            Return False
        End If

        If Not txtSQA1.Text.Equals(txtSQA1Verify.Text) OrElse
               Not txtSQA2.Text.Equals(txtSQA2Verify.Text) Then
            MessageBox.Show("Passwords do not match.")
            Return False
        End If

        Return True
    End Function

    ' Helper function to safely get selected item text
    Private Function GetSelectedItemText(combo As ComboBox) As String
        If combo.SelectedItem IsNot Nothing Then
            Return combo.SelectedItem.ToString()
        Else
            Return String.Empty
        End If
    End Function

    Private Sub frmResetAccountSecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the security questions
        PopulateSecurityQuestions()
        cmbSQ1.Select()
    End Sub

    ' New method to populate security questions
    Private Sub PopulateSecurityQuestions()
        ' Remove event handlers temporarily to prevent triggering during population
        RemoveHandler cmbSQ1.SelectedIndexChanged, AddressOf cmbSQ1_SelectedIndexChanged
        RemoveHandler cmbSQ2.SelectedIndexChanged, AddressOf cmbSQ2_SelectedIndexChanged

        ' Clear existing items
        cmbSQ1.Items.Clear()
        cmbSQ2.Items.Clear()

        ' Add security questions
        Dim securityQuestions As String() = {
               "What was the name of your first stuffed animal or doll?",
               "In what city did your parents meet?",
               "What was the first concert you ever attended?",
               "What is the name of the street where you grew up?",
               "What was the make and model of your first car?",
               "What was the name of your favorite teacher in elementary school?",
               "What was your childhood best friend’s nickname?",
               "What’s your pet’s name?",
               "What’s your favorite color?",
               "What’s your lucky number?"
           }

        ' Add items to both combo boxes
        For Each question As String In securityQuestions
            cmbSQ1.Items.Add(question)
            cmbSQ2.Items.Add(question)
        Next

        ' Reattach event handlers
        AddHandler cmbSQ1.SelectedIndexChanged, AddressOf cmbSQ1_SelectedIndexChanged
        AddHandler cmbSQ2.SelectedIndexChanged, AddressOf cmbSQ2_SelectedIndexChanged
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim email As String = lblWelcome1.Text

        ' Check if both combo boxes have selected items
        If cmbSQ1.SelectedIndex = -1 OrElse cmbSQ2.SelectedIndex = -1 OrElse
       cmbSQ1.SelectedItem Is Nothing OrElse cmbSQ2.SelectedItem Is Nothing Then
            MessageBox.Show("Please select both security questions.")
            Return
        End If

        If ValidateInputFields() Then
            Dim conn As MySqlConnection = createDBConnection()

            Try
                conn.Open()

                ' Use safe method to get selected text
                Dim sq1 As String = GetSelectedItemText(cmbSQ1)
                Dim sq2 As String = GetSelectedItemText(cmbSQ2)

                ' Check if we have valid questions
                If String.IsNullOrEmpty(sq1) OrElse String.IsNullOrEmpty(sq2) Then
                    MessageBox.Show("Please select valid security questions.")
                    Return
                End If

                ' Fixed query with correct question-answer relationships
                Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE email = @Email AND " &
                                 "((securityQuestion1 = @SQ1 AND securityAnswer1 = @SQA1) OR " &
                                 "(securityQuestion2 = @SQ1 AND securityAnswer2 = @SQA1)) AND " &
                                 "((securityQuestion1 = @SQ2 AND securityAnswer1 = @SQA2) OR " &
                                 "(securityQuestion2 = @SQ2 AND securityAnswer2 = @SQA2))"

                Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@SQ1", sq1)
                cmd.Parameters.AddWithValue("@SQA1", txtSQA1.Text)
                cmd.Parameters.AddWithValue("@SQ2", sq2)
                cmd.Parameters.AddWithValue("@SQA2", txtSQA2.Text)

                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If result > 0 Then
                    Me.Hide()
                    frmResetAccountPassword.Show()
                Else
                    lblError.ForeColor = Color.Red
                    lblError.Text = "Invalid Security Questions and Answers."
                    lblError.Show()
                    lblError2.ForeColor = Color.Red
                    lblError2.Text = "Invalid Security Questions and Answers."
                    lblError2.Show()
                End If

            Catch ex As Exception
                lblError.ForeColor = Color.Red
                lblError.Text = "Error: " & ex.Message
                lblError.Show()
                lblError2.ForeColor = Color.Red
                lblError2.Text = "Error: " & ex.Message
                lblError2.Show()
            Finally
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub

    ' Completely rewritten combo box selection handlers
    Private Sub cmbSQ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSQ1.SelectedIndexChanged
        ' Skip if nothing is selected or during initialization
        If cmbSQ1.SelectedIndex = -1 Then Return

        ' Store current selection from both combo boxes
        Dim selectedSQ1 As String = If(cmbSQ1.SelectedItem IsNot Nothing, cmbSQ1.SelectedItem.ToString(), String.Empty)
        Dim selectedSQ2 As String = If(cmbSQ2.SelectedItem IsNot Nothing, cmbSQ2.SelectedItem.ToString(), String.Empty)

        ' Only take action if both have selections and they're the same
        If Not String.IsNullOrEmpty(selectedSQ1) AndAlso selectedSQ1 = selectedSQ2 Then
            ' Clear the other combo box's selection to avoid duplicates
            cmbSQ2.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmbSQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSQ2.SelectedIndexChanged
        ' Skip if nothing is selected or during initialization
        If cmbSQ2.SelectedIndex = -1 Then Return

        ' Store current selection from both combo boxes
        Dim selectedSQ1 As String = If(cmbSQ1.SelectedItem IsNot Nothing, cmbSQ1.SelectedItem.ToString(), String.Empty)
        Dim selectedSQ2 As String = If(cmbSQ2.SelectedItem IsNot Nothing, cmbSQ2.SelectedItem.ToString(), String.Empty)

        ' Only take action if both have selections and they're the same
        If Not String.IsNullOrEmpty(selectedSQ2) AndAlso selectedSQ1 = selectedSQ2 Then
            ' Clear the other combo box's selection to avoid duplicates
            cmbSQ1.SelectedIndex = -1
        End If
    End Sub

    Public Sub SetEmail(email As String)
        lblWelcome1.Text = email
    End Sub
End Class
