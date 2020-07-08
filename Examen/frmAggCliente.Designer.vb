<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAggCliente
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
        Me.txtIdcliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaDataSet = New Examen.TiendaDataSet()
        Me.ClienteTableAdapter = New Examen.TiendaDataSetTableAdapters.clienteTableAdapter()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaDataSet1 = New Examen.TiendaDataSet1()
        Me.ClienteBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter1 = New Examen.TiendaDataSet1TableAdapters.clienteTableAdapter()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKVentaidCliente4D94879BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New Examen.TiendaDataSetTableAdapters.VentaTableAdapter()
        Me.TiendaDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKVentaidCliente4D94879BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdcliente
        '
        Me.txtIdcliente.Location = New System.Drawing.Point(89, 75)
        Me.txtIdcliente.Name = "txtIdcliente"
        Me.txtIdcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdcliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre "
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(83, 112)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(266, 79)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(265, 112)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.TiendaDataSet
        '
        'TiendaDataSet
        '
        Me.TiendaDataSet.DataSetName = "TiendaDataSet"
        Me.TiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(162, 144)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'ClienteBindingSource1
        '
        Me.ClienteBindingSource1.DataMember = "cliente"
        Me.ClienteBindingSource1.DataSource = Me.TiendaDataSet
        '
        'TiendaDataSet1
        '
        Me.TiendaDataSet1.DataSetName = "TiendaDataSet1"
        Me.TiendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource2
        '
        Me.ClienteBindingSource2.DataMember = "cliente"
        Me.ClienteBindingSource2.DataSource = Me.TiendaDataSet1
        '
        'ClienteTableAdapter1
        '
        Me.ClienteTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.ClienteBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(33, 183)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(333, 150)
        Me.DataGridView.TabIndex = 11
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
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
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'FKVentaidCliente4D94879BBindingSource
        '
        Me.FKVentaidCliente4D94879BBindingSource.DataMember = "FK__Venta__idCliente__4D94879B"
        Me.FKVentaidCliente4D94879BBindingSource.DataSource = Me.ClienteBindingSource
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'TiendaDataSet1BindingSource
        '
        Me.TiendaDataSet1BindingSource.DataSource = Me.TiendaDataSet1
        Me.TiendaDataSet1BindingSource.Position = 0
        '
        'ClienteBindingSource3
        '
        Me.ClienteBindingSource3.DataMember = "cliente"
        Me.ClienteBindingSource3.DataSource = Me.TiendaDataSet1BindingSource
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(108, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "INGRESAR CLIENTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmAggCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 372)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAggCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmAggCliente"
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKVentaidCliente4D94879BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdcliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents TiendaDataSet As TiendaDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As TiendaDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ClienteBindingSource1 As BindingSource
    Friend WithEvents TiendaDataSet1 As TiendaDataSet1
    Friend WithEvents ClienteBindingSource2 As BindingSource
    Friend WithEvents ClienteTableAdapter1 As TiendaDataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents FKVentaidCliente4D94879BBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As TiendaDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiendaDataSet1BindingSource As BindingSource
    Friend WithEvents ClienteBindingSource3 As BindingSource
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Label5 As Label
End Class
