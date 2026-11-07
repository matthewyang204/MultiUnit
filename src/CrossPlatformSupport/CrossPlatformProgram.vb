Imports System.Windows.Forms

Friend Module CrossPlatformProgram
    <STAThread>
    Public Sub Main(args As String())
        Dim form As New MultiUnit()
        form.AutoScaleMode = AutoScaleMode.None
        form.LoadRatios()
        form.FormBorderStyle = FormBorderStyle.Sizable
        form.MaximizeBox = True
        form.MinimizeBox = True

        Dim scaler As New ResponsiveFormScaler(form)
        AddHandler form.ClientSizeChanged, AddressOf scaler.Apply
        scaler.SetInitialScale(0.65F)

        Application.Run(form)
    End Sub
End Module
