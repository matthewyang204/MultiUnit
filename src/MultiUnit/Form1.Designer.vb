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
        Me.components = New System.ComponentModel.Container()
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
        Me.RefreshCurrencyDataButton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SciNoteBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.AccessibleName = "input"
        Me.Input.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Input.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Input.Location = New System.Drawing.Point(113, 93)
        Me.Input.Margin = New System.Windows.Forms.Padding(4)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(473, 50)
        Me.Input.TabIndex = 0
        '
        'inputmessage
        '
        Me.inputmessage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.inputmessage.AutoSize = True
        Me.inputmessage.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.inputmessage.Location = New System.Drawing.Point(124, 21)
        Me.inputmessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.inputmessage.Name = "inputmessage"
        Me.inputmessage.Size = New System.Drawing.Size(432, 35)
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
        Me.UnitCategorySelector.Items.AddRange(New Object() {"Temperature", "Length", "Area", "Volume", "Energy", "Speed", "Weight", "Mass", "Air Flow", "Angle", "Currency"})
        Me.UnitCategorySelector.Location = New System.Drawing.Point(199, 253)
        Me.UnitCategorySelector.Margin = New System.Windows.Forms.Padding(4)
        Me.UnitCategorySelector.Name = "UnitCategorySelector"
        Me.UnitCategorySelector.Size = New System.Drawing.Size(301, 50)
        Me.UnitCategorySelector.TabIndex = 2
        '
        'UnitSelectionBox
        '
        Me.UnitSelectionBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UnitSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnitSelectionBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.UnitSelectionBox.FormattingEnabled = True
        Me.UnitSelectionBox.Location = New System.Drawing.Point(41, 408)
        Me.UnitSelectionBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UnitSelectionBox.Name = "UnitSelectionBox"
        Me.UnitSelectionBox.Size = New System.Drawing.Size(235, 50)
        Me.UnitSelectionBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 181)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(644, 35)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select the category of conversion you want to perform:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(83, 343)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(509, 35)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select the conversion you want to perform:"
        '
        'ResultBox
        '
        Me.ResultBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ResultBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.ResultBox.Location = New System.Drawing.Point(41, 748)
        Me.ResultBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(616, 50)
        Me.ResultBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(301, 707)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 35)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Result:"
        '
        'ConvertButton
        '
        Me.ConvertButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ConvertButton.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ConvertButton.Location = New System.Drawing.Point(160, 638)
        Me.ConvertButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(378, 55)
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
        Me.Unit2SelectionBox.Location = New System.Drawing.Point(423, 415)
        Me.Unit2SelectionBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Unit2SelectionBox.Name = "Unit2SelectionBox"
        Me.Unit2SelectionBox.Size = New System.Drawing.Size(235, 50)
        Me.Unit2SelectionBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(322, 425)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 35)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "To"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 486)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(657, 35)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Enter the area (only required for conversions with CFM):"
        '
        'AreaInputBox
        '
        Me.AreaInputBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AreaInputBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.AreaInputBox.Location = New System.Drawing.Point(90, 549)
        Me.AreaInputBox.Name = "AreaInputBox"
        Me.AreaInputBox.Size = New System.Drawing.Size(130, 50)
        Me.AreaInputBox.TabIndex = 12
        '
        'AreaUnitSelector
        '
        Me.AreaUnitSelector.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AreaUnitSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AreaUnitSelector.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.AreaUnitSelector.FormattingEnabled = True
        Me.AreaUnitSelector.Location = New System.Drawing.Point(423, 549)
        Me.AreaUnitSelector.Name = "AreaUnitSelector"
        Me.AreaUnitSelector.Size = New System.Drawing.Size(266, 50)
        Me.AreaUnitSelector.TabIndex = 13
        '
        'Area2InputBox
        '
        Me.Area2InputBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Area2InputBox.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Area2InputBox.Location = New System.Drawing.Point(280, 549)
        Me.Area2InputBox.Name = "Area2InputBox"
        Me.Area2InputBox.Size = New System.Drawing.Size(130, 50)
        Me.Area2InputBox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(225, 560)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 35)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "W:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(38, 559)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 35)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "L:"
        '
        'RefreshCurrencyDataButton
        '
        Me.RefreshCurrencyDataButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RefreshCurrencyDataButton.AutoSize = True
        Me.RefreshCurrencyDataButton.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.RefreshCurrencyDataButton.Location = New System.Drawing.Point(193, 526)
        Me.RefreshCurrencyDataButton.Name = "RefreshCurrencyDataButton"
        Me.RefreshCurrencyDataButton.Size = New System.Drawing.Size(314, 58)
        Me.RefreshCurrencyDataButton.TabIndex = 17
        Me.RefreshCurrencyDataButton.Text = "Refresh Currency Data"
        Me.RefreshCurrencyDataButton.UseVisualStyleBackColor = True
        Me.RefreshCurrencyDataButton.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(103, 807)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(253, 39)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Display exact value"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Disables rounding the value to the maximum decimals found in the input(s).")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.CheckBox2.Location = New System.Drawing.Point(103, 846)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(475, 39)
        Me.CheckBox2.TabIndex = 19
        Me.CheckBox2.Text = "Round using significant figures instead"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        '
        'SciNoteBox
        '
        Me.SciNoteBox.AutoSize = True
        Me.SciNoteBox.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.SciNoteBox.Location = New System.Drawing.Point(103, 881)
        Me.SciNoteBox.Name = "SciNoteBox"
        Me.SciNoteBox.Size = New System.Drawing.Size(295, 39)
        Me.SciNoteBox.TabIndex = 20
        Me.SciNoteBox.Text = "Use scientific notation"
        Me.SciNoteBox.UseVisualStyleBackColor = True
        '
        'MultiUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 1033)
        Me.Controls.Add(Me.SciNoteBox)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RefreshCurrencyDataButton)
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
    Friend WithEvents RefreshCurrencyDataButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SciNoteBox As System.Windows.Forms.CheckBox
End Class
