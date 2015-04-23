Public Class Form1
    Public WithEvents oSkype As New SKYPE4COMLib.Skype
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxSkype1.Attach(7, True)
    End Sub

    Private Sub AxSkype1_CallStatus(sender As Object, e As AxSKYPE4COMLib._ISkypeEvents_CallStatusEvent) Handles AxSkype1.CallStatus
        If AxSkype1.ActiveCalls.Count = 0 Then
            Process.GetProcessesByName("skype")(0).Kill()
        End If
    End Sub
End Class
