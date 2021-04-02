Public Class Frm_Stockroom

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim New_Frm_ As New Frm_Lab_Req


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim New_Frm_ As New Frm_Cati_Remain


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_Stockroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox1.Parent = Me
        Me.GroupBox1.BackColor = Color.Transparent

    End Sub
End Class