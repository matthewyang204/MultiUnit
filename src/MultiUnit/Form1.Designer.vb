<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MultiUnit
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
        Me.Input = New System.Windows.Forms.TextBox()
        Me.inputmessage = New System.Windows.Forms.Label()
        Me.UnitCategorySelector = New System.Windows.Forms.ComboBox()
        Me.UnitSelectionBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.Unit2SelectionBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AreaInputBox = New System.Windows.Forms.TextBox()
        Me.AreaUnitSelector = New System.Windows.Forms.ComboBox()
        Me.Area2InputBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.AccessibleName = "input"
        Me.Input.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Input.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Input.Location = New System.Drawing.Point(123, 97)
        Me.Input.Margin = New System.Windows.Forms.Padding(4)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(516, 56)
        Me.Input.TabIndex = 0
        '
        'inputmessage
        '
        Me.inputmessage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.inputmessage.AutoSize = True
        Me.inputmessage.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.inputmessage.Location = New System.Drawing.Point(135, 22)
        Me.inputmessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.inputmessage.Name = "inputmessage"
        Me.inputmessage.Size = New System.Drawing.Size(493, 39)
        Me.inputmessage.TabIndex = 1
        Me.inputmessage.Text = "Enter the value you want to convert:"
        '
        'UnitCategorySelector
        '
        Me.UnitCategorySelector.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UnitCategorySelector.Cursor = System.Windows.Forms.Cursors.Default
        Me.UnitCategorySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitCategorySelector.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.UnitCategorySelector.FormattingEnabled = True
        Me.UnitCategorySelector.Items.AddRange(New Object() {"Temperature", "Length", "Area", "Speed", "Weight", "Mass", "Air Flow"})
        Me.UnitCategorySelector.Location = New System.Drawing.Point(217, 264)
        Me.UnitCategorySelector.Margin = New System.Windows.Forms.Padding(4)
        Me.UnitCategorySelector.Name = "UnitCategorySelector"
        Me.UnitCategorySelector.Size = New System.Drawing.Size(328, 57)
        Me.UnitCategorySelector.TabIndex = 2
        '
        'UnitSelectionBox
        '
        Me.UnitSelectionBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitSelectionBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.UnitSelectionBox.FormattingEnabled = True
        Me.UnitSelectionBox.Location = New System.Drawing.Point(45, 425)
        Me.UnitSelectionBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UnitSelectionBox.Name = "UnitSelectionBox"
        Me.UnitSelectionBox.Size = New System.Drawing.Size(256, 57)
        Me.UnitSelectionBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 189)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(735, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select the category of conversion you want to perform:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(91, 357)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(581, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select the conversion you want to perform:"
        '
        'ResultBox
        '
        Me.ResultBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ResultBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.ResultBox.Location = New System.Drawing.Point(45, 779)
        Me.ResultBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(672, 56)
        Me.ResultBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(328, 736)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 39)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Result:"
        '
        'ConvertButton
        '
        Me.ConvertButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ConvertButton.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ConvertButton.Location = New System.Drawing.Point(175, 665)
        Me.ConvertButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(412, 57)
        Me.ConvertButton.TabIndex = 8
        Me.ConvertButton.Text = "Convert"
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'Unit2SelectionBox
        '
        Me.Unit2SelectionBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Unit2SelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Unit2SelectionBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Unit2SelectionBox.FormattingEnabled = True
        Me.Unit2SelectionBox.Location = New System.Drawing.Point(461, 432)
        Me.Unit2SelectionBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Unit2SelectionBox.Name = "Unit2SelectionBox"
        Me.Unit2SelectionBox.Size = New System.Drawing.Size(256, 57)
        Me.Unit2SelectionBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(356, 443)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 39)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "To"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(279, 509)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 39)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Enter the area:"
        '
        'AreaInputBox
        '
        Me.AreaInputBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AreaInputBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.AreaInputBox.Location = New System.Drawing.Point(98, 572)
        Me.AreaInputBox.Name = "AreaInputBox"
        Me.AreaInputBox.Size = New System.Drawing.Size(141, 56)
        Me.AreaInputBox.TabIndex = 12
        '
        'AreaUnitSelector
        '
        Me.AreaUnitSelector.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AreaUnitSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AreaUnitSelector.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.AreaUnitSelector.FormattingEnabled = True
        Me.AreaUnitSelector.Location = New System.Drawing.Point(461, 572)
        Me.AreaUnitSelector.Name = "AreaUnitSelector"
        Me.AreaUnitSelector.Size = New System.Drawing.Size(290, 57)
        Me.AreaUnitSelector.TabIndex = 13
        '
        'Area2InputBox
        '
        Me.Area2InputBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Area2InputBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Area2InputBox.Location = New System.Drawing.Point(305, 572)
        Me.Area2InputBox.Name = "Area2InputBox"
        Me.Area2InputBox.Size = New System.Drawing.Size(141, 56)
        Me.Area2InputBox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(245, 583)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 39)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "W:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(41, 582)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 39)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "L:"
        '
        'MultiUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 874)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Area2InputBox)
        Me.Controls.Add(Me.AreaUnitSelector)
        Me.Controls.Add(Me.AreaInputBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Unit2SelectionBox)
        Me.Controls.Add(Me.ConvertButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UnitSelectionBox)
        Me.Controls.Add(Me.UnitCategorySelector)
        Me.Controls.Add(Me.inputmessage)
        Me.Controls.Add(Me.Input)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Unit2SelectionBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AreaInputBox As TextBox
    Friend WithEvents AreaUnitSelector As ComboBox
    Friend WithEvents Area2InputBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
