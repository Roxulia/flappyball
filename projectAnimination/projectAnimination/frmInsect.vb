Public Class frmInsect
    Dim rand As Random = New Random
    Dim score As Integer = 0
    Private Sub frmInsect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Left = rand.Next(390)
        PictureBox2.Left = rand.Next(390)
        PictureBox3.Left = rand.Next(390)
        PictureBox4.Left = rand.Next(390)
        PictureBox5.Left = rand.Next(390)
        PictureBox6.Left = rand.Next(390)
        PictureBox7.Left = rand.Next(390)
        Label3.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Location.Y < 37 Then

            Timer1.Enabled = False
            Label3.Visible = True
            Label4.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Label1.Visible = False
            Label2.Visible = False
        Else
            PictureBox1.Top = PictureBox1.Location.Y - 10
        End If
        If PictureBox2.Location.Y < 37 Then
            Timer1.Enabled = False
            Label3.Visible = True
            Label4.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Label1.Visible = False
            Label2.Visible = False

        Else
            PictureBox2.Top = PictureBox2.Location.Y - 10
        End If
        If PictureBox3.Location.Y < 37 Then
            Timer1.Enabled = False
            Label3.Visible = True
            Label4.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Label1.Visible = False
            Label2.Visible = False

        Else
            PictureBox3.Top = PictureBox3.Location.Y - 10
        End If
        If PictureBox4.Location.Y < 37 Then
            Timer1.Enabled = False
            Label3.Visible = True
            Label4.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Label1.Visible = False
            Label2.Visible = False

        Else
            PictureBox4.Top = PictureBox4.Location.Y - 10
        End If
        If PictureBox5.Location.Y < 37 Then
            Timer1.Enabled = False
            Label3.Visible = True
            Label4.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Label1.Visible = False
            Label2.Visible = False
        Else
            PictureBox5.Top = PictureBox5.Location.Y - 10
        End If
        If PictureBox6.Location.Y < 37 Then
            Timer1.Enabled = False
            Label3.Visible = True
            Label4.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Label1.Visible = False
            Label2.Visible = False
        Else
            PictureBox6.Top = PictureBox6.Location.Y - 10
        End If
        If PictureBox7.Location.Y < 37 Then
            Timer1.Enabled = False
            Label3.Visible = True
            Label4.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            Label1.Visible = False
            Label2.Visible = False
        Else
            PictureBox7.Top = PictureBox7.Location.Y - 10
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Dispose()
        frmInsertStart.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Left = rand.Next(330)
        PictureBox1.Top = 325 - 10
        score = score + 1
        Label2.Text = score.ToString()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Left = rand.Next(330)
        PictureBox2.Top = 325 - 10
        score = score + 1
        Label2.Text = score.ToString()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Left = rand.Next(330)
        PictureBox3.Top = 325 - 10
        score = score + 1
        Label2.Text = score.ToString()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox4.Left = rand.Next(330)
        PictureBox4.Top = 325 - 10
        score = score + 1
        Label2.Text = score.ToString()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox5.Left = rand.Next(330)
        PictureBox5.Top = 325 - 10
        score = score + 1
        Label2.Text = score.ToString()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox6.Left = rand.Next(330)
        PictureBox6.Top = 325 - 10
        score = score + 1
        Label2.Text = score.ToString()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.Left = rand.Next(330)
        PictureBox7.Top = 325 - 10
        score = score + 1
        Label2.Text = score.ToString()
    End Sub
End Class