Imports System.Windows.Forms

Public Class Frm_Main

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

   

    

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub Frm_Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.AnalogClock1.Parent = Me.SplitContainer1.Panel2
            Me.AnalogClock1.BackColor = Color.Transparent
            Me.Txt_User_Name1.Text = "المستخدم الحالي" & Space(2) & "/" & Space(2) & G_user_name

        Catch ex As Exception

        End Try
    End Sub

    

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Me.AnalogClock1.Time = Now
        Catch ex As Exception


        End Try
    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click
        Try
            Dim New_Frm_ As New Frm_Patients


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        Try
            Dim New_Frm_ As New Frm_Employee


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem23.Click
        Try
            Dim New_Frm_ As New Frm_Checkups


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        Try
            Dim New_Frm_ As New Frm_Antibiotics


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        Try
            Dim New_Frm_ As New Frm_Categories


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Try
            Dim New_Frm_ As New Frm_Mordeen


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Try
            Dim New_Frm_ As New Frm_Sender


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim New_Frm_ As New Frm_Case


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim New_Frm_ As New Frm_Religion


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        Try
            Dim New_Frm_ As New Frm_Users


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Try
            Dim New_Frm_ As New Frm_Buy_Bill


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Try
            Dim New_Frm_ As New Frm_Lab_Supplies


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Try
            Dim New_Frm_ As New Frm_Stockroom


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Try
            Dim New_Frm_ As New Frm_Checkup_Order


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Try
            Dim New_Frm_ As New Frm_Checkup_Procedure


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Try
            Dim New_Frm_ As New Frm_Open_Deciphered


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub تقريرالحالاتالاجتماعيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تقريرالحالاتالاجتماعيةToolStripMenuItem.Click
        Try
            Dim New_Frm_ As New Frm_Report


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub صرفرواتبالموظفينToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles صرفرواتبالموظفينToolStripMenuItem.Click
        Try
            Dim New_Frm_ As New Frm_Salary


            New_Frm_.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub
End Class
