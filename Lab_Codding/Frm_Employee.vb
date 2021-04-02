Imports System.Data.OleDb
Public Class Frm_Employee
#Region "Variable ------------"
    Private Dt_ As New DataTable
    Private Dt_Q As New DataTable
    Private Dt_S As New DataTable
    Private Dt_C As New DataTable
    Private Dt_J As New DataTable
    Private Dt_D As New DataTable
    Private Dt_EI As New DataTable
    Private WithEvents Cu_Manger_ As CurrencyManager
    Private WithEvents Cu_Manger_Q As CurrencyManager
    Private WithEvents Cu_Manger_S As CurrencyManager
    Private WithEvents Cu_Manger_C As CurrencyManager
    Private WithEvents Cu_Manger_J As CurrencyManager
    Private WithEvents Cu_Manger_D As CurrencyManager
    Private WithEvents Cu_Manger_EI As CurrencyManager
    Private Flg_ As Object = 0
    Private Flg1_ As Object = 0
#End Region
#Region "Functions -----------"
#Region "Functions_Identity -----------"


    Private Sub Get_Identity()
        Try
            Me.Dt_.Clear()

            Fill_LB_(Me.LB_Identity, "Identity", "Iden_No", "Iden_Name", " Active=0")

            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("select * from Identity")
            'إرسال الإستعلام إلى قاعدة البيانات
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)

            'وضع بيانات الإستعلام في اداة داتاتيبل
            Da_.Fill(Dt_)
            Me.LB_Identity.DataSource = Me.Dt_
            Me.LB_Identity.DisplayMember = "Iden_Name"
            Me.LB_Identity.ValueMember = "Iden_No"
            Show_Count_()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindingContext_Identity(ByVal Dt_Ref As DataTable)
        Try
            If Not Dt_Ref.Rows.Count <= 0 Then
                Me.Text_Iden_No.DataBindings.Add("Text", Dt_Ref, "Iden_No")
                Me.Text_Iden_Name.DataBindings.Add("Text", Dt_Ref, "Iden_Name")

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
    Private Sub New_Identity()
        Try

            Me.Text_Iden_Name.Text = Nothing
            Me.GB_Identity.Enabled = True
            Me.Text_Iden_No.Text = Get_Max("Identity", "Iden_No")
            Flg_ = 1
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Save_Identity()
        Try
            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Iden_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Iden_Name.Text.Trim

                    Dim Sql_ = "insert into Identity (Iden_No,Iden_Name) VALUES(" & Var1_No_ & ",'" & Var2_Name_ & "' )"


                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Identity()
                    Flg_ = 0
                    Controls_()
                    Me.GB_Identity.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If

            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Iden_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Iden_Name.Text.Trim

                    Dim Sql_ = "UPDATE Identity SET Iden_Name='" & Var2_Name_ & "'  WHERE Iden_No=" & Var1_No_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Identity()
                    LB_Identity = Nothing
                    Fill_LB_(Me.LB_Identity, "Identity", "Iden_No", "Iden_Name", " Active=0")

                    Flg_ = 0
                    Controls_()
                    Me.GB_Identity.Enabled = False
                    MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_Identity()
        Try
            Me.GB_Identity.Enabled = False
            Flg_ = 2
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete_Identity()
        Try
            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Iden_No.Text.Trim
                Dim Sql_ = "DELETE  FROM Identity WHERE Iden_No=" & Var1_No_ & ""
                Dim Cmd_ As New OleDbCommand
                Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Identity()
                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Identity()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Identity()
            Me.GB_Identity.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub

#End Region


