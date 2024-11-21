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

        Select Case UnitCategorySelector.SelectedItem.ToString()
            Case "Temperature"
                UnitSelectionBox.Items.Add("C -> F")
                UnitSelectionBox.Items.Add("C -> K")
                UnitSelectionBox.Items.Add("F -> C")
                UnitSelectionBox.Items.Add("F -> K")
                UnitSelectionBox.Items.Add("K -> C")
                UnitSelectionBox.Items.Add("K -> F")

            Case "Length"
                UnitSelectionBox.Items.Add("Meters -> Kilometers")
                UnitSelectionBox.Items.Add("Meters -> Centimeters")
                UnitSelectionBox.Items.Add("Kilometers -> Meters")
                UnitSelectionBox.Items.Add("Kilometers -> Centimeters")
                UnitSelectionBox.Items.Add("Centimeters -> Meters")
                UnitSelectionBox.Items.Add("Centimeters -> Kilometers")

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

            Case Else
                MessageBox.Show("Please select a valid category.")
        End Select

        If UnitSelectionBox.Items.Count > 0 Then
            UnitSelectionBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Input.TextChanged
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputmessage.Click
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class

