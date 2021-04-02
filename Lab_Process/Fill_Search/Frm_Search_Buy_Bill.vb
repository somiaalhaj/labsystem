Imports System.Data.OleDb
Public Class Frm_Search_Buy_Bill
#Region "Variables ---------"
    Private Dt_Buy_Bill As New DataTable
    Public Buy_Bill_No_ As Object
    Public Mord_No_ As Object
    Public Mord_Name_ As Object
#End Region
#Region "Functions ------------"
    Private Sub Get_Buy_Bill()
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim SQl_ As Object = New String("select  H.Buy_Bill_No, M.Mord_No, M.Mord_Name FROM Buy_Bill_H H , Mordeen M where H.Mord_No=M.Mord_No")
            Dim Da_ As New OleDbDataAdapter
            Da_ = New OleDbDataAdapter(SQl_, Conn)
            Da_.Fill(Me.Dt_Buy_Bill)
            Me.DataGridView1.DataSource = Me.Dt_Buy_Bill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Events -----------"
    Private Sub Frm_Search_Buy_Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Label1.Parent = Panel1
            Me.Label1.BackColor = Color.Transparent

            Me.GroupBox1.Parent = Panel1
            Me.GroupBox1.BackColor = Color.Transparent

            Get_Buy_Bill()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Me.Dt_Buy_Bill.DefaultView.RowFilter = " Mord_Name like'%" & Me.TextBox1.Text.Trim & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Buy_Bill_No_ = Me.DataGridView1.CurrentRow.Cells("Buy_Bill_No").Value.ToString
            Mord_No_ = Me.DataGridView1.CurrentRow.Cells("Mord_No").Value.ToString
            Mord_Name_ = Me.DataGridView1.CurrentRow.Cells("Mord_Name").Value.ToString

            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception

        End Try
    End Sub

#End Region
    End Class