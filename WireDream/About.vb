Imports System.Windows.Forms

Public Class About
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(Label3.Text)
        MsgBox("Copied to Clipboard")
    End Sub
End Class