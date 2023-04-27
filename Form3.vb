Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Int32 = Int32.Parse(TextBox1.Text)
        If num Mod 2 = 0 Then
            Label2.Text = "El numero es par"
        Else
            Label2.Text = "El numero es impar"
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class