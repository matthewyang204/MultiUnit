Imports System.Net
Imports System.Web.Script.Serialization

Public Class RateItem
    Public Property dateValue As String
    Public Property baseCurrency As String
    Public Property quote As String
    Public Property rate As Double
End Class

Public Class CurrencyAPI
    Public Shared Function DownloadCurrencyData() As String
        Dim url As String = "https://api.frankfurter.dev/v2/rates?base=CNY"
        Dim client As New WebClient()
        Dim json As String = client.DownloadString(url)
        Console.WriteLine("Downloaded new currency data: " & json)
        Return json
    End Function

    Public Function ParseRates(json As String) As Dictionary(Of String, Double)
        Dim serializer As New JavaScriptSerializer()
        Dim items As List(Of RateItem) = serializer.Deserialize(Of List(Of RateItem))(json)
        Dim dict As New Dictionary(Of String, Double)

        dict("CNY") = 1 ' Base currency
        Dim item
        For Each item In items
            dict(item.quote) = 1 / item.rate
        Next

        Return dict
    End Function

    Public Function RefreshRates() As Dictionary(Of String, Double)
        Dim json = DownloadCurrencyData()
        Dim rates = ParseRates(json)
        Return rates
    End Function

    Public Shared Sub SaveToJSON(contents As String)
        Dim dialog As New SaveFileDialog()

        dialog.Title = "Save Currency Rates"
        dialog.Filter = "JSON Files (*.json)|*.json"
        dialog.DefaultExt = "json"
        dialog.FileName = "rates.json"

        If dialog.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(dialog.FileName, contents)
        End If

        dialog.Dispose()
    End Sub

    Public Shared Function LoadFromJSON() As String
        Dim dialog As New OpenFileDialog()
        dialog.Title = "Load Currency Rates"
        dialog.Filter = "JSON Files (*.json)|*.json"
        dialog.DefaultExt = "json"
        If dialog.ShowDialog() = DialogResult.OK Then
            Dim json As String = IO.File.ReadAllText(dialog.FileName)
            Return json
        Else
            dialog.Dispose()
            Return Nothing
        End If
    End Function

    Public Shared Function SaveCurrencyRatios(ratios As Dictionary(Of String, Double)) As Boolean
        Try
            Dim serializer As New JavaScriptSerializer()
            Dim json As String = serializer.Serialize(ratios)
            SaveToJSON(json)
            Return True
        Catch ex As Exception
            Console.WriteLine("Error saving currency ratios: " & ex.Message)
            Return False
        End Try
    End Function
End Class
