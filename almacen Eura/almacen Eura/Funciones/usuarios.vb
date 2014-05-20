Imports MySql.Data.MySqlClient
Module usuarios
    Function usuarioExistente(ByVal usuario As String, ByVal password As String) As Boolean
        'funcion para usuarios'
        Dim oconexion As New MySqlConnection
        Dim odataadapter As New MySqlDataAdapter
        Dim odataset As New DataSet
        Dim sSql As String
        Dim sw As Boolean = False
        Try
            oconexion.ConnectionString = "server=localhost;database=eura_database;user id=root;password=david"
            sSql = "SELECT * FROM empleado WHERE username = '" & usuario & "' and password = '" & password & "'"
            odataadapter = New MySqlDataAdapter(sSql, oconexion)
            oconexion.Open()
            odataset.Clear()
            odataadapter.Fill(odataset, "empleado")
            If (odataset.Tables("empleado").Rows.Count() <> 0) Then
                MessageBox.Show("Bienvenido")
                sw = True
            Else
                MessageBox.Show("Sin acceso")
                sw = False
            End If
        Catch ex As Exception

        End Try
        Return sw

    End Function


    Private Sub conectar()

        Dim servidor As String = "localhost"
        Dim baseDatos As String = "eura_database"
        Dim usuario As String = "root"
        Dim password As String = "david"
        Dim conexion As New MySqlConnection

        Try

            conexion.ConnectionString = "Server=" & servidor _
                & "; Database=" & baseDatos _
                & "; Uid=" & usuario _
                & "; Pwd=" & password

            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