#End Region
#Region "Functions_Qualification -----------"


    Private Sub Get_Qualification()
        Try
            Me.Dt_Q.Clear()

            Fill_LB_(Me.LB_Qualification, "Qualification", "Qual_No", "Qual_Name", " Active=0")

            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("select * from Qualification")
            'إرسال الإستعلام إلى قاعدة البيانات
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)

            'وضع بيانات الإستعلام في اداة داتاتيبل
            Da_.Fill(Dt_Q)
            Me.LB_Qualification.DataSource = Me.Dt_Q
            Me.LB_Qualification.DisplayMember = "Qual_Name"
            Me.LB_Qualification.ValueMember = "Qual_No"
            Show_Count_Q()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindingContext_Qualification(ByVal Dt_Ref As DataTable)
        Try
            If Not Dt_Ref.Rows.Count <= 0 Then
                Me.Text_Qual_No.DataBindings.Add("Text", Dt_Ref, "Qual_No")
                Me.Text_Qual_Name.DataBindings.Add("Text", Dt_Ref, "Qual_Name")

                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل

                Me.Cu_Manger_Q = Me.BindingContext(Me.Dt_Q)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Show_Count_Q()
        Try
            Me.ToolStrip1.Items("Red_Count").Text = Me.Cu_Manger_Q.Count & "/" & Me.Cu_Manger_Q.Position + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'دالة تقوم بتعطيل أزرار التنقل 
    Private Sub CONTROL_FALSE_Q()
        On Error Resume Next
        If Me.Cu_Manger_Q.Position = 0 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = False
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = False
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_Q.Position > 0 And Me.Cu_Manger_Q.Position < Me.Cu_Manger_Q.Count - 1 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_Q.Position = Me.Cu_Manger_Q.Count - 1 Then
            Me.ToolStrip1.Items("Btn_Last").Enabled = False
            Me.ToolStrip1.Items("Btn_Next").Enabled = False
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
        End If
    End Sub
   
    'دالة تقوم بعرض عدد السجلات
   #Region "Functions Of DataBase "
    Private Sub New_Qualification()
        Try

            Me.Text_Qual_Name.Text = Nothing
            Me.GB_Qualification.Enabled = True
            Me.Text_Qual_No.Text = Get_Max("Qualification", "Qual_No")
            Flg_ = 1
            CONTROL_FALSE_Q()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Save_Qualification()
        Try
            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Qual_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Qual_Name.Text.Trim

                    Dim Sql_ = "insert into Qualification (Qual_No,Qual_Name) VALUES(" & Var1_No_ & ",'" & Var2_Name_ & "' )"


                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Qualification()
                    Flg_ = 0
                    Controls_()
                    Me.GB_Qualification.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If

            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Qual_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Qual_Name.Text.Trim

                    Dim Sql_ = "UPDATE Qualification SET Qual_Name='" & Var2_Name_ & "'  WHERE Qual_No=" & Var1_No_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Qualification()
                    LB_Qualification = Nothing
                    Fill_LB_(Me.LB_Qualification, "Qualification", "Qual_No", "Qual_Name", " Active=0")

                    Flg_ = 0
                    Controls_()
                    Me.GB_Qualification.Enabled = False
                    MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_Qualification()
        Try
            Me.GB_Qualification.Enabled = False
            Flg_ = 2
            CONTROL_FALSE_Q()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete_Qualification()
        Try
            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Iden_No.Text.Trim
                Dim Sql_ = "DELETE  FROM Qualification WHERE Qual_No=" & Var1_No_ & ""
                Dim Cmd_ As New OleDbCommand
                Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Qualification()
                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Qualification()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Qualification()
            Me.GB_Qualification.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub

#End Region


#End Region
#Region "Functions_Specializing -----------"
    Private Sub Get_Specializing()
        Try
            Me.Dt_S.Clear()

            Fill_LB_(Me.LB_Specializing, "Specializing", "Spec_No", "Spec_Name", " Active=0")

            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("select * from Specializing")
            'إرسال الإستعلام إلى قاعدة البيانات
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)

            'وضع بيانات الإستعلام في اداة داتاتيبل
            Da_.Fill(Dt_S)
            Me.LB_Specializing.DataSource = Me.Dt_S
            Me.LB_Specializing.DisplayMember = "Spec_Name"
            Me.LB_Specializing.ValueMember = "Spec_No"
            Show_Count_S()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindingContext_Specializing(ByVal Dt_Ref As DataTable)
        Try
            If Not Dt_Ref.Rows.Count <= 0 Then
                Me.Text_Spec_No.DataBindings.Add("Text", Dt_Ref, "Spec_No")
                Me.Text_Spec_Name.DataBindings.Add("Text", Dt_Ref, "Spec_Name")

                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل

                Me.Cu_Manger_S = Me.BindingContext(Me.Dt_S)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Show_Count_S()
        Try
            Me.ToolStrip1.Items("Red_Count").Text = Me.Cu_Manger_S.Count & "/" & Me.Cu_Manger_S.Position + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'دالة تقوم بتعطيل أزرار التنقل 
    Private Sub CONTROL_FALSE_S()
        On Error Resume Next
        If Me.Cu_Manger_S.Position = 0 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = False
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = False
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_S.Position > 0 And Me.Cu_Manger_S.Position < Me.Cu_Manger_S.Count - 1 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_S.Position = Me.Cu_Manger_S.Count - 1 Then
            Me.ToolStrip1.Items("Btn_Last").Enabled = False
            Me.ToolStrip1.Items("Btn_Next").Enabled = False
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
        End If
    End Sub

    'دالة تقوم بعرض عدد السجلات
#Region "Functions Of DataBase "
    Private Sub New_Specializing()
        Try

            Me.Text_Spec_Name.Text = Nothing
            Me.GB_Specializing.Enabled = True
            Me.Text_Spec_No.Text = Get_Max("Specializing", "Spec_No")
            Flg_ = 1
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Save_Specializing()
        Try
            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Spec_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Spec_Name.Text.Trim

                    Dim Sql_ = "insert into Specializing (Spec_No,Spec_Name) VALUES(" & Var1_No_ & ",'" & Var2_Name_ & "' )"


                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Specializing()
                    Flg_ = 0
                    Controls_()
                    Me.GB_Specializing.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If

            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Spec_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Spec_Name.Text.Trim

                    Dim Sql_ = "UPDATE Specializing SET Spec_Name='" & Var2_Name_ & "'  WHERE Spec_No=" & Var1_No_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Specializing()
                    LB_Specializing = Nothing
                    Fill_LB_(Me.LB_Specializing, "Specializing", "Spec_No", "Spec_Name", " Active=0")

                    Flg_ = 0
                    Controls_()
                    Me.GB_Specializing.Enabled = False
                    MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_Specializing()
        Try
            Me.GB_Specializing.Enabled = False
            Flg_ = 2
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete_Specializing()
        Try
            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Spec_No.Text.Trim
                Dim Sql_ = "DELETE  FROM Specializing WHERE Spec_No=" & Var1_No_ & ""
                Dim Cmd_ As New OleDbCommand
                Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Specializing()
                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Specializing()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Specializing()
            Me.GB_Specializing.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub

