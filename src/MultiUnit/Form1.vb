Public Class MultiUnit

    Private Sub Load_Menus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If UnitCategorySelector.Items.Count > 0 Then
            UnitCategorySelector.SelectedIndex = 0
        End If

        If UnitSelectionBox.Items.Count > 0 Then
            UnitSelectionBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub UnitCategorySelector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitCategorySelector.SelectedIndexChanged
        UnitSelectionBox.Items.Clear()
        ' Get UnitCategorySelector and set UnitSelectionBox accordingly
        Select Case UnitCategorySelector.SelectedItem.ToString()
            Case "Temperature"
                UnitSelectionBox.Items.Add("C -> F")
                UnitSelectionBox.Items.Add("C -> K")
                UnitSelectionBox.Items.Add("F -> C")
                UnitSelectionBox.Items.Add("F -> K")
                UnitSelectionBox.Items.Add("K -> C")
                UnitSelectionBox.Items.Add("K -> F")

            Case "Length"
                UnitSelectionBox.Items.Add("Meters -> Yards")
                UnitSelectionBox.Items.Add("Yards -> Meters")
                UnitSelectionBox.Items.Add("Centimeters -> Inches")
                UnitSelectionBox.Items.Add("Inches -> Centimeters")
                UnitSelectionBox.Items.Add("Kilometers -> Miles")
                UnitSelectionBox.Items.Add("Miles -> Kilometers")

            Case "Weight"
                UnitSelectionBox.Items.Add("Dyne -> Newton")
                UnitSelectionBox.Items.Add("Newton -> Dyne")
                UnitSelectionBox.Items.Add("Kilopond -> Newton")
                UnitSelectionBox.Items.Add("Newton -> Kilopond")
                UnitSelectionBox.Items.Add("Kilonewton -> Newton")
                UnitSelectionBox.Items.Add("Newton -> Kilonewton")
                UnitSelectionBox.Items.Add("Pound-force -> Kilonewton")
                UnitSelectionBox.Items.Add("Kilonewton -> Pound-force")
                UnitSelectionBox.Items.Add("Pound-force -> Kilopond")
                UnitSelectionBox.Items.Add("Kilopond -> Pound-force")
                UnitSelectionBox.Items.Add("Pound-force -> Newton")
                UnitSelectionBox.Items.Add("Newton -> Pound-force")



            Case "Mass"
                UnitSelectionBox.Items.Add("Grams -> Ounces")
                UnitSelectionBox.Items.Add("Ounces -> Grams")
                UnitSelectionBox.Items.Add("Kilograms -> Pounds")
                UnitSelectionBox.Items.Add("Pounds -> Kilograms")
                UnitSelectionBox.Items.Add("Metric Tonnes -> Short Tonnes")
                UnitSelectionBox.Items.Add("Short Tonnes -> Metric Tonnes")
                UnitSelectionBox.Items.Add("Metric Tonnes -> Long Tonnes")
                UnitSelectionBox.Items.Add("Long Tonnes -> Metric Tonnes")
                UnitSelectionBox.Items.Add("Short Tonnes -> Long Tonnes")
                UnitSelectionBox.Items.Add("Long Tonnes -> Short Tonnes")
            
            Case "Air Flow"
                UnitSelectionBox.Items.Add("CFM -> LFM")
                UnitSelectionBox.Items.Add("LFM -> CFM")

                ' Display error if the user doesn't select proper number
            Case Else
                MessageBox.Show("Please select a valid category.")
        End Select

        If UnitSelectionBox.Items.Count > 0 Then
            UnitSelectionBox.SelectedIndex = 0
        End If
    End Sub
    ' Detects when "Convert" button is clicked
    Private Sub ConvertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertButton.Click
        ' Get the user input as String from Input box
        Dim userInputSTR As String = Input.Text
        ' Create a blank Double variable
        Dim userInput As Double
        ' Convert the String to a Double and store it in a plain userInput value
        Try
            userInput = CDbl(userInputSTR)
        Catch ex As Exception
            MessageBox.Show("Invalid input. Please enter a valid number.")
            Exit Sub
        End Try
        ' Create a temporary variable that is cleaned up after each use
        Dim calcTemp As Double

        Select Case UnitSelectionBox.SelectedItem.ToString()

            ' Temperature conversions
            Case "C -> F"
                calcTemp = (userInput * (9 / 5)) + 32
                ResultBox.Text = calcTemp.ToString()

            Case "C -> K"
                calcTemp = userInput + 273.15
                ResultBox.Text = calcTemp.ToString()

            Case "F -> C"
                calcTemp = (userInput - 32) * 5 / 9
                ResultBox.Text = calcTemp.ToString()

            Case "F -> K"
                calcTemp = (userInput - 32) * 5 / 9 + 273.15
                ResultBox.Text = calcTemp.ToString()

            Case "K -> C"
                calcTemp = userInput - 273.15
                ResultBox.Text = calcTemp.ToString()

            Case "K -> F"
                calcTemp = (userInput - 273.15) * 9 / 5 + 32
                ResultBox.Text = calcTemp.ToString()

                ' Length conversions
            Case "Meters -> Yards"
                calcTemp = userInput * 1.09361
                ResultBox.Text = calcTemp.ToString()

            Case "Yards -> Meters"
                calcTemp = userInput / 1.09361
                ResultBox.Text = calcTemp.ToString()

            Case "Centimeters -> Inches"
                calcTemp = userInput * 2.54
                ResultBox.Text = calcTemp.ToString()

            Case "Inches -> Centimeters"
                calcTemp = userInput / 2.54
                ResultBox.Text = calcTemp.ToString()

            Case "Kilometers -> Miles"
                calcTemp = userInput * 0.62137119
                ResultBox.Text = calcTemp.ToString()

            Case "Miles -> Kilometers"
                calcTemp = userInput / 0.62137119
                ResultBox.Text = calcTemp.ToString()

                ' Weight conversions
            Case "Dyne -> Newton"
                calcTemp = userInput / 100000
                ResultBox.Text = calcTemp.ToString()

            Case "Newton -> Dyne"
                calcTemp = userInput * 100000
                ResultBox.Text = calcTemp.ToString()

            Case "Kilopond -> Newton"
                calcTemp = userInput * 9.80664999999931
                ResultBox.Text = calcTemp.ToString()

            Case "Newton -> Kilopond"
                calcTemp = userInput / 9.80664999999931
                ResultBox.Text = calcTemp.ToString()

            Case "Kilonewton -> Newton"
                calcTemp = userInput / 1000
                ResultBox.Text = calcTemp.ToString()

            Case "Newton -> Kilonewton"
                calcTemp = userInput * 1000
                ResultBox.Text = calcTemp.ToString()

            Case "Pound-force -> Kilonewton"
                calcTemp = userInput / 224.808943
                ResultBox.Text = calcTemp.ToString()

            Case "Kilonewton -> Pound-force"
                calcTemp = userInput * 224.808943
                ResultBox.Text = calcTemp.ToString()

            Case "Pound-force -> Kilopond"
                calcTemp = userInput * 0.45359237
                ResultBox.Text = calcTemp.ToString()

            Case "Kilopond -> Pound-force"
                calcTemp = userInput / 0.45359237
                ResultBox.Text = calcTemp.ToString()

            Case "Pound-force -> Newton"
                calcTemp = userInput * 4.44822
                ResultBox.Text = calcTemp.ToString()

            Case "Newton -> Pound-force"
                calcTemp = userInput / 4.44822
                ResultBox.Text = calcTemp.ToString()

                ' Mass conversions
            Case "Grams -> Ounces"
                calcTemp = userInput * 0.03527396
                ResultBox.Text = calcTemp.ToString()

            Case "Ounces -> Grams"
                calcTemp = userInput / 0.03527396
                ResultBox.Text = calcTemp.ToString()

            Case "Kilograms -> Pounds"
                calcTemp = userInput * 2.20462
                ResultBox.Text = calcTemp.ToString()

            Case "Pounds -> Kilograms"
                calcTemp = userInput / 2.20462
                ResultBox.Text = calcTemp.ToString()

            Case "Metric Tonnes -> Short Tonnes"
                calcTemp = userInput * 1.10231
                ResultBox.Text = calcTemp.ToString()

            Case "Short Tonnes -> Metric Tonnes"
                calcTemp = userInput / 1.10231
                ResultBox.Text = calcTemp.ToString()

            Case "Metric Tonnes -> Short Tonnes"
                calcTemp = userInput * 0.984207
                ResultBox.Text = calcTemp.ToString()

            Case "Long Tonnes -> Metric Tonnes"
                calcTemp = userInput / 0.984207
                ResultBox.Text = calcTemp.ToString()

            Case "Metric Tonnes -> Long Tonnes"
                calcTemp = userInput / 0.985207
                ResultBox.Text = calcTemp.ToString()

            Case "Short Tonnes -> Long Tonnes"
                calcTemp = userInput * 0.892857
                ResultBox.Text = calcTemp.ToString()

            Case "Long Tonnes -> Short Tonnes"
                calcTemp = userInput * 0.892857
                ResultBox.Text = calcTemp.ToString()
            
            ' Airflow conversions
            Case "CFM -> LFM"
                Dim areaString as String
                Dim area as Double
                areaString = InputBox("Enter the area in ft^2, which is required for this conversion formula: " + "Area")
                area = CDbl(areaString)
                calcTemp = userInput / area
                ResultBox.Text = calcTemp.ToString()
                areaString = Nothing
                area = Nothing
            
            Case "LFM -> CFM"
                Dim areaString as String
                Dim area as Double
                areaString = InputBox("Enter the area ft^2, which is required for thsi conversion formula: " + "Area")
                calcTemp = userInput / area
                ResultBox.Text = calcTemp.ToString()
                areaString = Nothing
                area = Nothing
            
            Case Else
                MessageBox.Show("Please select a conversion from the list.")

        End Select
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
End Class

