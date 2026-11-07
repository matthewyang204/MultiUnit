Imports System.Windows.Forms

Friend Module CrossPlatformProgram
    <STAThread>
    Public Sub Main(args As String())
        Dim form As New MultiUnit()
        form.LoadRatios()
        Application.Run(form)
    End Sub
End Module
