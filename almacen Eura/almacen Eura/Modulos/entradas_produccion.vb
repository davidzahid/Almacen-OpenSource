Public Class entradas_produccion

    Private Sub entradas_produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Eura_databaseDataSet.entrada' Puede moverla o quitarla según sea necesario.
        Me.EntradaTableAdapter.Fill(Me.Eura_databaseDataSet.entrada)
        'generar fecha y hora actual del sistema
        Dim timestamp As Date = Format(Now)
        txtFecha.Text = timestamp.ToString(("dd/MM/yyyy HH:mm tt"))
    End Sub

    Private Sub EntradaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EntradaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EntradaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Eura_databaseDataSet)

    End Sub
End Class