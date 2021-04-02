Public Class Frm_Checkup_Procedure

   
    Private Sub Frm_Checkup_Procedure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox1.Parent = Me
        Me.GroupBox1.BackColor = Color.Transparent

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim New_Frm_ As New Frm_Anti_Checkup


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub
End Class