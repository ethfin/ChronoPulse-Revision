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

    Public Sub NavigateToNextStep(currentForm As Form)
        If TypeOf currentForm Is frmResetAccountEmail Then
            ' Get the email from the email form
            Dim emailForm As frmResetAccountEmail = DirectCast(currentForm, frmResetAccountEmail)

            ' Create new security form instance and set the email
            Dim securityForm As New frmResetAccountSecurity()
            securityForm.lblWelcome1.Text = emailForm.UserEmail

            ' Load the security form into the panel
            LoadStep(securityForm)
        ElseIf TypeOf currentForm Is frmResetAccountSecurity Then
            ' Create the password form and pass the email
            Dim securityForm As frmResetAccountSecurity = DirectCast(currentForm, frmResetAccountSecurity)
            Dim passwordForm As New frmResetAccountPassword()

            ' Pass the email from the security form to the password form
            passwordForm.UserEmail = securityForm.lblWelcome1.Text

            ' Navigate to password form
            LoadStep(passwordForm)
        End If
    End Sub

End Class