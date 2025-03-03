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
        Me.Input = New System.Windows.Forms.TextBox()
        Me.inputmessage = New System.Windows.Forms.Label()
        Me.UnitCategorySelector = New System.Windows.Forms.ComboBox()
        Me.UnitSelectionBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.AccessibleName = "input"
        Me.Input.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Input.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Input.Location = New System.Drawing.Point(319, 175)
        Me.Input.Margin = New System.Windows.Forms.Padding(2)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(260, 32)
        Me.Input.TabIndex = 0
        '
        'inputmessage
        '
        Me.inputmessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputmessage.AutoSize = True
        Me.inputmessage.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.inputmessage.Location = New System.Drawing.Point(328, 140)
        Me.inputmessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inputmessage.Name = "inputmessage"
        Me.inputmessage.Size = New System.Drawing.Size(243, 19)
        Me.inputmessage.TabIndex = 1
        Me.inputmessage.Text = "Enter the value you want to convert:"
        '
        'UnitCategorySelector
        '
        Me.UnitCategorySelector.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnitCategorySelector.Cursor = System.Windows.Forms.Cursors.Default
        Me.UnitCategorySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitCategorySelector.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.UnitCategorySelector.FormattingEnabled = True
        Me.UnitCategorySelector.Items.AddRange(New Object() {"Temperature", "Length", "Speed", "Weight", "Mass", "Air Flow"})
        Me.UnitCategorySelector.Location = New System.Drawing.Point(366, 254)
        Me.UnitCategorySelector.Margin = New System.Windows.Forms.Padding(2)
        Me.UnitCategorySelector.Name = "UnitCategorySelector"
        Me.UnitCategorySelector.Size = New System.Drawing.Size(166, 32)
        Me.UnitCategorySelector.TabIndex = 2
        '
        'UnitSelectionBox
        '
        Me.UnitSelectionBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitSelectionBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.UnitSelectionBox.FormattingEnabled = True
        Me.UnitSelectionBox.Location = New System.Drawing.Point(341, 333)
        Me.UnitSelectionBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UnitSelectionBox.Name = "UnitSelectionBox"
        Me.UnitSelectionBox.Size = New System.Drawing.Size(216, 32)
        Me.UnitSelectionBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(268, 219)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select the category of conversion you want to perform:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(306, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select the conversion you want to perform:"
        '
        'ResultBox
        '
        Me.ResultBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.ResultBox.Location = New System.Drawing.Point(280, 451)
        Me.ResultBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(338, 32)
        Me.ResultBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(422, 416)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Result:"
        '
        'ConvertButton
        '
        Me.ConvertButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConvertButton.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ConvertButton.Location = New System.Drawing.Point(361, 377)
        Me.ConvertButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(176, 24)
        Me.ConvertButton.TabIndex = 8
        Me.ConvertButton.Text = "Convert"
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'MultiUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 497)
        Me.Controls.Add(Me.ConvertButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UnitSelectionBox)
        Me.Controls.Add(Me.UnitCategorySelector)
        Me.Controls.Add(Me.inputmessage)
        Me.Controls.Add(Me.Input)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ResultBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ConvertButton As System.Windows.Forms.Button

End Class
