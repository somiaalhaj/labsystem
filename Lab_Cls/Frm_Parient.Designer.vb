<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Parient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_New = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Save = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Edit = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Delete = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Cancel = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Search = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Print = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Exit = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Last = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Next = New System.Windows.Forms.ToolStripButton()
        Me.Red_Count = New System.Windows.Forms.ToolStripTextBox()
        Me.Btn_PREVIOUS = New System.Windows.Forms.ToolStripButton()
        Me.Btn_First = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.Lab_System.My.Resources.Resources.menus
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_New, Me.Btn_Save, Me.Btn_Edit, Me.Btn_Delete, Me.Btn_Cancel, Me.Btn_Search, Me.Btn_Print, Me.Btn_Exit, Me.Btn_Last, Me.Btn_Next, Me.Red_Count, Me.Btn_PREVIOUS, Me.Btn_First, Me.ToolStripTextBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1109, 96)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btn_New
        '
        Me.Btn_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_New.Image = Global.Lab_System.My.Resources.Resources._new
        Me.Btn_New.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(93, 93)
        Me.Btn_New.Text = "سجل جديد"
        '
        'Btn_Save
        '
        Me.Btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Save.Image = Global.Lab_System.My.Resources.Resources.save
        Me.Btn_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(93, 93)
        Me.Btn_Save.Text = "الحفظ"
        '
        'Btn_Edit
        '
        Me.Btn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Edit.Image = Global.Lab_System.My.Resources.Resources.edit
        Me.Btn_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(93, 93)
        Me.Btn_Edit.Text = "تعديل"
        '
        'Btn_Delete
        '
        Me.Btn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Delete.Image = Global.Lab_System.My.Resources.Resources.delete
        Me.Btn_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(93, 93)
        Me.Btn_Delete.Text = "حذف"
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Cancel.Image = Global.Lab_System.My.Resources.Resources.prev
        Me.Btn_Cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(93, 93)
        Me.Btn_Cancel.Text = "تراجع"
        '
        'Btn_Search
        '
        Me.Btn_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Search.Image = Global.Lab_System.My.Resources.Resources.search
        Me.Btn_Search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(93, 93)
        Me.Btn_Search.Text = "بحث"
        '
        'Btn_Print
        '
        Me.Btn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Print.Image = Global.Lab_System.My.Resources.Resources.print
        Me.Btn_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.Size = New System.Drawing.Size(93, 93)
        Me.Btn_Print.Text = "طباعة"
        '
        'Btn_Exit
        '
        Me.Btn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Exit.Image = Global.Lab_System.My.Resources.Resources.exit1
        Me.Btn_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(93, 93)
        Me.Btn_Exit.Text = "خروج"
        '
        'Btn_Last
        '
        Me.Btn_Last.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_Last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Last.Image = Global.Lab_System.My.Resources.Resources.Actions_go_first_view_icon
        Me.Btn_Last.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Last.Name = "Btn_Last"
        Me.Btn_Last.Size = New System.Drawing.Size(23, 93)
        Me.Btn_Last.Text = "السجل الأخير"
        '
        'Btn_Next
        '
        Me.Btn_Next.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Next.Image = Global.Lab_System.My.Resources.Resources.Actions_go_previous_icon
        Me.Btn_Next.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(23, 93)
        Me.Btn_Next.Text = "السجل التالي"
        '
        'Red_Count
        '
        Me.Red_Count.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Red_Count.Name = "Red_Count"
        Me.Red_Count.ReadOnly = True
        Me.Red_Count.Size = New System.Drawing.Size(60, 96)
        '
        'Btn_PREVIOUS
        '
        Me.Btn_PREVIOUS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_PREVIOUS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_PREVIOUS.Image = Global.Lab_System.My.Resources.Resources.Actions_go_next_icon
        Me.Btn_PREVIOUS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_PREVIOUS.Name = "Btn_PREVIOUS"
        Me.Btn_PREVIOUS.Size = New System.Drawing.Size(23, 93)
        Me.Btn_PREVIOUS.Text = "السجل السابق"
        '
        'Btn_First
        '
        Me.Btn_First.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_First.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_First.Image = Global.Lab_System.My.Resources.Resources.Actions_go_last_view_icon
        Me.Btn_First.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_First.Name = "Btn_First"
        Me.Btn_First.Size = New System.Drawing.Size(23, 93)
        Me.Btn_First.Text = "السجل الأول"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(120, 96)
        '
        'Frm_Parient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lab_System.My.Resources.Resources.parent_frm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1109, 595)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Parient"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Btn_New As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_Edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_Cancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_Search As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_Print As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_Exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_Last As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_Next As System.Windows.Forms.ToolStripButton
    Friend WithEvents Red_Count As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Btn_PREVIOUS As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_First As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
End Class
