Imports System.Data.OleDb

Public Class Frm_Buy_Bill

#Region "Variables ---------"

    Private Dt_ As New DataTable
    Private WithEvents Cu_Manger_ As CurrencyManager
    Private Flg_ As Object = 0
    Private Flg1_ As Object = 0
    Private Dt_Details As New DataTable

#End Region
#Region "Events -----------"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim newfrm As New Frm_Search_Mored

            If newfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.Text_Mord_No.Text = newfrm.Mord_No_
                Me.Text_Mord_Name.Text = newfrm.Mord_Name_
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim newfrm As New Frm_Search_Categories

            If newfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.Text_Cate_No.Text = newfrm.Cate_No_
                Me.Text_Cate_Name.Text = newfrm.Cate_Name_
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Frm_Buy_Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.GroupBox4.Parent = Me
            Me.GroupBox4.BackColor = Color.Transparent
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            Get_Buy_Bill_H()
            BindingContext_Data(Dt_)
            Show_Count_()
            CONTROL_FALSE()
            ' Me.GroupBox4.Enabled = False

            Me.ToolStrip1.Items("Btn_New").Enabled = False
            Me.ToolStrip1.Items("Btn_Edit").Enabled = False
            Me.ToolStrip1.Items("Btn_Delete").Enabled = False
            Me.ToolStrip1.Items("Btn_Exit").Enabled = False

            Me.ToolStrip1.Items("Btn_Save").Enabled = False
            Me.ToolStrip1.Items("Btn_Cancel").Enabled = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Change_Position_(ByVal Sender As Object, ByVal e As EventArgs) Handles Cu_Manger_.PositionChanged
        Try
            Show_Count_()
            CONTROL_FALSE()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Btn_First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_First.Click
        Try
            Me.Cu_Manger_.Position = 0
            Me.Text_Cate_No.Text = Nothing
            Me.Text_Quantity.Text = Nothing
            Me.Text_Price_Unit.Text = Nothing
            Me.Text_Cate_Name.Text = Nothing
            Me.Text_Total_Price.Text = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_PREVIOUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PREVIOUS.Click
        Try
            Me.Cu_Manger_.Position = Me.Cu_Manger_.Position - 1
            Me.Text_Cate_No.Text = Nothing
            Me.Text_Quantity.Text = Nothing
            Me.Text_Price_Unit.Text = Nothing
            Me.Text_Cate_Name.Text = Nothing
            Me.Text_Total_Price.Text = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Try
            Me.Cu_Manger_.Position = Me.Cu_Manger_.Position + 1
            Me.Text_Cate_No.Text = Nothing
            Me.Text_Quantity.Text = Nothing
            Me.Text_Price_Unit.Text = Nothing
            Me.Text_Cate_Name.Text = Nothing
            Me.Text_Total_Price.Text = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Last.Click
        Try
            Me.Cu_Manger_.Position = Me.Cu_Manger_.Count - 1
            Me.Text_Cate_No.Text = Nothing
            Me.Text_Quantity.Text = Nothing
            Me.Text_Price_Unit.Text = Nothing
            Me.Text_Cate_Name.Text = Nothing
            Me.Text_Total_Price.Text = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Try
            Select Case Me.ToolStrip1.Items.IndexOf(e.ClickedItem)
                Case "0"
                    If Flg1_ = 0 Then
                        New_()

                    ElseIf Flg1_ = 1 Then
                        New_Details()

                    End If

                Case "1"
                    If Flg1_ = 0 Then
                        Save_()
                    ElseIf Flg1_ = 1 Then
                        Save_Details()
                    End If
                Case "2"
                    If Flg1_ = 0 Then
                        Edit_()
                    ElseIf Flg1_ = 1 Then
                        Edit_Details()
                    End If
                Case "3"
                    If Flg1_ = 0 Then
                        Delete()
                    ElseIf Flg1_ = 1 Then
                        Delete_Details()
                    End If

                Case "4"
                    If Flg1_ = 0 Then
                        Cancel()
                    ElseIf Flg1_ = 1 Then
                        Cancel_Details()
                    End If

                Case "5"

                    Search()
                Case "6"
                    MsgBox("طباعة")
                Case "7"
                    Me.Hide()



            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_Bill_H.CheckedChanged
        GroupBox2.Enabled = False
        GroupBox1.Enabled = False
        Flg1_ = 0
        Me.ToolStrip1.Items("Btn_New").Enabled = True
        Me.ToolStrip1.Items("Btn_Edit").Enabled = True
        Me.ToolStrip1.Items("Btn_Delete").Enabled = True
        Me.ToolStrip1.Items("Btn_Exit").Enabled = True

        Me.ToolStrip1.Items("Btn_Save").Enabled = False
        Me.ToolStrip1.Items("Btn_Cancel").Enabled = False


    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_Bill_D.CheckedChanged
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False

        Flg1_ = 1
        Me.ToolStrip1.Items("Btn_New").Enabled = True
        Me.ToolStrip1.Items("Btn_Edit").Enabled = True
        Me.ToolStrip1.Items("Btn_Delete").Enabled = True
        Me.ToolStrip1.Items("Btn_Exit").Enabled = True

        Me.ToolStrip1.Items("Btn_Save").Enabled = False
        Me.ToolStrip1.Items("Btn_Cancel").Enabled = False
    End Sub
    Private Sub Text_Buy_Bill_No_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Buy_Bill_No.TextChanged
        Dim Var1_No_ As Object = Me.Text_Buy_Bill_No.Text.Trim
        Get_Buy_Bill_D(Var1_No_)
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Me.Text_Cate_No.Text = Me.DataGridView1.CurrentRow.Cells("Cate_No").Value.ToString
            Me.Text_Cate_Name.Text = Me.DataGridView1.CurrentRow.Cells("Cate_No_Name").Value.ToString
            Me.Text_Price_Unit.Text = Me.DataGridView1.CurrentRow.Cells("Price_Unit").Value.ToString
            Me.Text_Quantity.Text = Me.DataGridView1.CurrentRow.Cells("Quantity").Value.ToString

            Me.Text_Total_Price.Text = Me.DataGridView1.CurrentRow.Cells("Total_Price").Value.ToString
           

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Text_Quantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Quantity.TextChanged
        Try

        
        If Not Me.Text_Price_Unit.Text.Trim = Nothing Then


            Dim Var1_No_ As Object = Me.Text_Quantity.Text.Trim
            Dim Var2_No_ As Object = Me.Text_Price_Unit.Text.Trim
            Dim Total_ As Object = Var1_No_ * Var2_No_
            Me.Text_Total_Price.Text = Total_.ToString()
        Else
            MsgBox("الرجاءادخال سعر الوحدة اولاً")
            Me.Text_Quantity.Text = Nothing


        End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Text_Feof_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Feof.TextChanged
        Try

            If Not Me.Text_Feof.Text.Trim = Nothing Then


                Dim Var1_No_ As Object = Me.Text_Feof.Text.Trim
                Dim Var2_No_ As Object = Me.Text_Total.Text.Trim
                Dim Fefo_ As Object = Var2_No_ - Var1_No_
                Me.Text_Remanent.Text = Fefo_.ToString()
            ElseIf Me.Text_Feof.Text.Trim = Nothing Then
                Me.Text_Remanent.Text = Nothing
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Text_Remanent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Remanent.TextChanged
        Try

       
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If

        Dim Var1_No_ As Object = Me.Text_Buy_Bill_No.Text.Trim
        Dim Var2_Total_Price_ As Object = Me.Text_Total.Text.Trim
        Dim Var2_Feof_ As Object = Me.Text_Feof.Text.Trim
        Dim Var2_Remanent_ As Object = Me.Text_Remanent.Text.Trim



        Dim Sql_ = "UPDATE  Buy_Bill_H SET  Total_Price=" & Var2_Total_Price_ & ", Feof=" & Var2_Feof_ & ", Remanent=" & Var2_Remanent_ & "  WHERE Buy_Bill_No=" & Var1_No_ & ""

        Dim Cmd_ As New OleDbCommand
        Cmd_.CommandText = Sql_
        Cmd_.Connection = Conn
        Cmd_.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
   #End Region
