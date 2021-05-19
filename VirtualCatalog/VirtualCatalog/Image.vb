Imports System.Drawing
Public Class Image

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Image_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tt As New ToolTip()
        tt.SetToolTip(PictureBox2, "Close")
    End Sub
End Class