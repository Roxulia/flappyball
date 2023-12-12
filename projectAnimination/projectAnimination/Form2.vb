Public Class Form2
    Dim gravity As Double = 30
    Dim y1 As Integer = 20
    Dim rand1 As Random = New Random
    Dim rand2 As Random = New Random
    Dim score As Integer = 0
    Dim die As Boolean = False
    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click

        Dim b As Integer = PictureBox1.Location.Y
        If b > 0 Then
            PictureBox1.Top = b - 100
        End If
    End Sub

    Private Sub Form2_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

        Dim b As Integer = PictureBox1.Location.Y
        If b > 0 Then



            PictureBox1.Top = b - 100
        End If
    End Sub

    Private Sub Form2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        Dim b As Integer = PictureBox1.Location.Y
        If b > 0 And die <> True Then



            PictureBox1.Top = b - 100
        End If

        
        If (score > 200 And Timer2.Interval > 75) Then
            Timer2.Interval -= 3

        ElseIf (score > 500 And Timer2.Interval > 25) Then
            Timer2.Interval -= 6
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Location.Y < 380 Then

            PictureBox1.Top += gravity

        Else

            Timer1.Enabled() = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            die = True
            Label2.Visible = True
        End If

    End Sub

    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        Label2.Visible = False
        Label1.Visible = True
        Label3.Visible = False
    End Sub
    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim picx1 As Integer = PictureBox2.Location.X
        Dim picx2 As Integer = PictureBox3.Location.X
        Dim picx3 As Integer = PictureBox4.Location.X
        Dim picx4 As Integer = PictureBox5.Location.X
        Dim picx5 As Integer = PictureBox6.Location.X
        Dim picx6 As Integer = PictureBox7.Location.X
        If (PictureBox2.Location.X < -10 And PictureBox3.Location.X < -10) Then
            PictureBox2.Left = 800 - y1

            PictureBox3.Left = 800 - y1
            PictureBox2.Height = rand1.Next(200)
            PictureBox3.Height = 400 - PictureBox2.Height
        Else
            PictureBox2.Left = picx1 - y1
            PictureBox3.Left = picx2 - y1

        End If
        If (PictureBox4.Location.X < -10 And PictureBox6.Location.X < -10) Then
            PictureBox4.Left = 800 - y1

            PictureBox6.Left = 800 - y1
            PictureBox4.Height = rand1.Next(200)
            PictureBox6.Height = 400 - PictureBox4.Height
        Else
            PictureBox4.Left = picx3 - y1
            PictureBox6.Left = picx5 - y1

        End If
        If (PictureBox5.Location.X < -10 And PictureBox7.Location.X < -10) Then
            PictureBox5.Left = 800 - y1

            PictureBox7.Left = 800 - y1
            PictureBox7.Height = rand2.Next(200)
            PictureBox5.Height = 400 - PictureBox7.Height

        Else
            PictureBox5.Left = picx4 - y1
            PictureBox7.Left = picx6 - y1

        End If

    End Sub



    Private Sub Timer3_Tick_1(sender As Object, e As EventArgs) Handles Timer3.Tick

        If (PictureBox1.Location.X >= PictureBox2.Location.X - 20 And PictureBox1.Location.Y <= PictureBox2.Height) Then

            Timer1.Enabled() = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Label2.Visible = True
            die = True


        ElseIf (PictureBox1.Location.X >= PictureBox3.Location.X - 20 And PictureBox1.Location.Y >= PictureBox3.Location.Y - 20) Then
            Timer1.Enabled() = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Label2.Visible = True
            die = True
        ElseIf (PictureBox1.Location.X >= PictureBox4.Location.X - 20 And PictureBox1.Location.Y <= PictureBox4.Height) Then
            Timer1.Enabled() = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Label2.Visible = True
            die = True
        ElseIf (PictureBox1.Location.X >= PictureBox5.Location.X - 20 And PictureBox1.Location.Y >= PictureBox5.Location.Y - 20) Then
            Timer1.Enabled() = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Label2.Visible = True
            die = True
        ElseIf (PictureBox1.Location.X >= PictureBox6.Location.X - 20 And PictureBox1.Location.Y >= PictureBox6.Location.Y) Then
            Timer1.Enabled() = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Label2.Visible = True
            die = True
        ElseIf (PictureBox1.Location.X >= PictureBox7.Location.X - 20 And PictureBox1.Location.Y <= PictureBox7.Height) Then
            Timer1.Enabled() = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Label2.Visible = True
            die = True
        End If
        If (PictureBox1.Location.X >= PictureBox2.Location.X - 40 And PictureBox1.Location.Y > PictureBox2.Height) Then
            score = score + 1
            Label3.Text = score.ToString()
        ElseIf (PictureBox1.Location.X >= PictureBox3.Location.X - 40 And PictureBox1.Location.Y > PictureBox3.Height) Then
            score = score + 1
            Label3.Text = score.ToString()
        ElseIf (PictureBox1.Location.X >= PictureBox4.Location.X - 40 And PictureBox1.Location.Y > PictureBox4.Height) Then
            score = score + 1
            Label3.Text = score.ToString()
        ElseIf (PictureBox1.Location.X >= PictureBox5.Location.X - 40 And PictureBox1.Location.Y > PictureBox5.Height) Then
            score = score + 1
            Label3.Text = score.ToString()
        ElseIf (PictureBox1.Location.X >= PictureBox6.Location.X - 40 And PictureBox1.Location.Y > PictureBox6.Height) Then
            score = score + 1
            Label3.Text = score.ToString()
        ElseIf (PictureBox1.Location.X >= PictureBox7.Location.X - 40 And PictureBox1.Location.Y > PictureBox7.Height) Then
            score = score + 1
            Label3.Text = score.ToString()
        End If
        

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Dim y As Integer = PictureBox1.Location.Y = Me.Height / 2
        PictureBox4.Height = rand1.Next(200)
        PictureBox5.Height = rand2.Next(200)
        PictureBox6.Height = rand1.Next(200)
        PictureBox7.Height = rand2.Next(200)
        PictureBox2.Height = rand1.Next(Me.Height / 2)
        PictureBox3.Height = rand2.Next(Me.Height / 2)
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frmStarting.Show()
        Me.Hide()
        Me.Refresh()
        Me.Dispose()
    End Sub

End Class