#Region "Functions -----------"
    Private Sub Get_Buy_Bill_H()
        Try
            Me.Dt_.Clear()
            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("SELECT H.Buy_Bill_No , H.Buy_Bill_Date,H.Sal_Bill_NO  , H.Mord_No , H.Total_Price, H.Feof, H.Remanent, M.Mord_Name  FROM Buy_Bill_H H , Mordeen M where H.Mord_No=M.Mord_No ")
            'إرسال الإستعلام إلى قاعدة البيانات
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)

            'وضع بيانات الإستعلام في اداة داتاتيبل
            Da_.Fill(Dt_)

            Show_Count_()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindingContext_Data(ByVal Dt_Ref As DataTable)
        Try
            If Not Dt_Ref.Rows.Count <= 0 Then

                Me.Text_Buy_Bill_No.DataBindings.Add("Text", Dt_Ref, "Buy_Bill_No")
                Me.Text_Mord_No.DataBindings.Add("Text", Dt_Ref, "Mord_No")
                Me.Text_Mord_Name.DataBindings.Add("Text", Dt_Ref, "Mord_Name")
                Me.Text_Sal_Bill_NO.DataBindings.Add("Text", Dt_Ref, "Sal_Bill_NO")
                Me.Text_Buy_Bill_Date.DataBindings.Add("Value", Dt_Ref, "Buy_Bill_Date", True)
                ' Me.Text_Total.DataBindings.Add("Text", Dt_Ref, "Total_Price")
                Me.Text_Feof.DataBindings.Add("Text", Dt_Ref, "Feof")
                Me.Text_Remanent.DataBindings.Add("Text", Dt_Ref, "Remanent")

                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل
                Me.Cu_Manger_ = Me.BindingContext(Me.Dt_)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'دالة تقوم بعرض عدد السجلات
    Private Sub Show_Count_()
        Try
            Me.ToolStrip1.Items("Red_Count").Text = Me.Cu_Manger_.Count & "/" & Me.Cu_Manger_.Position + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'دالة تقوم بتعطيل أزرار التنقل 
    Private Sub CONTROL_FALSE()
        On Error Resume Next
        If Me.Cu_Manger_.Position = 0 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = False
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = False
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_.Position > 0 And Me.Cu_Manger_.Position < Me.Cu_Manger_.Count - 1 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_.Position = Me.Cu_Manger_.Count - 1 Then
            Me.ToolStrip1.Items("Btn_Last").Enabled = False
            Me.ToolStrip1.Items("Btn_Next").Enabled = False
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
        End If
    End Sub
    Private Sub Controls_()
        Try
            Me.ToolStrip1.Items("Btn_New").Enabled = True
            Me.ToolStrip1.Items("Btn_Edit").Enabled = True
            Me.ToolStrip1.Items("Btn_Delete").Enabled = True
            Me.ToolStrip1.Items("Btn_Exit").Enabled = True

            Me.ToolStrip1.Items("Btn_Save").Enabled = False
            Me.ToolStrip1.Items("Btn_Cancel").Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Controls_False()
        Try
            Me.ToolStrip1.Items("Btn_New").Enabled = False
            Me.ToolStrip1.Items("Btn_Edit").Enabled = False
            Me.ToolStrip1.Items("Btn_Delete").Enabled = False
            Me.ToolStrip1.Items("Btn_Exit").Enabled = False

            Me.ToolStrip1.Items("Btn_Save").Enabled = True
            Me.ToolStrip1.Items("Btn_Cancel").Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "Functions Of DataBase "
    Private Sub New_()
        Try
            GroupBox1.Enabled = True

            Me.Text_Mord_No.Text = Nothing
            Me.Text_Mord_Name.Text = Nothing
            Me.Text_Buy_Bill_Date.Text = Now
            Me.Text_Sal_Bill_NO.Text = Nothing
            Me.Text_Cate_No.Text = Nothing
            Me.Text_Quantity.Text = Nothing
            Me.Text_Price_Unit.Text = Nothing
            Me.Text_Cate_Name.Text = Nothing
            Me.Text_Total_Price.Text = Nothing
           
            Me.DataGridView1 = Nothing

            ' Me.GroupBox4.Enabled = True
            Me.Text_Buy_Bill_No.Text = Get_Max("Buy_Bill_H", "Buy_Bill_No")
            Flg_ = 1
            Controls_False()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Edit_()
        Try

            '  Me.GroupBox4.Enabled = True
            Flg_ = 2
            Controls_False()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete()
        Try


            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Buy_Bill_No.Text.Trim

                Dim Sql_1 = "DELETE  FROM Buy_Bill_D WHERE Buy_Bill_No=" & Var1_No_ & ""
                Dim Cmd_1 As New OleDbCommand
                Cmd_1.CommandText = Sql_1
                Cmd_1.Connection = Conn
                Cmd_1.ExecuteNonQuery()

                Dim Sql_ = "DELETE  FROM Buy_Bill_H WHERE Buy_Bill_No=" & Var1_No_ & ""
                Dim Cmd_ As New OleDbCommand
                Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Buy_Bill_H()
                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Save_()
        Try

            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If

                    Dim Var1_No_ As Object = Me.Text_Buy_Bill_No.Text.Trim
                    Dim Var2_Mord_No_ As Object = Me.Text_Mord_No.Text.Trim
                    Dim Var2_Sal_Bill_NO_ As Object = Me.Text_Sal_Bill_NO.Text.Trim
                    Dim Var2_Buy_Bill_Date_ As Object = Me.Text_Buy_Bill_Date.Value.Date
                   
                    Dim Sql_ = "insert Into Buy_Bill_H (Buy_Bill_No , Mord_No , Sal_Bill_NO , Buy_Bill_Date,Total_Price,Feof,Remanent ) VALUES (" & Var1_No_ & ",'" & Var2_Mord_No_ & "' ," & Var2_Sal_Bill_NO_ & " , '" & Var2_Buy_Bill_Date_ & "',0,0,0)"

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Buy_Bill_H()
                    Flg_ = 0
                    Controls_()
                    ' Me.GroupBox4.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If

                    Dim Var1_No_ As Object = Me.Text_Buy_Bill_No.Text.Trim
                    Dim Var2_Mord_No_ As Object = Me.Text_Mord_No.Text.Trim
                    Dim Var2_Sal_Bill_NO_ As Object = Me.Text_Sal_Bill_NO.Text.Trim
                    Dim Var2_Buy_Bill_Date_ As Object = Me.Text_Buy_Bill_Date.Value.Date
                    Dim Var2_Total_Price_ As Object = Me.Text_Total.Text.Trim
                    Dim Var2_Feof_ As Object = Me.Text_Feof.Text.Trim
                    Dim Var2_Remanent_ As Object = Me.Text_Remanent.Text.Trim



                    Dim Sql_ = "UPDATE  Buy_Bill_H SET Mord_No=" & Var2_Mord_No_ & " , Sal_Bill_NO=" & Var2_Sal_Bill_NO_ & " , Buy_Bill_Date='" & Var2_Buy_Bill_Date_ & "' , Total_Price=" & Var2_Total_Price_ & ", Feof=" & Var2_Feof_ & ", Remanent=" & Var2_Remanent_ & "  WHERE Buy_Bill_No=" & Var1_No_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Buy_Bill_H()
                    Flg_ = 0
                    Controls_()
                    '  Me.GroupBox4.Enabled = False
                    MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Buy_Bill_H()
            '  Me.GroupBox4.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub
    Private Sub Search()
        Try
            Dim newfrm As New Frm_Search_Buy_Bill

            If newfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.Text_Buy_Bill_No.Text = newfrm.Buy_Bill_No_
                Me.Text_Mord_No.Text = newfrm.Mord_No_
                Me.Text_Mord_Name.Text = newfrm.Mord_Name_
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "Functions Of Details -------------"
    Private Sub Get_Buy_Bill_D(ByVal Buy_Bill_No_ As Object)
        Try
            Me.Dt_Details.Clear()
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim Sql_ As Object = New String("SELECT d.Cate_No , i.Cate_No_Name ,d.Quantity  , d.Total_Price , d.Price_Unit FROM Categories i , Buy_Bill_D d where d.Cate_No=i.Cate_No and d.Buy_Bill_No='" & Buy_Bill_No_ & "'")
            Dim Da_Details As New OleDbDataAdapter
            Da_Details = New OleDbDataAdapter(Sql_, Conn)
            Da_Details.Fill(Dt_Details)
            Me.DataGridView1.DataSource = Dt_Details
            Me.Text_Total.Text = Get_Sum("Buy_Bill_D", "Total_Price", "Buy_Bill_No=" & Buy_Bill_No_ & "")

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Save_Details()
        Try
           
            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If

                    Dim Var1_No_ As Object = Me.Text_Buy_Bill_No.Text.Trim
                    Dim Var2_Cate_No_ As Object = Me.Text_Cate_No.Text.Trim
                    Dim Var2_Quantity_ As Object = Me.Text_Quantity.Text.Trim
                    Dim Var2_Price_Unit_ As Object = Me.Text_Price_Unit.Text.Trim
                    Dim Var2_Total_Price_ As Object = Me.Text_Total_Price.Text.Trim
                   
                    Dim Sql_ = "insert Into Buy_Bill_D (Buy_Bill_No , Cate_No , Quantity , Price_Unit,Total_Price) VALUES (" & Var1_No_ & ",'" & Var2_Cate_No_ & "' ," & Var2_Quantity_ & " , " & Var2_Price_Unit_ & ", " & Var2_Total_Price_ & ")"

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Buy_Bill_D(Var1_No_)
                    Me.Text_Total.Text = Get_Sum("Buy_Bill_D", "Total_Price", "Buy_Bill_No=" & Var1_No_ & "")
                    Flg_ = 0
                    Controls_()
                    ' Me.GroupBox4.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If

                    Dim Var1_No_ As Object = Me.Text_Buy_Bill_No.Text.Trim
                    Dim Var2_Cate_No_ As Object = Me.Text_Cate_No.Text.Trim
                    Dim Var2_Quantity_ As Object = Me.Text_Quantity.Text.Trim
                    Dim Var2_Price_Unit_ As Object = Me.Text_Price_Unit.Text.Trim
                    Dim Var2_Total_Price_ As Object = Me.Text_Total_Price.Text.Trim
                   

                    Dim Sql_ = "UPDATE  Buy_Bill_D SET Cate_No=" & Var2_Cate_No_ & " , Quantity=" & Var2_Quantity_ & " , Price_Unit=" & Var2_Price_Unit_ & " , Total_Price=" & Var2_Total_Price_ & "   WHERE Buy_Bill_No=" & Var1_No_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Me.Text_Total.Text = Get_Sum("Buy_Bill_D", "Total_Price", "Buy_Bill_No=" & Var1_No_ & "")
                    Get_Buy_Bill_D(Var1_No_)
                    Flg_ = 0
                    Controls_()
                    '  Me.GroupBox4.Enabled = False
                    MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_Details()
        Try
            '  Me.GroupBox4.Enabled = True
            Flg_ = 2
            Controls_False()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete_Details()
        Try


            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Buy_Bill_No.Text.Trim
                Dim Sql_ = "DELETE  FROM Buy_Bill_D WHERE Buy_Bill_No=" & Var1_No_ & ""
                Dim Cmd_ As New OleDbCommand
                Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()

                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Details()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then

            '  Me.GroupBox4.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub
    Private Sub New_Details()
        Try
            GroupBox2.Enabled = True

            If Not Me.Text_Buy_Bill_No.Text = Nothing Then

                Me.Text_Cate_No.Text = Nothing
                Me.Text_Quantity.Text = Nothing
                Me.Text_Price_Unit.Text = Nothing
                Me.Text_Cate_Name.Text = Nothing
                Me.Text_Total_Price.Text = Nothing
              

                Flg_ = 1
                Controls_False()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#End Region
#End Region

    

    
    End Class