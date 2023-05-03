Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form17
    Dim productos As New List(Of Producto)
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Public Class Producto
        Public Property nombre As String
        Public Property cantidad As Integer
        Public Property precio As Decimal
    End Class

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim cantidad, totalVenta As Decimal

        For Each producto In productos
            cantidad += producto.cantidad
            totalVenta += producto.cantidad * producto.precio
        Next

        'Calcular el IVA del 16%
        Dim iva As Decimal = totalVenta * 0.16

        'Calcular el total a pagar
        Dim totalPagar As Decimal = totalVenta + iva

        'Mostrar los resultados en los cuadros de texto correspondientes
        txtTotalVenta.Text = totalVenta.ToString("C")
        txtIVA.Text = iva.ToString("C")
        txtTotalPagar.Text = totalPagar.ToString("C")
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        'Agregar los valores ingresados a una lista para llevar un registro de todas las ventas
        Dim nombreProducto As String = txtNombreProducto.Text
        Dim cantidad As Integer = Integer.Parse(txtCantidad.Text)
        Dim valorUnitario As Decimal = Decimal.Parse(txtValorUnitario.Text)

        Dim producto1 As New Producto With {
    .nombre = nombreProducto,
    .cantidad = cantidad,
    .precio = valorUnitario
    }

        productos.Add(producto1)

        Dim lblName As New Label()
        Dim lblItems As New Label()
        Dim lblPrice As New Label()
        lblName.Text = nombreProducto
        lblName.TextAlign = ContentAlignment.MiddleCenter
        lblItems.Text = cantidad.ToString()
        lblItems.TextAlign = ContentAlignment.MiddleCenter
        lblPrice.Text = valorUnitario.ToString("C")
        lblPrice.TextAlign = ContentAlignment.MiddleCenter
        Dim rowCount As Integer = TableLayoutPanel1.RowCount

        ' Agregar una nueva fila al TableLayoutPanel
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        TableLayoutPanel1.RowCount = rowCount + 1

        TableLayoutPanel1.Controls.Add(lblName, 0, rowCount)
        TableLayoutPanel1.Controls.Add(lblItems, 1, rowCount)
        TableLayoutPanel1.Controls.Add(lblPrice, 2, rowCount)

        'Limpiar los cuadros de texto y poner el foco en el cuadro de texto de nombre de producto
        btnLimpiar.PerformClick()
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Limpiar los cuadros de texto
        txtNombreProducto.Clear()
        txtCantidad.Clear()
        txtValorUnitario.Clear()
        txtTotalVenta.Clear()
        txtIVA.Clear()
        txtTotalPagar.Clear()

        'Poner el foco en el cuadro de texto de nombre de producto
        txtNombreProducto.Focus()
    End Sub

End Class