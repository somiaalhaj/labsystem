Imports System.Data.OleDb
Public Class Frm_Checkups
#Region "Variable ------------"
    Private Dt_F As New DataTable
    Private Dt_CH As New DataTable
    Private Dt_U As New DataTable
    Private WithEvents Cu_Manger_F As CurrencyManager
    Private WithEvents Cu_Manger_CH As CurrencyManager
    Private WithEvents Cu_Manger_U As CurrencyManager
    Private Flg_ As Object = 0
    Private Flg1_ As Object = 0
    Private Flg2_ As Object = 0
    Private Flg3_ As Object = 0
    Private Flg4_ As Object = 0

    Dim LOC_DATASET As New DataTable
#End Region
#Region "Functions -----------"
#Region "Functions_Checkups -----------"
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
    Private Sub Get_Checkups()
        Try
            Me.Dt_CH.Clear()

            ' Fill_LB_(Me.LB_Che_Fath, "Identity", "Iden_No", "Iden_Name", " Active=0")

            'فحص حالة الإتصال
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            'تعريق متغير يحمل جملة الإستعلاوم
            Dim Sql_ As Object = New String("select * from Checkups")
            'إرسال الإستعلام إلى قاعدة البيانات
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)

            'وضع بيانات الإستعلام في اداة داتاتيبل
            Da_.Fill(Dt_CH)
            Show_Count_CH()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BindingContext_Checkups(ByVal Dt_Ref As DataTable)
        Try
            If Not Dt_Ref.Rows.Count <= 0 Then
                Me.Text_Checkups_NO.DataBindings.Add("Text", Dt_Ref, "Checkups_NO")
                Me.Text_Checkups_Name.DataBindings.Add("Text", Dt_Ref, "Checkups_Name")
                Me.Che_Fath_No.DataBindings.Add("Text", Dt_Ref, "Che_Fath_No")
                Me.Che_Unit_No.DataBindings.Add("Text", Dt_Ref, "Che_Unit_No")
                Me.Text_Checkups_Price_Prim.DataBindings.Add("Text", Dt_Ref, "Checkups_Price_Prim")
                Me.Text_Checkups_Adore.DataBindings.Add("Text", Dt_Ref, "Checkups_Adore")
                Me.Text_Unit_Part.DataBindings.Add("Text", Dt_Ref, "CHE_UNIT_PART_NO")

                'في السطر التالي نقوم بتفعيل عملية ربط السجلات مع أحداث التنقل

                Me.Cu_Manger_CH = Me.BindingContext(Me.Dt_CH)
            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub
    'دالة تقوم بعرض عدد السجلات
    Private Sub Show_Count_CH()
        Try
            Me.ToolStrip1.Items("Red_Count").Text = Me.Cu_Manger_CH.Count & "/" & Me.Cu_Manger_CH.Position + 1
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub
    'دالة تقوم بتعطيل أزرار التنقل 
    Private Sub CONTROL_FALSE_CH()
        On Error Resume Next
        If Me.Cu_Manger_CH.Position = 0 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = False
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = False
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_CH.Position > 0 And Me.Cu_Manger_CH.Position < Me.Cu_Manger_CH.Count - 1 Then
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
            Me.ToolStrip1.Items("Btn_Last").Enabled = True
            Me.ToolStrip1.Items("Btn_Next").Enabled = True
        ElseIf Me.Cu_Manger_CH.Position = Me.Cu_Manger_CH.Count - 1 Then
            Me.ToolStrip1.Items("Btn_Last").Enabled = False
            Me.ToolStrip1.Items("Btn_Next").Enabled = False
            Me.ToolStrip1.Items("Btn_First").Enabled = True
            Me.ToolStrip1.Items("Btn_PREVIOUS").Enabled = True
        End If
    End Sub
    Private Sub LODA_DATA_TREE()
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
            'Conn.Open()
            LOC_DATASET.Clear()
            Dim SQLstr As String = "select * from Checkups_Tree"
            '   Conn.Open()
            Dim AccTableAdapter As New OleDbDataAdapter(SQLstr, Conn)
            AccTableAdapter.Fill(LOC_DATASET)
            'Conn.Close()
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub
    Private Sub AddSubNode(ByVal Node As TreeNode)
        Try
            Dim dv1 As DataView = LOC_DATASET.DefaultView

            dv1.RowFilter = "CH_Parent_NO=" & CType(Node.Tag, Integer)

            For Each drLine As DataRowView In dv1

                Dim SubNode As New TreeNode(drLine("CH_Tree_NO") & " -- " & (drLine("CHECKUPS_NAME").ToString()))

                SubNode.Tag = drLine("CH_Tree_NO").ToString

                SubNode.Name = drLine("CH_Tree_NO").ToString
                SubNode.SelectedImageIndex = 0
                SubNode.StateImageIndex = 0
               
                Node.Nodes.Add(SubNode)

                If Not SubNode.Tag Is String.Empty Then

                    AddSubNode(SubNode)

                End If
            Next
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub
    Private Sub CreateTree()
        On Error Resume Next
        'TreeView1.BeginUpdate()
        TreeView1.Nodes.Clear()
        Dim MainHeader As New TreeNode("" & " . " & "شــجـــرة الفحوصات")

        MainHeader.Tag = 0

        TreeView1.Nodes.Add(MainHeader)

        AddSubNode(MainHeader)

        'TreeView1.EndUpdate()
        TreeView1.ExpandAll()
        'TreeView1.Select()
    End Sub
