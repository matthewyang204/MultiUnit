Public Class MultiUnit

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
    End Sub

    ' Declare the variables
    Dim Units As New List(Of String)

    Private Sub UnitCategorySelector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitCategorySelector.SelectedIndexChanged
        Units.Clear()
        UnitSelectionBox.Items.Clear()
        Unit2SelectionBox.Items.Clear()
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
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Length"
                Units.Add("Meters")
                Units.Add("Yards")
                Units.Add("Centimeters")
                Units.Add("Inches")
                Units.Add("Kilometers")
                Units.Add("Miles")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Weight"
                Units.Add("Dyne")
                Units.Add("Newton")
                Units.Add("Kilopond")
                Units.Add("Kilonewton")
                Units.Add("Pound-force")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Mass"
                Units.Add("Grams")
                Units.Add("Ounces")
                Units.Add("Kilograms")
                Units.Add("Pounds")
                Units.Add("Metric Tonnes")
                Units.Add("Short Tonnes")
                Units.Add("Long Tonnes")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

            Case "Air Flow"
                Units.Add("CFM")
                Units.Add("LFM")
                UnitSelectionBox.Items.AddRange(Units.ToArray())
                Unit2SelectionBox.Items.AddRange(Units.ToArray())

                ' Display error if the user doesn't select proper number
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
    Private SpeedRatios As New Dictionary(Of String, Double)
    Private MassRatios As New Dictionary(Of String, Double)
    Private WeightRatios As New Dictionary(Of String, Double)

    Private Sub LoadRatios()
        ' Length ratios
        LengthRatios.Add("Meters", 1)
        LengthRatios.Add("Yards", 0.9144)
        LengthRatios.Add("Centimeters", 0.01)
        LengthRatios.Add("Inches", 0.0254)
        LengthRatios.Add("Kilometers", 1000.0)
        LengthRatios.Add("Miles", 1609.34)

        ' Speed ratios
        SpeedRatios.Add("MPH", 0.44704)
        SpeedRatios.Add("km/h", 0.277777778)
        SpeedRatios.Add("ft/s", 0.3048)
        SpeedRatios.Add("m/s", 1)

        ' Mass ratios
        MassRatios.Add("Grams", 0.001)
        MassRatios.Add("Ounces", 0.0283495)
        MassRatios.Add("Kilograms", 1)
        MassRatios.Add("Pounds", 0.45359237)
        MassRatios.Add("Metric Tonnes", 1000)
        MassRatios.Add("Short Tonnes", 907.18474)
        MassRatios.Add("Long Tonnes", 1016.0469088)

        ' Weight ratios
        WeightRatios.Add("Dyne", 0.00001)
        WeightRatios.Add("Newton", 1)
        WeightRatios.Add("Kilopond", 9.80665)
        WeightRatios.Add("Kilonewton", 1000)
        WeightRatios.Add("Pound-force", 4.44822)
    End Sub

    ' Simulate ConvertButton click when user hits enter key with the Input box focused
    Private Sub EnterKey_Press(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Input.KeyDown
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
        Dim calcTemp As Double
        Dim category As String = UnitCategorySelector.SelectedItem.ToString()
        Dim fromUnit As String = UnitSelectionBox.SelectedItem.ToString()
        Dim toUnit As String = Unit2SelectionBox.SelectedItem.ToString()
        Dim ratioDict As Dictionary(Of String, Double)
        Dim result As Double

        Select Case category
            Case "Length"
                ratioDict = LengthRatios
            Case "Speed"
                ratioDict = SpeedRatios
            Case "Mass"
                ratioDict = MassRatios
            Case "Weight"
                ratioDict = WeightRatios
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
End Class

