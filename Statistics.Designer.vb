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
        Me.ListBoxStats = New System.Windows.Forms.ListBox()
        Me.ButtonSort = New System.Windows.Forms.Button()
        Me.ComboBoxNameGamer = New System.Windows.Forms.ComboBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
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
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(299, 171)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 3
        Me.ButtonSearch.Text = "Détails"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 270)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.ComboBoxNameGamer)
        Me.Controls.Add(Me.ButtonSort)
        Me.Controls.Add(Me.ListBoxStats)
        Me.Name = "Statistics"
        Me.Text = "Statistics"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxStats As ListBox
    Friend WithEvents ButtonSort As Button
    Friend WithEvents ComboBoxNameGamer As ComboBox
    Friend WithEvents ButtonSearch As Button
End Class
