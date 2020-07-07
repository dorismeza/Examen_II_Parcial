Public Class Tienda
    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim agregar As String = "insert into factura.cliente values ( '" + txtIDVenta.Text + "','" + txtFecha.Text + "','" + txtPrecio.Text + "','" + txtCantidad.Text + "','" + txtCodigoCliente.Text + "','" + txtCodProducto.Text + "')"

        If conexion.Insertar(agregar) Then
            MsgBox("Datos Agregados")
            mostrarDatos()
        Else
            MsgBox("Error")
        End If

    End Sub
    Public Sub mostrarDatos()

        conexion.consulta("select * from factura.ventas", "venta")
        DataGridView.DataSource = conexion.ds.Tables("Tienda")

    End Sub


End Class
