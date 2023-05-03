<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button17 = New Button()
        btnCalcular = New Button()
        btnSiguiente = New Button()
        txtNombreProducto = New TextBox()
        txtCantidad = New TextBox()
        txtValorUnitario = New TextBox()
        txtTotalVenta = New TextBox()
        txtIVA = New TextBox()
        txtTotalPagar = New TextBox()
        btnLimpiar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        SuspendLayout()
        ' 
        ' Button17
        ' 
        Button17.Location = New Point(12, 12)
        Button17.Name = "Button17"
        Button17.Size = New Size(34, 23)
        Button17.TabIndex = 18
        Button17.Text = "<-"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.BackColor = SystemColors.GradientActiveCaption
        btnCalcular.Location = New Point(406, 389)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(75, 23)
        btnCalcular.TabIndex = 19
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = False
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.BackColor = SystemColors.GradientActiveCaption
        btnSiguiente.Location = New Point(306, 389)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(75, 23)
        btnSiguiente.TabIndex = 20
        btnSiguiente.Text = "Siguiente"
        btnSiguiente.UseVisualStyleBackColor = False
        ' 
        ' txtNombreProducto
        ' 
        txtNombreProducto.Location = New Point(169, 84)
        txtNombreProducto.Name = "txtNombreProducto"
        txtNombreProducto.Size = New Size(100, 23)
        txtNombreProducto.TabIndex = 21
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(169, 131)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(100, 23)
        txtCantidad.TabIndex = 22
        ' 
        ' txtValorUnitario
        ' 
        txtValorUnitario.Location = New Point(169, 176)
        txtValorUnitario.Name = "txtValorUnitario"
        txtValorUnitario.Size = New Size(100, 23)
        txtValorUnitario.TabIndex = 23
        ' 
        ' txtTotalVenta
        ' 
        txtTotalVenta.Cursor = Cursors.No
        txtTotalVenta.Enabled = False
        txtTotalVenta.Location = New Point(169, 230)
        txtTotalVenta.Name = "txtTotalVenta"
        txtTotalVenta.Size = New Size(100, 23)
        txtTotalVenta.TabIndex = 24
        ' 
        ' txtIVA
        ' 
        txtIVA.Cursor = Cursors.No
        txtIVA.Enabled = False
        txtIVA.Location = New Point(169, 281)
        txtIVA.Name = "txtIVA"
        txtIVA.Size = New Size(100, 23)
        txtIVA.TabIndex = 25
        ' 
        ' txtTotalPagar
        ' 
        txtTotalPagar.Cursor = Cursors.No
        txtTotalPagar.Enabled = False
        txtTotalPagar.Location = New Point(169, 329)
        txtTotalPagar.Name = "txtTotalPagar"
        txtTotalPagar.Size = New Size(100, 23)
        txtTotalPagar.TabIndex = 26
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = SystemColors.GradientActiveCaption
        btnLimpiar.Location = New Point(502, 389)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(75, 23)
        btnLimpiar.TabIndex = 27
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 29
        Label1.Text = "Nombre"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(97, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 30
        Label2.Text = "Cantidad"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(85, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 31
        Label3.Text = "Valor Unitario"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(95, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 32
        Label4.Text = "Total Venta"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(110, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 15)
        Label5.TabIndex = 33
        Label5.Text = "IVA 16%"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(85, 332)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 15)
        Label6.TabIndex = 34
        Label6.Text = "Total a Pagar"' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.BackColor = SystemColors.ButtonFace
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 84F))
        TableLayoutPanel1.Location = New Point(396, 54)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RightToLeft = RightToLeft.No
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(268, 23)
        TableLayoutPanel1.TabIndex = 35
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Location = New Point(412, 36)
        Label13.Name = "Label13"
        Label13.Size = New Size(56, 15)
        Label13.TabIndex = 36
        Label13.Text = "Producto"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Location = New Point(502, 36)
        Label14.Name = "Label14"
        Label14.Size = New Size(55, 15)
        Label14.TabIndex = 3
        Label14.Text = "Cantidad"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Location = New Point(592, 36)
        Label15.Name = "Label15"
        Label15.Size = New Size(40, 15)
        Label15.TabIndex = 3
        Label15.Text = "Precio"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form17
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLimpiar)
        Controls.Add(txtTotalPagar)
        Controls.Add(txtIVA)
        Controls.Add(txtTotalVenta)
        Controls.Add(txtValorUnitario)
        Controls.Add(txtCantidad)
        Controls.Add(txtNombreProducto)
        Controls.Add(btnSiguiente)
        Controls.Add(btnCalcular)
        Controls.Add(Button17)
        Name = "Form17"
        Text = "Form17"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button17 As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtValorUnitario As TextBox
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
