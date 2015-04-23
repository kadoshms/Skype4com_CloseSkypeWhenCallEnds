Public Class Main
    Public WithEvents oSkype As New SKYPE4COMLib.Skype
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not AxSkype1.Client.IsRunning Then
            AxSkype1.Client.Start(True, True)
        End If
        AxSkype1.Attach(7, True)
    End Sub
    Private Declare Function ShowWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal nCmdShow As Integer) As Integer

    Private Sub AxSkype1_AttachmentStatusEvent(sender As Object, e As AxSKYPE4COMLib._ISkypeEvents_AttachmentStatusEvent) Handles AxSkype1.AttachmentStatusEvent
        Console.WriteLine("Attachment status:" & e.status)
        If e.status = SKYPE4COMLib.TAttachmentStatus.apiAttachAvailable Then
            AxSkype1.Attach(7, True)
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
    Private Sub AxSkype1_CallStatus(sender As Object, e As AxSKYPE4COMLib._ISkypeEvents_CallStatusEvent) Handles AxSkype1.CallStatus
        If AxSkype1.ActiveCalls.Count = 0 Then
            Dim p = Process.GetProcessesByName("skype")(0)
            Dim hWnd As Integer = CType(p.MainWindowHandle, Integer)
            AxSkype1.EndInit()
            ShowWindow(hWnd, 2)
        End If
    End Sub
End Class
