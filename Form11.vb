Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtener los nombres ingresados en el cuadro de texto
        Dim nombres As String() = TextBox1.Text.Split(","c)

        ' Ordenar los nombres alfabéticamente
        Array.Sort(nombres)

        ' Mostrar los nombres ordenados en el cuadro de texto de resultado
        Label2.Text = String.Join(", ", nombres)
    End Sub
End Class