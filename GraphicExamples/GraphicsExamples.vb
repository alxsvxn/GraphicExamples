'Alexis Villagran
'RCET
'Spring 2025
'Etch-A-Sketch
'https://github.com/alxsvxn/GraphicExamples
Public Class GraphicsExamples

    Function ForegroundColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = Color.Black

        If newColor <> Nothing Then
            _foreColor = newColor
        End If

        Return _foreColor
    End Function

    Function PenWidth(Optional newWidth As Integer = -1) As Integer
        Static _penWidth As Integer = 2
        If newWidth > 0 AndAlso newWidth <= 100 Then _penWidth = newWidth
        Return _penWidth
    End Function

    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForegroundColor, PenWidth())

        g.DrawLine(pen, oldX, oldY, newX, newY)

        g.Dispose()
    End Sub
    Sub DrawGraticule()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(Color.LightGray)

        Dim spacingX As Double = DrawingPictureBox.Width / 10.0
        Dim spacingY As Double = DrawingPictureBox.Height / 10.0

        For i As Integer = 1 To 9
            g.DrawLine(pen, CInt(i * spacingX), 0, CInt(i * spacingX), DrawingPictureBox.Height)
            g.DrawLine(pen, 0, CInt(i * spacingY), DrawingPictureBox.Width, CInt(i * spacingY))
        Next
        g.Dispose()
    End Sub
    Sub SelectColor()
        Dim cd As New ColorDialog()
        If cd.ShowDialog() = DialogResult.OK Then
            ForegroundColor(cd.Color)
        End If
    End Sub
    Private Sub DisplayPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        Static oldX, oldY As Integer

        Select Case e.Button
            Case MouseButtons.Left
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case MouseButtons.Middle
                SelectColor()
        End Select

        oldX = e.X
        oldY = e.Y
    End Sub
    Sub ClearScreen()
        DrawingPictureBox.Refresh()
    End Sub
    Sub DrawWaveforms()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim centerY As Integer = DrawingPictureBox.Height \ 2
        Dim scaleX As Double = 10
        Dim scaleY As Double = 50
        Dim sinPen As New Pen(Color.Blue)
        Dim cosPen As New Pen(Color.Red)
        Dim tanPen As New Pen(Color.Green)
        Dim sinPoints(DrawingPictureBox.Width - 1) As Point
        Dim cosPoints(DrawingPictureBox.Width - 1) As Point
        Dim tanPoints(DrawingPictureBox.Width - 1) As Point

        For x As Integer = 0 To DrawingPictureBox.Width - 1
            sinPoints(x) = New Point(x, CInt(centerY - Math.Sin(x / scaleX) * scaleY))
            cosPoints(x) = New Point(x, CInt(centerY - Math.Cos(x / scaleX) * scaleY))

            Dim tanY As Double = Math.Tan(x / scaleX)
            If Math.Abs(tanY) < 10 Then
                tanPoints(x) = New Point(x, CInt(centerY - tanY * scaleY))
            Else
                tanPoints(x) = New Point(x, -1000) 'incase too big
            End If
        Next
        g.DrawLines(sinPen, sinPoints)
        g.DrawLines(cosPen, cosPoints)
        g.DrawLines(tanPen, tanPoints)

        g.Dispose()
    End Sub
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click
        SelectColor()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearScreen()
    End Sub

    Private Sub WaveButton_Click(sender As Object, e As EventArgs) Handles WaveButton.Click
        DrawingPictureBox.Refresh()
        DrawGraticule()
        DrawWaveforms()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Etch-A-Sketch 1.0.0" & vbCrLf & "Created by Alexis V", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class