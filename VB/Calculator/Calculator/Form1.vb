Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim oper As String
    Dim mem As Decimal
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button6.Click, Number8.Click, Number7.Click, Number4.Click, Number1.Click, Number3.Click, Number2.Click, Button12.Click, Number5.Click, Number0.Click, DecimalButton.click
        DisplayTextBox.Text = DisplayTextBox.Text + sender.text
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayTextBox.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles AdditionButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "+"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles EqualsButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num2)
        If oper = "+" Then
            DisplayTextBox.Text = num1 + num2
        End If
        If oper = "-" Then
            DisplayTextBox.Text = num1 - num2
        End If
        If oper = "/" Then
            DisplayTextBox.Text = num1 / num2
        End If
        If oper = "*" Then
            DisplayTextBox.Text = num1 * num2
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles SubtractionButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "-"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles DivideButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "/"
        DisplayTextBox.Clear()
    End Sub

    Private Sub MultiplicationButton_Click(sender As Object, e As EventArgs) Handles MultiplicationButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "*"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Sqrt(num1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Sin(num1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Tan(num1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Cos(num1)
    End Sub

    Private Sub PIButton_Click(sender As Object, e As EventArgs) Handles PIButton.Click
        DisplayTextBox.Text = Math.PI
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Decimal.TryParse(DisplayTextBox.Text, mem)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DisplayTextBox.Text = mem
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        mem = 0
    End Sub
End Class