#Region "Functions Of DataBase "
    Private Sub New_Checkups()
        Try

            Me.Text_Checkups_NO.Text = Nothing
            Me.Text_Checkups_Name.Text = Nothing
            Me.Che_Fath_No.Text = Nothing
            Me.Che_Fath_Name.Text = Nothing
            Me.Che_Unit_No.Text = Nothing
            Me.Che_Unit_Name.Text = Nothing
            Me.Text_CHE_Part_No.Text = Nothing
            Me.Text_CHE_Part_Name.Text = Nothing
            Me.Text_Checkups_Price_Prim.Text = Nothing
            Me.Text_Checkups_Adore.Text = Nothing
            Me.Text_TYPE_SAMPLE_NO.Text = Nothing
            Me.Text_TYPE_SAMPLE_NAME.Text = Nothing
            Me.Text_Unit_Part.Text = Nothing
            Me.CHE_UNIT_PART_NAME.Text = Nothing
            ' Me.Text_Checkups_Name.ReadOnly = True
            Me.GB_Checkups.Enabled = True
            Flg_ = 1


            Controls_False()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Save_Checkups()
        Try
            If Flg_ = 1 Then
                'إضافة سجل جديد
                Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في إضافة السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
                If Msg_Re = MsgBoxResult.Ok Then
                    If Not Conn.State = ConnectionState.Open Then
                        Conn.Open()
                    End If

                    Dim Var1_No_ As Object = Me.Text_Checkups_NO.Text.Trim
                    Dim Var2_Name_ As Object = Me.Text_Checkups_Name.Text.Trim
                    Dim Var2_Che_Fath_No_ As Object = Me.Che_Fath_No.Text.Trim
                    Dim Var2_Che_Unit_No_ As Object = Me.Che_Unit_No.Text.Trim
                    Dim Var2_Checkups_Price_Prim_ As Object = Me.Text_Checkups_Price_Prim.Text.Trim
                    Dim Var2_Checkups_Adore_ As Object = Me.Text_Checkups_Adore.Text.Trim
                    Dim Var2_CHE_FATH_NAME_ As Object = Me.Che_Fath_Name.Text.Trim
                    Dim Var2_CHE_UNIT_NAME_ As Object = Me.Che_Unit_Name.Text.Trim
                    Dim Var2_CHE_PART_NAME_ As Object = Me.Text_CHE_Part_Name.Text.Trim
                    Dim Var2_CHE_UNIT_PART_NAME_ As Object = Me.CHE_UNIT_PART_NAME.Text.Trim
                    Dim Var2_TYPE_SAMPLE_NO_ As Object = Me.Text_TYPE_SAMPLE_NO.Text.Trim
                    Dim Var2_TYPE_SAMPLE_NAME_ As Object = Me.Text_TYPE_SAMPLE_NAME.Text.Trim
                    Dim Var2_CHE_PART_NO_ As Object = Me.Text_CHE_Part_No.Text.Trim
                    Dim Var2_CHE_UNIT_PART_NO_ As Object = Me.Text_Unit_Part.Text.Trim


                    Dim Sql_ = "insert into Checkups (Checkups_NO,Che_Fath_No,Che_Unit_No,Checkups_Price_Prim,Checkups_Adore,CHE_UNIT_NAME,CHE_UNIT_PART_NAME,TYPE_SAMPLE_NO,TYPE_SAMPLE_NAME,CHE_PART_NO,CHE_UNIT_PART_NO) VALUES(" & Var1_No_ & "," & Var2_Che_Fath_No_ & "," & Var2_Che_Unit_No_ & "," & Var2_Checkups_Price_Prim_ & "," & Var2_Checkups_Adore_ & ",'" & Var2_CHE_UNIT_NAME_ & "','" & Var2_CHE_UNIT_PART_NAME_ & "'," & Var2_TYPE_SAMPLE_NO_ & ",'" & Var2_TYPE_SAMPLE_NAME_ & "' ," & Var2_CHE_PART_NO_ & "," & Var2_CHE_UNIT_PART_NO_ & ")"
                  
                    Dim Cmd_ As New OleDbCommand
                    Cmd_.CommandText = Sql_
                    Cmd_.Connection = Conn
                    Cmd_.ExecuteNonQuery()
                    If Flg2_ = 0 Then
                        Insert_("Checkups_Tree", "CH_Tree_NO,CHECKUPS_NAME,CH_Parent_NO", "" & Var2_Che_Fath_No_ & ",'" & Var2_CHE_FATH_NAME_ & "',0")
                    End If
                    If Flg3_ = 0 Then
                        Insert_("Checkups_Tree", "CH_Tree_NO,CHECKUPS_NAME,CH_Parent_NO", "" & Var1_No_ & ",'" & Var2_Name_ & "'," & Var2_Che_Fath_No_ & "")

                    End If
                    If Flg4_ = 0 Then
                        Insert_("Checkups_Tree", "CH_Tree_NO,CHECKUPS_NAME,CH_Parent_NO", "" & Var2_CHE_PART_NO_ & ",'" & Var2_CHE_PART_NAME_ & "'," & Var1_No_ & "")
                

            End If

            Get_Checkups()
            Flg_ = 0
            Controls_()
            Me.GB_Checkups.Enabled = False
            MsgBox("تمت عملية الحفظ بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If

            ElseIf Flg_ = 2 Then
            'تعديل السجل الحالي 
            Dim Msg_Re As MsgBoxResult = MsgBox("؟هل ترغب في تعديل السجل الحالي", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Checkups_NO.Text.Trim
                Dim Var2_Name_ As Object = Me.Text_Checkups_Name.Text.Trim
                Dim Var2_Che_Fath_No_ As Object = Me.Che_Fath_No.Text.Trim
                Dim Var2_Che_Unit_No_ As Object = Me.Che_Unit_No.Text.Trim
                Dim Var2_Checkups_Price_Prim_ As Object = Me.Text_Checkups_Price_Prim.Text.Trim
                Dim Var2_Checkups_Adore_ As Object = Me.Text_Checkups_Adore.Text.Trim
                Dim Var2_CHE_FATH_NAME_ As Object = Me.Che_Fath_Name.Text.Trim
                Dim Var2_CHE_UNIT_NAME_ As Object = Me.Che_Unit_Name.Text.Trim
                Dim Var2_CHE_PART_NAME_ As Object = Me.Text_CHE_Part_Name.Text.Trim
                Dim Var2_CHE_UNIT_PART_NAME_ As Object = Me.CHE_UNIT_PART_NAME.Text.Trim
                Dim Var2_TYPE_SAMPLE_NO_ As Object = Me.Text_TYPE_SAMPLE_NO.Text.Trim
                Dim Var2_TYPE_SAMPLE_NAME_ As Object = Me.Text_TYPE_SAMPLE_NAME.Text.Trim
                Dim Var2_CHE_PART_NO_ As Object = Me.Text_CHE_Part_No.Text.Trim
                Dim Var2_CHE_UNIT_PART_NO_ As Object = Me.Text_Unit_Part.Text.Trim

                Dim Sql_ = "UPDATE Checkups SET  Che_Fath_No=" & Var2_Che_Fath_No_ & " ,Che_Unit_No=" & Var2_Che_Unit_No_ & ",Checkups_Price_Prim=" & Var2_Checkups_Price_Prim_ & ",Checkups_Adore=" & Var2_Checkups_Adore_ & ",CHE_UNIT_NAME='" & Var2_CHE_UNIT_NAME_ & "',CHE_UNIT_PART_NAME='" & Var2_CHE_UNIT_PART_NAME_ & "',TYPE_SAMPLE_NO=" & Var2_TYPE_SAMPLE_NO_ & ",TYPE_SAMPLE_NAME='" & Var2_TYPE_SAMPLE_NAME_ & "',CHE_PART_NO=" & Var2_CHE_PART_NO_ & ",CHE_UNIT_PART_NO=" & Var2_CHE_UNIT_PART_NO_ & " WHERE Checkups_NO=" & Var1_No_ & ""

                Dim Cmd_ As New OleDbCommand
                Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Checkups()

                Flg_ = 0
                Controls_()
                Me.GB_Checkups.Enabled = False
                MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Edit_Checkups()
        Try
            Me.GB_Checkups.Enabled = False
            Flg_ = 2
            Controls_False()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Delete_Checkups()
        Try
            Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب في حذف السجل الحالي؟", MsgBoxStyle.OkCancel, "ستار سوفت")
            If Msg_Re = MsgBoxResult.Ok Then
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                Dim Var1_No_ As Object = Me.Text_Checkups_NO.Text.Trim
                Dim Var2_No_ As Object = Me.Che_Fath_No.Text.Trim
                Dim Var3_No_ As Object = Me.Text_CHE_Part_No.Text.Trim
                Dim Sql_ = "DELETE  FROM Checkups WHERE Checkups_NO=" & Var1_No_ & " and CHE_FATH_NO=" & Var2_No_ & " and CHE_PART_NO=" & Var3_No_ & ""
                Dim Cmd_ As New OleDbCommand
                Cmd_.CommandText = Sql_
                Cmd_.Connection = Conn
                Cmd_.ExecuteNonQuery()
                Get_Checkups()
                MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
            End If

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Checkups()
        On Error Resume Next
        Dim Msg_Re As MsgBoxResult = MsgBox("هل ترغب فعلاً في التراجع عن حفظ التغيرات؟", MsgBoxStyle.OkCancel, "ستار سوفت")
        If Msg_Re = MsgBoxResult.Ok Then
            Get_Checkups()
            Me.GB_Checkups.Enabled = False
            Flg_ = 0
            Controls_()
        Else

        End If
    End Sub

#End Region


#End Region
#End Region
#Region "Events ---------"
    Private Sub Frm_Checkups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TabControl1.Parent = Me
            Me.TabControl1.BackColor = Color.Transparent
            Me.GB_Checkups.Parent = Panel3
            Me.GB_Checkups.BackColor = Color.Transparent

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Change_Position_CH(ByVal Sender As Object, ByVal e As EventArgs) Handles Cu_Manger_CH.PositionChanged
        Try

            Show_Count_CH()
            CONTROL_FALSE_CH()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_First.Click
        Try
            If Flg1_ = 1 Then
                Me.Cu_Manger_F.Position = 0
            ElseIf Flg1_ = 2 Then
                Me.Cu_Manger_U.Position = 0
            ElseIf Flg1_ = 3 Then
                Me.Cu_Manger_CH.Position = 0
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_PREVIOUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PREVIOUS.Click
        Try
            If Flg1_ = 1 Then
                Me.Cu_Manger_F.Position = Me.Cu_Manger_F.Position - 1
            ElseIf Flg1_ = 2 Then
                Me.Cu_Manger_U.Position = Me.Cu_Manger_U.Position - 1
            ElseIf Flg1_ = 3 Then
                Me.Cu_Manger_CH.Position = Me.Cu_Manger_CH.Position - 1

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Try
            If Flg1_ = 1 Then
                Me.Cu_Manger_F.Position = Me.Cu_Manger_F.Position + 1
            ElseIf Flg1_ = 2 Then
                Me.Cu_Manger_U.Position = Me.Cu_Manger_U.Position + 1
            ElseIf Flg1_ = 3 Then
                Me.Cu_Manger_CH.Position = Me.Cu_Manger_CH.Position + 1


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Last.Click
        Try
            If Flg1_ = 1 Then
                Me.Cu_Manger_F.Position = Me.Cu_Manger_F.Count - 1

            ElseIf Flg1_ = 2 Then
                Me.Cu_Manger_U.Position = Me.Cu_Manger_U.Count - 1
            ElseIf Flg1_ = 3 Then
                Me.Cu_Manger_CH.Position = Me.Cu_Manger_CH.Count - 1

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        Try
            Select Case Me.ToolStrip1.Items.IndexOf(e.ClickedItem)
                Case "0"
                    If Flg1_ = 3 Then

                        New_Checkups()

                    End If

                Case "1"
                    If Flg1_ = 3 Then

                        Save_Checkups()
                    End If
                Case "2"
                    If Flg1_ = 3 Then

                        Edit_Checkups()
                    End If

                Case "3"
                    If Flg1_ = 3 Then

                        Delete_Checkups()
                    End If
                Case "4"
                    If Flg1_ = 3 Then

                        Cancel_Checkups()

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

            If TabControl1.SelectedTab.Name = "TB_Checkups" Then

               

                Get_Checkups()
                BindingContext_Checkups(Dt_CH)
                Show_Count_CH()
                CONTROL_FALSE_CH()
                LODA_DATA_TREE()
                CreateTree()
                Me.GB_Checkups.Enabled = False
                Flg1_ = 3

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim newfrm As New Frm_Search_Che_Fath

            If newfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.Che_Fath_No.Text = newfrm.Che_Fath_No_
                Me.Che_Fath_Name.Text = newfrm.Che_Fath_Name_
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim newfrm As New Frm_Che_Unit

            If newfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.Che_Unit_No.Text = newfrm.Che_Unit_No_
                Me.Che_Unit_Name.Text = newfrm.Che_Unit_Name_
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Text_Checkups_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Checkups_Name.TextChanged
        Try
            If Text_Checkups_Name.Text = Nothing Then

            Else

                Dim Var1_No_ As Object = Me.Text_Checkups_Name.Text.Trim
                Dim Sql_ As Object = New String("SELECT distinct CH_Tree_NO FROM Checkups_Tree where CHECKUPS_NAME = '" & Var1_No_ & "' ")
                Dim Da_ As OleDbDataAdapter
                Da_ = New OleDbDataAdapter(Sql_, Conn)
                Dim Dt_ As New DataTable
                Da_.Fill(Dt_)

                If Dt_.Rows.Count > 0 Then
                    Flg3_ = 1

                    Me.Text_Checkups_NO.Text = Dt_.Rows(0).Item(0).ToString

                Else
                    Flg3_ = 0

                    Me.Text_Checkups_NO.Text = Che_Fath_No.Text & 0 & (Get_Max_Trip("Checkups_Tree", "CH_Tree_NO", "CH_Parent_NO = " & Che_Fath_No.Text & "", "3", "1") + 1)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Che_Fath_Name_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Che_Fath_Name.TextChanged
        Try

            Dim Var1_No_ As Object = Me.Che_Fath_Name.Text.Trim
            Dim Sql_ As Object = New String("SELECT distinct CH_Tree_NO FROM Checkups_Tree where CHECKUPS_NAME = '" & Var1_No_ & "' ")
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)
            Dim Dt_ As New DataTable
            Da_.Fill(Dt_)

            If Dt_.Rows.Count > 0 Then

                Flg2_ = 1
                Me.Che_Fath_No.Text = Dt_.Rows(0).Item(0).ToString

            Else
                Flg2_ = 0

                Me.Che_Fath_No.Text = (Get_Max_Trip("Checkups_Tree", "CH_Tree_NO", "CH_Parent_NO =0", "1", "1") + 1)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Text_CHE_Part_Name_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_CHE_Part_Name.TextChanged
        Try
            If Text_CHE_Part_Name.Text = Nothing Then


            Else
                Dim Var1_No_ As Object = Me.Text_CHE_Part_Name.Text.Trim
                Dim Sql_ As Object = New String("SELECT distinct CH_Tree_NO FROM Checkups_Tree where CHECKUPS_NAME = '" & Var1_No_ & "' ")
                Dim Da_ As OleDbDataAdapter
                Da_ = New OleDbDataAdapter(Sql_, Conn)
                Dim Dt_ As New DataTable
                Da_.Fill(Dt_)

                If Dt_.Rows.Count > 0 Then
                    Flg4_ = 1
                    Me.Text_CHE_Part_No.Text = Dt_.Rows(0).Item(0).ToString
                Else

                    Flg4_ = 0
                    Me.Text_CHE_Part_No.Text = Text_Checkups_NO.Text.Trim & 0 & (Get_Max_Trip("Checkups_Tree", "CH_Tree_NO", "CH_Parent_NO = " & Text_Checkups_NO.Text & "", "5", "1") + 1)

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Che_Unit_Name_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Che_Unit_Name.TextChanged
        Dim Var1_No_ As Object = Me.Che_Unit_Name.Text.Trim
        Dim Sql_ As Object = New String("SELECT distinct Che_Unit_NO FROM Checkups where Che_Unit_Name = '" & Var1_No_ & "' ")
        Dim Da_ As OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)

        If Dt_.Rows.Count > 0 Then


            Me.Che_Unit_No.Text = Dt_.Rows(0).Item(0).ToString

        Else

            Me.Che_Unit_No.Text = Get_Max("Checkups", "Che_Unit_NO")
        End If
    End Sub

    Private Sub CHE_UNIT_PART_NAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHE_UNIT_PART_NAME.TextChanged
        Dim Var1_No_ As Object = Me.CHE_UNIT_PART_NAME.Text.Trim
        Dim Sql_ As Object = New String("SELECT distinct CHE_UNIT_PART_NO FROM Checkups where CHE_UNIT_PART_NAME = '" & Var1_No_ & "' ")
        Dim Da_ As OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)

        If Dt_.Rows.Count > 0 Then


            Me.Text_Unit_Part.Text = Dt_.Rows(0).Item(0).ToString

        Else

            Me.Text_Unit_Part.Text = Get_Max("Checkups", "CHE_UNIT_PART_NO")
        End If
    End Sub

    Private Sub Text_TYPE_SAMPLE_NAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_TYPE_SAMPLE_NAME.TextChanged
        Dim Var1_No_ As Object = Me.Text_TYPE_SAMPLE_NAME.Text.Trim
        Dim Sql_ As Object = New String("SELECT distinct TYPE_SAMPLE_NO FROM Checkups where TYPE_SAMPLE_NAME = '" & Var1_No_ & "' ")
        Dim Da_ As OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)

        If Dt_.Rows.Count > 0 Then


            Me.Text_TYPE_SAMPLE_NO.Text = Dt_.Rows(0).Item(0).ToString

        Else

            Me.Text_TYPE_SAMPLE_NO.Text = Get_Max("Checkups", "TYPE_SAMPLE_NO")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim newfrm As New Frm_Search_TYPE_SAMPLE

            If newfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.Text_TYPE_SAMPLE_NO.Text = newfrm.TYPE_SAMPLE_NO_
                Me.Text_TYPE_SAMPLE_NAME.Text = newfrm.TYPE_SAMPLE_NAME_
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim New_Frm_ As New Frm_Checkup_Supplies

            Me.Hide()
            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub
#End Region

    
    

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        TabControl1.SelectedTab = TB_Checkups
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        TabControl1.SelectedTab = TabPage2
    End Sub
End Class