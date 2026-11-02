Public Class CustomGravity
    Public Function ConfigureGravity(ByVal DefaultGravity As Double, Optional ByVal DefaultAltitude As Double = 0) As Double
        Dim setter As New GravitySetter(DefaultGravity, DefaultAltitude)
        setter.ShowDialog()

        Dim SetGravity As Double = setter.Gravity

        setter.Dispose()

        Return SetGravity
    End Function
End Class

