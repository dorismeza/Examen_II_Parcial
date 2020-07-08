Imports System.ComponentModel
Public Class frmAggCliente
    Dim conexion As conexion = New conexion()
    Public Sub mostrarDatos()
        conexion.consulta("select * from factura.cliente", "cliente")
        DataGridView.DataSource = conexion.ds.Tables("cliente")

    End Sub

    Private Sub frmAggCliente_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.TiendaDataSet.Venta)
        'TODO: esta línea de código carga datos en la tabla 'TiendaDataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter1.Fill(Me.TiendaDataSet1.cliente)
        'TODO: esta línea de código carga datos en la tabla 'TiendaDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.TiendaDataSet.cliente)
        mostrarDatos()
    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
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
        Tienda.Show()
        Me.Hide()
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


    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
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


    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
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


    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

        ' idCliente int
        'nombre 
        ' apellido 
        'direccion 
        Dim dtgv As DataGridViewRow = DataGridView.Rows(e.RowIndex)
        txtIdcliente.Text = dtgv.Cells(0).Value.ToString()
        txtNombre.Text = dtgv.Cells(1).Value.ToString()
        txtApellido.Text = dtgv.Cells(2).Value.ToString()
        txtDireccion.Text = dtgv.Cells(3).Value.ToString()
    End Sub



    Private Sub txtIdcliente_Validating(sender As Object, e As CancelEventArgs) Handles txtIdcliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdcliente_MouseHover(sender As Object, e As EventArgs) Handles txtIdcliente.MouseHover
        ToolTip.SetToolTip(txtIdcliente, "Escriba el codigo del Cliente")
        ToolTip.ToolTipTitle = "Codigo del Cliente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Escriba el nombre del Cliente")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtApellido_MouseHover(sender As Object, e As EventArgs) Handles txtApellido.MouseHover
        ToolTip.SetToolTip(txtApellido, "Escriba el apellido del Cliente")
        ToolTip.ToolTipTitle = "Apellido"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip.SetToolTip(txtDireccion, "Ingrese una direccion")
        ToolTip.ToolTipTitle = "Direccion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class
