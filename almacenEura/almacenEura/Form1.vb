Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AlmaceneuraDataSet1.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.AlmaceneuraDataSet1.empleados)
        'TODO: esta línea de código carga datos en la tabla 'AlmaceneuraDataSet.entradas' Puede moverla o quitarla según sea necesario.
        Me.EntradasTableAdapter.Fill(Me.AlmaceneuraDataSet.entradas)

    End Sub


End Class