#End Region
#End Region
#Region "Functions_Center -----------"
    Private Sub Get_Center()
        Try
            Me.Dt_C.Clear()

            Fill_LB_(Me.LB_Center, "Center", "Center_No", "Center_Name", " Active=0")

            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("select * from Center")
            'إرسال الإستعلام إلى قاعدة البيانات
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)

            'وضع بيانات الإستعلام في اداة داتاتيبل
            Da_.Fill(Dt_C)
            Me.LB_Center.DataSource = Me.Dt_C
            Me.LB_Center.DisplayMember = "Center_Name"
            Me.LB_Center.ValueMember = "Center_No"
            Show_Count_C()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindingContext_Center(ByVal Dt_Ref As DataTable)
        Try
            If Not Dt_Ref.Rows.Count <= 0 Then
                Me.Text_Center_No.DataBindings.Add("Text", Dt_Ref, "Center_No")
                Me.Text_Center_Name.DataBindings.Add("Text", Dt_Ref, "Center_Name")
                Me.Text_Country_Name.DataBindings.Add("Text", Dt_Ref, "Country_Name")
                Me.Text_Phon_No.DataBindings.Add("Text", Dt_Ref, "Phon_No")
                Me.Text_Email.DataBindings.Add("Text", Dt_Ref, "Email")

                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل

                Me.Cu_Manger_C = Me.BindingContext(Me.Dt_C)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Show_Count_C()
        Try
            Me.ToolStrip1.Items("Red_Count").Text = Me.Cu_Manger_C.Count & "/" & Me.Cu_Manger_C.Position + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'دالة تقوم بتعطيل أزرار التنقل 
    Private Sub CONTROL_FALSE_C()
        On Error Resume Next
        If Me.Cu_Manger_C.Position = 0 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = False
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = False
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_C.Position > 0 And Me.Cu_Manger_C.Position < Me.Cu_Manger_C.Count - 1 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_C.Position = Me.Cu_Manger_C.Count - 1 Then
            Me.ToolStrip1.Items("Btn_Last").Enabled = False
            Me.ToolStrip1.Items("Btn_Next").Enabled = False
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
        End If
    End Sub

    'دالة تقوم بعرض عدد السجلات
#Region "Functions Of DataBase "
    Private Sub New_Center()
        Try

            Me.Text_Center_Name.Text = Nothing
            Me.Text_Country_Name.Text = Nothing
            Me.Text_Email.Text = Nothing
            Me.Text_Phon_No.Text = Nothing
            Me.GB_Center.Enabled = True
            Me.Text_Center_No.Text = Get_Max("Center", "Center_No")
            Flg_ = 1
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Save_Center()
        Try
            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Center_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Center_Name.Text.Trim
                    Dim Var2_Country_Name_ As Object = Me.Text_Country_Name.Text.Trim
                    Dim Var2_Email_ As Object = Me.Text_Email.Text.Trim
                    Dim Var2_Phon_No_ As Object = Me.Text_Phon_No.Text.Trim

                    Dim Sql_ = "insert into Center (Center_No,Center_Name,Country_Name,Email,Phon_No) VALUES(" & Var1_No_ & ",'" & Var2_Name_ & "','" & Var2_Country_Name_ & "','" & Var2_Email_ & "','" & Var2_Phon_No_ & "' )"


                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Center()
                    Flg_ = 0
                    Controls_()
                    Me.GB_Center.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If

            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Center_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Center_Name.Text.Trim
                    Dim Var2_Country_Name_ As Object = Me.Text_Country_Name.Text.Trim
                    Dim Var2_Email_ As Object = Me.Text_Email.Text.Trim
                    Dim Var2_Phon_No_ As Object = Me.Text_Phon_No.Text.Trim

                    Dim Sql_ = "UPDATE Center SET Center_Name='" & Var2_Name_ & "',Country_Name='" & Var2_Country_Name_ & "',Email='" & Var2_Email_ & "',Phon_No='" & Var2_Phon_No_ & "'  WHERE Center_No=" & Var1_No_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Center()
                    LB_Center = Nothing
                    Fill_LB_(Me.LB_Center, "Center", "Center_No", "Center_Name", " Active=0")

                    Flg_ = 0
                    Controls_()
                    Me.GB_Center.Enabled = False
                    MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_Center()
        Try
            Me.GB_Center.Enabled = False
            Flg_ = 2
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete_Center()
        Try
            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Center_No.Text.Trim
                Dim Sql_ = "DELETE  FROM Center WHERE Center_No=" & Var1_No_ & ""
                Dim Cmd_ As New OleDbCommand
                Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Center()
                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Center()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Center()
            Me.GB_Center.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub

