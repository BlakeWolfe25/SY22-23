Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
        LowDunksTextBox.Text = UniversityBlueLowDunks
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.ShowDialog()
        HighDunkTextBox.Text = HighDunkPandas
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.ShowDialog()
        Jordan1sTextBox.Text = OffWhiteJordan1s
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Jordan4s.Click
        Form5.ShowDialog()
        Jordan4sTextBox.Text = Jordan4sRedThunder
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.ShowDialog()
        Jordan36sTextBox.Text = Jordan36sBlackWhite
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim GrandTotal As Decimal = UniversityBlueLowDunks * 400 + HighDunkPandas * 1800 +
            OffWhiteJordan1s * 2200 + Jordan4sRedThunder * 200 + Jordan36sBlackWhite * 185
        GrandTotalLabel.Text = GrandTotal.ToString("C2")
    End Sub
End Class
