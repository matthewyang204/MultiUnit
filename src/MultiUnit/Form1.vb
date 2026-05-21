Public Class MultiUnit
    Dim CurrencyAPI As New CurrencyAPI()

    Private Sub Load_Menus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If UnitCategorySelector.Items.Count > 0 Then
            UnitCategorySelector.SelectedIndex = 0
        End If

        If UnitSelectionBox.Items.Count > 0 Then
            UnitSelectionBox.SelectedIndex = 0
        End If

        If Unit2SelectionBox.Items.Count > 0 Then
            Unit2SelectionBox.SelectedIndex = 1
        End If

        ' Load the ratios
        LoadRatios()

        ' Make some components invisible
        ' CFM/LFM-specific stuff
        Label5.Visible = False
        AreaUnitSelector.Visible = False
        AreaInputBox.Visible = False
        Area2InputBox.Visible = False
        Label6.Visible = False
        Label7.Visible = False

        ' Load the area selector units
        Dim AreaUnits As New List(Of String)
        AreaUnits.Add("Meters")
        AreaUnits.Add("Yards")
        AreaUnits.Add("Centimeters")
        AreaUnits.Add("Millimeters")
        AreaUnits.Add("Inches")
        AreaUnits.Add("Kilometers")
        AreaUnits.Add("Miles")
        AreaUnits.Add("Feet")
        AreaUnits.Add("Decimeters")
        AreaUnitSelector.Items.AddRange(AreaUnits.ToArray())

        If AreaUnitSelector.Items.Count > 0 Then
            AreaUnitSelector.SelectedIndex = 0
        End If
    End Sub

    ' Declare the variables
    Dim Units As New List(Of String)

    Private Sub UnitCategorySelector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitCategorySelector.SelectedIndexChanged
        Units.Clear()
        UnitSelectionBox.Items.Clear()
        Unit2SelectionBox.Items.Clear()
        ' Make some components invisible
        ' CFM/LFM-specific stuff
        Label5.Visible = False
        AreaUnitSelector.Visible = False
        AreaInputBox.Visible = False
        Area2InputBox.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        RefreshCurrencyDataButton.Visible = False

        ' Get UnitCategorySelector and set UnitSelectionBox accordingly
        Select Case UnitCategorySelector.SelectedItem.ToString()
            Case "Temperature"
                Units.Add("C")
                Units.Add("F")
                Units.Add("K")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Speed"
                Units.Add("MPH")
                Units.Add("km/h")
                Units.Add("ft/s")
                Units.Add("m/s")
                Units.Add("Knots")
                Units.Add("Mach")
                Units.Add("cm/s")
                Units.Add("mm/s")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Length"
                Units.Add("Meters")
                Units.Add("Yards")
                Units.Add("Centimeters")
                Units.Add("Millimeters")
                Units.Add("Micrometers")
                Units.Add("Nanometers")
                Units.Add("Inches")
                Units.Add("Kilometers")
                Units.Add("Miles")
                Units.Add("Feet")
                Units.Add("Decimeters")
                Units.Add("Microns")
                Units.Add("Nautical Miles")
                Units.Add("Astronomical Units")
                Units.Add("Light Years")
                Units.Add("Parsecs")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Area"
                Units.Add("Square Meters")
                Units.Add("Square Yards")
                Units.Add("Square Centimeters")
                Units.Add("Square Millimeters")
                Units.Add("Square Inches")
                Units.Add("Square Kilometers")
                Units.Add("Square Miles")
                Units.Add("Square Feet")
                Units.Add("Square Decimeters")
                Units.Add("Hectares")
                Units.Add("Acres")
                Units.Add("Ares")
                Units.Add("Square Nautical Miles")
                Units.Add("Barns")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Volume"
                Units.Add("Milliliters")
                Units.Add("Tablespoons")
                Units.Add("Teaspoons")
                Units.Add("Barrels")
                Units.Add("Imperial Gallons")
                Units.Add("Gallons")
                Units.Add("Liters")
                Units.Add("Quarts")
                Units.Add("Pints")
                Units.Add("Cups")
                Units.Add("Fluid Ounces")
                Units.Add("US Gill")
                Units.Add("UK Gill")
                Units.Add("Cubic Meters")
                Units.Add("Cubic Yards")
                Units.Add("Cubic Centimeters")
                Units.Add("Cubic Millimeters")
                Units.Add("Cubic Inches")
                Units.Add("Cubic Kilometers")
                Units.Add("Cubic Miles")
                Units.Add("Cubic Feet")
                Units.Add("Cubic Decimeters")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Energy"
                Units.Add("Joules")
                Units.Add("Kilojoules")
                Units.Add("Megajoules")
                Units.Add("Watt-hours")
                Units.Add("Kilowatt-hours")
                Units.Add("Electronvolts")
                Units.Add("Calories")
                Units.Add("Kilocalories")
                Units.Add("BTUs (British Thermal Units)")
                Units.Add("Foot-Pounds")
                Units.Add("Ergs")
                Units.Add("Therms")
                Units.Add("Ton TNT")
                Units.Add("Horsepower-hours")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Weight"
                Units.Add("Dyne")
                Units.Add("Newton")
                Units.Add("Kilopond")
                Units.Add("Kilonewton")
                Units.Add("Pound-force")
                Units.Add("Gram-force")
                Units.Add("Ton-force")
                Units.Add("Earth Grams")
                Units.Add("Earth Ounces")
                Units.Add("Earth Kilograms")
                Units.Add("Earth Pounds")
                Units.Add("Earth Metric Tonnes")
                Units.Add("Earth Short Tonnes")
                Units.Add("Earth Long Tonnes")
                Units.Add("Earth Stones")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Mass"
                Units.Add("Grams")
                Units.Add("Milligrams")
                Units.Add("Micrograms")
                Units.Add("Carats")
                Units.Add("Atomic Mass Units")
                Units.Add("Ounces")
                Units.Add("Kilograms")
                Units.Add("Pounds")
                Units.Add("Metric Tonnes")
                Units.Add("Short Tonnes")
                Units.Add("Long Tonnes")
                Units.Add("Stones")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Air Flow"
                Units.Add("CFM")
                Units.Add("LFM")
                Units.Add("MPH")
                Units.Add("km/h")
                Units.Add("ft/s")
                Units.Add("m/s")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())
                ' Make the area input stuff visible
                Label5.Visible = True
                AreaUnitSelector.Visible = True
                AreaInputBox.Visible = True
                Area2InputBox.Visible = True
                Label6.Visible = True
                Label7.Visible = True

            Case "Angle"
                Units.Add("Degrees")
                Units.Add("Radians")
                Units.Add("Gradians")
                Units.Add("Arcminutes")
                Units.Add("Arcseconds")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Currency"
                RefreshCurrencyDataButton.Visible = True
                Dim progDlg As New ContinuousProgress()
                progDlg.Text = "Currency Data Downloader"
                progDlg.Label1.Text = "Downloading latest currency data..."
                progDlg.Show()
                Application.DoEvents()

                Try
                    CurrencyRatios = CurrencyAPI.RefreshRates()
                    Dim KeyName As String
                    For Each KeyName In CurrencyRatios.Keys
                        Units.Add(KeyName)
                    Next
                    UnitSelectionBox.Items.AddRange(Units.ToArray())
                    Unit2SelectionBox.Items.AddRange(Units.ToArray())
                Catch ex As Exception
                    MessageBox.Show("Failed to download currency data. Please check your internet connection and try again. Error: " & vbCrLf & ex.Message)
                End Try

                progDlg.Close()

                ' Display error if the user doesn't select proper category
            Case Else
                MessageBox.Show("Please select a valid category.")
        End Select

        If UnitSelectionBox.Items.Count > 0 Then
            UnitSelectionBox.SelectedIndex = 0
        End If
        If Unit2SelectionBox.Items.Count > 0 Then
            Unit2SelectionBox.SelectedIndex = 1
        End If
    End Sub

    ' Define the ratios for each unit
    Private LengthRatios As New Dictionary(Of String, Double)
    Private AreaRatios As New Dictionary(Of String, Double)
    Private VolumeRatios As New Dictionary(Of String, Double)
    Private SpeedRatios As New Dictionary(Of String, Double)
    Private MassRatios As New Dictionary(Of String, Double)
    Private WeightRatios As New Dictionary(Of String, Double)
    Private EnergyRatios As New Dictionary(Of String, Double)
    Private AngleRatios As New Dictionary(Of String, Double)
    Private CurrencyRatios As New Dictionary(Of String, Double)

    Private Sub LoadRatios()
        ' Length ratios
        LengthRatios.Add("Meters", 1) ' Base unit
        LengthRatios.Add("Yards", 0.9144)
        LengthRatios.Add("Centimeters", 0.01)
        LengthRatios.Add("Millimeters", 0.001)
        LengthRatios.Add("Inches", 0.0254)
        LengthRatios.Add("Kilometers", 1000.0)
        LengthRatios.Add("Miles", 1609.344)
        LengthRatios.Add("Feet", 0.3048)
        LengthRatios.Add("Decimeters", 0.1)
        LengthRatios.Add("Micrometers", 0.000001)
        LengthRatios.Add("Nanometers", 0.000000001)
        LengthRatios.Add("Microns", 0.000001)
        LengthRatios.Add("Nautical Miles", 1852)
        LengthRatios.Add("Astronomical Units", 149597870700.0)
        LengthRatios.Add("Light Years", 9.4607E+15)
        LengthRatios.Add("Parsecs", 3.0857E+16)

        ' Area ratios
        AreaRatios.Add("Square Meters", 1) ' Base unit
        AreaRatios.Add("Square Yards", Math.Pow(LengthRatios("Yards"), 2))
        AreaRatios.Add("Square Centimeters", Math.Pow(LengthRatios("Centimeters"), 2))
        AreaRatios.Add("Square Millimeters", Math.Pow(LengthRatios("Millimeters"), 2))
        AreaRatios.Add("Square Inches", Math.Pow(LengthRatios("Inches"), 2))
        AreaRatios.Add("Square Kilometers", Math.Pow(LengthRatios("Kilometers"), 2))
        AreaRatios.Add("Square Miles", Math.Pow(LengthRatios("Miles"), 2))
        AreaRatios.Add("Square Feet", Math.Pow(LengthRatios("Feet"), 2))
        AreaRatios.Add("Square Decimeters", Math.Pow(LengthRatios("Decimeters"), 2))
        AreaRatios.Add("Hectares", 10000.0)
        AreaRatios.Add("Acres", 4046.8564224)
        AreaRatios.Add("Ares", 100.0)
        AreaRatios.Add("Square Nautical Miles", Math.Pow(LengthRatios("Nautical Miles"), 2))
        AreaRatios.Add("Barns", 1.0E-28)

        ' Volume Ratios
        VolumeRatios.Add("Milliliters", 0.000001)
        VolumeRatios.Add("Tablespoons", 0.0000147868)
        VolumeRatios.Add("Teaspoons", 0.00000492892)
        VolumeRatios.Add("Barrels", 0.158987294928)
        VolumeRatios.Add("Imperial Gallons", 0.00454609)
        VolumeRatios.Add("Gallons", 0.003785411784)
        VolumeRatios.Add("Liters", 0.001)
        VolumeRatios.Add("Quarts", 0.000946352946)
        VolumeRatios.Add("Pints", 0.000473176473)
        VolumeRatios.Add("Cups", 0.0002365882365)
        VolumeRatios.Add("Fluid Ounces", 0.0000295735295625)
        VolumeRatios.Add("US Gill", 0.00011829411825)
        VolumeRatios.Add("UK Gill", 0.0001420653125)
        VolumeRatios.Add("Cubic Meters", 1) ' Base unit
        VolumeRatios.Add("Cubic Yards", Math.Pow(LengthRatios("Yards"), 3))
        VolumeRatios.Add("Cubic Centimeters", Math.Pow(LengthRatios("Centimeters"), 3))
        VolumeRatios.Add("Cubic Millimeters", Math.Pow(LengthRatios("Millimeters"), 3))
        VolumeRatios.Add("Cubic Inches", Math.Pow(LengthRatios("Inches"), 3))
        VolumeRatios.Add("Cubic Kilometers", Math.Pow(LengthRatios("Kilometers"), 3))
        VolumeRatios.Add("Cubic Miles", Math.Pow(LengthRatios("Miles"), 3))
        VolumeRatios.Add("Cubic Feet", Math.Pow(LengthRatios("Feet"), 3))
        VolumeRatios.Add("Cubic Decimeters", Math.Pow(LengthRatios("Decimeters"), 3))

        ' Energy ratios
        EnergyRatios.Add("Joules", 1) ' Base unit
        EnergyRatios.Add("Kilojoules", 1000.0)
        EnergyRatios.Add("Megajoules", 1000000.0)
        EnergyRatios.Add("Watt-hours", 3600.0)
        EnergyRatios.Add("Kilowatt-hours", 3600000.0)
        EnergyRatios.Add("Electronvolts", 1.602176634E-19)
        EnergyRatios.Add("Calories", 4.184)
        EnergyRatios.Add("Kilocalories", 4184.0)
        EnergyRatios.Add("BTUs (British Thermal Units)", 1055.05585)
        EnergyRatios.Add("Foot-Pounds", 1.355817948)
        EnergyRatios.Add("Ergs", 0.0000001)
        EnergyRatios.Add("Therms", 105505585.257)
        EnergyRatios.Add("Ton TNT", 4184000000.0)
        EnergyRatios.Add("Horsepower-hours", 2684519.54)

        ' Speed ratios
        SpeedRatios.Add("MPH", 0.44704)
        SpeedRatios.Add("km/h", 0.277777778)
        SpeedRatios.Add("ft/s", 0.3048)
        SpeedRatios.Add("m/s", 1) ' Base unit
        SpeedRatios.Add("LFM", 0.00508)
        SpeedRatios.Add("Knots", 0.514444)
        SpeedRatios.Add("Mach", 343.0) ' Approximately at sea level; may change at higher or lower altitudes
        SpeedRatios.Add("cm/s", 0.01)
        SpeedRatios.Add("mm/s", 0.001)

        ' Mass ratios
        MassRatios.Add("Grams", 0.001)
        MassRatios.Add("Milligrams", 0.000001)
        MassRatios.Add("Micrograms", 0.000000001)
        MassRatios.Add("Carats", 0.0002)
        MassRatios.Add("Atomic Mass Units", 1.6605390666E-27)
        MassRatios.Add("Ounces", 0.0283495)
        MassRatios.Add("Kilograms", 1) ' Base unit
        MassRatios.Add("Pounds", 0.45359237)
        MassRatios.Add("Metric Tonnes", 1000)
        MassRatios.Add("Short Tonnes", 907.18474)
        MassRatios.Add("Long Tonnes", 1016.0469088)
        MassRatios.Add("Stones", 6.35029318)

        ' Weight ratios
        WeightRatios.Add("Dyne", 0.00001)
        WeightRatios.Add("Newton", 1) ' Base unit
        WeightRatios.Add("Kilopond", 9.80665)
        WeightRatios.Add("Kilonewton", 1000)
        WeightRatios.Add("Pound-force", 4.44822)
        WeightRatios.Add("Gram-force", 0.00980665)
        WeightRatios.Add("Ton-force", 8896.443)
        For Each kvp As KeyValuePair(Of String, Double) In MassRatios
            WeightRatios.Add("Earth " & kvp.Key, kvp.Value)
        Next

        ' Angle ratios
        AngleRatios.Add("Degrees", 1) ' Base unit
        AngleRatios.Add("Radians", 180 / Math.PI)
        AngleRatios.Add("Gradians", 0.9)
        AngleRatios.Add("Arcminutes", 1.0 / 60)
        AngleRatios.Add("Arcseconds", 1.0 / 3600)


    End Sub

    ' Temperature conversion function
    Private Sub TempConvert(ByVal fromUnit As String, ByVal toUnit As String, ByVal userInput As Double)
        Dim calcTemp As Double

        If fromUnit = "C" And toUnit = "F" Then
            calcTemp = (userInput * (9 / 5)) + 32
            ResultBox.Text = calcTemp.ToString()

        ElseIf fromUnit = "C" And toUnit = "K" Then
            calcTemp = userInput + 273.15
            ResultBox.Text = calcTemp.ToString()

        ElseIf fromUnit = "F" And toUnit = "C" Then
            calcTemp = (userInput - 32) * 5 / 9
            ResultBox.Text = calcTemp.ToString()

        ElseIf fromUnit = "F" And toUnit = "K" Then
            calcTemp = (userInput - 32) * 5 / 9 + 273.15
            ResultBox.Text = calcTemp.ToString()

        ElseIf fromUnit = "K" And toUnit = "C" Then
            calcTemp = userInput - 273.15
            ResultBox.Text = calcTemp.ToString()

        ElseIf fromUnit = "K" And toUnit = "F" Then
            calcTemp = (userInput - 273.15) * 9 / 5 + 32
            ResultBox.Text = calcTemp.ToString()

        ElseIf fromUnit = toUnit Then
            ResultBox.Text = userInput.ToString()

        Else
            MessageBox.Show("Invalid temperature conversion. This is probably a bug and should be reported at https://github.com/matthewyang204/MultiUnit/issues.")
        End If
    End Sub

    ' Airflow Conversions
    Private Sub AFConvert(ByVal fromUnit As String, ByVal toUnit As String, ByVal userInput As Double)
        Dim calcTemp As Double
        ' Dim areaBox As String = "Enter the area in square feet, which is required for this conversion formula: "
        Dim rawDimensions As New List(Of Double)
        Dim dimensions As New List(Of Double)
        Dim area As Double
        Dim areaUnit As String = AreaUnitSelector.SelectedItem.ToString()
        ' Convert the length and width to Double, but make sure to catch exception, otherwise program will crash into hell
        If fromUnit = "CFM" Or toUnit = "CFM" Then
            Try
                rawDimensions.Add(CDbl(AreaInputBox.Text))
                rawDimensions.Add(CDbl(Area2InputBox.Text))
            Catch ex As Exception
                MessageBox.Show("Invalid input. Please enter a valid number.")
                Exit Sub
            End Try
            dimensions.Add(rawDimensions(0) * LengthRatios(areaUnit) / LengthRatios("Feet"))
            dimensions.Add(rawDimensions(1) * LengthRatios(areaUnit) / LengthRatios("Feet"))
            area = dimensions(0) * dimensions(1)
            If area <= 0 Then
                MessageBox.Show("Your area is 0 or negative. This will give you meaningless results.")
            Else
                ' Enable only to debug area value
                ' MessageBox.Show(area)
            End If
        End If

        ' Airflow conversions
        If fromUnit = "CFM" And toUnit = "LFM" Then
            ' areaString = InputBox(areaBox + "Area")
            calcTemp = userInput / area
            ResultBox.Text = calcTemp.ToString()

        ElseIf fromUnit = "LFM" And toUnit = "CFM" Then
            ' areaString = InputBox(areaBox + "Area")
            calcTemp = userInput * area
            ResultBox.Text = calcTemp.ToString()

        ElseIf fromUnit = toUnit Then
            ResultBox.Text = userInput.ToString()

        ElseIf SpeedRatios.ContainsKey(fromUnit) Or SpeedRatios.ContainsKey(toUnit) Then
            Dim ratioDict As Dictionary(Of String, Double)
            ratioDict = SpeedRatios
            If fromUnit = "CFM" Then
                userInput = userInput / area
                fromUnit = "LFM"
            ElseIf toUnit = "CFM" Then
                calcTemp = userInput * ratioDict(fromUnit) / ratioDict("LFM")
                Dim result As Double = calcTemp * area
                ResultBox.Text = result.ToString()
                Exit Sub
            End If

            calcTemp = userInput * ratioDict(fromUnit) / ratioDict(toUnit)
            ResultBox.Text = calcTemp.ToString()
        Else
            MessageBox.Show("Invalid Airflow conversion. This is probably a bug and should be reported at https://github.com/matthewyang204/MultiUnit/issues.")
            Exit Sub
        End If
    End Sub


    ' Simulate ConvertButton click when user hits enter key with the Input box focused
    Private Sub EnterKey_Press(sender As Object, e As KeyEventArgs) Handles Input.KeyDown, AreaInputBox.KeyDown, Area2InputBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConvertButton.PerformClick()
        End If
    End Sub

    ' Detects when "Convert" button is clicked
    Private Sub ConvertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertButton.Click
        ' Get the user input as String from Input box
        Dim userInputStr As String = Input.Text
        ' Create a blank Double variable
        Dim userInput As Double
        ' Convert the String to a Double and store it in a plain userInput value
        Try
            userInput = CDbl(userInputStr)
        Catch ex As Exception
            MessageBox.Show("Invalid input. Please enter a valid number.")
            Exit Sub
        End Try
        Dim category As String = UnitCategorySelector.SelectedItem.ToString()
        Dim fromUnit As String = UnitSelectionBox.SelectedItem.ToString()
        Dim toUnit As String = Unit2SelectionBox.SelectedItem.ToString()
        Dim ratioDict As Dictionary(Of String, Double)
        Dim result As Double

        Select Case category
            Case "Length"
                ratioDict = LengthRatios
            Case "Area"
                ratioDict = AreaRatios
            Case "Volume"
                ratioDict = VolumeRatios
            Case "Energy"
                ratioDict = EnergyRatios
            Case "Speed"
                ratioDict = SpeedRatios
            Case "Mass"
                ratioDict = MassRatios
            Case "Weight"
                ratioDict = WeightRatios
            Case "Temperature"
                TempConvert(fromUnit, toUnit, userInput)
                Exit Sub
            Case "Air Flow"
                AFConvert(fromUnit, toUnit, userInput)
                Exit Sub
            Case "Angle"
                ratioDict = AngleRatios
            Case "Currency"
                ratioDict = CurrencyRatios
            Case Else
                MessageBox.Show("Unknown category. Please select a known category from the list.")
                Exit Sub
        End Select

        result = userInput * ratioDict(fromUnit) / ratioDict(toUnit)
        ResultBox.Text = result.ToString()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Input.TextChanged
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputmessage.Click
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub UnitSelectionBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitSelectionBox.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class

