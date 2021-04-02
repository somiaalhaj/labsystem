Imports System.Data.OleDb
Public Class Frm_Search_TYPE_SAMPLE
#Region "Variables ---------"
    Private Dt_TYPE_SAMPLE As New DataTable
    Public TYPE_SAMPLE_NO_ As Object
    Public TYPE_SAMPLE_NAME_ As Object
#End Region
#Region "Functions ------------"
    Private Sub Get_TYPE_SAMPLE()
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim SQl_ As Object = New String("select distinct to_char(TYPE_SAMPLE_NO) TYPE_SAMPLE_NO, TYPE_SAMPLE_NAME, Active from Checkups where Active=0")
            Dim Da_ As New OleDbDataAdapter
            Da_ = New OleDbDataAdapter(SQl_, Conn)
            Da_.Fill(Me.Dt_TYPE_SAMPLE)
            Me.DataGridView1.DataSource = Me.Dt_TYPE_SAMPLE
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Events -----------"
    Private Sub Frm_Search_TYPE_SAMPLE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Label1.Parent = Panel1
            Me.Label1.BackColor = Color.Transparent

            Me.GroupBox1.Parent = Panel1
            Me.GroupBox1.BackColor = Color.Transparent

            Get_TYPE_SAMPLE()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Me.Dt_TYPE_SAMPLE.DefaultView.RowFilter = "TYPE_SAMPLE_No like'%" & Me.TextBox1.Text.Trim & "%' OR TYPE_SAMPLE_Name like'%" & Me.TextBox1.Text.Trim & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            TYPE_SAMPLE_NO_ = Me.DataGridView1.CurrentRow.Cells("TYPE_SAMPLE_NO").Value.ToString
            TYPE_SAMPLE_NAME_ = Me.DataGridView1.CurrentRow.Cells("TYPE_SAMPLE_NAME").Value.ToString
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception

        End Try
    End Sub

#End Region
    End Class