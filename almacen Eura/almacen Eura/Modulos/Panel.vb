Public Class Panel

    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Eura_databaseDataSet.entrada' Puede moverla o quitarla según sea necesario.

        Acceso.Hide()


    End Sub

   
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Acceso.Close()
    End Sub


    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles verAyuda.Click

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles acercaDe.Click

    End Sub




    Private Sub cbxUnidad_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



   

    Private Sub ToolStripContainer1_TopToolStripPanel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub entradaProduccion_Click(sender As Object, e As EventArgs) Handles entradaProduccion.Click
        entradas_produccion.ShowDialog()
    End Sub

    Private Sub EntradaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()


    End Sub
End Class