#End Region
#End Region
#Region "Functions_Jop -----------"
    Private Sub Get_Jop()
        Try
            Me.Dt_J.Clear()

            'Fill_LB_(Me.LB_Jop, "Jop", "Jop_No", "Jop_Name", " Active=0")

            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("select * from Jop")
            'إرسال الإستعلام إلى قاعدة البيانات
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)

            'وضع بيانات الإستعلام في اداة داتاتيبل
            Da_.Fill(Dt_J)
            'Me.LB_Jop.DataSource = Me.Dt_J
            'Me.LB_Jop.DisplayMember = "Jop_Name"
            'Me.LB_Jop.ValueMember = "Jop_No"
            Show_Count_J()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindingContext_Jop(ByVal Dt_Ref As DataTable)
        Try
            If Not Dt_Ref.Rows.Count <= 0 Then
                'Me.Text_Jop_No.DataBindings.Add("Text", Dt_Ref, "Jop_No")
                'Me.Text_Jop_Name.DataBindings.Add("Text", Dt_Ref, "Jop_Name")

                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل

                Me.Cu_Manger_J = Me.BindingContext(Me.Dt_J)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Show_Count_J()
        Try
            Me.ToolStrip1.Items("Red_Count").Text = Me.Cu_Manger_J.Count & "/" & Me.Cu_Manger_J.Position + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'دالة تقوم بتعطيل أزرار التنقل 
    Private Sub CONTROL_FALSE_J()
        On Error Resume Next
        If Me.Cu_Manger_J.Position = 0 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = False
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = False
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_J.Position > 0 And Me.Cu_Manger_J.Position < Me.Cu_Manger_J.Count - 1 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_J.Position = Me.Cu_Manger_J.Count - 1 Then
            Me.ToolStrip1.Items("Btn_Last").Enabled = False
            Me.ToolStrip1.Items("Btn_Next").Enabled = False
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
        End If
    End Sub

    'دالة تقوم بعرض عدد السجلات
#Region "Functions Of DataBase "
    Private Sub New_Jop()
        Try

            'Me.Text_Jop_Name.Text = Nothing
            'Me.GB_Jop.Enabled = True
            'Me.Text_Jop_No.Text = Get_Max("Jop", "Jop_No")
            'Flg_ = 1
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Save_Jop()
        Try
            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    'Dim Var1_No_ As Object = Me.Text_Jop_No.Text.Trim
                    'Dim Var2_Name_ As Object = Me.Text_Jop_Name.Text.Trim

                    'Dim Sql_ = "insert into Jop (Jop_No,Jop_Name) VALUES(" & Var1_No_ & ",'" & Var2_Name_ & "' )"


                    Dim Cmd_ As New OleDbCommand
                    'Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Jop()
                    Flg_ = 0
                    Controls_()
                    'Me.GB_Jop.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If

            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Spec_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Spec_Name.Text.Trim

                    Dim Sql_ = "UPDATE Jop SET Jop_Name='" & Var2_Name_ & "'  WHERE Jop_No=" & Var1_No_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Jop()
                    'LB_Jop = Nothing
                    'Fill_LB_(Me.LB_Jop, "Jop", "Jop_No", "Jop_Name", " Active=0")

                    Flg_ = 0
                    Controls_()
                    'Me.GB_Jop.Enabled = False
                    MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_Jop()
        Try
            'Me.GB_Jop.Enabled = False
            Flg_ = 2
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete_Jop()
        Try
            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                'Dim Var1_No_ As Object = Me.Text_Jop_No.Text.Trim
                'Dim Sql_ = "DELETE  FROM Jop WHERE Jop_No=" & Var1_No_ & ""
                Dim Cmd_ As New OleDbCommand
                'Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Jop()
                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Jop()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Jop()
            'Me.GB_Jop.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub

#End Region
#End Region
#Region "Functions_Depart -----------"
    Private Sub Get_Depart()
        Try
            Me.Dt_D.Clear()



            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("select * from Depart_Jop")
            'إرسال الإستعلام إلى قاعدة البيانات
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)

            'وضع بيانات الإستعلام في اداة داتاتيبل
            Da_.Fill(Dt_D)
            'Me.LB_Depart.DataSource = Me.Dt_D
            'Me.LB_Depart.DisplayMember = "Depart_Name"
            'Me.LB_Depart.ValueMember = "Depart_No"
            'Show_Count_D()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindingContext_Depart(ByVal Dt_Ref As DataTable)
        Try
            If Not Dt_Ref.Rows.Count <= 0 Then
                Me.Text_Depart_No.DataBindings.Add("Text", Dt_Ref, "Depart_No")
                Me.Text_Depart_Name.DataBindings.Add("Text", Dt_Ref, "Depart_Name")
                Me.Jop_No.DataBindings.Add("Text", Dt_Ref, "Jop_No")
                Me.Jop_Name.DataBindings.Add("Text", Dt_Ref, "Jop_Name")
                Me.Text_Sal_Ini.DataBindings.Add("Text", Dt_Ref, "Sal_Ini")

                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل

                Me.Cu_Manger_D = Me.BindingContext(Me.Dt_D)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Show_Count_D()
        Try
            Me.ToolStrip1.Items("Red_Count").Text = Me.Cu_Manger_D.Count & "/" & Me.Cu_Manger_D.Position + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'دالة تقوم بتعطيل أزرار التنقل 
    Private Sub CONTROL_FALSE_D()
        On Error Resume Next
        If Me.Cu_Manger_D.Position = 0 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = False
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = False
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_D.Position > 0 And Me.Cu_Manger_D.Position < Me.Cu_Manger_D.Count - 1 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_D.Position = Me.Cu_Manger_D.Count - 1 Then
            Me.ToolStrip1.Items("Btn_Last").Enabled = False
            Me.ToolStrip1.Items("Btn_Next").Enabled = False
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
        End If
    End Sub

    'دالة تقوم بعرض عدد السجلات
