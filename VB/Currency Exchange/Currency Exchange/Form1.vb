Public Class Form1
    Private Sub PesosButton_Click(sender As Object, e As EventArgs) Handles PesosButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextBox.Text, Dollars)
        Dim Pesos As Decimal
        Pesos = Dollars * 20
        outputTextBox.Text = Pesos.ToString("n2")
    End Sub

    Private Sub BahamaianButton_Click(sender As Object, e As EventArgs) Handles BahamaianButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextBox.Text, Dollars)
        Dim bahama As Decimal
        bahama = Dollars * 1
        outputTextBox.Text = bahama.ToString("n2")
    End Sub

    Private Sub EuroButton_Click(sender As Object, e As EventArgs) Handles EuroButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextBox.Text, Dollars)
        Dim Euro As Decimal
        Euro = Dollars * 1
        outputTextBox.Text = Euro.ToString("n2")
    End Sub

    Private Sub CADButton_Click(sender As Object, e As EventArgs) Handles CADButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextBox.Text, Dollars)
        Dim CAD As Decimal
        CAD = Dollars * 1.29
        outputTextBox.Text = CAD.ToString("n2")
    End Sub

    Private Sub IndianRupeeButton_Click(sender As Object, e As EventArgs) Handles IndianRupeeButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextBox.Text, Dollars)
        Dim Rupee As Decimal
        Rupee = Dollars * 79.89
        outputTextBox.Text = Rupee.ToString("n2")
    End Sub

    Private Sub JapaneseYenButton_Click(sender As Object, e As EventArgs) Handles JapaneseYenButton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextBox.Text, Dollars)
        Dim Yen As Decimal
        Yen = Dollars * 136.72
        outputTextBox.Text = Yen.ToString("n2")
    End Sub
End Class
