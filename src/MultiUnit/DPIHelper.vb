Imports System.Runtime.InteropServices

Public Class DPIHelper

    <DllImport("user32.dll")>
    Private Shared Function SetProcessDPIAware() As Boolean
    End Function

    <DllImport("shcore.dll")>
    Private Shared Function SetProcessDpiAwareness(value As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetProcessDpiAwarenessContext(value As IntPtr) As Boolean
    End Function

    Private Shared ReadOnly DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 As New IntPtr(-4)

    Public Shared Sub EnableDPIAwareness()

        Try
            If Environment.OSVersion.Version.Major >= 10 Then
                SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2)

            ElseIf Environment.OSVersion.Version.Major = 6 AndAlso Environment.OSVersion.Version.Minor >= 3 Then
                SetProcessDpiAwareness(2)

            Else
                SetProcessDPIAware()
            End If

        Catch
        End Try

    End Sub

End Class