Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class frmTOS

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
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTOS.MouseDown
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

    Private Sub frmTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the TOS content into the RichTextBox
        rtbTOS.Text = "Terms of Service" & vbCrLf & vbCrLf &
                     "Effective Date: March 20, 2025" & vbCrLf & vbCrLf &
                     "1. Introduction" & vbCrLf &
                     "Welcome to our application. By using our services, you agree to comply with and be bound by the following terms and conditions. Please review them carefully." & vbCrLf & vbCrLf &
                     "2. Data Collection" & vbCrLf &
                     "We collect the following types of data:" & vbCrLf &
                     "- User Experience Data: This includes the user's current experience points (XP) and level. This data is used to track and enhance the user's progress within the application." & vbCrLf &
                     "- Account Data: This includes the user's ID, username, and preferences such as whether to hide their name in the leaderboard." & vbCrLf & vbCrLf &
                     "3. Use of Data" & vbCrLf &
                     "The data we collect is used for the following purposes:" & vbCrLf &
                     "- To provide and improve our services." & vbCrLf &
                     "- To personalize the user experience." & vbCrLf &
                     "- To track user progress and achievements." & vbCrLf &
                     "- To manage user accounts and preferences." & vbCrLf & vbCrLf &
                     "4. Data Storage" & vbCrLf &
                     "User data is stored securely in our database. We use industry-standard security measures to protect your data from unauthorized access, disclosure, alteration, or destruction." & vbCrLf & vbCrLf &
                     "5. User Responsibilities" & vbCrLf &
                     "Users are responsible for maintaining the confidentiality of their account information and for all activities that occur under their account." & vbCrLf & vbCrLf &
                     "6. Changes to the Terms of Service" & vbCrLf &
                     "We reserve the right to modify these terms at any time. Any changes will be effective immediately upon posting the updated terms on our application. Your continued use of the services after any changes constitutes your acceptance of the new terms." & vbCrLf & vbCrLf &
                     "7. Contact Us" & vbCrLf &
                     "If you have any questions about these Terms of Service, please contact us at christophergalano13@gmail.com." & vbCrLf & vbCrLf &
                     "By using our application, you acknowledge that you have read, understood, and agree to be bound by these terms and conditions." & vbCrLf & vbCrLf &
                     "Thank you for using our application!"

        btnAccept.Enabled = False ' Initially disable the Accept button
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        ' Proceed to the signup form
        Dim signupForm As New frmSignup()
        signupForm.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back to the login screen?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub chbAgree_CheckedChanged(sender As Object, e As EventArgs) Handles chbAgree.CheckedChanged
        ' Enable or disable the Accept button based on the checkbox state
        btnAccept.Enabled = chbAgree.Checked
    End Sub
End Class
