Imports System.Collections.Immutable
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeros As String = TextBox1.Text
        Dim numerosseparados() As String = numeros.Split(",")
        Dim arr(numerosseparados.Length - 1) As Integer
        For i As Integer = 0 To numerosseparados.Length - 1
            arr(i) = Integer.Parse(numerosseparados(i))
        Next
        Array.Sort(arr)
        MessageBox.Show("El maximo es " & arr(arr.Length - 1) & " el minimo es " & arr(0))
    End Sub

End Class