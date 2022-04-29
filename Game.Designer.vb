<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.Grid = New System.Windows.Forms.Panel()
        Me.ImageListPictures = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelName = New System.Windows.Forms.Label()
        Me.LabelGamerName = New System.Windows.Forms.Label()
        Me.PanelCountdown = New System.Windows.Forms.Panel()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.TextBoxTrace = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTrace = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerGame = New System.Windows.Forms.Timer(Me.components)
        Me.ImageListCountdown = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelFlagCount = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.BackColor = System.Drawing.SystemColors.Window
        Me.Grid.Location = New System.Drawing.Point(53, 137)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(186, 158)
        Me.Grid.TabIndex = 1
        '
        'ImageListPictures
        '
        Me.ImageListPictures.ImageStream = CType(resources.GetObject("ImageListPictures.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListPictures.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListPictures.Images.SetKeyName(0, "vide.png")
        Me.ImageListPictures.Images.SetKeyName(1, "1.png")
        Me.ImageListPictures.Images.SetKeyName(2, "2.png")
        Me.ImageListPictures.Images.SetKeyName(3, "3.png")
        Me.ImageListPictures.Images.SetKeyName(4, "4.png")
        Me.ImageListPictures.Images.SetKeyName(5, "5.png")
        Me.ImageListPictures.Images.SetKeyName(6, "6.png")
        Me.ImageListPictures.Images.SetKeyName(7, "7.png")
        Me.ImageListPictures.Images.SetKeyName(8, "8.png")
        Me.ImageListPictures.Images.SetKeyName(9, "default.png")
        Me.ImageListPictures.Images.SetKeyName(10, "drapeau.png")
        Me.ImageListPictures.Images.SetKeyName(11, "mine.png")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PanelFlagCount)
        Me.Panel1.Controls.Add(Me.labelName)
        Me.Panel1.Controls.Add(Me.LabelGamerName)
        Me.Panel1.Controls.Add(Me.PanelCountdown)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 72)
        Me.Panel1.TabIndex = 2
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Location = New System.Drawing.Point(108, 30)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(82, 13)
        Me.labelName.TabIndex = 8
        Me.labelName.Text = "Nom du joueur :"
        '
        'LabelGamerName
        '
        Me.LabelGamerName.AutoSize = True
        Me.LabelGamerName.Location = New System.Drawing.Point(196, 30)
        Me.LabelGamerName.Name = "LabelGamerName"
        Me.LabelGamerName.Size = New System.Drawing.Size(39, 13)
        Me.LabelGamerName.TabIndex = 7
        Me.LabelGamerName.Text = "Label1"
        '
        'PanelCountdown
        '
        Me.PanelCountdown.BackColor = System.Drawing.SystemColors.Window
        Me.PanelCountdown.Location = New System.Drawing.Point(12, 13)
        Me.PanelCountdown.Name = "PanelCountdown"
        Me.PanelCountdown.Size = New System.Drawing.Size(70, 48)
        Me.PanelCountdown.TabIndex = 6
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(284, 302)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(59, 23)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'TextBoxTrace
        '
        Me.TextBoxTrace.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBoxTrace.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxTrace.Location = New System.Drawing.Point(0, 331)
        Me.TextBoxTrace.Multiline = True
        Me.TextBoxTrace.Name = "TextBoxTrace"
        Me.TextBoxTrace.ReadOnly = True
        Me.TextBoxTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxTrace.Size = New System.Drawing.Size(407, 84)
        Me.TextBoxTrace.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(407, 24)
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
        'PanelFlagCount
        '
        Me.PanelFlagCount.BackColor = System.Drawing.SystemColors.Window
        Me.PanelFlagCount.Location = New System.Drawing.Point(325, 13)
        Me.PanelFlagCount.Name = "PanelFlagCount"
        Me.PanelFlagCount.Size = New System.Drawing.Size(70, 48)
        Me.PanelFlagCount.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_IHM_VB.net.My.Resources.Resources.Flag_V2
        Me.PictureBox1.Location = New System.Drawing.Point(286, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 30)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(407, 415)
        Me.Controls.Add(Me.TextBoxTrace)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ButtonStart)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Game"
        Me.Text = "Minesweeper"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ImageListCountdown As ImageList
    Friend WithEvents PanelCountdown As Panel
    Friend WithEvents LabelGamerName As Label
    Friend WithEvents labelName As Label
    Friend WithEvents PanelFlagCount As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
