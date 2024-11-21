<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiUnit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Input = New System.Windows.Forms.TextBox
        Me.inputmessage = New System.Windows.Forms.Label
        Me.UnitCategorySelector = New System.Windows.Forms.ComboBox
        Me.UnitSelectionBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.AccessibleName = "input"
        Me.Input.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Input.Location = New System.Drawing.Point(377, 155)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(1446, 56)
        Me.Input.TabIndex = 0
        '
        'inputmessage
        '
        Me.inputmessage.AutoSize = True
        Me.inputmessage.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.inputmessage.Location = New System.Drawing.Point(683, 86)
        Me.inputmessage.Name = "inputmessage"
        Me.inputmessage.Size = New System.Drawing.Size(817, 66)
        Me.inputmessage.TabIndex = 1
        Me.inputmessage.Text = "Enter the value you want to convert:"
        '
        'UnitCategorySelector
        '
        Me.UnitCategorySelector.Cursor = System.Windows.Forms.Cursors.Default
        Me.UnitCategorySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitCategorySelector.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.UnitCategorySelector.FormattingEnabled = True
        Me.UnitCategorySelector.Items.AddRange(New Object() {"Temperature", "Length", "Weight", "Mass"})
        Me.UnitCategorySelector.Location = New System.Drawing.Point(893, 293)
        Me.UnitCategorySelector.Name = "UnitCategorySelector"
        Me.UnitCategorySelector.Size = New System.Drawing.Size(329, 57)
        Me.UnitCategorySelector.TabIndex = 2
        '
        'UnitSelectionBox
        '
        Me.UnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitSelectionBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.UnitSelectionBox.FormattingEnabled = True
        Me.UnitSelectionBox.Location = New System.Drawing.Point(834, 439)
        Me.UnitSelectionBox.Name = "UnitSelectionBox"
        Me.UnitSelectionBox.Size = New System.Drawing.Size(428, 57)
        Me.UnitSelectionBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(782, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select the conversion you want to perform:"
        '
        'MultiUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2363, 1193)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UnitSelectionBox)
        Me.Controls.Add(Me.UnitCategorySelector)
        Me.Controls.Add(Me.inputmessage)
        Me.Controls.Add(Me.Input)
        Me.Name = "MultiUnit"
        Me.Text = "MultiUnit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Input As System.Windows.Forms.TextBox
    Friend WithEvents inputmessage As System.Windows.Forms.Label
    Friend WithEvents UnitCategorySelector As System.Windows.Forms.ComboBox
    Friend WithEvents UnitSelectionBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
