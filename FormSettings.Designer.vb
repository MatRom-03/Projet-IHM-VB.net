﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSettings
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelColumnsCount = New System.Windows.Forms.Label()
        Me.LabelLinesCount = New System.Windows.Forms.Label()
        Me.LabelMinesCount = New System.Windows.Forms.Label()
        Me.ButtonValidate = New System.Windows.Forms.Button()
        Me.TextBoxColumnsCount = New System.Windows.Forms.TextBox()
        Me.TextBoxLinesCount = New System.Windows.Forms.TextBox()
        Me.TextBoxMinesCount = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ErrorProviderSettings = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBoxCountdown = New System.Windows.Forms.TextBox()
        Me.LabelGameTime = New System.Windows.Forms.Label()
        Me.CheckBoxCountdown = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorProviderSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelColumnsCount
        '
        Me.LabelColumnsCount.AutoSize = True
        Me.LabelColumnsCount.Location = New System.Drawing.Point(39, 35)
        Me.LabelColumnsCount.Name = "LabelColumnsCount"
        Me.LabelColumnsCount.Size = New System.Drawing.Size(111, 13)
        Me.LabelColumnsCount.TabIndex = 0
        Me.LabelColumnsCount.Text = "Nombre de colonnes :"
        '
        'LabelLinesCount
        '
        Me.LabelLinesCount.AutoSize = True
        Me.LabelLinesCount.Location = New System.Drawing.Point(39, 62)
        Me.LabelLinesCount.Name = "LabelLinesCount"
        Me.LabelLinesCount.Size = New System.Drawing.Size(95, 13)
        Me.LabelLinesCount.TabIndex = 1
        Me.LabelLinesCount.Text = "Nombre de lignes :"
        '
        'LabelMinesCount
        '
        Me.LabelMinesCount.AutoSize = True
        Me.LabelMinesCount.Location = New System.Drawing.Point(39, 90)
        Me.LabelMinesCount.Name = "LabelMinesCount"
        Me.LabelMinesCount.Size = New System.Drawing.Size(95, 13)
        Me.LabelMinesCount.TabIndex = 2
        Me.LabelMinesCount.Text = "Nombre de mines :"
        '
        'ButtonValidate
        '
        Me.ButtonValidate.Location = New System.Drawing.Point(181, 210)
        Me.ButtonValidate.Name = "ButtonValidate"
        Me.ButtonValidate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonValidate.TabIndex = 3
        Me.ButtonValidate.Text = "Valider"
        Me.ButtonValidate.UseVisualStyleBackColor = True
        '
        'TextBoxColumnsCount
        '
        Me.TextBoxColumnsCount.Location = New System.Drawing.Point(156, 35)
        Me.TextBoxColumnsCount.Name = "TextBoxColumnsCount"
        Me.TextBoxColumnsCount.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxColumnsCount.TabIndex = 4
        '
        'TextBoxLinesCount
        '
        Me.TextBoxLinesCount.Location = New System.Drawing.Point(156, 64)
        Me.TextBoxLinesCount.Name = "TextBoxLinesCount"
        Me.TextBoxLinesCount.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLinesCount.TabIndex = 5
        '
        'TextBoxMinesCount
        '
        Me.TextBoxMinesCount.Location = New System.Drawing.Point(156, 90)
        Me.TextBoxMinesCount.Name = "TextBoxMinesCount"
        Me.TextBoxMinesCount.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMinesCount.TabIndex = 6
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(42, 210)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Annuler"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ErrorProviderSettings
        '
        Me.ErrorProviderSettings.ContainerControl = Me
        '
        'TextBoxCountdown
        '
        Me.TextBoxCountdown.Location = New System.Drawing.Point(156, 154)
        Me.TextBoxCountdown.Name = "TextBoxCountdown"
        Me.TextBoxCountdown.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCountdown.TabIndex = 10
        '
        'LabelGameTime
        '
        Me.LabelGameTime.AutoSize = True
        Me.LabelGameTime.Location = New System.Drawing.Point(57, 157)
        Me.LabelGameTime.Name = "LabelGameTime"
        Me.LabelGameTime.Size = New System.Drawing.Size(77, 13)
        Me.LabelGameTime.TabIndex = 9
        Me.LabelGameTime.Text = "Temps de jeu :"
        '
        'CheckBoxCountdown
        '
        Me.CheckBoxCountdown.AutoSize = True
        Me.CheckBoxCountdown.Location = New System.Drawing.Point(42, 125)
        Me.CheckBoxCountdown.Name = "CheckBoxCountdown"
        Me.CheckBoxCountdown.Size = New System.Drawing.Size(117, 17)
        Me.CheckBoxCountdown.TabIndex = 11
        Me.CheckBoxCountdown.Text = "Activer le compteur"
        Me.CheckBoxCountdown.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AcceptButton = Me.ButtonValidate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(316, 262)
        Me.Controls.Add(Me.CheckBoxCountdown)
        Me.Controls.Add(Me.TextBoxCountdown)
        Me.Controls.Add(Me.LabelGameTime)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.TextBoxMinesCount)
        Me.Controls.Add(Me.TextBoxLinesCount)
        Me.Controls.Add(Me.TextBoxColumnsCount)
        Me.Controls.Add(Me.ButtonValidate)
        Me.Controls.Add(Me.LabelMinesCount)
        Me.Controls.Add(Me.LabelLinesCount)
        Me.Controls.Add(Me.LabelColumnsCount)
        Me.Name = "FormSettings"
        Me.Text = "Settings"
        CType(Me.ErrorProviderSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelColumnsCount As Label
    Friend WithEvents LabelLinesCount As Label
    Friend WithEvents LabelMinesCount As Label
    Friend WithEvents ButtonValidate As Button
    Friend WithEvents TextBoxColumnsCount As TextBox
    Friend WithEvents TextBoxLinesCount As TextBox
    Friend WithEvents TextBoxMinesCount As TextBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ErrorProviderSettings As ErrorProvider
    Friend WithEvents TextBoxCountdown As TextBox
    Friend WithEvents LabelGameTime As Label
    Friend WithEvents CheckBoxCountdown As CheckBox
End Class
