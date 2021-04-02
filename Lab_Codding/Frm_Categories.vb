﻿Imports System.Data.OleDb
Public Class Frm_Categories
#Region "Variables ------------"
    Private Dt_ As New DataTable
    Private WithEvents Cu_Manger_ As CurrencyManager

    Private Flg_ As Object = 0
#End Region   
#Region "Events -------------"
    Private Sub Frm_Categories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        'Fill_Cmb_(Me.Comb_Cate_Type_No, "Cate_Type", "Cate_Type_No", "Cate_Type_Name", " Active=0")
        'Fill_Cmb_(Me.Comb_Cate_Unit_No, "Cate_Unit", "Cate_Unit_No", "Cate_Unit_Name", " Active=0")

        Me.GroupBox1.Parent = Me
        Me.GroupBox1.BackColor = Color.Transparent
        Get_Categories()
        BindingContext_Data(Dt_)
        Show_Count_()
        CONTROL_FALSE()

        Me.GroupBox1.Enabled = False


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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_PREVIOUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PREVIOUS.Click
        Try
            Me.Cu_Manger_.Position = Me.Cu_Manger_.Position - 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Try
            Me.Cu_Manger_.Position = Me.Cu_Manger_.Position + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Last.Click
        Try
            Me.Cu_Manger_.Position = Me.Cu_Manger_.Count - 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        Try
            Select Case Me.ToolStrip1.Items.IndexOf(e.ClickedItem)
                Case "0"
                    New_()
                Case "1"
                    Save_()
                Case "2"
                    Edit_()
                Case "3"
                    Delete()
                Case "4"
                    Cancel()
                Case "5"
                    MsgBox("بحث")
                Case "6"
                    MsgBox("طباعة")
                Case "7"
                    Me.Hide()



            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
     Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_CATE_Fath_Name.TextChanged
        Dim Var1_No_ As Object = Me.Text_CATE_Fath_Name.Text.Trim
        Dim Sql_ As Object = New String("SELECT distinct CATE_Fath_No FROM Categories where CATE_Fath_Name = '" & Var1_No_ & "' ")
        Dim Da_ As OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)

        If Dt_.Rows.Count > 0 Then


            Me.Text_CATE_Fath_No.Text = Dt_.Rows(0).Item(0).ToString

        Else

            Me.Text_CATE_Fath_No.Text = Get_Max("Categories", "CATE_Fath_No")
        End If
    End Sub

    Private Sub Text_Cate_No_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Cate_No_Name.TextChanged
        Dim Var1_No_ As Object = Me.Text_Cate_No_Name.Text.Trim
        Dim Sql_ As Object = New String("SELECT distinct Cate_No FROM Categories where Cate_No_Name = '" & Var1_No_ & "' ")
        Dim Da_ As OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)

        If Dt_.Rows.Count > 0 Then

            Me.Text_Cate_No.Text = Dt_.Rows(0).Item(0).ToString

        Else



            '  Me.Text_Cate_No.Text = Text_CATE_Fath_No.Text & 0 & (Get_Max_Trip("Categories", "Cate_No", "CATE_Fath_No=" & Text_CATE_Fath_No.Text & "", "Cate_No", "3", "1") + 1)




        End If
    End Sub
    Private Sub Text_CATE_Unit_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_CATE_Unit_Name.TextChanged
        Dim Var1_No_ As Object = Me.Text_CATE_Unit_Name.Text.Trim
        Dim Sql_ As Object = New String("SELECT distinct CATE_Unit_No FROM Categories where CATE_Unit_Name = '" & Var1_No_ & "' ")
        Dim Da_ As OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)

        If Dt_.Rows.Count > 0 Then


            Me.Text_CATE_Unit_No.Text = Dt_.Rows(0).Item(0).ToString

        Else

            Me.Text_CATE_Unit_No.Text = Get_Max("Categories", "CATE_Fath_No")
        End If
    End Sub


