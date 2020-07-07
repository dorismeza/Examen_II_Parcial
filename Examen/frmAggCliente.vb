Imports System.ComponentModel
Public Class frmAggCliente
    Dim conexion As conexion = New conexion()
    Private Sub frmAggCliente_Load(sender As Object, e As EventArgs)


    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        Try
            Dim agregar As String = "insert into factura.cliente values ( '" + txtIdcliente.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDireccion.Text + "')"

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
        conexion.consulta("select * from factura.cliente", "cliente")
        DataGridViewClientes.DataSource = conexion.ds.Tables("Tienda")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DataGridViewClientes_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

        ' idCliente int
        'nombre 
        ' apellido 
        'direccion 

        Dim dtgv As DataGridViewRow = DataGridViewClientes.Rows(e.RowIndex)
        txtIdcliente.Text = dtgv.Cells(0).Value.ToString()
        txtNombre.Text = dtgv.Cells(1).Value.ToString()
        txtApellido.Text = dtgv.Cells(2).Value.ToString()
        txtDireccion.Text = dtgv.Cells(3).Value.ToString()
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frmAggCliente_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.TiendaDataSet.cliente)
        mostrarDatos()

    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub


    Private Sub txtIdcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdcliente.KeyPress
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


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress

    End Sub
End Class
