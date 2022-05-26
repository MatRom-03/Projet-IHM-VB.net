<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.ComboBoxNameGamer = New System.Windows.Forms.ComboBox()
        Me.BtnStats = New System.Windows.Forms.Button()
        Me.BtnNewGame = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LabelNameGamer = New System.Windows.Forms.Label()
        Me.TextBoxTrace = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTrace = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProviderLauncher = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProviderLauncher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxNameGamer
        '
        Me.ComboBoxNameGamer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxNameGamer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxNameGamer.FormattingEnabled = True
        Me.ComboBoxNameGamer.Location = New System.Drawing.Point(154, 107)
        Me.ComboBoxNameGamer.Name = "ComboBoxNameGamer"
        Me.ComboBoxNameGamer.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxNameGamer.TabIndex = 0
        '
        'BtnStats
        '
        Me.BtnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStats.Location = New System.Drawing.Point(26, 222)
        Me.BtnStats.Name = "BtnStats"
        Me.BtnStats.Size = New System.Drawing.Size(82, 30)
        Me.BtnStats.TabIndex = 1
        Me.BtnStats.Text = "Statistiques"
        Me.BtnStats.UseVisualStyleBackColor = True
        '
        'BtnNewGame
        '
        Me.BtnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewGame.Location = New System.Drawing.Point(120, 222)
        Me.BtnNewGame.Name = "BtnNewGame"
        Me.BtnNewGame.Size = New System.Drawing.Size(111, 30)
        Me.BtnNewGame.TabIndex = 2
        Me.BtnNewGame.Text = "Nouvelle Partie"
        Me.BtnNewGame.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(240, 222)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 30)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Quitter"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LabelNameGamer
        '
        Me.LabelNameGamer.AutoSize = True
        Me.LabelNameGamer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameGamer.Location = New System.Drawing.Point(56, 110)
        Me.LabelNameGamer.Name = "LabelNameGamer"
        Me.LabelNameGamer.Size = New System.Drawing.Size(95, 15)
        Me.LabelNameGamer.TabIndex = 4
        Me.LabelNameGamer.Text = "Nom du joueur :"
        '
        'TextBoxTrace
        '
        Me.TextBoxTrace.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBoxTrace.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxTrace.Location = New System.Drawing.Point(0, 285)
        Me.TextBoxTrace.Multiline = True
        Me.TextBoxTrace.Name = "TextBoxTrace"
        Me.TextBoxTrace.ReadOnly = True
        Me.TextBoxTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxTrace.Size = New System.Drawing.Size(359, 84)
        Me.TextBoxTrace.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemTrace, Me.ToolStripMenuItemSettings})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "Options"
        '
        'ToolStripMenuItemTrace
        '
        Me.ToolStripMenuItemTrace.Name = "ToolStripMenuItemTrace"
        Me.ToolStripMenuItemTrace.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItemTrace.Text = "Trace"
        '
        'ToolStripMenuItemSettings
        '
        Me.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings"
        Me.ToolStripMenuItemSettings.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItemSettings.Text = "Settings"
        '
        'ErrorProviderLauncher
        '
        Me.ErrorProviderLauncher.ContainerControl = Me
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(359, 369)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBoxTrace)
        Me.Controls.Add(Me.LabelNameGamer)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnNewGame)
        Me.Controls.Add(Me.BtnStats)
        Me.Controls.Add(Me.ComboBoxNameGamer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Démineur"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProviderLauncher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxNameGamer As ComboBox
    Friend WithEvents BtnStats As Button
    Friend WithEvents BtnNewGame As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LabelNameGamer As Label
    Friend WithEvents TextBoxTrace As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemTrace As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSettings As ToolStripMenuItem
    Friend WithEvents ErrorProviderLauncher As ErrorProvider
End Class