#Region "Functions Of DataBase "
    Private Sub New_Depart()
        Try

            Me.Text_Depart_No.Text = Nothing
            Me.Text_Depart_Name.Text = Nothing

            Me.Jop_No.Text = Nothing

            Me.Jop_Name.Text = Nothing

            Me.Text_Sal_Ini.Text = Nothing

            Me.GB_Depart.Enabled = True

            Flg_ = 1
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Save_Depart()
        Try
            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Depart_No.Text.Trim
                    Dim Var1_Name_ As Object = Me.Text_Depart_Name.Text.Trim
                    Dim Var2_No_ As Object = Me.Jop_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Jop_Name.Text.Trim
                    Dim Var3_No_ As Object = Me.Text_Sal_Ini.Text.Trim

                    Dim Sql_ = "insert into Depart_Jop (Depart_No,Depart_Name,Jop_No,Jop_Name,Sal_Ini) VALUES(" & Var1_No_ & ",'" & Var1_Name_ & "'," & Var2_No_ & ",'" & Var2_Name_ & "'," & Var3_No_ & " )"


                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Depart()
                    Flg_ = 0
                    Controls_()
                    Me.GB_Depart.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If

            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_Depart_No.Text.Trim
                    Dim Var1_Name_ As Object = Me.Text_Depart_Name.Text.Trim
                    Dim Var2_No_ As Object = Me.Jop_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Jop_Name.Text.Trim
                    Dim Var3_No_ As Object = Me.Text_Sal_Ini.Text.Trim

                    Dim Sql_ = "UPDATE Depart_Jop SET Depart_Name='" & Var1_Name_ & "',Jop_Name='" & Var2_Name_ & "',Sal_Ini=" & Var3_No_ & "  WHERE Depart_No=" & Var1_No_ & " and Jop_No=" & Var2_No_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Get_Depart()
                    'LB_Depart = Nothing
                    'Fill_LB_(Me.LB_Depart, "Depart", "Depart_No", "Depart_Name", " Active=0")

                    Flg_ = 0
                    Controls_()
                    Me.GB_Depart.Enabled = False
                    MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_Depart()
        Try
            Me.GB_Depart.Enabled = False
            Flg_ = 2
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete_Depart()
        Try
            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Depart_No.Text.Trim
                'Dim Var2_No_ As Object = Me.Text_Jop_No.Text.Trim
                'Dim Sql_ = "DELETE  FROM Depart_Jop WHERE Depart_No=" & Var1_No_ & "and Jop_No=" & Var2_No_ & ""
                Dim Cmd_ As New OleDbCommand
                'Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Depart()
                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Depart()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Depart()
            Me.GB_Depart.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub

#End Region
#End Region
#Region "Functions_employee_ -----------"
#Region "Functions_employee_Identity -----------"
    Private Sub Get_EMP_Identity()
        Try
            Me.Dt_EI.Clear()
            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("select * from EMP_Identity")
            'إرسال الإستعلام إلى قاعدة البيانات
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)

            'وضع بيانات الإستعلام في اداة داتاتيبل
            Da_.Fill(Dt_EI)
            Show_Count_EI()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindingContext_EMP_Identity(ByVal Dt_Ref As DataTable)
        Try
            If Not Dt_Ref.Rows.Count <= 0 Then
                Me.CB_EMP_Identity.DataBindings.Add("SelectedValue", Dt_Ref, "Iden_No")
                Me.PictureBox1.DataBindings.Add("Image", Dt_Ref, "img_Iden", True)
                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل

                Me.Cu_Manger_EI = Me.BindingContext(Me.Dt_EI)

                Dim obj As New [MyClass]()
                Dim b As New Binding("Checked", Me.Dt_EI, "active", True)
                AddHandler b.Format, AddressOf b_Format
                Me.Chk_ACTIVE_EI.DataBindings.Add(b)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Show_Count_EI()
        Try
            Me.ToolStrip1.Items("Red_Count").Text = Me.Cu_Manger_EI.Count & "/" & Me.Cu_Manger_EI.Position + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'دالة تقوم بتعطيل أزرار التنقل 
    Private Sub CONTROL_FALSE_EI()
        On Error Resume Next
        If Me.Cu_Manger_EI.Position = 0 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = False
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = False
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_EI.Position > 0 And Me.Cu_Manger_EI.Position < Me.Cu_Manger_EI.Count - 1 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_EI.Position = Me.Cu_Manger_EI.Count - 1 Then
            Me.ToolStrip1.Items("Btn_Last").Enabled = False
            Me.ToolStrip1.Items("Btn_Next").Enabled = False
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
        End If
    End Sub
    Private Sub Save_Img(ByVal emp_no_ As Object, ByVal Iden_No_ As Object)
        On Error Resume Next
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim var2_ As Object = Me.CB_EMP_Identity.SelectedValue.ToString
        cmd.CommandText = "update EMP_Identity set img_Iden=:img where emp_no=" & emp_no_ & " AND Iden_No=" & Iden_No_ & ""
        cmd.Connection = Conn
        Dim ms As New IO.MemoryStream
        Dim x_ As New OleDb.OleDbParameter
        x_.OleDbType = OleDbType.VarBinary
        x_.ParameterName = "img"
        Me.PictureBox1.Image.Save(ms, Drawing.Imaging.ImageFormat.Png)
        x_.Value = ms.GetBuffer
        cmd.Parameters.Add(x_)
        cmd.ExecuteNonQuery()
    End Sub
    'دالة تقوم بعرض عدد السجلات
