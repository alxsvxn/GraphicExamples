
Public Class GraphicsExamples
    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        g.DrawLine(pen, 150, 150, 100, 100)

        g.Dispose()

    End Sub
    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black, 3)

        g.DrawRectangle(pen, 150, 150, 100, 100)

        g.Dispose()

    End Sub
    Sub DrawEllipse()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black, 3)

        g.DrawEllipse(pen, 250, 250, 150, 150)

        g.Dispose()

    End Sub

    Private Sub GraphicsExamples_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        DrawRectangle()
        DrawEllipse()
    End Sub
    Private Sub GraphicsExamples_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"{e.X},{e.Y})"
    End Sub

End Class
