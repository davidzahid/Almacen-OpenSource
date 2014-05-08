Public Class Panel

    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub
End Class
