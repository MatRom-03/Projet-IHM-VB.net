<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Statistics
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistics))
        Me.ListBoxStats = New System.Windows.Forms.ListBox()
        Me.ButtonSort = New System.Windows.Forms.Button()
        Me.ComboBoxNameGamer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxStats
        '
        Me.ListBoxStats.FormattingEnabled = True
        Me.ListBoxStats.Location = New System.Drawing.Point(35, 37)
        Me.ListBoxStats.Name = "ListBoxStats"
        Me.ListBoxStats.Size = New System.Drawing.Size(222, 199)
        Me.ListBoxStats.TabIndex = 0
        '
        'ButtonSort
        '
        Me.ButtonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSort.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSort.Location = New System.Drawing.Point(277, 37)
        Me.ButtonSort.Name = "ButtonSort"
        Me.ButtonSort.Size = New System.Drawing.Size(35, 35)
        Me.ButtonSort.TabIndex = 1
        Me.ButtonSort.Text = "↑"
        Me.ButtonSort.UseVisualStyleBackColor = True
        '
        'ComboBoxNameGamer
        '
        Me.ComboBoxNameGamer.FormattingEnabled = True
        Me.ComboBoxNameGamer.Location = New System.Drawing.Point(277, 100)
        Me.ComboBoxNameGamer.Name = "ComboBoxNameGamer"
        Me.ComboBoxNameGamer.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNameGamer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'ExitButton
        '
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(462, 232)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Retour"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 270)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxNameGamer)
        Me.Controls.Add(Me.ButtonSort)
        Me.Controls.Add(Me.ListBoxStats)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Statistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistiques"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxStats As ListBox
    Friend WithEvents ButtonSort As Button
    Friend WithEvents ComboBoxNameGamer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitButton As Button
End Class
