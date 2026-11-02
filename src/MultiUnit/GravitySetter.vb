Public Class GravitySetter
    Public Gravity As Double
    Public Altitude As Double

    Public Sub New(ByVal GravityValue As Double, ByVal AltitudeValue As Double)
        InitializeComponent()

        Gravity = GravityValue
        Altitude = AltitudeValue

        SyncValues()
    End Sub

    Public Sub SyncValues()
        GravityBox.Text = Gravity.ToString()
        AltitudeBox.Text = Altitude.ToString()
    End Sub

    Public Function GetGravity(ByVal altitude As Double) As Double
        Const G As Double = 0.000000000066743
        Const M As Double = 5.9722E+24
        Const R As Double = 6371000.0

        Dim distance As Double = R + altitude

        Return (G * M) / (distance * distance)
    End Function

    Public Sub SetGravity()
        Dim userInput As Double
        Try
            userInput = CDbl(GravityBox.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid input. Please enter a valid number.")
            Exit Sub
        End Try

        Gravity = userInput
    End Sub

    Public Sub SetGravityByAltitude()
        Dim userInput As Double
        Try
            userInput = CDbl(AltitudeBox.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid input. Please enter a valid number.")
            Exit Sub
        End Try

        Altitude = userInput
        Gravity = GetGravity(Altitude)

        SyncValues()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SetGravityByAltitude()
    End Sub

    Private Sub GravityButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravityButton.Click
        SetGravity()
    End Sub
End Class