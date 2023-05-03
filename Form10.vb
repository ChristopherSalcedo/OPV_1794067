Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim letra As Char = TextBox1.Text
        Dim palabra As String = TextBox2.Text
        Dim X As Int32 = 0
        For Each letr As Char In palabra
            If (letr = letra) Then
                X += 1
            End If
        Next
        MessageBox.Show("La cantidad caracteres es " & X)
    End Sub
End Class