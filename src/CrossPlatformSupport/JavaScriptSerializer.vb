Imports System.Text.Json

Namespace Global.System.Web.Script.Serialization
    Public Class JavaScriptSerializer
        Public Function Deserialize(Of T)(json As String) As T
            Return JsonSerializer.Deserialize(Of T)(json)
        End Function

        Public Function Serialize(value As Object) As String
            Return JsonSerializer.Serialize(value)
        End Function
    End Class
End Namespace
