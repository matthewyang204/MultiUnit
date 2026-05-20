Imports System.Net
Imports System.Web.Script.Serialization

Public Class RateItem
    Public Property dateValue As String
    Public Property baseCurrency As String
    Public Property quote As String
    Public Property rate As Double
End Class

Public Class CurrencyAPI
    Public Shared Function DownloadCurrencyData()
        Dim url As String = "https://api.frankfurter.dev/v2/rates?base=CNY"
        Dim client As New WebClient()
        Dim json As String = client.DownloadString(url)
        Console.WriteLine("Downloaded new currency data: " & json)
    End Function

    Public Function ParseRates(json As String) As Dictionary(Of String, Double)
        Dim serializer As New JavaScriptSerializer()
        Dim items As List(Of RateItem) = serializer.Deserialize(Of List(Of RateItem))(json)
        Dim dict As New Dictionary(Of String, Double)

        Dim item
        For Each item In items
            If item.base = "CNY" Then
                dict(item.quote) = item.rate
            End If
        Next

        Return dict
    End Function

    Public Function RefreshRates() As Dictionary(Of String, Double)
        Dim json = DownloadCurrencyData()
        Dim rates = ParseRates(json)
        Return rates
    End Function
End Class
