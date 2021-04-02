Public Class Frm_Checkup_Order

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim New_Frm_ As New Frm_Price_


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim newfrm As New Frm_Search_Symp

            If newfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                '    Me.Text_Cate_No.Text = newfrm.Cate_No_
                '    Me.Text_Cate_Name.Text = newfrm.Cate_Name_
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class