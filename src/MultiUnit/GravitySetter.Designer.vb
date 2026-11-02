<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GravitySetter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AltitudeBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GravityBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GravityButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(579, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your altitude above sea level on Earth here:"
        '
        'AltitudeBox
        '
        Me.AltitudeBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AltitudeBox.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.AltitudeBox.Location = New System.Drawing.Point(33, 73)
        Me.AltitudeBox.Name = "AltitudeBox"
        Me.AltitudeBox.Size = New System.Drawing.Size(291, 42)
        Me.AltitudeBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(330, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kilometers"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(473, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(193, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Set Gravity"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(27, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(342, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Or manually set your gravity:"
        '
        'GravityBox
        '
        Me.GravityBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GravityBox.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GravityBox.Location = New System.Drawing.Point(33, 183)
        Me.GravityBox.Name = "GravityBox"
        Me.GravityBox.Size = New System.Drawing.Size(291, 42)
        Me.GravityBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(330, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 35)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "m/s^2"
        '
        'GravityButton
        '
        Me.GravityButton.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GravityButton.Location = New System.Drawing.Point(422, 182)
        Me.GravityButton.Name = "GravityButton"
        Me.GravityButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GravityButton.Size = New System.Drawing.Size(193, 42)
        Me.GravityButton.TabIndex = 7
        Me.GravityButton.Text = "Set Gravity"
        Me.GravityButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(104, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(472, 35)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "When you are finished, close this dialog."
        '
        'GravitySetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 505)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GravityButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GravityBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AltitudeBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GravitySetter"
        Me.Text = "Gravity Setter For MultiUnit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AltitudeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GravityBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GravityButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
