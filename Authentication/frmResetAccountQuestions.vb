Public Class frmResetAccountQuestions
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim parentForm As frmResetAccount = CType(Me.ParentForm, frmResetAccount)
        parentForm.NavigateToNextStep(Me)
    End Sub
End Class