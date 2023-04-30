Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double = Val(TextBox1.Text)
        Dim num2 As Double = Val(TextBox2.Text)
        Dim suma As Double = num1 + num2
        Dim resta As Double = num1 - num2
        Dim multi As Double = num1 * num2
        Dim division As Double = num1 / num2
        MessageBox.Show("La suma es " & suma & " la resta es " & resta & " la multiplicacion es " & multi & " la division es " & division)
    End Sub
End Class