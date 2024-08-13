Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class frmSignup
    ' Constants for handling window dragging
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    ' Import the SendMessage function from user32.dll
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    ' Import the ReleaseCapture function from user32.dll
    <DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    ' Override the window procedure to handle custom window messages
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MAXIMIZE As Integer = &HF030

        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32() = SC_MAXIMIZE Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub

    ' The MouseDown event for the panel to initiate the form dragging
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlLoginContainer.MouseDown, pbxBackground.MouseDown, pnlSignUpProgress.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim path As New GraphicsPath()
        Dim radius As Integer = 50
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        Me.Region = New Region(path)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            frmLogin.Close()
        End If
    End Sub

    Private Sub lnklblSignup_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSignup.LinkClicked
        frmLogin.Show()
        Me.Close()
    End Sub
End Class