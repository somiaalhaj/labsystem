<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Perpetuity
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
        Me.Comb_Timing = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Text_Scramming_Time = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Text_Attending_Time = New System.Windows.Forms.TextBox()
        Me.Text_Per_No = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Comb_Timing)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Text_Scramming_Time)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Text_Attending_Time)
        Me.GroupBox1.Controls.Add(Me.Text_Per_No)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 374)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "أوقات الدوام"
        '
        'Comb_Timing
        '
        Me.Comb_Timing.FormattingEnabled = True
        Me.Comb_Timing.Location = New System.Drawing.Point(561, 222)
        Me.Comb_Timing.Name = "Comb_Timing"
        Me.Comb_Timing.Size = New System.Drawing.Size(100, 28)
        Me.Comb_Timing.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(726, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "الفترة"
        '
        'Text_Scramming_Time
        '
        Me.Text_Scramming_Time.Location = New System.Drawing.Point(70, 143)
        Me.Text_Scramming_Time.Name = "Text_Scramming_Time"
        Me.Text_Scramming_Time.Size = New System.Drawing.Size(188, 26)
        Me.Text_Scramming_Time.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "وقت الأنصراف"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(419, 286)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(58, 24)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "ايقاف"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Text_Attending_Time
        '
        Me.Text_Attending_Time.Location = New System.Drawing.Point(475, 143)
        Me.Text_Attending_Time.Name = "Text_Attending_Time"
        Me.Text_Attending_Time.Size = New System.Drawing.Size(186, 26)
        Me.Text_Attending_Time.TabIndex = 6
        '
        'Text_Per_No
        '
        Me.Text_Per_No.Location = New System.Drawing.Point(561, 70)
        Me.Text_Per_No.Name = "Text_Per_No"
        Me.Text_Per_No.ReadOnly = True
        Me.Text_Per_No.Size = New System.Drawing.Size(100, 26)
        Me.Text_Per_No.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(726, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "وقت الحضور"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(743, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = " رقم الدوام"
        '
        'Frm_Perpetuity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Perpetuity"
        Me.Text = "أوقات الدوام"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Comb_Timing As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Text_Scramming_Time As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Text_Attending_Time As System.Windows.Forms.TextBox
    Friend WithEvents Text_Per_No As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
