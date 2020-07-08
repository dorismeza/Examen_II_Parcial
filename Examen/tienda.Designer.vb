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
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtIDVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsultaTiendaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaDataSet2 = New Examen.TiendaDataSet2()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.VentaTableAdapter = New Examen.TiendaDataSetTableAdapters.VentaTableAdapter()
        Me.ConsultaTiendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaTiendaTableAdapter = New Examen.TiendaDataSet2TableAdapters.consultaTiendaTableAdapter()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New Examen.TiendaDataSet2TableAdapters.productoTableAdapter()
        Me.mskFecha = New System.Windows.Forms.MaskedTextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaTiendaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaTiendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(114, 19)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(85, 20)
        Me.txtCodigoCliente.TabIndex = 1
        '
        'txtIDVenta
        '
        Me.txtIDVenta.Location = New System.Drawing.Point(114, 52)
        Me.txtIDVenta.Name = "txtIDVenta"
        Me.txtIDVenta.Size = New System.Drawing.Size(85, 20)
        Me.txtIDVenta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo de Cliente"
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.FechaVentaDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.ConsultaTiendaBindingSource1
        Me.DataGridView.Location = New System.Drawing.Point(12, 179)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(408, 193)
        Me.DataGridView.TabIndex = 6
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'FechaVentaDataGridViewTextBoxColumn
        '
        Me.FechaVentaDataGridViewTextBoxColumn.DataPropertyName = "fechaVenta"
        Me.FechaVentaDataGridViewTextBoxColumn.HeaderText = "fechaVenta"
        Me.FechaVentaDataGridViewTextBoxColumn.Name = "FechaVentaDataGridViewTextBoxColumn"
        '
        'ConsultaTiendaBindingSource1
        '
        Me.ConsultaTiendaBindingSource1.DataMember = "consultaTienda"
        Me.ConsultaTiendaBindingSource1.DataSource = Me.TiendaDataSet2
        '
        'TiendaDataSet2
        '
        Me.TiendaDataSet2.DataSetName = "TiendaDataSet2"
        Me.TiendaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.TiendaDataSetBindingSource
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
        Me.txtBuscar.Location = New System.Drawing.Point(264, 136)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(75, 23)
        Me.txtBuscar.TabIndex = 7
        Me.txtBuscar.Text = "Buscar"
        Me.txtBuscar.UseVisualStyleBackColor = True
        '
        'txtGuardar
        '
        Me.txtGuardar.Location = New System.Drawing.Point(345, 136)
        Me.txtGuardar.Name = "txtGuardar"
        Me.txtGuardar.Size = New System.Drawing.Size(75, 23)
        Me.txtGuardar.TabIndex = 8
        Me.txtGuardar.Text = "Guardar"
        Me.txtGuardar.UseVisualStyleBackColor = True
        '
        'txtModificar
        '
        Me.txtModificar.Location = New System.Drawing.Point(102, 136)
        Me.txtModificar.Name = "txtModificar"
        Me.txtModificar.Size = New System.Drawing.Size(75, 23)
        Me.txtModificar.TabIndex = 9
        Me.txtModificar.Text = "Modificar"
        Me.txtModificar.UseVisualStyleBackColor = True
        '
        'txtEliminar
        '
        Me.txtEliminar.Location = New System.Drawing.Point(183, 136)
        Me.txtEliminar.Name = "txtEliminar"
        Me.txtEliminar.Size = New System.Drawing.Size(75, 23)
        Me.txtEliminar.TabIndex = 10
        Me.txtEliminar.Text = "Eliminar"
        Me.txtEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(21, 136)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Id Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha de venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Codigo de Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(326, 87)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(85, 20)
        Me.txtPrecio.TabIndex = 15
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(326, 50)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(85, 20)
        Me.txtCantidad.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(262, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cantidad"
        '
        'txtCodProducto
        '
        Me.txtCodProducto.Location = New System.Drawing.Point(326, 16)
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.Size = New System.Drawing.Size(85, 20)
        Me.txtCodProducto.TabIndex = 19
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'ConsultaTiendaBindingSource
        '
        Me.ConsultaTiendaBindingSource.DataMember = "consultaTienda"
        Me.ConsultaTiendaBindingSource.DataSource = Me.TiendaDataSet2
        '
        'ConsultaTiendaTableAdapter
        '
        Me.ConsultaTiendaTableAdapter.ClearBeforeFill = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.TiendaDataSet2
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'mskFecha
        '
        Me.mskFecha.Location = New System.Drawing.Point(114, 86)
        Me.mskFecha.Mask = "00/00/0000"
        Me.mskFecha.Name = "mskFecha"
        Me.mskFecha.Size = New System.Drawing.Size(85, 20)
        Me.mskFecha.TabIndex = 20
        Me.mskFecha.ValidatingType = GetType(Date)
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 384)
        Me.Controls.Add(Me.mskFecha)
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
        Me.Name = "Tienda"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaTiendaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaTiendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As TiendaDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents TiendaDataSet2 As TiendaDataSet2
    Friend WithEvents ConsultaTiendaBindingSource As BindingSource
    Friend WithEvents ConsultaTiendaTableAdapter As TiendaDataSet2TableAdapters.consultaTiendaTableAdapter
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As TiendaDataSet2TableAdapters.productoTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConsultaTiendaBindingSource1 As BindingSource
    Friend WithEvents mskFecha As MaskedTextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