#Region "Functions Of DataBase "
    Private Sub New_EMP_Identity()
        Try

            Me.CB_EMP_Identity.Text = Nothing

            Me.PictureBox1.Image = Nothing



            Flg_ = 1
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Save_EMP_Identity()
        Try
            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_EMP_NO.Text.Trim
                    Dim var2_ As Object = Me.CB_EMP_Identity.SelectedValue.ToString
                    Dim Chk_ACTIVE_EI_ As Object = 0
                    If Chk_ACTIVE_EI.Checked = True Then
                        Chk_ACTIVE_EI_ = 1
                    End If


                    Dim Sql_ = "insert into EMP_Identity (emp_no,Iden_No,ACTIVE) VALUES(" & Var1_No_ & ",'" & var2_ & "','" & Chk_ACTIVE_EI_ & "' )"


                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    Save_Img(Var1_No_, var2_)
                    Get_EMP_Identity()
                    Flg_ = 0
                    Controls_()
                    Show_Count_EI()
                    CONTROL_FALSE_EI()
                    ' Me.GB_Depart.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If

            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If
                    Dim Var1_No_ As Object = Me.Text_EMP_NO.Text.Trim
                    Dim var2_ As Object = Me.CB_EMP_Identity.SelectedValue.ToString
                    Dim Chk_ACTIVE_EI_ As Object = 0
                    If Chk_ACTIVE_EI.Checked = True Then
                        Chk_ACTIVE_EI_ = 1
                    End If
                    Dim Sql_ = "UPDATE EMP_Identity SET ACTIVE ='" & Chk_ACTIVE_EI_ & "' WHERE emp_no=" & Var1_No_ & " and Iden_No=" & var2_ & ""

                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()

                    Save_Img(Var1_No_, var2_)

                    '  Get_Depart()
                    'LB_Depart = Nothing
                    'Fill_LB_(Me.LB_Depart, "Depart", "Depart_No", "Depart_Name", " Active=0")

                    Flg_ = 0
                    Controls_()
                    ' Me.GB_Depart.Enabled = False
                    MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_EMP_Identity()
        Try
            Me.GB_Depart.Enabled = False
            Flg_ = 2
            Controls_False()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete_EMP_Identity()
        Try
            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Depart_No.Text.Trim
                'Dim Var2_No_ As Object = Me.Text_Jop_No.Text.Trim
                'Dim Sql_ = "DELETE  FROM Depart_Jop WHERE Depart_No=" & Var1_No_ & "and Jop_No=" & Var2_No_ & ""
                Dim Cmd_ As New OleDbCommand
                'Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Depart()
                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_EMP_Identity()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Depart()
            Me.GB_Depart.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub

#End Region
#End Region
    
