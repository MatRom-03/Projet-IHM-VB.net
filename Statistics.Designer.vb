<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Me.ListBoxStats = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxStats
        '
        Me.ListBoxStats.FormattingEnabled = True
        Me.ListBoxStats.Location = New System.Drawing.Point(237, 92)
        Me.ListBoxStats.Name = "ListBoxStats"
        Me.ListBoxStats.Size = New System.Drawing.Size(300, 264)
        Me.ListBoxStats.TabIndex = 0
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBoxStats)
        Me.Name = "Statistics"
        Me.Text = "Statistics"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxStats As ListBox
End Class
