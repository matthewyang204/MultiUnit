Imports System.Drawing
Imports System.Windows.Forms

Friend NotInheritable Class ResponsiveFormScaler
    Private ReadOnly _form As Form
    Private ReadOnly _designSize As Size
    Private ReadOnly _controls As New List(Of ControlLayout)
    Private ReadOnly _toolStripItems As New List(Of ToolStripItemLayout)
    Private _currentScale As Single = 1.0F
    Private _isApplying As Boolean

    Public Sub New(form As Form)
        _form = form
        _designSize = form.ClientSize
        CaptureControls(form.Controls)
    End Sub

    Public Sub SetInitialScale(scale As Single)
        scale = Math.Max(0.2F, Math.Min(1.0F, scale))
        _form.ClientSize = New Size(Math.Max(1, CInt(Math.Round(_designSize.Width * scale))),
                                    Math.Max(1, CInt(Math.Round(_designSize.Height * scale))))
        Apply(_form, EventArgs.Empty)
    End Sub

    Public Sub Apply(sender As Object, e As EventArgs)
        If _isApplying OrElse _designSize.Width <= 0 OrElse _designSize.Height <= 0 Then Return

        Dim widthScale = CSng(_form.ClientSize.Width) / _designSize.Width
        Dim heightScale = CSng(_form.ClientSize.Height) / _designSize.Height
        Dim scale = Math.Max(0.2F, Math.Min(widthScale, heightScale))
        If Math.Abs(scale - _currentScale) < 0.01F Then Return

        _isApplying = True
        Try
            For Each controlLayout In _controls
                controlLayout.Apply(scale)
            Next

            For Each itemLayout In _toolStripItems
                itemLayout.Apply(scale)
            Next

            _currentScale = scale
        Finally
            _isApplying = False
        End Try
    End Sub

    Private Sub CaptureControls(controls As Control.ControlCollection)
        For Each control As Control In controls
            _controls.Add(New ControlLayout(control))
            If TypeOf control Is ToolStrip Then
                CaptureItems(DirectCast(control, ToolStrip).Items)
            End If
            If control.HasChildren Then CaptureControls(control.Controls)
        Next
    End Sub

    Private Sub CaptureItems(items As ToolStripItemCollection)
        For Each item As ToolStripItem In items
            _toolStripItems.Add(New ToolStripItemLayout(item))
            If TypeOf item Is ToolStripDropDownItem Then
                CaptureItems(DirectCast(item, ToolStripDropDownItem).DropDownItems)
            End If
        Next
    End Sub

    Private Shared Function ScalePadding(value As Padding, factor As Single) As Padding
        Return New Padding(CInt(Math.Round(value.Left * factor)),
                           CInt(Math.Round(value.Top * factor)),
                           CInt(Math.Round(value.Right * factor)),
                           CInt(Math.Round(value.Bottom * factor)))
    End Function

    Private Shared Function ScaleFont(value As Font, factor As Single) As Font
        ' If value Is Nothing OrElse value.FontFamily Is Nothing Then
        '     Return New Font("Calibri", Math.Max(1.0F, 20.0F * factor), FontStyle.Regular, GraphicsUnit.Point)
        ' End If

        ' Return New Font(value.FontFamily, Math.Max(1.0F, value.Size * factor), value.Style,
        '                 value.Unit, value.GdiCharSet, value.GdiVerticalFont)
        If OperatingSystem.IsMacOS() Then
            Return New Font("Helvetica", Math.Max(1.0F, 30.0F * factor), FontStyle.Regular, GraphicsUnit.Point)
        Else
            Return New Font("Calibri", Math.Max(1.0F, 20.0F * factor), FontStyle.Regular, GraphicsUnit.Point)
        End If
    End Function

    Private NotInheritable Class ControlLayout
        Private ReadOnly _control As Control
        Private ReadOnly _bounds As Rectangle
        Private ReadOnly _font As Font
        Private ReadOnly _padding As Padding
        Private ReadOnly _margin As Padding

        Public Sub New(control As Control)
            _control = control
            _bounds = control.Bounds
            _font = control.Font
            _padding = control.Padding
            _margin = control.Margin
            _control.Anchor = AnchorStyles.Top
        End Sub

        Public Sub Apply(factor As Single)
            _control.Font = ScaleFont(_font, factor)
            _control.Padding = ScalePadding(_padding, factor)
            _control.Margin = ScalePadding(_margin, factor)
            _control.Bounds = New Rectangle(CInt(Math.Round(_bounds.X * factor)),
                                            CInt(Math.Round(_bounds.Y * factor)),
                                            Math.Max(1, CInt(Math.Round(_bounds.Width * factor))),
                                            Math.Max(1, CInt(Math.Round(_bounds.Height * factor))))
        End Sub
    End Class

    Private NotInheritable Class ToolStripItemLayout
        Private ReadOnly _item As ToolStripItem
        Private ReadOnly _font As Font
        Private ReadOnly _padding As Padding
        Private ReadOnly _margin As Padding

        Public Sub New(item As ToolStripItem)
            _item = item
            _font = item.Font
            _padding = item.Padding
            _margin = item.Margin
        End Sub

        Public Sub Apply(factor As Single)
            _item.Font = ScaleFont(_font, factor)
            _item.Padding = ScalePadding(_padding, factor)
            _item.Margin = ScalePadding(_margin, factor)
        End Sub
    End Class
End Class
