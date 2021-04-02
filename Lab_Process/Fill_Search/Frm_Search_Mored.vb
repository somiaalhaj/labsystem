Imports System.Data.OleDb
Public Class Frm_Search_Mored
#Region "Variables ---------"
    Private Dt_Mordeen As New DataTable
    Public Mord_No_ As Object
    Public Mord_Name_ As Object
#End Region
#Region "Events -----------"
    Private Sub Frm_Search_Mored_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Label1.Parent = Panel1
            Me.Label1.BackColor = Color.Transparent

            Me.GroupBox1.Parent = Panel1
            Me.GroupBox1.BackColor = Color.Transparent

            Get_Mordeen()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Me.Dt_Mordeen.DefaultView.RowFilter = "Mord_No like'%" & Me.TextBox1.Text.Trim & "%' OR Mord_Name like'%" & Me.TextBox1.Text.Trim & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Mord_No_ = Me.DataGridView1.CurrentRow.Cells("Mord_no").Value.ToString
            Mord_Name_ = Me.DataGridView1.CurrentRow.Cells("Mord_Name").Value.ToString
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception

        End Try
    End Sub

#End Region
#Region "Functions ------------"
    Private Sub Get_Mordeen()
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim SQl_ As Object = New String("select to_char(Mord_No) Mord_No, Mord_Name , Activ from Mordeen where Activ=0")
            Dim Da_ As New OleDbDataAdapter
            Da_ = New OleDbDataAdapter(SQl_, Conn)
            Da_.Fill(Me.Dt_Mordeen)
            Me.DataGridView1.DataSource = Me.Dt_Mordeen
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
   
End Class