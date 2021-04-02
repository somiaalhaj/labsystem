Imports System.Data.OleDb
Public Class Frm_Search_Che_Fath
#Region "Variables ---------"
    Private Dt_Che_Fath As New DataTable
    Public Che_Fath_No_ As Object
    Public Che_Fath_Name_ As Object
#End Region
#Region "Functions ------------"
    Private Sub Get_Che_Fath()
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim SQl_ As Object = New String("select distinct to_char(Che_Fath_No) Che_Fath_No, Che_Fath_Name , Active from Checkups where Active=0")
            Dim Da_ As New OleDbDataAdapter
            Da_ = New OleDbDataAdapter(SQl_, Conn)
            Da_.Fill(Me.Dt_Che_Fath)
            Me.DataGridView1.DataSource = Me.Dt_Che_Fath
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Events -----------"
    Private Sub Frm_Search_Che_Fath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Label1.Parent = Panel1
            Me.Label1.BackColor = Color.Transparent

            Me.GroupBox1.Parent = Panel1
            Me.GroupBox1.BackColor = Color.Transparent

            Get_Che_Fath()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Me.Dt_Che_Fath.DefaultView.RowFilter = "Che_Fath_No like'%" & Me.TextBox1.Text.Trim & "%' OR Che_Fath_Name like'%" & Me.TextBox1.Text.Trim & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Che_Fath_No_ = Me.DataGridView1.CurrentRow.Cells("Che_Fath_No").Value.ToString
            Che_Fath_Name_ = Me.DataGridView1.CurrentRow.Cells("Che_Fath_Name").Value.ToString
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception

        End Try
    End Sub

#End Region

   
End Class