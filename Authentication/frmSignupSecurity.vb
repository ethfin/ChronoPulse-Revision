Public Class frmSignupSecurity
    Private prevSelectedIndex1 As Integer = -1
    Private prevSelectedIndex2 As Integer = -1

    Private Sub lnklblGoBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub cmbQuestion1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuestion1.SelectedIndexChanged
        ' Handle changes in cmbSecurityQ1
        If cmbQuestion1.SelectedIndex <> -1 AndAlso prevSelectedIndex2 <> -1 Then
            ' Add the previously selected item back to cmbSecurityQ2
            cmbQuestion2.Items.Insert(prevSelectedIndex2, cmbQuestion2.Tag)
        End If
        ' Remove the currently selected item of cmbSecurityQ1 from cmbSecurityQ2
        If cmbQuestion2.Items.Contains(cmbQuestion1.SelectedItem) Then
            prevSelectedIndex2 = cmbQuestion2.Items.IndexOf(cmbQuestion1.SelectedItem)
            cmbQuestion2.Tag = cmbQuestion1.SelectedItem ' Store the removed item
            cmbQuestion2.Items.Remove(cmbQuestion1.SelectedItem)
        End If
    End Sub

    Private Sub cmbQuestion2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuestion2.SelectedIndexChanged
        ' Handle changes in cmbSecurityQ2
        If cmbQuestion2.SelectedIndex <> -1 AndAlso prevSelectedIndex1 <> -1 Then
            ' Add the previously selected item back to cmbSecurityQ1
            cmbQuestion1.Items.Insert(prevSelectedIndex1, cmbQuestion1.Tag)
        End If
        ' Remove the currently selected item of cmbSecurityQ2 from cmbSecurityQ1
        If cmbQuestion1.Items.Contains(cmbQuestion2.SelectedItem) Then
            prevSelectedIndex1 = cmbQuestion1.Items.IndexOf(cmbQuestion2.SelectedItem)
            cmbQuestion1.Tag = cmbQuestion2.SelectedItem ' Store the removed item
            cmbQuestion1.Items.Remove(cmbQuestion2.SelectedItem)
        End If
    End Sub

    Private Sub txtSQAnswer1_Leave(sender As Object, e As EventArgs) Handles txtSQAnswer1.Leave
        CompareAnswersQ1()
    End Sub

    Private Sub txtSQAnswer2_Leave(sender As Object, e As EventArgs) Handles txtSQAnswer2.Leave
        CompareAnswersQ2()
    End Sub

    Private Sub txtSQVAnswer1_Leave(sender As Object, e As EventArgs) Handles txtSQVAnswer1.Leave
        CompareAnswersQ1()
    End Sub

    Private Sub txtSQVAnswer2_Leave(sender As Object, e As EventArgs) Handles txtSQVAnswer2.Leave
        CompareAnswersQ2()
    End Sub

    'compare the answers of answer 1 and answer 2
    Private Function CompareAnswersQ1() As Boolean
        If txtSQAnswer1.Text = txtSQVAnswer1.Text Then
            lblErrorMsg.Hide()
            txtSQAnswer1.BorderColor = Color.FromArgb(213, 218, 223)
            txtSQVAnswer1.BorderColor = Color.FromArgb(213, 218, 223)
            Return True
        Else
            lblErrorMsg.Text = "Answers do not match."
            lblErrorMsg.Visible = True
            lblErrorMsg.ForeColor = Color.Red
            txtSQAnswer1.BorderColor = Color.Red
            txtSQVAnswer1.BorderColor = Color.Red
            Return False
        End If
    End Function

    Private Function CompareAnswersQ2() As Boolean
        If txtSQAnswer2.Text = txtSQVAnswer2.Text Then
            lblErrorMsg.Hide()
            txtSQAnswer2.BorderColor = Color.FromArgb(213, 218, 223)
            txtSQVAnswer2.BorderColor = Color.FromArgb(213, 218, 223)
            Return True
        Else
            lblErrorMsg.Text = "Answers do not match."
            lblErrorMsg.Visible = True
            lblErrorMsg.ForeColor = Color.Red
            txtSQAnswer2.BorderColor = Color.Red
            txtSQVAnswer2.BorderColor = Color.Red
            Return False
        End If
    End Function

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowAnswer1.CheckedChanged
        If cbxShowAnswer1.Checked Then
            txtSQAnswer1.PasswordChar = ""
            txtSQVAnswer1.PasswordChar = ""
        Else
            txtSQAnswer1.PasswordChar = "*"
            txtSQVAnswer1.PasswordChar = "*"
        End If
    End Sub

    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowAnswer2.CheckedChanged
        If cbxShowAnswer2.Checked Then
            txtSQAnswer2.PasswordChar = ""
            txtSQVAnswer2.PasswordChar = ""
        Else
            txtSQAnswer2.PasswordChar = "*"
            txtSQVAnswer2.PasswordChar = "*"
        End If
    End Sub
End Class