Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Int32 = Int32.Parse(TextBox1.Text)
        If num > 0 Then
            Label2.Text = "Positivo"
        ElseIf num < 0 Then
            Label2.Text = "Es negativo"
        Else
            Label2.Text = "Cero"
        End If
    End Sub
End Class