#End Region
#End Region
#Region "Events ---------"
    Private Sub Frm_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Fill_Cmb_(Me.CB_EMP_Identity, "Identity", "IDEN_NO", "IDEN_NAME", "ACTIVE=0")

            Me.TabControl1.Parent = Me
            Me.TabControl1.BackColor = Color.Transparent
            Me.GB_Identity.Parent = Panel4
            Me.GB_Identity.BackColor = Color.Transparent
            Me.GB_Qualification.Parent = Panel5
            Me.GB_Qualification.BackColor = Color.Transparent
            Me.GB_Specializing.Parent = Panel6
            Me.GB_Specializing.BackColor = Color.Transparent
            Me.GB_Center.Parent = Panel7
            Me.GB_Center.BackColor = Color.Transparent
            'Me.GB_Jop.Parent = Panel8
            'Me.GB_Jop.BackColor = Color.Transparent
            Me.GB_Depart.Parent = Panel9
            Me.GB_Depart.BackColor = Color.Transparent

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
    Private Sub Change_Position_Q(ByVal Sender As Object, ByVal e As EventArgs) Handles Cu_Manger_Q.PositionChanged
        Try

            Show_Count_Q()
            CONTROL_FALSE_Q()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Change_Position_S(ByVal Sender As Object, ByVal e As EventArgs) Handles Cu_Manger_S.PositionChanged
        Try

            Show_Count_S()
            CONTROL_FALSE_S()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Change_Position_C(ByVal Sender As Object, ByVal e As EventArgs) Handles Cu_Manger_C.PositionChanged
        Try

            Show_Count_C()
            CONTROL_FALSE_C()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Change_Position_J(ByVal Sender As Object, ByVal e As EventArgs) Handles Cu_Manger_J.PositionChanged
        Try

            Show_Count_J()
            CONTROL_FALSE_J()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Change_Position_D(ByVal Sender As Object, ByVal e As EventArgs) Handles Cu_Manger_D.PositionChanged
        Try

            Show_Count_D()
            CONTROL_FALSE_D()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_First.Click
        Try
            If Flg1_ = 1 Then
                Me.Cu_Manger_.Position = 0
            ElseIf Flg1_ = 2 Then
                Me.Cu_Manger_Q.Position = 0
            ElseIf Flg1_ = 3 Then
                Me.Cu_Manger_S.Position = 0
            ElseIf Flg1_ = 4 Then
                Me.Cu_Manger_C.Position = 0
            ElseIf Flg1_ = 5 Then
                Me.Cu_Manger_J.Position = 0
            ElseIf Flg1_ = 6 Then
                Me.Cu_Manger_D.Position = 0
            End If

            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_PREVIOUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PREVIOUS.Click
        Try
            If Flg1_ = 1 Then
                Me.Cu_Manger_.Position = Me.Cu_Manger_.Position - 1
            ElseIf Flg1_ = 2 Then
                Me.Cu_Manger_Q.Position = Me.Cu_Manger_Q.Position - 1
            ElseIf Flg1_ = 3 Then
                Me.Cu_Manger_S.Position = Me.Cu_Manger_S.Position - 1
            ElseIf Flg1_ = 4 Then
                Me.Cu_Manger_C.Position = Me.Cu_Manger_C.Position - 1
            ElseIf Flg1_ = 5 Then
                Me.Cu_Manger_J.Position = Me.Cu_Manger_J.Position - 1
            ElseIf Flg1_ = 6 Then
                Me.Cu_Manger_D.Position = Me.Cu_Manger_D.Position - 1

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Try
            If Flg1_ = 1 Then
                Me.Cu_Manger_.Position = Me.Cu_Manger_.Position + 1

            ElseIf Flg1_ = 2 Then
                Me.Cu_Manger_Q.Position = Me.Cu_Manger_Q.Position + 1
            ElseIf Flg1_ = 3 Then
                Me.Cu_Manger_S.Position = Me.Cu_Manger_S.Position + 1
            ElseIf Flg1_ = 4 Then
                Me.Cu_Manger_C.Position = Me.Cu_Manger_C.Position + 1
            ElseIf Flg1_ = 5 Then
                Me.Cu_Manger_J.Position = Me.Cu_Manger_J.Position + 1
            ElseIf Flg1_ = 6 Then
                Me.Cu_Manger_D.Position = Me.Cu_Manger_D.Position + 1

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Last.Click
        Try
            If Flg1_ = 1 Then
                Me.Cu_Manger_.Position = Me.Cu_Manger_.Count - 1

            ElseIf Flg1_ = 2 Then
                Me.Cu_Manger_Q.Position = Me.Cu_Manger_Q.Count - 1
            ElseIf Flg1_ = 3 Then
                Me.Cu_Manger_S.Position = Me.Cu_Manger_S.Count - 1
            ElseIf Flg1_ = 4 Then
                Me.Cu_Manger_C.Position = Me.Cu_Manger_C.Count - 1
            ElseIf Flg1_ = 5 Then
                Me.Cu_Manger_J.Position = Me.Cu_Manger_J.Count - 1
            ElseIf Flg1_ = 6 Then
                Me.Cu_Manger_D.Position = Me.Cu_Manger_D.Count - 1

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        Try
            Select Case Me.ToolStrip1.Items.IndexOf(e.ClickedItem)
                Case "0"
                    If Flg1_ = 1 Then
                        New_Identity()
                    ElseIf Flg1_ = 2 Then
                        New_Qualification()
                    ElseIf Flg1_ = 3 Then
                        New_Specializing()
                    ElseIf Flg1_ = 4 Then
                        New_Center()
                    ElseIf Flg1_ = 5 Then
                        New_Jop()
                    ElseIf Flg1_ = 6 Then
                        New_Depart()
                    ElseIf Flg1_ = 7 Then
                        New_EMP_Identity()
                    End If

                Case "1"
                    If Flg1_ = 1 Then
                        Save_Identity()
                    ElseIf Flg1_ = 2 Then
                        Save_Qualification()
                    ElseIf Flg1_ = 3 Then
                        Save_Specializing()
                    ElseIf Flg1_ = 4 Then
                        Save_Center()
                    ElseIf Flg1_ = 5 Then
                        Save_Jop()
                    ElseIf Flg1_ = 6 Then
                        Save_Depart()
                    ElseIf Flg1_ = 7 Then
                        Save_EMP_Identity()
                    End If
                Case "2"
                    If Flg1_ = 1 Then
                        Edit_Identity()
                    ElseIf Flg1_ = 2 Then
                        Edit_Qualification()
                    ElseIf Flg1_ = 3 Then
                        Edit_Specializing()
                    ElseIf Flg1_ = 4 Then
                        Edit_Center()
                    ElseIf Flg1_ = 5 Then
                        Edit_Jop()
                    ElseIf Flg1_ = 6 Then
                        Edit_Depart()
                    End If

                Case "3"
                    If Flg1_ = 1 Then
                        Delete_Identity()
                    ElseIf Flg1_ = 2 Then
                        Delete_Qualification()
                    ElseIf Flg1_ = 3 Then
                        Delete_Specializing()
                    ElseIf Flg1_ = 4 Then
                        Delete_Center()
                    ElseIf Flg1_ = 5 Then
                        Delete_Jop()
                    ElseIf Flg1_ = 6 Then
                        Delete_Depart()
                    End If
                Case "4"
                    If Flg1_ = 1 Then
                        Cancel_Identity()
                    ElseIf Flg1_ = 2 Then
                        Cancel_Qualification()
                    ElseIf Flg1_ = 3 Then
                        Cancel_Specializing()
                    ElseIf Flg1_ = 4 Then
                        Cancel_Center()
                    ElseIf Flg1_ = 5 Then
                        Cancel_Jop()
                    ElseIf Flg1_ = 6 Then
                        Cancel_Depart()
                    End If
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
    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click, TabControl1.Click
        Try

            If TabControl1.SelectedTab.Name = "TB_Identity" Then
                Fill_LB_(Me.LB_Identity, "Identity", "Iden_No", "Iden_Name", " Active=0")
                Get_Identity()
                BindingContext_Identity(Dt_)
                Show_Count_()
                CONTROL_FALSE()
                Me.GB_Identity.Enabled = False
                Flg1_ = 1

            ElseIf TabControl1.SelectedTab.Name = "TB_Qualification" Then
                Fill_LB_(Me.LB_Qualification, "Qualification", "Qual_No", "Qual_Name", " Active=0")
                Get_Qualification()
                BindingContext_Qualification(Dt_Q)
                Show_Count_Q()
                CONTROL_FALSE_Q()
                Me.GB_Qualification.Enabled = False
                Flg1_ = 2
            ElseIf TabControl1.SelectedTab.Name = "TB_Specializing" Then
                Fill_LB_(Me.LB_Specializing, "Specializing", "Spec_No", "Spec_Name", " Active=0")
                Get_Specializing()
                BindingContext_Specializing(Dt_S)
                Show_Count_S()
                CONTROL_FALSE_S()
                Me.GB_Specializing.Enabled = False
                Flg1_ = 3
            ElseIf TabControl1.SelectedTab.Name = "TB_Center" Then
                Fill_LB_(Me.LB_Center, "Center", "Center_No", "Center_Name", " Active=0")
                Get_Center()
                BindingContext_Center(Dt_C)
                Show_Count_C()
                CONTROL_FALSE_C()
                Me.GB_Center.Enabled = False
                Flg1_ = 4
            ElseIf TabControl1.SelectedTab.Name = "TB_Jop" Then
                'Fill_LB_(Me.LB_Jop, "Jop", "Jop_No", "Jop_Name", " Active=0")
                Get_Jop()
                BindingContext_Jop(Dt_J)
                Show_Count_J()
                CONTROL_FALSE_J()
                'Me.GB_Jop.Enabled = False
                Flg1_ = 5
            ElseIf TabControl1.SelectedTab.Name = "TB_Depart" Then
                'Fill_LB_(Me.LB_Depart, "Depart", "Depart_No", "Depart_Name", " Active=0")
                Get_Depart()
                BindingContext_Depart(Dt_D)
                Show_Count_D()
                CONTROL_FALSE_D()
                Me.GB_Depart.Enabled = False
                Flg1_ = 6
            ElseIf TabControl1.SelectedTab.Text = "بيانات الموظف" Then

               
                Get_EMP_Identity()
                BindingContext_EMP_Identity(Dt_EI)
                Show_Count_EI()
                CONTROL_FALSE_EI()
                Fill_Cmb_(Me.CB_EMP_Identity, "Identity", "IDEN_NO", "IDEN_NAME", "ACTIVE=0")

                ' Me.GB_Depart.Enabled = False
                Flg1_ = 7
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Text_Depart_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Depart_Name.TextChanged
        Dim Var1_No_ As Object = Me.Text_Depart_Name.Text.Trim
        Dim Sql_ As Object = New String("SELECT distinct Depart_No FROM Depart_Jop where Depart_Name = '" & Var1_No_ & "' ")
        Dim Da_ As OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)

        If Dt_.Rows.Count > 0 Then


            Me.Text_Depart_No.Text = Dt_.Rows(0).Item(0).ToString

        Else

            Me.Text_Depart_No.Text = Get_Max("Depart_Jop", "Depart_No")
        End If
    End Sub
    Private Sub Jop_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jop_Name.TextChanged
        Dim Var1_No_ As Object = Me.Jop_Name.Text.Trim
        Dim Sql_ As Object = New String("SELECT distinct Jop_No FROM Depart_Jop where Jop_Name = '" & Var1_No_ & "' ")
        Dim Da_ As OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)

        If Dt_.Rows.Count > 0 Then

            Me.Jop_No.Text = Dt_.Rows(0).Item(0).ToString

        Else



            '   Me.Jop_No.Text = Text_Depart_No.Text & 0 & (Get_Max_Trip("Depart_Jop", "Jop_No", "Depart_No=" & Text_Depart_No.Text & "", "Jop_No", "3", "1") + 1)




        End If
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        Me.ProgressBar1.Visible = True
        Dim OPENFILLEDIALOG1 As New OpenFileDialog
        With OPENFILLEDIALOG1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = _
            "ALL FILES|*.*|Bitmap Files (*) | * .bmp;*.gif;*.jpg"
            .FilterIndex = 2
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.PictureBox1.Image = Image.FromFile(.FileName)
            End If
        End With


        Me.ProgressBar1.PerformStep()
        With ProgressBar1
            .Minimum = 1
            .Maximum = 230
            .Value = 10
            .Step = 5
            For i As Integer = .Minimum To .Maximum
                ' Perform one step of the action being tracked.
                .PerformStep()
            Next i
        End With

        Me.ProgressBar1.Value = 5
        Me.ProgressBar1.Visible = False

    End Sub

#End Region

    
  
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        TabControl1.SelectedTab = TB_Identity
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        TabControl1.SelectedTab = TB_Qualification
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        TabControl1.SelectedTab = TB_Depart
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        TabControl1.SelectedTab = TB_Center
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        TabControl1.SelectedTab = TB_Depart
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        TabControl1.SelectedTab = TabPage13
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        TabControl1.SelectedTab = TabPage3
    End Sub
End Class