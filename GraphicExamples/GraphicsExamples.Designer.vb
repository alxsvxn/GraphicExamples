<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GraphicsExamples
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForegroundColorTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaveButton = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ForegroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopMenuStrip.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Location = New System.Drawing.Point(46, 67)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(732, 284)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.TopMenuStrip.TabIndex = 1
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorTopMenuItem, Me.BackgroundColorTopMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ForegroundColorTopMenuItem
        '
        Me.ForegroundColorTopMenuItem.Name = "ForegroundColorTopMenuItem"
        Me.ForegroundColorTopMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ForegroundColorTopMenuItem.Text = "Foreground Color"
        '
        'BackgroundColorTopMenuItem
        '
        Me.BackgroundColorTopMenuItem.Name = "BackgroundColorTopMenuItem"
        Me.BackgroundColorTopMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorTopMenuItem.Text = "Background Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'WaveButton
        '
        Me.WaveButton.Location = New System.Drawing.Point(648, 357)
        Me.WaveButton.Name = "WaveButton"
        Me.WaveButton.Size = New System.Drawing.Size(130, 67)
        Me.WaveButton.TabIndex = 2
        Me.WaveButton.Text = "Wave"
        Me.WaveButton.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorContextMenuItem, Me.BackgroundColorContextMenuItem, Me.FontContextMenuItem, Me.ClearContextMenuItem, Me.WidthContextMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(171, 114)
        '
        'ForegroundColorContextMenuItem
        '
        Me.ForegroundColorContextMenuItem.Name = "ForegroundColorContextMenuItem"
        Me.ForegroundColorContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ForegroundColorContextMenuItem.Text = "Foreground Color"
        '
        'BackgroundColorContextMenuItem
        '
        Me.BackgroundColorContextMenuItem.Name = "BackgroundColorContextMenuItem"
        Me.BackgroundColorContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorContextMenuItem.Text = "Background Color"
        '
        'FontContextMenuItem
        '
        Me.FontContextMenuItem.Name = "FontContextMenuItem"
        Me.FontContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FontContextMenuItem.Text = "Font"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ClearContextMenuItem.Text = "Clear"
        '
        'WidthContextMenuItem
        '
        Me.WidthContextMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PickToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.WidthContextMenuItem.Name = "WidthContextMenuItem"
        Me.WidthContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.WidthContextMenuItem.Text = "Width"
        '
        'PickToolStripMenuItem
        '
        Me.PickToolStripMenuItem.Name = "PickToolStripMenuItem"
        Me.PickToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.PickToolStripMenuItem.Text = "Pick"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(408, 357)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(136, 67)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(238, 357)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectColorButton.TabIndex = 4
        Me.SelectColorButton.Text = "Color"
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'GraphicsExamples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.WaveButton)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "GraphicsExamples"
        Me.Text = "Form1"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForegroundColorTopMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WaveButton As Button
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ForegroundColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents FontContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextMenuItem As ToolStripMenuItem
    Friend WithEvents WidthContextMenuItem As ToolStripMenuItem
    Friend WithEvents PickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents ClearButton As Button
    Friend WithEvents SelectColorButton As Button
End Class
