Imports System.Data.OleDb
Module Lab_Md
    Private Str_ As String = "Provider=OraOLEDB.Oracle.1;Password=abc123;Persist Security Info=True;User ID=Lab;Data Source=star"
    Public Conn As New OleDbConnection(Str_)
    Public G_user_name As Object = Nothing
    Public G_user_no As Object = Nothing
    Sub Main()
        Try
            'فحص الإتصال بقاعدة البيانات
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
                MsgBox("تم الاتصال بنجاح")

            End If
            Dim New_Frm_ As New Frm_Login
            New_Frm_.Show()
            Application.EnableVisualStyles()
            Application.Run()
        Catch ex As Exception
            MsgBox("لايمكن الإتصال بقاعدة البيانات", MsgBoxStyle.Information, "ستار سوفت")
            End
        End Try
    End Sub
#Region "Functions Of Project "
    Public Function Get_Max(ByVal Table_Name_ As Object, ByVal CoLUMN_Name_ As Object) As Object
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim Sql_ As Object = New String("SELECT NVL(max(" & CoLUMN_Name_ & "),0)+1 FROM " & Table_Name_ & " ")
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)
            Dim Dt_ As New DataTable
            Da_.Fill(Dt_)
            Dim New_Val_ As Object
            If Dt_.Rows.Count > 0 Then
                New_Val_ = Dt_.Rows(0).Item(0).ToString
                Return New_Val_
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Get_Max_Trip(ByVal Table_Name_ As Object, ByVal CoLUMN_Name_ As Object, ByVal Conditions_ As Object, ByVal First As Object, ByVal Num As Object) As Object
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim Sql_1 As Object = New String("select distinct max(" & CoLUMN_Name_ & ") from " & Table_Name_ & " where " & Conditions_ & "  ")

            Dim Da_1 As OleDbDataAdapter
            Da_1 = New OleDbDataAdapter(Sql_1, Conn)
            Dim Dt_1 As New DataTable
            Da_1.Fill(Dt_1)
            Dim New_Val_1 As Object = 0

            If Dt_1.Rows.Count > 0 Then
                New_Val_1 = Dt_1.Rows(0).Item(0).ToString.Trim
                '*************************
                Dim Sql_2 As Object = New String("select distinct to_char(" & CoLUMN_Name_ & ") " & CoLUMN_Name_ & " from " & Table_Name_ & " where " & CoLUMN_Name_ & "= " & New_Val_1 & "")

                Dim Da_2 As OleDbDataAdapter
                Da_2 = New OleDbDataAdapter(Sql_2, Conn)
                Dim Dt_2 As New DataTable
                Da_2.Fill(Dt_2)
                Dim New_Val_2 As Object = 0

                If Dt_2.Rows.Count > 0 Then
                    New_Val_2 = Dt_2.Rows(0).Item(0).ToString.Trim

                    '*************************
                    Dim Sql_3 As Object = New String("select distinct substr('" & New_Val_2 & "'," & First & "," & Num & ") from " & Table_Name_ & " ")

                    Dim Da_3 As OleDbDataAdapter
                    Da_3 = New OleDbDataAdapter(Sql_3, Conn)
                    Dim Dt_3 As New DataTable
                    Da_3.Fill(Dt_3)
                    Dim New_Val_3 As Object = 0

                    If Dt_3.Rows.Count > 0 Then
                        New_Val_3 = Dt_3.Rows(0).Item(0).ToString.Trim
                        '  MsgBox(New_Val_3)
                        Return New_Val_3


                    End If
                    '*************************

                End If
                '*************************

            Else
                Return 0
            End If




        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Function
    Public Function Insert_(ByVal Table_Name_ As Object, ByVal CoLUMN_Name_ As Object, ByVal CoLUMN_Values_ As Object) As Object
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim Sql_ As Object = New String("insert into " & Table_Name_ & " (" & CoLUMN_Name_ & ") Values(" & CoLUMN_Values_ & ") ")
            Dim Cmd_ As New OleDbCommand
            Cmd_.CommandText = Sql_
            Cmd_.Connection = Conn
            Cmd_.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Update_(ByVal Table_Name_ As Object, ByVal CoLUMN_Name_ As Object, ByVal Conditions_ As Object) As Object
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim Sql_ As Object = New String("UPDATE " & Table_Name_ & " set " & CoLUMN_Name_ & " where " & Conditions_ & "")
            Dim Cmd_ As New OleDbCommand
            Cmd_.CommandText = Sql_
            Cmd_.Connection = Conn
            Cmd_.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Delete__(ByVal Table_Name_ As Object, ByVal Conditions_ As Object) As Object
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim Sql_ = "DELETE  FROM " & Table_Name_ & " WHERE " & Conditions_ & ""
            Dim Cmd_ As New OleDbCommand
            Cmd_.CommandText = Sql_
            Cmd_.Connection = Conn
            Cmd_.ExecuteNonQuery()

            MsgBox("تمت عملية الحذف بنجاح", MsgBoxStyle.Information, "ستار سوفت")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Sub Fill_Cmb_(ByVal Cmb_Name_ As ComboBox, ByVal Table_Name As Object, ByVal Value_Member As Object, ByVal Display_Memeber As Object, ByVal Conditions_ As Object)
        On Error Resume Next
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Dim Sql_ As Object = New String("SELECT " & Value_Member & " , " & Display_Memeber & " FROM " & Table_Name & " where " & Conditions_ & "")
        Dim Da_ As New OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)


        Cmb_Name_.DataSource = Dt_
        Cmb_Name_.ValueMember = Value_Member
        Cmb_Name_.DisplayMember = Display_Memeber



    End Sub
    Public Sub Fill_LB_(ByVal LB_Name_ As ListBox, ByVal Table_Name As Object, ByVal Value_Member As Object, ByVal Display_Memeber As Object, ByVal Conditions_ As Object)
        On Error Resume Next
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Dim Sql_ As Object = New String("SELECT " & Value_Member & " , " & Display_Memeber & " FROM " & Table_Name & " where " & Conditions_ & "")
        Dim Da_ As New OleDbDataAdapter
        Da_ = New OleDbDataAdapter(Sql_, Conn)
        Dim Dt_ As New DataTable
        Da_.Fill(Dt_)


        LB_Name_.DataSource = Dt_
        LB_Name_.ValueMember = Value_Member
        LB_Name_.DisplayMember = Display_Memeber



    End Sub
    Public Function Get_Sum(ByVal Table_Name_ As Object, ByVal CoLUMN_Name_ As Object, ByVal Conditions_ As Object) As Object
        Try
            If Not Conn.State = ConnectionState.Open Then
                Conn.Open()
            End If
            Dim Sql_ As Object = New String("SELECT SUM(" & CoLUMN_Name_ & ") FROM " & Table_Name_ & " where " & Conditions_ & " ")
            Dim Da_ As OleDbDataAdapter
            Da_ = New OleDbDataAdapter(Sql_, Conn)
            Dim Dt_ As New DataTable
            Da_.Fill(Dt_)
            Dim Sum_Val_ As Object
            If Dt_.Rows.Count > 0 Then
                Sum_Val_ = Dt_.Rows(0).Item(0).ToString
                Return Sum_Val_
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
#Region "Check Box DataMamping "
    Class [MyClass]
        Private m_yesno As String
        Public Property YesNo() As String
            Get
                Return m_yesno
            End Get
            Set(ByVal value As String)
                m_yesno = value
            End Set
        End Property
    End Class
    Public Sub b_Format(ByVal sender As Object, ByVal e As ConvertEventArgs)
        Dim b As Binding = TryCast(sender, Binding)
        Dim chk As CheckBox = TryCast(b.Control, CheckBox)
        If e.Value.Equals("1") Then
            chk.Checked = True
        Else
            chk.Checked = False

        End If
    End Sub
#End Region
#End Region
End Module
