Public Class Frm_Parient

    Private Sub Frm_Parient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ToolStripTextBox1.Text = "المستخدم الحالي" & Space(2) & "/" & Space(2) & G_user_name
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class