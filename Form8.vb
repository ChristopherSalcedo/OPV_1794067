Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim celcius As Double = Val(TextBox1.Text)
        Dim farengheit As Double = (celcius * 1.8) + 32
        MessageBox.Show("La temperatura en fharenheit es " & farengheit)
    End Sub
End Class