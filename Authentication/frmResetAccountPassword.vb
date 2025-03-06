Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmResetAccountPassword

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32() = SC_MAXIMIZE Then
            Return
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


    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        lblError.Text = ""

        If txtPassword.Text = txtVerifyPassword.Text AndAlso txtPassword.Text <> "" Then
            If ValidatePassword(txtPassword.Text) Then
                Dim conn As MySqlConnection = createDBConnection()
                Try
                    conn.Open()
                    Dim cmd As MySqlCommand = conn.CreateCommand
                    cmd.CommandText = "UPDATE dbaccounts SET password = @password WHERE email = @email"
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@email", frmResetAccountSecurity.lblWelcome1.Text)
                    cmd.ExecuteNonQuery()
                    lblError.Text = "Password has been reset successfully."
                    lblError.ForeColor = Color.Green
                    lblError.Show()

                    Dim parentForm As frmResetAccount = CType(Me.ParentForm, frmResetAccount)
                    parentForm.NavigateToNextStep(Me)
                Catch ex As Exception
                    lblError.Text = "An error occurred while resetting the password. Please try again."
                    lblError.ForeColor = Color.Red
                    lblError.Show()
                Finally
                    conn.Close()
                End Try
            Else
                lblError.Text = "Password does not meet the complexity requirements. Please try again."
                lblError.ForeColor = Color.Red
                lblError.Show()
            End If
        Else
            lblError.Text = "Passwords do not match or are empty. Please try again."
            lblError.ForeColor = Color.Red
            lblError.Show()
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.PasswordChar = If(chkShowPassword.Checked, "", "*")
    End Sub

    Private Sub chkShowVerifyPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword2.CheckedChanged
        txtVerifyPassword.PasswordChar = If(chkShowPassword2.Checked, "", "*")
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ComparePasswords()
    End Sub

    Private Sub txtVerifyPassword_TextChanged(sender As Object, e As EventArgs) Handles txtVerifyPassword.TextChanged
        ComparePasswords()
    End Sub

    Private Sub ComparePasswords()
        If txtPassword.Text = txtVerifyPassword.Text Then
            If ValidatePassword(txtPassword.Text) Then
                txtPassword.BorderColor = Color.Green
                txtVerifyPassword.BorderColor = Color.Green
                lblError.ForeColor = Color.Green
                lblError.Text = "Password matches and meets requirements."
            Else
                txtPassword.BorderColor = Color.Red
                txtVerifyPassword.BorderColor = Color.Red
                lblError.ForeColor = Color.Red
                lblError.Text = "Password must be at least 8 characters, contain numbers, and special characters, and should not include : ; "" ' / \\."
            End If
        Else
            txtPassword.BorderColor = Color.Red
            txtVerifyPassword.BorderColor = Color.Red
            lblError.ForeColor = Color.Red
            lblError.Text = "Passwords do not match."
        End If
        lblError.Show()
    End Sub

    Function ValidatePassword(ByVal pwd As String) As Boolean
        If Len(pwd) < 8 Then Return False

        Dim hasNumber As New Regex("[0-9]")
        Dim hasLetter As New Regex("[a-zA-Z]")
        Dim hasSpecial As New Regex("[^a-zA-Z0-9]")
        Dim invalidChars As New Regex("[ :;""'/\\]")

        If hasNumber.Matches(pwd).Count < 1 OrElse hasLetter.Matches(pwd).Count < 1 OrElse hasSpecial.Matches(pwd).Count < 1 Then
            Return False
        End If

        If invalidChars.Matches(pwd).Count > 0 Then
            Return False
        End If

        Return True
    End Function

    Private Sub frmResetAccountPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Select()
    End Sub
End Class