Public Class Form1
    Dim Dpounds As Decimal
    Dim Rpounds As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Decimal.TryParse(DecafTextBox.Text, Dpounds)
        Decimal.TryParse(RegularTextBox.Text, Rpounds)
        PoundsTextBox.Text = Rpounds + Dpounds
        TotalTextBox.Text = ((Rpounds + Dpounds) * 4.99).ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TotalTextBox.Clear()
        PoundsTextBox.Clear()
        RegularTextBox.Clear()
        DecafTextBox.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
