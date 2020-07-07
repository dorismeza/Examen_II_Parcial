<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tienda
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
        Me.components = New System.ComponentModel.Container()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtIDVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.TiendaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaDataSet = New Examen.TiendaDataSet()
        Me.txtBuscar = New System.Windows.Forms.Button()
        Me.txtGuardar = New System.Windows.Forms.Button()
        Me.txtModificar = New System.Windows.Forms.Button()
        Me.txtEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodProducto = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(116, 86)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(75, 20)
        Me.txtFecha.TabIndex = 0
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(124, 29)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigoCliente.TabIndex = 1
        '
        'txtIDVenta
        '
        Me.txtIDVenta.Location = New System.Drawing.Point(101, 56)
        Me.txtIDVenta.Name = "txtIDVenta"
        Me.txtIDVenta.Size = New System.Drawing.Size(90, 20)
        Me.txtIDVenta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo de Cliente"
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.DataSource = Me.TiendaDataSetBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(34, 217)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(472, 183)
        Me.DataGridView.TabIndex = 6
        '
        'TiendaDataSetBindingSource
        '
        Me.TiendaDataSetBindingSource.DataSource = Me.TiendaDataSet
        Me.TiendaDataSetBindingSource.Position = 0
        '
        'TiendaDataSet
        '
        Me.TiendaDataSet.DataSetName = "TiendaDataSet"
        Me.TiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(431, 33)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(75, 23)
        Me.txtBuscar.TabIndex = 7
        Me.txtBuscar.Text = "Buscar"
        Me.txtBuscar.UseVisualStyleBackColor = True
        '
        'txtGuardar
        '
        Me.txtGuardar.Location = New System.Drawing.Point(431, 72)
        Me.txtGuardar.Name = "txtGuardar"
        Me.txtGuardar.Size = New System.Drawing.Size(75, 23)
        Me.txtGuardar.TabIndex = 8
        Me.txtGuardar.Text = "Guardar"
        Me.txtGuardar.UseVisualStyleBackColor = True
        '
        'txtModificar
        '
        Me.txtModificar.Location = New System.Drawing.Point(431, 145)
        Me.txtModificar.Name = "txtModificar"
        Me.txtModificar.Size = New System.Drawing.Size(75, 23)
        Me.txtModificar.TabIndex = 9
        Me.txtModificar.Text = "Modificar"
        Me.txtModificar.UseVisualStyleBackColor = True
        '
        'txtEliminar
        '
        Me.txtEliminar.Location = New System.Drawing.Point(431, 174)
        Me.txtEliminar.Name = "txtEliminar"
        Me.txtEliminar.Size = New System.Drawing.Size(75, 23)
        Me.txtEliminar.TabIndex = 10
        Me.txtEliminar.Text = "Eliminar"
        Me.txtEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(431, 107)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Id Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha de venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Codigo de Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(296, 53)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(85, 20)
        Me.txtPrecio.TabIndex = 15
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(296, 96)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(85, 20)
        Me.txtCantidad.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cantidad"
        '
        'txtCodProducto
        '
        Me.txtCodProducto.Location = New System.Drawing.Point(334, 19)
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.Size = New System.Drawing.Size(68, 20)
        Me.txtCodProducto.TabIndex = 19
        '
        'Tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 438)
        Me.Controls.Add(Me.txtCodProducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtEliminar)
        Me.Controls.Add(Me.txtModificar)
        Me.Controls.Add(Me.txtGuardar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDVenta)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.txtFecha)
        Me.Name = "Tienda"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents txtIDVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents TiendaDataSetBindingSource As BindingSource
    Friend WithEvents TiendaDataSet As TiendaDataSet
    Friend WithEvents txtBuscar As Button
    Friend WithEvents txtGuardar As Button
    Friend WithEvents txtModificar As Button
    Friend WithEvents txtEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodProducto As TextBox
End Class
