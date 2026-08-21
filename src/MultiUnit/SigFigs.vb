Public Class SigFigs
    Public Shared Function RoundToSigFigs(value As Double, sigFigs As Integer) As Double
        If value = 0 Then
            Return 0
        End If
        Dim scale As Double = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(value))) + 1 - sigFigs)
        Return Math.Round(value / scale) * scale
    End Function

    Public Shared Function GetSigFigs(value As Double) As Integer
        If value = 0 Then
            Return 1
        End If
        Dim strValue As String = value.ToString("G", System.Globalization.CultureInfo.InvariantCulture)
        Dim decimalIndex As Integer = strValue.IndexOf("."c)
        Dim sigFigs As Integer = 0
        For Each c As Char In strValue
            If Char.IsDigit(c) Then
                sigFigs += 1
            End If
        Next
        If decimalIndex >= 0 Then
            sigFigs -= (strValue.Length - decimalIndex - 1)
        End If
        Return sigFigs
    End Function

    Public Shared Function GetSigFigsFromList(values As List(Of Double)) As Integer
        Dim maxSigFigs As Integer = 0
        Dim value
        For Each value In values
            Dim sigFigs As Integer = GetSigFigs(value)
            If sigFigs > maxSigFigs Then
                maxSigFigs = sigFigs
            End If
        Next
        Return maxSigFigs
    End Function
End Class
