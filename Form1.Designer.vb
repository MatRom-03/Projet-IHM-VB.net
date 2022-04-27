<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Grid = New System.Windows.Forms.Panel()
        Me.ImageListPictures = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PanelCountdown = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.TextBoxTrace = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTrace = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerGame = New System.Windows.Forms.Timer(Me.components)
        Me.ImageListCountdown = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.BackColor = System.Drawing.SystemColors.Window
        Me.Grid.Location = New System.Drawing.Point(148, 116)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(476, 181)
        Me.Grid.TabIndex = 1
        '
        'ImageListPictures
        '
        Me.ImageListPictures.ImageStream = CType(resources.GetObject("ImageListPictures.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListPictures.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListPictures.Images.SetKeyName(0, "1.png")
        Me.ImageListPictures.Images.SetKeyName(1, "2.png")
        Me.ImageListPictures.Images.SetKeyName(2, "3.png")
        Me.ImageListPictures.Images.SetKeyName(3, "4.png")
        Me.ImageListPictures.Images.SetKeyName(4, "5.png")
        Me.ImageListPictures.Images.SetKeyName(5, "6.png")
        Me.ImageListPictures.Images.SetKeyName(6, "7.png")
        Me.ImageListPictures.Images.SetKeyName(7, "8.png")
        Me.ImageListPictures.Images.SetKeyName(8, "default.png")
        Me.ImageListPictures.Images.SetKeyName(9, "drapeau.png")
        Me.ImageListPictures.Images.SetKeyName(10, "mine.png")
        Me.ImageListPictures.Images.SetKeyName(11, "vide.png")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.PanelCountdown)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonStart)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 64)
        Me.Panel1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(321, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'PanelCountdown
        '
        Me.PanelCountdown.BackColor = System.Drawing.SystemColors.Window
        Me.PanelCountdown.Location = New System.Drawing.Point(12, 13)
        Me.PanelCountdown.Name = "PanelCountdown"
        Me.PanelCountdown.Size = New System.Drawing.Size(107, 48)
        Me.PanelCountdown.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(448, 19)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "ButtonStart"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'TextBoxTrace
        '
        Me.TextBoxTrace.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxTrace.Location = New System.Drawing.Point(0, 366)
        Me.TextBoxTrace.Multiline = True
        Me.TextBoxTrace.Name = "TextBoxTrace"
        Me.TextBoxTrace.ReadOnly = True
        Me.TextBoxTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxTrace.Size = New System.Drawing.Size(800, 84)
        Me.TextBoxTrace.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemTrace})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(56, 20)
        Me.ToolStripMenuItem1.Text = "Option"
        '
        'ToolStripMenuItemTrace
        '
        Me.ToolStripMenuItemTrace.Name = "ToolStripMenuItemTrace"
        Me.ToolStripMenuItemTrace.Size = New System.Drawing.Size(101, 22)
        Me.ToolStripMenuItemTrace.Text = "Trace"
        '
        'TimerGame
        '
        Me.TimerGame.Interval = 1000
        '
        'ImageListCountdown
        '
        Me.ImageListCountdown.ImageStream = CType(resources.GetObject("ImageListCountdown.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListCountdown.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListCountdown.Images.SetKeyName(0, "Countdown 0.png")
        Me.ImageListCountdown.Images.SetKeyName(1, "Countdown 1.png")
        Me.ImageListCountdown.Images.SetKeyName(2, "Countdown 2.png")
        Me.ImageListCountdown.Images.SetKeyName(3, "Countdown 3.png")
        Me.ImageListCountdown.Images.SetKeyName(4, "Countdown 4.png")
        Me.ImageListCountdown.Images.SetKeyName(5, "Countdown 5.png")
        Me.ImageListCountdown.Images.SetKeyName(6, "Countdown 6.png")
        Me.ImageListCountdown.Images.SetKeyName(7, "Countdown 7.png")
        Me.ImageListCountdown.Images.SetKeyName(8, "Countdown 8.png")
        Me.ImageListCountdown.Images.SetKeyName(9, "Countdown 9.png")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxTrace)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grid As Panel
    Friend WithEvents ImageListPictures As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonStart As Button
    Friend WithEvents TextBoxTrace As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemTrace As ToolStripMenuItem
    Friend WithEvents TimerGame As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageListCountdown As ImageList
    Friend WithEvents PanelCountdown As Panel
    Friend WithEvents ComboBox1 As ComboBox
End Class
