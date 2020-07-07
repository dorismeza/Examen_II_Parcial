Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data source= DORISMEZA\SQLEXPRESS ;Initial catalog=Tienda; Integrated security=true")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")

        Catch ex As Exception
            MessageBox.Show("error al Conectado")
        Finally
            conexion.Close()

        End Try
    End Sub

    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)

        da.Fill(ds, tabla)


    End Sub

    Function insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False

        End If
    End Function

    Function eliminar(ByVal tabla, ByVal condicion)
        Try
            conexion.Open()
            Dim elimina As String = "delete from " + tabla + " where " + condicion
            comando = New SqlCommand(elimina, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MessageBox.Show("Elimine primero el empleado")
        End Try

    End Function

    Function actualizar(sql As String)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)

        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False

        End If
    End Function

End Class
