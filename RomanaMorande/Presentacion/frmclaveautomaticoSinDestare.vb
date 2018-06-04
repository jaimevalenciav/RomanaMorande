Public Class frmanulaautomaticoSinDestare
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(contador.Text) <= 3 Then
            If txtpass.Text = 1996 Then
                txtpass.Text = ""
                frmanulaobservacionessindestare.ShowDialog()
                Me.Close()
            Else
                MessageBox.Show("La clave no es correcta", "Pesaje Manual", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpass.Text = ""
                txtpass.Focus()
                contador.Text = Val(contador.Text) + 1
            End If
        Else
            MessageBox.Show("Acceso No Permitido", "Pesaje Manual", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub frmclavemanualDestare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador.Text = "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

End Class