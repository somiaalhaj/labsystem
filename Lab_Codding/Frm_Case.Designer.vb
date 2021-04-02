<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Case
    Inherits Frm_Parient

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Chk_ACTIVE = New System.Windows.Forms.CheckBox()
        Me.Text_Case_Name = New System.Windows.Forms.TextBox()
        Me.Text_Case_No = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chk_ACTIVE)
        Me.GroupBox1.Controls.Add(Me.Text_Case_Name)
        Me.GroupBox1.Controls.Add(Me.Text_Case_No)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 374)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الحالة الاجتماعية"
        '
        'Chk_ACTIVE
        '
        Me.Chk_ACTIVE.AutoSize = True
        Me.Chk_ACTIVE.ForeColor = System.Drawing.Color.Red
        Me.Chk_ACTIVE.Location = New System.Drawing.Point(411, 278)
        Me.Chk_ACTIVE.Name = "Chk_ACTIVE"
        Me.Chk_ACTIVE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Chk_ACTIVE.Size = New System.Drawing.Size(58, 24)
        Me.Chk_ACTIVE.TabIndex = 10
        Me.Chk_ACTIVE.Text = "ايقاف"
        Me.Chk_ACTIVE.UseVisualStyleBackColor = True
        '
        'Text_Case_Name
        '
        Me.Text_Case_Name.Location = New System.Drawing.Point(450, 179)
        Me.Text_Case_Name.Name = "Text_Case_Name"
        Me.Text_Case_Name.Size = New System.Drawing.Size(242, 26)
        Me.Text_Case_Name.TabIndex = 6
        '
        'Text_Case_No
        '
        Me.Text_Case_No.Location = New System.Drawing.Point(592, 106)
        Me.Text_Case_No.Name = "Text_Case_No"
        Me.Text_Case_No.ReadOnly = True
        Me.Text_Case_No.Size = New System.Drawing.Size(100, 26)
        Me.Text_Case_No.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(757, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "اسم الحالة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(758, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = " رقم الحالة"
        '
        'Frm_Case
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Case"
        Me.Text = "ترميز الحالات الاجتماعية"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_ACTIVE As System.Windows.Forms.CheckBox
    Friend WithEvents Text_Case_Name As System.Windows.Forms.TextBox
    Friend WithEvents Text_Case_No As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
