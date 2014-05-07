Public Class Panel

    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Acceso.Hide()

        ''  ProveedoresToolStripMenuItem.Enabled = False

    End Sub

   
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Acceso.Close()
    End Sub


    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click

    End Sub
End Class
