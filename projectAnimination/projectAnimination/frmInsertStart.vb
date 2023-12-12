Public Class frmInsertStart
    Dim rand As Random = New Random
    Private Sub frmInsertStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If PictureBox1.Location.Y < -12 Then
            PictureBox1.Left = rand.Next(400)
            PictureBox1.Top = 300 - 10
        Else
            PictureBox1.Top = PictureBox1.Location.Y - 10
        End If
        If PictureBox2.Location.Y < -12 Then
            PictureBox2.Left = rand.Next(400)
            PictureBox2.Top = 300 - 10
        Else
            PictureBox2.Top = PictureBox2.Location.Y - 10
        End If
        If PictureBox3.Location.Y < -12 Then
            PictureBox3.Left = rand.Next(400)
            PictureBox3.Top = 300 - 10
        Else
            PictureBox3.Top = PictureBox3.Location.Y - 10
        End If
        If PictureBox4.Location.Y < -12 Then
            PictureBox4.Left = rand.Next(400)
            PictureBox4.Top = 300 - 10
        Else
            PictureBox4.Top = PictureBox4.Location.Y - 10
        End If
        If PictureBox5.Location.Y < -12 Then
            PictureBox5.Left = rand.Next(400)
            PictureBox5.Top = 300 - 10
        Else
            PictureBox5.Top = PictureBox5.Location.Y - 10
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frmInsect.Show()
        Me.Hide()
    End Sub
End Class