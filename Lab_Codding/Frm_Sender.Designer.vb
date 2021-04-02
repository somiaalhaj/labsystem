<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Sender
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Text_Email = New System.Windows.Forms.TextBox()
        Me.Text_Adress = New System.Windows.Forms.TextBox()
        Me.Text_phon_no = New System.Windows.Forms.TextBox()
        Me.Text_Sender_Name = New System.Windows.Forms.TextBox()
        Me.Text_Sender_No = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Text_Email)
        Me.GroupBox1.Controls.Add(Me.Text_Adress)
        Me.GroupBox1.Controls.Add(Me.Text_phon_no)
        Me.GroupBox1.Controls.Add(Me.Text_Sender_Name)
        Me.GroupBox1.Controls.Add(Me.Text_Sender_No)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(901, 374)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الجهة المرسلة"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(369, 295)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(58, 24)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "ايقاف"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Text_Email
        '
        Me.Text_Email.Location = New System.Drawing.Point(493, 211)
        Me.Text_Email.Name = "Text_Email"
        Me.Text_Email.Size = New System.Drawing.Size(242, 26)
        Me.Text_Email.TabIndex = 9
        '
        'Text_Adress
        '
        Me.Text_Adress.Location = New System.Drawing.Point(61, 205)
        Me.Text_Adress.Name = "Text_Adress"
        Me.Text_Adress.Size = New System.Drawing.Size(242, 26)
        Me.Text_Adress.TabIndex = 8
        '
        'Text_phon_no
        '
        Me.Text_phon_no.Location = New System.Drawing.Point(61, 134)
        Me.Text_phon_no.Name = "Text_phon_no"
        Me.Text_phon_no.Size = New System.Drawing.Size(242, 26)
        Me.Text_phon_no.TabIndex = 7
        '
        'Text_Sender_Name
        '
        Me.Text_Sender_Name.Location = New System.Drawing.Point(493, 132)
        Me.Text_Sender_Name.Name = "Text_Sender_Name"
        Me.Text_Sender_Name.Size = New System.Drawing.Size(242, 26)
        Me.Text_Sender_Name.TabIndex = 6
        '
        'Text_Sender_No
        '
        Me.Text_Sender_No.Location = New System.Drawing.Point(635, 59)
        Me.Text_Sender_No.Name = "Text_Sender_No"
        Me.Text_Sender_No.ReadOnly = True
        Me.Text_Sender_No.Size = New System.Drawing.Size(100, 26)
        Me.Text_Sender_No.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(772, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "البريد الالكتروني"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "العنوان"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "رقم الهاتف"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(765, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "اسم الجهة المرسلة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(809, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "رقم الجهة"
        '
        'Frm_Sender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Sender"
        Me.Text = "ترميز الجهات المرسلة"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Text_Email As System.Windows.Forms.TextBox
    Friend WithEvents Text_Adress As System.Windows.Forms.TextBox
    Friend WithEvents Text_phon_no As System.Windows.Forms.TextBox
    Friend WithEvents Text_Sender_Name As System.Windows.Forms.TextBox
    Friend WithEvents Text_Sender_No As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
