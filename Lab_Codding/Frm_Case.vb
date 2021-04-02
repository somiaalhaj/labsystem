Imports System.Data.OleDb
Imports Star_Soft
Public Class Frm_Case

#Region "Variable ------------"
    Private Dt_ As New DataTable
    Private WithEvents Cu_Manger_ As CurrencyManager
    Private Flg_ As Object = 0
#End Region
#Region "Events ---------"
    Private Sub Frm_Case_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.GroupBox1.Parent = Me
            Me.GroupBox1.BackColor = Color.Transparent
            Get_Case()
            BindingContext_Data(Dt_)
            Show_Count_()
            CONTROL_FALSE()
            Me.GroupBox1.Enabled = False
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
    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
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

#End Region
#Region "Functions -----------"
    Private Sub Get_Case()
        Try
            Me.Dt_.Clear()
            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("select * from Cases")
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
                Me.Text_Case_No.DataBindings.Add("Text", Dt_Ref, "Case_No")
                Me.Text_Case_Name.DataBindings.Add("Text", Dt_Ref, "Case_Name")

                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل

                Me.Cu_Manger_ = Me.BindingContext(Me.Dt_)
                Dim obj As New [MyClass]()
                Dim b As New Binding("Checked", Me.Dt_, "Activ", True)
                AddHandler b.Format, AddressOf b_Format
                Me.Chk_ACTIVE.DataBindings.Add(b)

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
            Me.Text_Case_No.Text = Nothing
            Me.Text_Case_Name.Text = Nothing
            Me.GroupBox1.Enabled = True
            Me.Text_Case_No.Text = Get_Max("Cases", "Case_No")
            Flg_ = 1
            Controls_False()
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
                    Dim Var1_No_ As Object = Me.Text_Case_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Case_Name.Text.Trim
                    Dim Chk_ACTIVE_ As Object = 0
                    If Chk_ACTIVE.Checked = True Then
                        Chk_ACTIVE_ = 1
                    End If
                    Data.Insert_("Cases", "Case_No,Case_Name,activ", "" & Var1_No_ & ",'" & Var2_Name_ & "','" & Chk_ACTIVE_ & "'", Conn)
                    Flg_ = 0
                    Controls_()
                    Me.GroupBox1.Enabled = False
                    MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
                End If

            ElseIf Flg_ = 2 Then
                'تعديل السجل الحالي 
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    
                    Dim Var1_No_ As Object = Me.Text_Case_No.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Case_Name.Text.Trim
                    Dim Chk_ACTIVE_ As Object = 0
                    If Chk_ACTIVE.Checked = True Then
                        Chk_ACTIVE_ = 1
                    End If
                    Data.Update_("Cases", "Case_Name='" & Var2_Name_ & "', activ='" & Chk_ACTIVE_ & "' ", "Case_No=" & Var1_No_ & "", Conn)

                    Get_Case()
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
                Dim Var1_No_ As Object = Me.Text_Case_No.Text.Trim
                Data.Delete__("Cases", "Case_No=" & Var1_No_ & "", Conn)
                Get_Case()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Case()
            Me.GroupBox1.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub




#End Region
#End Region
End Class