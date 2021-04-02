Imports System.Data.OleDb

Public Class Frm_Login
    Dim iCount As Integer
    Dim goingup As Boolean
    Private Sub But_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_exit.Click
        Try
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub But_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Log.Click

        Try
            Try
                If Not Conn.State = ConnectionState.Open Then
                    Conn.Open()
                End If
                G_user_name = Me.txtUsername.Text
                Dim strPassword As String = Me.txtPassword.Text
                If G_user_name = "" Or strPassword = "" Then
                    MessageBox.Show("قم بإدخال أسم المستخدم و كلمة المرور للدخول إلى النظام !", "معلومات ناقصة")
                    Me.txtUsername.Focus()
                    Return
                End If
                Dim strsql As String = "SELECT  USER_NAME,USER_PASS ,USER_NO FROM USER_ WHERE USER_NAME='" & G_user_name & "' "
                Dim cm As New OleDbCommand(strsql, Conn)
                Dim dr As OleDbDataReader
                Dim valid As Boolean = False
                Dim HasRows As Boolean = False
                Try
                    cm.Connection = Conn
                    dr = cm.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            If strPassword = dr.Item("USER_PASS") Then
                                G_user_no = dr.Item("USER_NO")
                                valid = True
                            End If
                        End While
                        HasRows = True
                    End If
                    dr.Close()
                Catch exO As OleDb.OleDbException
                    ' MsgBox(exO.Message)
                Catch ex As Exception

                Finally
                    cm = Nothing
                    dr = Nothing
                    GC.Collect()
                End Try

                iCount = iCount + 1
                If valid = True Then
                    goingup = True
                    Dim NEWFRM As New Frm_Main
                    Me.Hide()
                    NEWFRM.ShowDialog()

                ElseIf iCount = 3 Then
                    MessageBox.Show("لقد قمت بإدخال كلمة مرور خاطئة ثلاث مرات " & vbNewLine & vbNewLine & _
                                     "سيتم إيقاف النظام", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    End
                ElseIf HasRows = False Then
                    MessageBox.Show("لقد أدخلت أسم مستخدم أو كلمة مرور خاطئة " & vbNewLine & vbNewLine & _
                                    "تأكد من أسم المستخدم او كلمة المرور", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    Me.txtUsername.Focus()
                    Me.txtUsername.Text = ""
                    Me.txtPassword.Text = ""
                Else
                    MessageBox.Show("كلمة مرور خاطئة " & vbNewLine & vbNewLine & _
                                  "تأكد من كلمة المرور", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    Me.txtPassword.Focus()
                    Me.txtPassword.Text = ""
                End If
            Catch exp As Exception
                MsgBox("هناك خطاء قد حصل , يرجى أعادة تشغيل النظام", MsgBoxStyle.OkOnly, "تنبية")
            End Try


        Catch ex As Exception

        End Try

        
    End Sub

    Private Sub Frm_Login_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class