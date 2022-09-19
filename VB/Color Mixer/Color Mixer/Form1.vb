Public Class Form1
    Dim Inputred As Integer
    Dim Inputblue As Integer
    Dim Inputgreen As Integer
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Integer.TryParse(RedTextBox.Text, Inputred)
        Integer.TryParse(BlueTextBox.Text, Inputblue)
        Integer.TryParse(GreenTextBox.Text, Inputgreen)
        ColorOvalButton.BackColor = Color.FromArgb(Inputred, Inputblue, Inputgreen)
    End Sub

End Class