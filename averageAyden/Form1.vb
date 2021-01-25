Public Class Form1
    Dim sngTotal As Single
    Dim intCounter As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim sngAverage As Single

        sngTotal = sngTotal + Val(txtNumber.Text)

        intCounter = intCounter + 1
        sngAverage = sngTotal / intCounter

        lblAverage.Text = "Average: " & sngAverage
    End Sub
        
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        sngTotal = 0
        lblAverage.Text = "Average: " & sngTotal

    End Sub
End Class
