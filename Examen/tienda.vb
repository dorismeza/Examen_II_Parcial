Imports System.ComponentModel

Public Class Tienda
    Dim conexion As conexion = New conexion()
    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        Try
            Dim agregar As String = "insert into factura.cliente values ( '" + txtIDVenta.Text + "','" + mskFecha.Text + "','" + txtPrecio.Text + "','" + txtCantidad.Text + "','" + txtCodigoCliente.Text + "','" + txtCodProducto.Text + "')"
            Dim actualizar As String = "insert into factura.cliente values "
            If conexion.insertar(agregar) Then
                MsgBox("Datos Agregados")
                mostrarDatos()

            Else
                MsgBox("Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Registro existente")
        End Try


    End Sub
    Public Sub mostrarDatos()

        conexion.consulta("select * from factura.Venta", "venta")
        DataGridView.DataSource = conexion.ds.Tables("venta")

    End Sub

    Private Sub Tienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaDataSet2.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.TiendaDataSet2.producto)
        'TODO: esta línea de código carga datos en la tabla 'TiendaDataSet2.consultaTienda' Puede moverla o quitarla según sea necesario.
        Me.ConsultaTiendaTableAdapter.Fill(Me.TiendaDataSet2.consultaTienda)
        'TODO: esta línea de código carga datos en la tabla 'TiendaDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.TiendaDataSet.Venta)
        frmAddProducto.Show()
        Me.Hide()
        frmAggCliente.Show()
        Me.Hide()

    End Sub
    Private Sub txtCodigoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoCliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtIDVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDVenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProducto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub



    Private Sub mskFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskFecha.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigoCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigoCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIDVenta_Validating(sender As Object, e As CancelEventArgs) Handles txtIDVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub mskFecha_Validating(sender As Object, e As CancelEventArgs) Handles mskFecha.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCodProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtCodProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCodigoCliente_MouseHover(sender As Object, e As EventArgs) Handles txtCodigoCliente.MouseHover
        ToolTip.SetToolTip(txtCodigoCliente, "Escriba el codigo del cliente")
        ToolTip.ToolTipTitle = "Codigo Cliente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIDVenta_MouseHover(sender As Object, e As EventArgs) Handles txtIDVenta.MouseHover
        ToolTip.SetToolTip(txtIDVenta, "Escriba el codigo de la venta")
        ToolTip.ToolTipTitle = "Codigo de Venta"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mskFecha_MouseHover(sender As Object, e As EventArgs) Handles mskFecha.MouseHover
        ToolTip.SetToolTip(mskFecha, "Escriba el codigo del cliente")
        ToolTip.ToolTipTitle = "Codigo Cliente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodProducto_MouseHover(sender As Object, e As EventArgs) Handles txtCodProducto.MouseHover
        ToolTip.SetToolTip(txtCodProducto, "Escriba el codigol Producto")
        ToolTip.ToolTipTitle = "Codigo de Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        ToolTip.SetToolTip(txtCantidad, "Ingrese la cantidad")
        ToolTip.ToolTipTitle = "Cantidad de producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        ToolTip.SetToolTip(txtPrecio, "Ingrese el Precio")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEliminar_Click(sender As Object, e As EventArgs) Handles txtEliminar.Click

    End Sub

    Private Sub txtModificar_Click(sender As Object, e As EventArgs) Handles txtModificar.Click

    End Sub
End Class
