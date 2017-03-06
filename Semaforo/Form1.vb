Public Class Form1
    Dim A As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        A = 0
        Timer1.Enabled = True
        Timer1.Interval = 1000

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        A = A + 1
        If A = 1 Then
            Button2.Visible = False
            Button3.Visible = True
            Button4.Visible = True
        End If
        If A = 5 Then
            Button2.Visible = True
            Button3.Visible = False
            Button4.Visible = True

        End If
        If A = 9 Then
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = False
        End If
        If A = 12 Then
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            A = 0

        End If
    End Sub
End Class
