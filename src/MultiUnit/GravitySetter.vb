Public Class GravitySetter
    Public Gravity As Double
    Public Altitude As Double

    Public GravityPresets As Dictionary(Of String, Double) = New Dictionary(Of String, Double)

    Public Sub New(ByVal GravityValue As Double, ByVal AltitudeValue As Double)
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        Gravity = GravityValue
        Altitude = AltitudeValue

        SyncValues()
        LoadPresets()
    End Sub

    Public Sub SyncValues()
        GravityBox.Text = Gravity.ToString()
        AltitudeBox.Text = Altitude.ToString()
    End Sub

    Public Sub LoadPresets()
        GravityPresets.Add("Earth", 9.80665)
        GravityPresets.Add("Mariana Trench", 9.8541)
        GravityPresets.Add("Mount Everest", 9.784)
        GravityPresets.Add("Earth's Moon", 1.625)
        GravityPresets.Add("Mercury", 3.7)
        GravityPresets.Add("Venus", 8.87)
        GravityPresets.Add("Mars", 3.721)
        GravityPresets.Add("Jupiter", 24.79)
        GravityPresets.Add("Saturn", 10.44)
        GravityPresets.Add("Uranus", 9.01)
        GravityPresets.Add("Neptune", 11.27)
        GravityPresets.Add("Pluto", 0.616)
        GravityPresets.Add("Ceres", 0.284)
        GravityPresets.Add("The Sun", 274.21)

        For Each kvp As KeyValuePair(Of String, Double) In GravityPresets
            PresetsBox.Items.Add(kvp.Key)
        Next
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

    Private Sub PresetsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetsButton.Click
        Dim PresetName As String
        If PresetsBox.SelectedIndex <> -1 Then
            PresetName = PresetsBox.Text
        Else
            MessageBox.Show("Select a preset before attempting to set one.")
            Exit Sub
        End If

        Gravity = GravityPresets(PresetName)
        SyncValues()
    End Sub
End Class