#End Region
#Region "Functions -----------"
    Private Sub Get_Categories()
        Try
            Me.Dt_.Clear()
            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("SELECT * FROM Categories")
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
                Me.Text_CATE_Fath_No.DataBindings.Add("Text", Dt_Ref, "CATE_Fath_No")
                Me.Text_CATE_Fath_Name.DataBindings.Add("Text", Dt_Ref, "CATE_Fath_Name")
                Me.Text_Cate_No.DataBindings.Add("Text", Dt_Ref, "Cate_No")
                Me.Text_Cate_No_Name.DataBindings.Add("Text", Dt_Ref, "Cate_No_Name")
                Me.Text_CATE_Unit_No.DataBindings.Add("Text", Dt_Ref, "CATE_Unit_No")
                Me.Text_CATE_Unit_Name.DataBindings.Add("Text", Dt_Ref, "CATE_Unit_Name")

                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل
                Me.Cu_Manger_ = Me.BindingContext(Me.Dt_)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'دالة تقوم بعرض عدد السجلات
    Private Sub Show_Count_()
        On Error Resume Next
        Me.ToolStrip1.Items("Red_Count").Text = Me.Cu_Manger_.Count & "/" & Me.Cu_Manger_.Position + 1
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

    'دالة تعمل على تفعيل و تعطيل ازرار التحكم
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
            Me.Text_CATE_Fath_No.Text = Nothing
            Me.Text_CATE_Fath_Name.Text = Nothing
            Me.Text_Cate_No.Text = Nothing
            Me.Text_Cate_No_Name.Text = Nothing
            Me.Text_CATE_Unit_No.Text = Nothing
            Me.Text_CATE_Unit_Name.Text = Nothing

            Me.GroupBox1.Enabled = True

            Flg_ = 1
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_()
        Try
            Me.GroupBox1.Enabled = True
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
                Dim Var1_No_ As Object = Me.Text_Cate_No.Text.Trim
                Dim Var2_No_ As Object = Me.Text_CATE_Fath_No.Text.Trim
                Dim Sql_ = "DELETE  FROM Categories WHERE Cate_No=" & Var1_No_ & " and CATE_Fath_No=" & Var2_No_ & ""
                Dim Cmd_ As New OleDbCommand
                Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Categories()
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

                    Dim Var2_No_ As Object = Me.Text_Cate_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Cate_No_Name.Text.Trim
                    Dim Var3_No_ As Object = Me.Text_CATE_Fath_No.Text.Trim
                    Dim Var3_Name_ As Object = Me.Text_CATE_Fath_Name.Text.Trim
                    Dim Var4_No_ As Object = Me.Text_CATE_Unit_No.Text.Trim
                    Dim Var4_Name_ As Object = Me.Text_CATE_Unit_Name.Text.Trim


                    Dim Sql_ = "insert Into Categories(Cate_No ,Cate_No_Name,CATE_FATH_NO,CATE_FATH_NAME ,CATE_UNIT_NO,CATE_UNIT_NAME) VALUES(" & Var2_No_ & ",'" & Var2_Name_ & "'," & Var3_No_ & ",'" & Var3_Name_ & "'," & Var4_No_ & ",'" & Var4_Name_ & "' )"

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Categories()
                    Flg_ = 0
                    Controls_()
                    Me.GroupBox1.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If

                    Dim Var2_No_ As Object = Me.Text_Cate_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Cate_No_Name.Text.Trim
                    Dim Var3_No_ As Object = Me.Text_CATE_Fath_No.Text.Trim
                    Dim Var3_Name_ As Object = Me.Text_CATE_Fath_Name.Text.Trim
                    Dim Var4_No_ As Object = Me.Text_CATE_Unit_No.Text.Trim
                    Dim Var4_Name_ As Object = Me.Text_CATE_Unit_Name.Text.Trim




                    Dim Sql_ = "UPDATE  Categories SET Cate_No_Name='" & Var2_Name_ & "' ,CATE_Fath_Name='" & Var3_Name_ & "',CATE_Unit_Name='" & Var4_Name_ & "'   WHERE Cate_No=" & Var2_No_ & " AND CATE_Fath_No=" & Var3_No_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Categories()
                    Flg_ = 0
                    Controls_()
                    Me.GroupBox1.Enabled = False
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
            Get_Categories()
            Me.GroupBox1.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub
#End Region
#End Region
   
      End Class