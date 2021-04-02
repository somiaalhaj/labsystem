<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Buy_Bill
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Text_Buy_Bill_Date = New System.Windows.Forms.DateTimePicker()
        Me.Text_Sal_Bill_NO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Text_Mord_Name = New System.Windows.Forms.TextBox()
        Me.Text_Mord_No = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_Buy_Bill_No = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Radio_Bill_H = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Text_Cate_Name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Text_Price_Unit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Text_Total_Price = New System.Windows.Forms.TextBox()
        Me.Text_Quantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Text_Cate_No = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Text_Remanent = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Text_Feof = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Radio_Bill_D = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cate_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cate_No_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Text_Total = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Text_Buy_Bill_Date)
        Me.GroupBox1.Controls.Add(Me.Text_Sal_Bill_NO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Text_Mord_Name)
        Me.GroupBox1.Controls.Add(Me.Text_Mord_No)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Text_Buy_Bill_No)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(591, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 212)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 26)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Text_Buy_Bill_Date
        '
        Me.Text_Buy_Bill_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Text_Buy_Bill_Date.Location = New System.Drawing.Point(123, 25)
        Me.Text_Buy_Bill_Date.Name = "Text_Buy_Bill_Date"
        Me.Text_Buy_Bill_Date.Size = New System.Drawing.Size(127, 26)
        Me.Text_Buy_Bill_Date.TabIndex = 17
        '
        'Text_Sal_Bill_NO
        '
        Me.Text_Sal_Bill_NO.Location = New System.Drawing.Point(359, 150)
        Me.Text_Sal_Bill_NO.Name = "Text_Sal_Bill_NO"
        Me.Text_Sal_Bill_NO.Size = New System.Drawing.Size(101, 26)
        Me.Text_Sal_Bill_NO.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "رقم الفاتورة المورد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = " تاريخ الفاتورة"
        '
        'Text_Mord_Name
        '
        Me.Text_Mord_Name.Location = New System.Drawing.Point(123, 91)
        Me.Text_Mord_Name.Name = "Text_Mord_Name"
        Me.Text_Mord_Name.ReadOnly = True
        Me.Text_Mord_Name.Size = New System.Drawing.Size(240, 26)
        Me.Text_Mord_Name.TabIndex = 13
        '
        'Text_Mord_No
        '
        Me.Text_Mord_No.Location = New System.Drawing.Point(369, 91)
        Me.Text_Mord_No.Name = "Text_Mord_No"
        Me.Text_Mord_No.ReadOnly = True
        Me.Text_Mord_No.Size = New System.Drawing.Size(100, 26)
        Me.Text_Mord_No.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(535, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = " المورد"
        '
        'Text_Buy_Bill_No
        '
        Me.Text_Buy_Bill_No.Location = New System.Drawing.Point(368, 28)
        Me.Text_Buy_Bill_No.Name = "Text_Buy_Bill_No"
        Me.Text_Buy_Bill_No.ReadOnly = True
        Me.Text_Buy_Bill_No.Size = New System.Drawing.Size(100, 26)
        Me.Text_Buy_Bill_No.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(506, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = " رقم الفاتورة"
        '
        'Radio_Bill_H
        '
        Me.Radio_Bill_H.AutoSize = True
        Me.Radio_Bill_H.ForeColor = System.Drawing.Color.Red
        Me.Radio_Bill_H.Location = New System.Drawing.Point(1075, 36)
        Me.Radio_Bill_H.Name = "Radio_Bill_H"
        Me.Radio_Bill_H.Size = New System.Drawing.Size(102, 24)
        Me.Radio_Bill_H.TabIndex = 23
        Me.Radio_Bill_H.TabStop = True
        Me.Radio_Bill_H.Text = "بيانات الفاتورة"
        Me.Radio_Bill_H.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Text_Cate_Name)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Text_Price_Unit)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Text_Total_Price)
        Me.GroupBox2.Controls.Add(Me.Text_Quantity)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Text_Cate_No)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 212)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 26)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Text_Cate_Name
        '
        Me.Text_Cate_Name.Location = New System.Drawing.Point(145, 53)
        Me.Text_Cate_Name.Name = "Text_Cate_Name"
        Me.Text_Cate_Name.ReadOnly = True
        Me.Text_Cate_Name.Size = New System.Drawing.Size(210, 26)
        Me.Text_Cate_Name.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = " الاجمالي"
        '
        'Text_Price_Unit
        '
        Me.Text_Price_Unit.Location = New System.Drawing.Point(363, 120)
        Me.Text_Price_Unit.Name = "Text_Price_Unit"
        Me.Text_Price_Unit.Size = New System.Drawing.Size(100, 26)
        Me.Text_Price_Unit.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(494, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = " سعر الوحدة"
        '
        'Text_Total_Price
        '
        Me.Text_Total_Price.Location = New System.Drawing.Point(15, 120)
        Me.Text_Total_Price.Name = "Text_Total_Price"
        Me.Text_Total_Price.ReadOnly = True
        Me.Text_Total_Price.Size = New System.Drawing.Size(99, 26)
        Me.Text_Total_Price.TabIndex = 13
        '
        'Text_Quantity
        '
        Me.Text_Quantity.Location = New System.Drawing.Point(199, 120)
        Me.Text_Quantity.Name = "Text_Quantity"
        Me.Text_Quantity.Size = New System.Drawing.Size(100, 26)
        Me.Text_Quantity.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = " الكمية"
        '
        'Text_Cate_No
        '
        Me.Text_Cate_No.Location = New System.Drawing.Point(361, 53)
        Me.Text_Cate_No.Name = "Text_Cate_No"
        Me.Text_Cate_No.ReadOnly = True
        Me.Text_Cate_No.Size = New System.Drawing.Size(100, 26)
        Me.Text_Cate_No.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(494, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = " رقم الصنف"
        '
        'Text_Remanent
        '
        Me.Text_Remanent.Location = New System.Drawing.Point(78, 420)
        Me.Text_Remanent.Name = "Text_Remanent"
        Me.Text_Remanent.ReadOnly = True
        Me.Text_Remanent.Size = New System.Drawing.Size(101, 26)
        Me.Text_Remanent.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(224, 420)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "المبلغ المتبقي"
        '
        'Text_Feof
        '
        Me.Text_Feof.Location = New System.Drawing.Point(81, 371)
        Me.Text_Feof.Name = "Text_Feof"
        Me.Text_Feof.Size = New System.Drawing.Size(101, 26)
        Me.Text_Feof.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "المبلغ المدفوع"
        '
        'Radio_Bill_D
        '
        Me.Radio_Bill_D.AutoSize = True
        Me.Radio_Bill_D.ForeColor = System.Drawing.Color.Red
        Me.Radio_Bill_D.Location = New System.Drawing.Point(475, 37)
        Me.Radio_Bill_D.Name = "Radio_Bill_D"
        Me.Radio_Bill_D.Size = New System.Drawing.Size(110, 24)
        Me.Radio_Bill_D.TabIndex = 20
        Me.Radio_Bill_D.TabStop = True
        Me.Radio_Bill_D.Text = "تفاصيل الفاتورة"
        Me.Radio_Bill_D.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(330, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(754, 259)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "اصناف الفاتورة"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cate_No, Me.Cate_No_Name, Me.Price_Unit, Me.Quantity, Me.Total_Price})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(683, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'Cate_No
        '
        Me.Cate_No.DataPropertyName = "Cate_No"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cate_No.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cate_No.HeaderText = "رقم الصنف"
        Me.Cate_No.Name = "Cate_No"
        Me.Cate_No.ReadOnly = True
        Me.Cate_No.Width = 110
        '
        'Cate_No_Name
        '
        Me.Cate_No_Name.DataPropertyName = "Cate_No_Name"
        Me.Cate_No_Name.HeaderText = "اسم الصنف"
        Me.Cate_No_Name.Name = "Cate_No_Name"
        Me.Cate_No_Name.ReadOnly = True
        Me.Cate_No_Name.Width = 200
        '
        'Price_Unit
        '
        Me.Price_Unit.DataPropertyName = "Price_Unit"
        Me.Price_Unit.HeaderText = "سعر الوحدة"
        Me.Price_Unit.Name = "Price_Unit"
        Me.Price_Unit.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.HeaderText = "الكمية"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Total_Price
        '
        Me.Total_Price.DataPropertyName = "Total_Price"
        Me.Total_Price.HeaderText = "الاجمالي"
        Me.Total_Price.Name = "Total_Price"
        Me.Total_Price.ReadOnly = True
        Me.Total_Price.Width = 130
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Text_Total)
        Me.GroupBox4.Controls.Add(Me.Radio_Bill_H)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.Text_Remanent)
        Me.GroupBox4.Controls.Add(Me.Radio_Bill_D)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Text_Feof)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1189, 539)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(211, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "اجمالي الفاتورة"
        '
        'Text_Total
        '
        Me.Text_Total.Location = New System.Drawing.Point(81, 326)
        Me.Text_Total.Name = "Text_Total"
        Me.Text_Total.ReadOnly = True
        Me.Text_Total.Size = New System.Drawing.Size(101, 26)
        Me.Text_Total.TabIndex = 25
        '
        'Frm_Buy_Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 706)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "Frm_Buy_Bill"
        Me.Text = "فاتورة شراء"
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Text_Buy_Bill_No As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Text_Buy_Bill_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Text_Sal_Bill_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Text_Mord_Name As System.Windows.Forms.TextBox
    Friend WithEvents Text_Mord_No As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Text_Cate_Name As System.Windows.Forms.TextBox
    Friend WithEvents Text_Remanent As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Text_Price_Unit As System.Windows.Forms.TextBox
    Friend WithEvents Text_Feof As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Text_Total_Price As System.Windows.Forms.TextBox
    Friend WithEvents Text_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Text_Cate_No As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Radio_Bill_H As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_Bill_D As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Cate_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cate_No_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Text_Total As System.Windows.Forms.TextBox
End Class
