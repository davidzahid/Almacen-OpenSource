
Public Class Acceso

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click



        If (usuarioExistente(txtUsuario.Text, txtContrasena.Text)) Then

            Panel.Show()


        Else
            txtContrasena.Text = ""
            txtUsuario.Text = ""
        End If

    End Sub

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Eura_databaseDataSet)

    End Sub

    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'TODO: esta línea de código carga datos en la tabla 'Eura_databaseDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.Eura_databaseDataSet.empleado)

    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        'CON LA SIGUIENTE INSTRUCCIÓN, AL MOMENTO DE PRESIONAR LA TECLA
        'ENTER NOS DIRIGIRA AL BOTON DE ACCEDER'

        If e.KeyCode = Keys.Enter Then
            btnAcceder_Click(sender, e)
        End If
    End Sub


End Class