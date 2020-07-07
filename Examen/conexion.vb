Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DORISMEZA\SQLEXPRESS ;Initial Catalog=Tienda; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub conectar()
        Try
            conexion.Open()

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        Dim i As Integer = comando.ExecuteNonQuery()
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)

    End Sub

    Function Insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()

        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function Insertar(ByVal tabla, ByVal condicion)
        Try
            conexion.Open()
        comando = New SqlCommand(Sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()

            If (i > 0) Then
                Return True
            Else
                Return False
            End If


    End Function


End Class
