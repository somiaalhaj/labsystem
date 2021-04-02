<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("تهيئة النظام")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("المستخدمين")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("النسخ الاحتياطي والاسترجاع")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("الضبط والتحكم", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميز المرضى", 12, 12)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميز الموظفين", 13, 13)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميز الفحوصات", 14, 14)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميز المضادات", 15, 15)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميز الأصناف")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميز الموردين")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميز أوقات الدوام", 18, 18)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميز الجهات المرسلة", 21, 21)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميزالحالات الاجتماعية", 19, 19)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ترميز الديانات", 20, 20)
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ملف الترميزات", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("فاتورة شراء", 23, 23)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("مستلزمات المختبر", 24, 24)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("طلب فحص", 25, 25)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("اجراء فحص", 26, 26)
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("حساب انتهاء المحاليل المفتوحة", 22, 22)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("صرف رواتب الموظفين", 29, 29)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ملف العمليات", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("نموذج التقارير", 28, 28)
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ملف التقارير", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ملف المساعدة", 4, 4)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ملفالعملياتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.فاتورةشراءToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مستلزماتالمختبرToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.المخازنToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.طلبفحصToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اجراءفحصToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حسابانتهاءالمحاليلالمفتوحةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ملفالتقاريرToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ملفالمساعدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.خروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Txt_User_Name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AnalogClock1 = New AnalogClock.AnalogClock()
        Me.TV_Lab_System = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Txt_User_Name1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.صرفرواتبالموظفينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.تقريرالحالاتالاجتماعيةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.الضبطوالتحكمToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تهيئةالنظامToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.المستخدمينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.النسخالاحتياطيوالأسترجاعToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ملفالترميزاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Patients = New System.Windows.Forms.ToolStripMenuItem()
        Me.Employee = New System.Windows.Forms.ToolStripMenuItem()
        Me.Checkups = New System.Windows.Forms.ToolStripMenuItem()
        Me.Antibiotics = New System.Windows.Forms.ToolStripMenuItem()
        Me.Categories = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mordeen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sender = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cases = New System.Windows.Forms.ToolStripMenuItem()
        Me.Religions = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ملفالعملياتToolStripMenuItem
        '
        Me.ملفالعملياتToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ملفالعملياتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ملفالعملياتToolStripMenuItem.Name = "ملفالعملياتToolStripMenuItem"
        Me.ملفالعملياتToolStripMenuItem.Size = New System.Drawing.Size(178, 93)
        Me.ملفالعملياتToolStripMenuItem.Text = "ملف العمليات"
        '
        'فاتورةشراءToolStripMenuItem
        '
        Me.فاتورةشراءToolStripMenuItem.Name = "فاتورةشراءToolStripMenuItem"
        Me.فاتورةشراءToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.فاتورةشراءToolStripMenuItem.Text = "فاتورة شراء"
        '
        'مستلزماتالمختبرToolStripMenuItem
        '
        Me.مستلزماتالمختبرToolStripMenuItem.Name = "مستلزماتالمختبرToolStripMenuItem"
        Me.مستلزماتالمختبرToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.مستلزماتالمختبرToolStripMenuItem.Text = "مستلزمات المختبر"
        '
        'المخازنToolStripMenuItem
        '
        Me.المخازنToolStripMenuItem.Name = "المخازنToolStripMenuItem"
        Me.المخازنToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.المخازنToolStripMenuItem.Text = "المخازن"
        '
        'طلبفحصToolStripMenuItem
        '
        Me.طلبفحصToolStripMenuItem.Name = "طلبفحصToolStripMenuItem"
        Me.طلبفحصToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.طلبفحصToolStripMenuItem.Text = "طلب فحص"
        '
        'اجراءفحصToolStripMenuItem
        '
        Me.اجراءفحصToolStripMenuItem.Name = "اجراءفحصToolStripMenuItem"
        Me.اجراءفحصToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.اجراءفحصToolStripMenuItem.Text = "اجراء فحص"
        '
        'حسابانتهاءالمحاليلالمفتوحةToolStripMenuItem
        '
        Me.حسابانتهاءالمحاليلالمفتوحةToolStripMenuItem.Name = "حسابانتهاءالمحاليلالمفتوحةToolStripMenuItem"
        Me.حسابانتهاءالمحاليلالمفتوحةToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.حسابانتهاءالمحاليلالمفتوحةToolStripMenuItem.Text = "حساب انتهاء المحاليل المفتوحة"
        '
        'ملفالتقاريرToolStripMenuItem
        '
        Me.ملفالتقاريرToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ملفالتقاريرToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ملفالتقاريرToolStripMenuItem.Name = "ملفالتقاريرToolStripMenuItem"
        Me.ملفالتقاريرToolStripMenuItem.Size = New System.Drawing.Size(177, 93)
        Me.ملفالتقاريرToolStripMenuItem.Text = "ملف التقارير"
        '
        'ملفالمساعدةToolStripMenuItem
        '
        Me.ملفالمساعدةToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ملفالمساعدةToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ملفالمساعدةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ملفالمساعدةToolStripMenuItem.Name = "ملفالمساعدةToolStripMenuItem"
        Me.ملفالمساعدةToolStripMenuItem.Size = New System.Drawing.Size(183, 93)
        Me.ملفالمساعدةToolStripMenuItem.Text = "ملف المساعدة"
        '
        'خروجToolStripMenuItem
        '
        Me.خروجToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.خروجToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem"
        Me.خروجToolStripMenuItem.Size = New System.Drawing.Size(195, 93)
        Me.خروجToolStripMenuItem.Text = "خروج من النظام"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(146, 17)
        Me.ToolStripStatusLabel.Text = "حقوق البرنامج محفوظة للمبرمج"
        '
        'Txt_User_Name
        '
        Me.Txt_User_Name.Name = "Txt_User_Name"
        Me.Txt_User_Name.Size = New System.Drawing.Size(67, 17)
        Me.Txt_User_Name.Text = "User_Name"
        '
        'AnalogClock1
        '
        Me.AnalogClock1.DrawHourHand = True
        Me.AnalogClock1.DrawHourHandShadow = True
        Me.AnalogClock1.DrawMinuteHand = True
        Me.AnalogClock1.DrawMinuteHandShadow = True
        Me.AnalogClock1.DrawSecondHand = True
        Me.AnalogClock1.DropShadowColor = System.Drawing.Color.Black
        Me.AnalogClock1.DropShadowOffset = New System.Drawing.Point(0, 0)
        Me.AnalogClock1.FaceColorHigh = System.Drawing.Color.RoyalBlue
        Me.AnalogClock1.FaceColorLow = System.Drawing.Color.SkyBlue
        Me.AnalogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.AnalogClock1.FaceImage = Nothing
        Me.AnalogClock1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogClock1.HourHandColor = System.Drawing.Color.Gainsboro
        Me.AnalogClock1.HourHandDropShadowColor = System.Drawing.Color.Gray
        Me.AnalogClock1.Location = New System.Drawing.Point(830, 3)
        Me.AnalogClock1.MinuteHandColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogClock1.MinuteHandDropShadowColor = System.Drawing.Color.Gray
        Me.AnalogClock1.MinuteHandTickStyle = AnalogClock.TickStyle.Normal
        Me.AnalogClock1.Name = "AnalogClock1"
        Me.AnalogClock1.NumeralColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogClock1.RimColorHigh = System.Drawing.Color.RoyalBlue
        Me.AnalogClock1.RimColorLow = System.Drawing.Color.SkyBlue
        Me.AnalogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.AnalogClock1.SecondHandColor = System.Drawing.Color.Tomato
        Me.AnalogClock1.SecondHandDropShadowColor = System.Drawing.Color.Gray
        Me.AnalogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.AnalogClock1.SecondHandTickStyle = AnalogClock.TickStyle.Normal
        Me.AnalogClock1.Size = New System.Drawing.Size(175, 175)
        Me.AnalogClock1.TabIndex = 0
        Me.AnalogClock1.Time = New Date(CType(0, Long))
        '
        'TV_Lab_System
        '
        Me.TV_Lab_System.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TV_Lab_System.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TV_Lab_System.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TV_Lab_System.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TV_Lab_System.ImageIndex = 0
        Me.TV_Lab_System.ImageList = Me.ImageList1
        Me.TV_Lab_System.Indent = 40
        Me.TV_Lab_System.ItemHeight = 58
        Me.TV_Lab_System.Location = New System.Drawing.Point(0, 0)
        Me.TV_Lab_System.Name = "TV_Lab_System"
        TreeNode1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        TreeNode1.ImageKey = "3.png"
        TreeNode1.Name = "Node8"
        TreeNode1.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode1.SelectedImageIndex = 11
        TreeNode1.Text = "تهيئة النظام"
        TreeNode2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        TreeNode2.ImageIndex = 9
        TreeNode2.Name = "Node11"
        TreeNode2.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode2.SelectedImageKey = "1.png"
        TreeNode2.Text = "المستخدمين"
        TreeNode3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        TreeNode3.ImageKey = "2.png"
        TreeNode3.Name = "Node12"
        TreeNode3.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode3.SelectedImageKey = "2.png"
        TreeNode3.Text = "النسخ الاحتياطي والاسترجاع"
        TreeNode4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        TreeNode4.ImageIndex = 0
        TreeNode4.Name = "Node0"
        TreeNode4.NodeFont = New System.Drawing.Font("Segoe UI", 13.0!)
        TreeNode4.SelectedImageIndex = 0
        TreeNode4.Text = "الضبط والتحكم"
        TreeNode5.ImageIndex = 12
        TreeNode5.Name = "Node13"
        TreeNode5.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode5.SelectedImageIndex = 12
        TreeNode5.Text = "ترميز المرضى"
        TreeNode6.ImageIndex = 13
        TreeNode6.Name = "Node14"
        TreeNode6.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode6.SelectedImageIndex = 13
        TreeNode6.Text = "ترميز الموظفين"
        TreeNode7.ImageIndex = 14
        TreeNode7.Name = "Node16"
        TreeNode7.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode7.SelectedImageIndex = 14
        TreeNode7.Text = "ترميز الفحوصات"
        TreeNode8.ImageIndex = 15
        TreeNode8.Name = "Node0"
        TreeNode8.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode8.SelectedImageIndex = 15
        TreeNode8.Text = "ترميز المضادات"
        TreeNode9.ImageIndex = 16
        TreeNode9.Name = "Node15"
        TreeNode9.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode9.SelectedImageKey = "9.png"
        TreeNode9.Text = "ترميز الأصناف"
        TreeNode10.ImageIndex = 17
        TreeNode10.Name = "Node20"
        TreeNode10.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode10.SelectedImageKey = "11.png"
        TreeNode10.Text = "ترميز الموردين"
        TreeNode11.ImageIndex = 18
        TreeNode11.Name = "Node19"
        TreeNode11.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode11.SelectedImageIndex = 18
        TreeNode11.Text = "ترميز أوقات الدوام"
        TreeNode12.ImageIndex = 21
        TreeNode12.Name = "Node21"
        TreeNode12.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode12.SelectedImageIndex = 21
        TreeNode12.Text = "ترميز الجهات المرسلة"
        TreeNode13.ImageIndex = 19
        TreeNode13.Name = "Node17"
        TreeNode13.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode13.SelectedImageIndex = 19
        TreeNode13.Text = "ترميزالحالات الاجتماعية"
        TreeNode14.ImageIndex = 20
        TreeNode14.Name = "Node18"
        TreeNode14.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode14.SelectedImageIndex = 20
        TreeNode14.Text = "ترميز الديانات"
        TreeNode15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        TreeNode15.ImageIndex = 1
        TreeNode15.Name = "Node1"
        TreeNode15.NodeFont = New System.Drawing.Font("Segoe UI", 13.0!)
        TreeNode15.SelectedImageIndex = 1
        TreeNode15.Text = "ملف الترميزات"
        TreeNode16.ImageIndex = 23
        TreeNode16.Name = "Node22"
        TreeNode16.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode16.SelectedImageIndex = 23
        TreeNode16.Text = "فاتورة شراء"
        TreeNode17.ImageIndex = 24
        TreeNode17.Name = "Node23"
        TreeNode17.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode17.SelectedImageIndex = 24
        TreeNode17.Text = "مستلزمات المختبر"
        TreeNode18.ImageIndex = 25
        TreeNode18.Name = "Node24"
        TreeNode18.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode18.SelectedImageIndex = 25
        TreeNode18.Text = "طلب فحص"
        TreeNode19.ImageIndex = 26
        TreeNode19.Name = "Node25"
        TreeNode19.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode19.SelectedImageIndex = 26
        TreeNode19.Text = "اجراء فحص"
        TreeNode20.ImageIndex = 22
        TreeNode20.Name = "Node2"
        TreeNode20.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode20.SelectedImageIndex = 22
        TreeNode20.Text = "حساب انتهاء المحاليل المفتوحة"
        TreeNode21.ImageIndex = 29
        TreeNode21.Name = "Node1"
        TreeNode21.SelectedImageIndex = 29
        TreeNode21.Text = "صرف رواتب الموظفين"
        TreeNode22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        TreeNode22.ImageIndex = 2
        TreeNode22.Name = "Node2"
        TreeNode22.NodeFont = New System.Drawing.Font("Segoe UI", 13.0!)
        TreeNode22.SelectedImageIndex = 2
        TreeNode22.Text = "ملف العمليات"
        TreeNode23.ImageIndex = 28
        TreeNode23.Name = "Node0"
        TreeNode23.NodeFont = New System.Drawing.Font("Segoe UI", 12.0!)
        TreeNode23.SelectedImageIndex = 28
        TreeNode23.Text = "نموذج التقارير"
        TreeNode24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        TreeNode24.ImageIndex = 3
        TreeNode24.Name = "Node3"
        TreeNode24.NodeFont = New System.Drawing.Font("Segoe UI", 13.0!)
        TreeNode24.SelectedImageIndex = 3
        TreeNode24.Text = "ملف التقارير"
        TreeNode25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        TreeNode25.ImageIndex = 4
        TreeNode25.Name = "Node4"
        TreeNode25.NodeFont = New System.Drawing.Font("Segoe UI", 13.0!)
        TreeNode25.SelectedImageIndex = 4
        TreeNode25.Text = "ملف المساعدة"
        Me.TV_Lab_System.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode15, TreeNode22, TreeNode24, TreeNode25})
        Me.TV_Lab_System.RightToLeftLayout = True
        Me.TV_Lab_System.SelectedImageIndex = 0
        Me.TV_Lab_System.Size = New System.Drawing.Size(328, 573)
        Me.TV_Lab_System.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "seeting1.png")
        Me.ImageList1.Images.SetKeyName(1, "codding1.png")
        Me.ImageList1.Images.SetKeyName(2, "process.png")
        Me.ImageList1.Images.SetKeyName(3, "report.png")
        Me.ImageList1.Images.SetKeyName(4, "help.png")
        Me.ImageList1.Images.SetKeyName(5, "exit.png")
        Me.ImageList1.Images.SetKeyName(6, "b.png")
        Me.ImageList1.Images.SetKeyName(7, "a.png")
        Me.ImageList1.Images.SetKeyName(8, "free-vector-green-menu-icon-set-down-clip-art_117229_Green_Menu_Icon_Set_Down_cli" & _
                "p_art_medium.png")
        Me.ImageList1.Images.SetKeyName(9, "1.png")
        Me.ImageList1.Images.SetKeyName(10, "2.png")
        Me.ImageList1.Images.SetKeyName(11, "3.png")
        Me.ImageList1.Images.SetKeyName(12, "4.png")
        Me.ImageList1.Images.SetKeyName(13, "5.png")
        Me.ImageList1.Images.SetKeyName(14, "7.png")
        Me.ImageList1.Images.SetKeyName(15, "8.png")
        Me.ImageList1.Images.SetKeyName(16, "10.png")
        Me.ImageList1.Images.SetKeyName(17, "11.png")
        Me.ImageList1.Images.SetKeyName(18, "12.png")
        Me.ImageList1.Images.SetKeyName(19, "14.png")
        Me.ImageList1.Images.SetKeyName(20, "15.png")
        Me.ImageList1.Images.SetKeyName(21, "13.png")
        Me.ImageList1.Images.SetKeyName(22, "16.png")
        Me.ImageList1.Images.SetKeyName(23, "17.png")
        Me.ImageList1.Images.SetKeyName(24, "18.png")
        Me.ImageList1.Images.SetKeyName(25, "19.png")
        Me.ImageList1.Images.SetKeyName(26, "20.png")
        Me.ImageList1.Images.SetKeyName(27, "21.png")
        Me.ImageList1.Images.SetKeyName(28, "22.png")
        Me.ImageList1.Images.SetKeyName(29, "23.png")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 97)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImage = Global.Lab_System.My.Resources.Resources.right
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.TV_Lab_System)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.Lab_System.My.Resources.Resources.lab_main1
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.AnalogClock1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1344, 575)
        Me.SplitContainer1.SplitterDistance = 330
        Me.SplitContainer1.TabIndex = 15
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'StatusStrip
        '
        Me.StatusStrip.BackgroundImage = Global.Lab_System.My.Resources.Resources.بدون_عنوان_9
        Me.StatusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.Txt_User_Name1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 672)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1344, 22)
        Me.StatusStrip.TabIndex = 13
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(146, 17)
        Me.ToolStripStatusLabel2.Text = "حقوق البرنامج محفوظة للمبرمج"
        '
        'Txt_User_Name1
        '
        Me.Txt_User_Name1.Name = "Txt_User_Name1"
        Me.Txt_User_Name1.Size = New System.Drawing.Size(67, 17)
        Me.Txt_User_Name1.Text = "User_Name"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackgroundImage = Global.Lab_System.My.Resources.Resources.menus
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem17, Me.ToolStripMenuItem24, Me.ToolStripMenuItem3, Me.ToolStripMenuItem13, Me.ToolStripMenuItem12, Me.ToolStripMenuItem14})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1344, 97)
        Me.MenuStrip2.TabIndex = 14
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem18, Me.ToolStripMenuItem19, Me.ToolStripMenuItem20})
        Me.ToolStripMenuItem17.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripMenuItem17.Image = Global.Lab_System.My.Resources.Resources.seeting1
        Me.ToolStripMenuItem17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(195, 93)
        Me.ToolStripMenuItem17.Text = "الضبط  و التحكم"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(289, 26)
        Me.ToolStripMenuItem18.Text = "تهيئة النظام"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(289, 26)
        Me.ToolStripMenuItem19.Text = "المستخدمين"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(289, 26)
        Me.ToolStripMenuItem20.Text = "النسخ الاحتياطي والإسترجاع"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem22, Me.ToolStripMenuItem21, Me.ToolStripMenuItem23, Me.ToolStripMenuItem16, Me.ToolStripMenuItem15, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.ToolStripMenuItem24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem24.Image = Global.Lab_System.My.Resources.Resources.codding1
        Me.ToolStripMenuItem24.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(189, 93)
        Me.ToolStripMenuItem24.Text = "ملف الترميزات"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem22.Text = "ترميز المرضى"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem21.Text = "ترميز المؤظفين"
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem23.Text = "ترميز الفحوصات"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem16.Text = "ترميز المضادات"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem15.Text = "ترميز الأصناف"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem10.Text = "ترميز الموردين"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem11.Text = "ترميز الجهات المرسلة"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem2.Text = "ترميز الحالات الإجتماعية"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem1.Text = "ترميز الديانات"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.صرفرواتبالموظفينToolStripMenuItem})
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripMenuItem3.Image = Global.Lab_System.My.Resources.Resources.process
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(178, 93)
        Me.ToolStripMenuItem3.Text = "ملف العمليات"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(240, 26)
        Me.ToolStripMenuItem4.Text = "فاتورة شراء"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(240, 26)
        Me.ToolStripMenuItem5.Text = "مستلزمات المختبر"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(240, 26)
        Me.ToolStripMenuItem6.Text = "المخازن"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(240, 26)
        Me.ToolStripMenuItem7.Text = "طلب فحص"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(240, 26)
        Me.ToolStripMenuItem8.Text = "اجراء فحص"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(240, 26)
        Me.ToolStripMenuItem9.Text = "حساب انتهاء المحاليل المفتوحة"
        '
        'صرفرواتبالموظفينToolStripMenuItem
        '
        Me.صرفرواتبالموظفينToolStripMenuItem.Name = "صرفرواتبالموظفينToolStripMenuItem"
        Me.صرفرواتبالموظفينToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.صرفرواتبالموظفينToolStripMenuItem.Text = "صرف رواتب الموظفين"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.تقريرالحالاتالاجتماعيةToolStripMenuItem})
        Me.ToolStripMenuItem13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripMenuItem13.Image = Global.Lab_System.My.Resources.Resources.report
        Me.ToolStripMenuItem13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(177, 93)
        Me.ToolStripMenuItem13.Text = "ملف التقارير"
        '
        'تقريرالحالاتالاجتماعيةToolStripMenuItem
        '
        Me.تقريرالحالاتالاجتماعيةToolStripMenuItem.Name = "تقريرالحالاتالاجتماعيةToolStripMenuItem"
        Me.تقريرالحالاتالاجتماعيةToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.تقريرالحالاتالاجتماعيةToolStripMenuItem.Text = "نموذج التقارير"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripMenuItem12.Image = Global.Lab_System.My.Resources.Resources.help
        Me.ToolStripMenuItem12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripMenuItem12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(183, 93)
        Me.ToolStripMenuItem12.Text = "ملف المساعدة"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripMenuItem14.Image = Global.Lab_System.My.Resources.Resources._exit
        Me.ToolStripMenuItem14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(195, 93)
        Me.ToolStripMenuItem14.Text = "خروج من النظام"
        '
        'الضبطوالتحكمToolStripMenuItem
        '
        Me.الضبطوالتحكمToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.تهيئةالنظامToolStripMenuItem, Me.المستخدمينToolStripMenuItem, Me.النسخالاحتياطيوالأسترجاعToolStripMenuItem})
        Me.الضبطوالتحكمToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.الضبطوالتحكمToolStripMenuItem.Image = Global.Lab_System.My.Resources.Resources.seeting1
        Me.الضبطوالتحكمToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.الضبطوالتحكمToolStripMenuItem.Name = "الضبطوالتحكمToolStripMenuItem"
        Me.الضبطوالتحكمToolStripMenuItem.Size = New System.Drawing.Size(195, 93)
        Me.الضبطوالتحكمToolStripMenuItem.Text = "الضبط  و التحكم"
        '
        'تهيئةالنظامToolStripMenuItem
        '
        Me.تهيئةالنظامToolStripMenuItem.Name = "تهيئةالنظامToolStripMenuItem"
        Me.تهيئةالنظامToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.تهيئةالنظامToolStripMenuItem.Size = New System.Drawing.Size(289, 26)
        Me.تهيئةالنظامToolStripMenuItem.Text = "تهيئة النظام"
        '
        'المستخدمينToolStripMenuItem
        '
        Me.المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem"
        Me.المستخدمينToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.المستخدمينToolStripMenuItem.Size = New System.Drawing.Size(289, 26)
        Me.المستخدمينToolStripMenuItem.Text = "المستخدمين"
        '
        'النسخالاحتياطيوالأسترجاعToolStripMenuItem
        '
        Me.النسخالاحتياطيوالأسترجاعToolStripMenuItem.Name = "النسخالاحتياطيوالأسترجاعToolStripMenuItem"
        Me.النسخالاحتياطيوالأسترجاعToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.النسخالاحتياطيوالأسترجاعToolStripMenuItem.Size = New System.Drawing.Size(289, 26)
        Me.النسخالاحتياطيوالأسترجاعToolStripMenuItem.Text = "النسخ الاحتياطي والإسترجاع"
        '
        'ملفالترميزاتToolStripMenuItem
        '
        Me.ملفالترميزاتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Patients, Me.Employee, Me.Checkups, Me.Antibiotics, Me.Categories, Me.Mordeen, Me.Sender, Me.Cases, Me.Religions})
        Me.ملفالترميزاتToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ملفالترميزاتToolStripMenuItem.Image = Global.Lab_System.My.Resources.Resources.codding1
        Me.ملفالترميزاتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ملفالترميزاتToolStripMenuItem.Name = "ملفالترميزاتToolStripMenuItem"
        Me.ملفالترميزاتToolStripMenuItem.Size = New System.Drawing.Size(189, 93)
        Me.ملفالترميزاتToolStripMenuItem.Text = "ملف الترميزات"
        '
        'Patients
        '
        Me.Patients.Name = "Patients"
        Me.Patients.Size = New System.Drawing.Size(213, 26)
        Me.Patients.Text = "ترميز المرضى"
        '
        'Employee
        '
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(213, 26)
        Me.Employee.Text = "ترميز المؤظفين"
        '
        'Checkups
        '
        Me.Checkups.Name = "Checkups"
        Me.Checkups.Size = New System.Drawing.Size(213, 26)
        Me.Checkups.Text = "ترميز الفحوصات"
        '
        'Antibiotics
        '
        Me.Antibiotics.Name = "Antibiotics"
        Me.Antibiotics.Size = New System.Drawing.Size(213, 26)
        Me.Antibiotics.Text = "ترميز المضادات"
        '
        'Categories
        '
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(213, 26)
        Me.Categories.Text = "ترميز الأصناف"
        '
        'Mordeen
        '
        Me.Mordeen.Name = "Mordeen"
        Me.Mordeen.Size = New System.Drawing.Size(213, 26)
        Me.Mordeen.Text = "ترميز الموردين"
        '
        'Sender
        '
        Me.Sender.Name = "Sender"
        Me.Sender.Size = New System.Drawing.Size(213, 26)
        Me.Sender.Text = "ترميز الجهات المرسلة"
        '
        'Cases
        '
        Me.Cases.Name = "Cases"
        Me.Cases.Size = New System.Drawing.Size(213, 26)
        Me.Cases.Text = "ترميز الحالات الإجتماعية"
        '
        'Religions
        '
        Me.Religions.Name = "Religions"
        Me.Religions.Size = New System.Drawing.Size(213, 26)
        Me.Religions.Text = "ترميز الديانات"
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 694)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.Name = "Frm_Main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نظام إدارة المختبرات الطبية_الشاشة الرئيسية"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents الضبطوالتحكمToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تهيئةالنظامToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents المستخدمينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents النسخالاحتياطيوالأسترجاعToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ملفالترميزاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Patients As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Employee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Checkups As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Antibiotics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Categories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ملفالعملياتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ملفالتقاريرToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ملفالمساعدةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents خروجToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Mordeen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sender As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cases As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Religions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents فاتورةشراءToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents مستلزماتالمختبرToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents المخازنToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents طلبفحصToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اجراءفحصToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حسابانتهاءالمحاليلالمفتوحةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Txt_User_Name As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalogClock1 As AnalogClock.AnalogClock
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Txt_User_Name1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TV_Lab_System As System.Windows.Forms.TreeView
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem23 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem24 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents تقريرالحالاتالاجتماعيةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents صرفرواتبالموظفينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
