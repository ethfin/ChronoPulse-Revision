Public Class frmResetAccount
    Private Sub frmResetAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStep(New frmResetAccountEmail)
    End Sub

    Private Sub lnklblGoBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblGoBack.LinkClicked
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub LoadStep(ByVal form As Form)
        ' Check if the form is already open
        If pnlResetAccountProgress.Controls.Count > 0 Then
            pnlResetAccountProgress.Controls.RemoveAt(0)
        End If
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        pnlResetAccountProgress.Controls.Add(form)
        pnlResetAccountProgress.Tag = form
        form.Show()
    End Sub

    Public Sub NavigateToNextStep(currentStep As Form)
        If TypeOf currentStep Is frmResetAccountEmail Then
            LoadStep(New frmResetAccountPassword)
        ElseIf TypeOf currentStep Is frmResetAccountPassword Then
            LoadStep(New frmResetAccountSecurity)
        ElseIf TypeOf currentStep Is frmResetAccountSecurity Then
            MessageBox.Show("Account reset process completed.")
            frmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class