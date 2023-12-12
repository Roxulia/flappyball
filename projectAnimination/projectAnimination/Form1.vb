Public Class Form1
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim g As Graphics = CreateGraphics()
        g.DrawImage(ImageList1.Images(i), 10, 10)
        i = (i + 1) Mod ImageList1.Images.Count
    End Sub
End Class
