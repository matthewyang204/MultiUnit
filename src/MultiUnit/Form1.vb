Public Class MultiUnit

    Private Sub Load_Menus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If UnitCategorySelector.Items.Count > 0 Then
            UnitCategorySelector.SelectedIndex = 0
        End If

        If UnitSelectionBox.Items.Count > 0 Then
            UnitSelectionBox.SelectedIndex = 0
        End If

        Me.Controls.Add(UnitCategorySelector)
        Me.Controls.Add(UnitSelectionBox)
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
                UnitSelectionBox.Items.Add("Grams -> Kilograms")
                UnitSelectionBox.Items.Add("Grams -> Pounds")
                UnitSelectionBox.Items.Add("Kilograms -> Grams")
                UnitSelectionBox.Items.Add("Kilograms -> Pounds")
                UnitSelectionBox.Items.Add("Pounds -> Grams")
                UnitSelectionBox.Items.Add("Pounds -> Kilograms")

            Case "Mass"
                UnitSelectionBox.Items.Add("Kilograms -> Grams")
                UnitSelectionBox.Items.Add("Kilograms -> Tonnes")
                UnitSelectionBox.Items.Add("Grams -> Kilograms")
                UnitSelectionBox.Items.Add("Grams -> Tonnes")
                UnitSelectionBox.Items.Add("Tonnes -> Kilograms")
                UnitSelectionBox.Items.Add("Tonnes -> Grams")

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
        ' Convert the String to a Double and store it in a plain userInput value
        Dim userInput As Double = CDbl(userInputSTR)
        ' Create a temporary variable that is cleaned up after each use
        Dim calcTemp As Double

        Select Case UnitSelectionBox.SelectedItem.ToString()
            Case "C -> F"
                calcTemp = (userInput * (9 / 5)) + 32
                ResultBox.Text = calcTemp.ToString()
                calcTemp = 0

            Case "C -> K"
                calcTemp = userInput + 273.15
                ResultBox.Text = calcTemp.ToString
                calcTemp = 0

            Case "F -> C"
                calcTemp = (userInput - 32) * 5 / 9
                ResultBox.Text = calcTemp.ToString()
                calcTemp = 0

            Case "F -> K"
                calcTemp = (userInput - 32) * 5 / 9 + 273.15
                ResultBox.Text = calcTemp.ToString()
                calcTemp = 0

            Case "K -> C"
                calcTemp = userInput - 273.15
                ResultBox.Text = calcTemp.ToString
                calcTemp = 0

            Case "K -> F"
                calcTemp = (userInput - 273.15) * 9 / 5 + 32
                ResultBox.Text = calcTemp.ToString
                calcTemp = 0



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
End Class

