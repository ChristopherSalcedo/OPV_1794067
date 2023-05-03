Public Class Form16
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = Integer.Parse(TextBox1.Text)
        Dim output As String = ""
        For i As Integer = 1 To num - 1
            output &= i.ToString() & " "
        Next
        MessageBox.Show("Números naturales menores que " & num.ToString() & ": " & output)
    End Sub
End Class