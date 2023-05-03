Imports System.Security.Cryptography

Public Class Form12
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fecha As Date = DateTimePicker1.Value
        Dim dia As Integer = fecha.Day
        Dim mes As Integer = fecha.Month
        Dim anio As Integer = fecha.Year
        Label1.Text = dia.ToString() & "/" & mes.ToString() & "/" & anio.ToString()
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class