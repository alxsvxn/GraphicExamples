
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
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearScreen()
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------
    'NEWCODE ABOVE
    '------------------------------------------------------------------------------------------------------------------------------
    'Private Sub DrawGraticule(g As Graphics)
    '    Dim width = DrawingPictureBox.Width
    '    Dim height = DrawingPictureBox.Height

    '    Dim hSpacing = width / 10   ' Divide into 10 vertical sections
    '    Dim vSpacing = height / 10  ' Divide into 10 horizontal sections

    '    Dim gridPen As New Pen(Color.LightGray, 1) ' Light grid color

    '    ' Vertical lines
    '    For i = 0 To 10
    '        g.DrawLine(gridPen, CInt(i * hSpacing), 0, CInt(i * hSpacing), height)
    '    Next

    '    ' Horizontal lines
    '    For i = 0 To 10
    '        g.DrawLine(gridPen, 0, CInt(i * vSpacing), width, CInt(i * vSpacing))
    '    Next
    'End Sub
    '' Event Handlers ----------------------------------------------------------

    'Private Sub ChangeforegroundColor(sender As Object, e As EventArgs)
    '    Dim result As DialogResult = ColorDialog.ShowDialog()
    '    If result.ToString = "OK" Then
    '        ForegroundColor(ColorDialog.Color)
    '    End If
    'End Sub

    'Private Sub BackgroundColorContextMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorTopMenuItem.Click
    '    Dim result As DialogResult = ColorDialog.ShowDialog()
    '    If result.ToString = "OK" Then
    '        BackgroundColor(ColorDialog.Color)
    '        'This erases everything
    '        'DrawingPictureBox.BackColor = BackgroundColor()
    '    End If
    'End Sub
    'Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
    '    Me.Hide()
    '    AboutForm.Show()
    'End Sub


    'Private Sub WaveButton_Click(sender As Object, e As EventArgs) Handles WaveButton.Click
    '    ' 1. Clear the PictureBox
    '    DrawingPictureBox.Refresh()

    '    ' 2. Force a repaint (triggers DrawingPictureBox_Paint)
    '    DrawingPictureBox.Invalidate()
    'End Sub

End Class