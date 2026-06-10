Imports System.Globalization

Public Class Common
    Public Shared Function GetDecimalPlaces(value As Double) As Integer
        Dim strValue As String = value.ToString(CultureInfo.InvariantCulture)
        Dim decimalIndex As Integer = strValue.IndexOf("."c)
        If decimalIndex >= 0 Then
            Return strValue.Length - decimalIndex - 1
        Else
            Return 0
        End If
    End Function

    Public Shared Function Round2DecPlaces(value As Double, index As Integer) As Double
        Return Math.Round(value, index)
    End Function

    Public Shared Function GetHighestDecimalPlaces(values As List(Of Double)) As Integer
        Dim maxDecimalPlaces As Integer = 0
        Dim value
        For Each value In values
            Dim decimalPlaces As Integer = GetDecimalPlaces(value)
            If decimalPlaces > maxDecimalPlaces Then
                maxDecimalPlaces = decimalPlaces
            End If
        Next
        Return maxDecimalPlaces
    End Function
End Class
