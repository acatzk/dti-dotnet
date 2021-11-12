<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim Animation12 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation11 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation14 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation13 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation15 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMaximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.sideMenu = New System.Windows.Forms.Panel()
        Me.lblAttendance = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblSogodSpeed = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblMonitoring = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Body = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCheckbox1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtIDnumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panelAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.LogoAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.monitoringAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.attendanceAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.sogodSPEDanimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Header.SuspendLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sideMenu.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Body.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 4
        Me.BunifuElipse1.TargetControl = Me
        '
        'Header
        '
        Me.Header.BackgroundImage = CType(resources.GetObject("Header.BackgroundImage"), System.Drawing.Image)
        Me.Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Header.Controls.Add(Me.BunifuImageButton4)
        Me.Header.Controls.Add(Me.btnMinimize)
        Me.Header.Controls.Add(Me.btnMaximize)
        Me.Header.Controls.Add(Me.btnExit)
        Me.LogoAnimator.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.GradientBottomLeft = System.Drawing.Color.Black
        Me.Header.GradientBottomRight = System.Drawing.Color.Gray
        Me.Header.GradientTopLeft = System.Drawing.Color.Black
        Me.Header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Quality = 10
        Me.Header.Size = New System.Drawing.Size(676, 27)
        Me.Header.TabIndex = 2
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(649, 3)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(22, 22)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 3
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.btnMinimize, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.btnMinimize, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.btnMinimize, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.btnMinimize, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.btnMinimize, BunifuAnimatorNS.DecorationType.None)
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageActive = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(47, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        Me.btnMinimize.Zoom = 10
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.btnMaximize, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.btnMaximize, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.btnMaximize, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.btnMaximize, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.btnMaximize, BunifuAnimatorNS.DecorationType.None)
        Me.btnMaximize.Image = CType(resources.GetObject("btnMaximize.Image"), System.Drawing.Image)
        Me.btnMaximize.ImageActive = Nothing
        Me.btnMaximize.Location = New System.Drawing.Point(27, 4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(20, 20)
        Me.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximize.TabIndex = 2
        Me.btnMaximize.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnMaximize, "Maximize")
        Me.btnMaximize.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.btnExit, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.btnExit, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.btnExit, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.btnExit, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.btnExit, BunifuAnimatorNS.DecorationType.None)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(6, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 1
        Me.btnExit.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit")
        Me.btnExit.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Header
        Me.BunifuDragControl1.Vertical = True
        '
        'sideMenu
        '
        Me.sideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sideMenu.BackgroundImage = CType(resources.GetObject("sideMenu.BackgroundImage"), System.Drawing.Image)
        Me.sideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.sideMenu.Controls.Add(Me.lblAttendance)
        Me.sideMenu.Controls.Add(Me.lblSogodSpeed)
        Me.sideMenu.Controls.Add(Me.Logo)
        Me.sideMenu.Controls.Add(Me.btnMenu)
        Me.sideMenu.Controls.Add(Me.lblMonitoring)
        Me.sogodSPEDanimator.SetDecoration(Me.sideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.sideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.sideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.sideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.sideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.sideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideMenu.Location = New System.Drawing.Point(0, 27)
        Me.sideMenu.Name = "sideMenu"
        Me.sideMenu.Size = New System.Drawing.Size(322, 445)
        Me.sideMenu.TabIndex = 7
        '
        'lblAttendance
        '
        Me.lblAttendance.AutoSize = True
        Me.lblAttendance.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.lblAttendance, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.lblAttendance, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.lblAttendance, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.lblAttendance, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.lblAttendance, BunifuAnimatorNS.DecorationType.None)
        Me.lblAttendance.Font = New System.Drawing.Font("Segoe UI Light", 34.0!)
        Me.lblAttendance.ForeColor = System.Drawing.Color.White
        Me.lblAttendance.Location = New System.Drawing.Point(47, 158)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(227, 62)
        Me.lblAttendance.TabIndex = 6
        Me.lblAttendance.Text = "Daily Time"
        '
        'lblSogodSpeed
        '
        Me.lblSogodSpeed.AutoSize = True
        Me.lblSogodSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.lblSogodSpeed, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.lblSogodSpeed, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.lblSogodSpeed, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.lblSogodSpeed, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.lblSogodSpeed, BunifuAnimatorNS.DecorationType.None)
        Me.lblSogodSpeed.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSogodSpeed.ForeColor = System.Drawing.Color.White
        Me.lblSogodSpeed.Location = New System.Drawing.Point(49, 265)
        Me.lblSogodSpeed.Name = "lblSogodSpeed"
        Me.lblSogodSpeed.Size = New System.Drawing.Size(205, 50)
        Me.lblSogodSpeed.TabIndex = 8
        Me.lblSogodSpeed.Text = "Pandan-San Miguel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sogod, Southern Leyte"
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.sogodSPEDanimator.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(47, 15)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(122, 109)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 5
        Me.Logo.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageActive = Nothing
        Me.btnMenu.Location = New System.Drawing.Point(291, 11)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(25, 25)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.TabStop = False
        Me.btnMenu.Zoom = 10
        '
        'lblMonitoring
        '
        Me.lblMonitoring.AutoSize = True
        Me.lblMonitoring.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.lblMonitoring, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.lblMonitoring, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.lblMonitoring, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.lblMonitoring, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.lblMonitoring, BunifuAnimatorNS.DecorationType.None)
        Me.lblMonitoring.Font = New System.Drawing.Font("Segoe UI", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitoring.ForeColor = System.Drawing.Color.White
        Me.lblMonitoring.Location = New System.Drawing.Point(44, 205)
        Me.lblMonitoring.Name = "lblMonitoring"
        Me.lblMonitoring.Size = New System.Drawing.Size(175, 61)
        Me.lblMonitoring.TabIndex = 7
        Me.lblMonitoring.Text = "Record"
        '
        'Body
        '
        Me.Body.BackColor = System.Drawing.Color.White
        Me.Body.BackgroundImage = CType(resources.GetObject("Body.BackgroundImage"), System.Drawing.Image)
        Me.Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Body.Controls.Add(Me.BunifuImageButton2)
        Me.Body.Controls.Add(Me.BunifuCustomLabel2)
        Me.Body.Controls.Add(Me.BunifuSeparator4)
        Me.Body.Controls.Add(Me.btnLogin)
        Me.Body.Controls.Add(Me.BunifuCustomLabel7)
        Me.Body.Controls.Add(Me.BunifuCheckbox1)
        Me.Body.Controls.Add(Me.txtPassword)
        Me.Body.Controls.Add(Me.txtIDnumber)
        Me.Body.Controls.Add(Me.BunifuCustomLabel6)
        Me.Body.Controls.Add(Me.BunifuCustomLabel5)
        Me.LogoAnimator.SetDecoration(Me.Body, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.Body, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.Body, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.Body, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.Body, BunifuAnimatorNS.DecorationType.None)
        Me.Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Body.GradientBottomLeft = System.Drawing.Color.White
        Me.Body.GradientBottomRight = System.Drawing.Color.White
        Me.Body.GradientTopLeft = System.Drawing.Color.White
        Me.Body.GradientTopRight = System.Drawing.Color.White
        Me.Body.Location = New System.Drawing.Point(322, 27)
        Me.Body.Name = "Body"
        Me.Body.Quality = 10
        Me.Body.Size = New System.Drawing.Size(354, 445)
        Me.Body.TabIndex = 8
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(200, 426)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(18, 18)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 15
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Gray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(217, 427)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(137, 17)
        Me.BunifuCustomLabel2.TabIndex = 14
        Me.BunifuCustomLabel2.Text = "Alright Reserved 2017"
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimator.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.BunifuSeparator4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(7, 419)
        Me.BunifuSeparator4.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(342, 10)
        Me.BunifuSeparator4.TabIndex = 13
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 30
        Me.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.White
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sogodSPEDanimator.SetDecoration(Me.btnLogin, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.btnLogin, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.btnLogin, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.btnLogin, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.btnLogin, BunifuAnimatorNS.DecorationType.None)
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 30
        Me.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnLogin.IdleForecolor = System.Drawing.Color.White
        Me.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(238, 267)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(95, 43)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel7
        '
        Me.LogoAnimator.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(37, 247)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(99, 18)
        Me.BunifuCustomLabel7.TabIndex = 12
        Me.BunifuCustomLabel7.Text = "Remember me"
        '
        'BunifuCheckbox1
        '
        Me.BunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.BunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCheckbox1.Checked = True
        Me.BunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.attendanceAnimator.SetDecoration(Me.BunifuCheckbox1, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.BunifuCheckbox1, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.BunifuCheckbox1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuCheckbox1, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.BunifuCheckbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCheckbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox1.Location = New System.Drawing.Point(18, 246)
        Me.BunifuCheckbox1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuCheckbox1.Name = "BunifuCheckbox1"
        Me.BunifuCheckbox1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox1.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LogoAnimator.SetDecoration(Me.txtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.txtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.txtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.txtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.txtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.Gray
        Me.txtPassword.HintText = "Password"
        Me.txtPassword.isPassword = True
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPassword.LineThickness = 2
        Me.txtPassword.Location = New System.Drawing.Point(18, 198)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(315, 33)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtIDnumber
        '
        Me.txtIDnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LogoAnimator.SetDecoration(Me.txtIDnumber, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.txtIDnumber, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.txtIDnumber, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.txtIDnumber, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.txtIDnumber, BunifuAnimatorNS.DecorationType.None)
        Me.txtIDnumber.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIDnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIDnumber.HintForeColor = System.Drawing.Color.Gray
        Me.txtIDnumber.HintText = "ID number"
        Me.txtIDnumber.isPassword = False
        Me.txtIDnumber.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.txtIDnumber.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.txtIDnumber.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtIDnumber.LineThickness = 2
        Me.txtIDnumber.Location = New System.Drawing.Point(18, 141)
        Me.txtIDnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDnumber.Name = "txtIDnumber"
        Me.txtIDnumber.Size = New System.Drawing.Size(315, 33)
        Me.txtIDnumber.TabIndex = 1
        Me.txtIDnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.LogoAnimator.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(21, 85)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(307, 43)
        Me.BunifuCustomLabel6.TabIndex = 8
        Me.BunifuCustomLabel6.Text = "Don't have an account? Create on. It takes less" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "than a minute. Contact your admi" & _
    "nistrator."
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.White
        Me.LogoAnimator.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI Light", 30.0!)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(15, 26)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(114, 54)
        Me.BunifuCustomLabel5.TabIndex = 7
        Me.BunifuCustomLabel5.Text = "Login"
        '
        'panelAnimator
        '
        Me.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.panelAnimator.Cursor = Nothing
        Animation12.AnimateOnlyDifferences = True
        Animation12.BlindCoeff = CType(resources.GetObject("Animation12.BlindCoeff"), System.Drawing.PointF)
        Animation12.LeafCoeff = 0.0!
        Animation12.MaxTime = 1.0!
        Animation12.MinTime = 0.0!
        Animation12.MosaicCoeff = CType(resources.GetObject("Animation12.MosaicCoeff"), System.Drawing.PointF)
        Animation12.MosaicShift = CType(resources.GetObject("Animation12.MosaicShift"), System.Drawing.PointF)
        Animation12.MosaicSize = 0
        Animation12.Padding = New System.Windows.Forms.Padding(0)
        Animation12.RotateCoeff = 0.0!
        Animation12.RotateLimit = 0.0!
        Animation12.ScaleCoeff = CType(resources.GetObject("Animation12.ScaleCoeff"), System.Drawing.PointF)
        Animation12.SlideCoeff = CType(resources.GetObject("Animation12.SlideCoeff"), System.Drawing.PointF)
        Animation12.TimeCoeff = 0.0!
        Animation12.TransparencyCoeff = 0.0!
        Me.panelAnimator.DefaultAnimation = Animation12
        '
        'LogoAnimator
        '
        Me.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.LogoAnimator.Cursor = Nothing
        Animation11.AnimateOnlyDifferences = True
        Animation11.BlindCoeff = CType(resources.GetObject("Animation11.BlindCoeff"), System.Drawing.PointF)
        Animation11.LeafCoeff = 0.0!
        Animation11.MaxTime = 1.0!
        Animation11.MinTime = 0.0!
        Animation11.MosaicCoeff = CType(resources.GetObject("Animation11.MosaicCoeff"), System.Drawing.PointF)
        Animation11.MosaicShift = CType(resources.GetObject("Animation11.MosaicShift"), System.Drawing.PointF)
        Animation11.MosaicSize = 0
        Animation11.Padding = New System.Windows.Forms.Padding(30)
        Animation11.RotateCoeff = 0.5!
        Animation11.RotateLimit = 0.2!
        Animation11.ScaleCoeff = CType(resources.GetObject("Animation11.ScaleCoeff"), System.Drawing.PointF)
        Animation11.SlideCoeff = CType(resources.GetObject("Animation11.SlideCoeff"), System.Drawing.PointF)
        Animation11.TimeCoeff = 0.0!
        Animation11.TransparencyCoeff = 0.0!
        Me.LogoAnimator.DefaultAnimation = Animation11
        '
        'monitoringAnimator
        '
        Me.monitoringAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.monitoringAnimator.Cursor = Nothing
        Animation14.AnimateOnlyDifferences = True
        Animation14.BlindCoeff = CType(resources.GetObject("Animation14.BlindCoeff"), System.Drawing.PointF)
        Animation14.LeafCoeff = 0.0!
        Animation14.MaxTime = 1.0!
        Animation14.MinTime = 0.0!
        Animation14.MosaicCoeff = CType(resources.GetObject("Animation14.MosaicCoeff"), System.Drawing.PointF)
        Animation14.MosaicShift = CType(resources.GetObject("Animation14.MosaicShift"), System.Drawing.PointF)
        Animation14.MosaicSize = 0
        Animation14.Padding = New System.Windows.Forms.Padding(0)
        Animation14.RotateCoeff = 0.0!
        Animation14.RotateLimit = 0.0!
        Animation14.ScaleCoeff = CType(resources.GetObject("Animation14.ScaleCoeff"), System.Drawing.PointF)
        Animation14.SlideCoeff = CType(resources.GetObject("Animation14.SlideCoeff"), System.Drawing.PointF)
        Animation14.TimeCoeff = 0.0!
        Animation14.TransparencyCoeff = 0.0!
        Me.monitoringAnimator.DefaultAnimation = Animation14
        '
        'attendanceAnimator
        '
        Me.attendanceAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.attendanceAnimator.Cursor = Nothing
        Animation13.AnimateOnlyDifferences = True
        Animation13.BlindCoeff = CType(resources.GetObject("Animation13.BlindCoeff"), System.Drawing.PointF)
        Animation13.LeafCoeff = 0.0!
        Animation13.MaxTime = 1.0!
        Animation13.MinTime = 0.0!
        Animation13.MosaicCoeff = CType(resources.GetObject("Animation13.MosaicCoeff"), System.Drawing.PointF)
        Animation13.MosaicShift = CType(resources.GetObject("Animation13.MosaicShift"), System.Drawing.PointF)
        Animation13.MosaicSize = 0
        Animation13.Padding = New System.Windows.Forms.Padding(0)
        Animation13.RotateCoeff = 0.0!
        Animation13.RotateLimit = 0.0!
        Animation13.ScaleCoeff = CType(resources.GetObject("Animation13.ScaleCoeff"), System.Drawing.PointF)
        Animation13.SlideCoeff = CType(resources.GetObject("Animation13.SlideCoeff"), System.Drawing.PointF)
        Animation13.TimeCoeff = 0.0!
        Animation13.TransparencyCoeff = 0.0!
        Me.attendanceAnimator.DefaultAnimation = Animation13
        '
        'sogodSPEDanimator
        '
        Me.sogodSPEDanimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.sogodSPEDanimator.Cursor = Nothing
        Animation15.AnimateOnlyDifferences = True
        Animation15.BlindCoeff = CType(resources.GetObject("Animation15.BlindCoeff"), System.Drawing.PointF)
        Animation15.LeafCoeff = 0.0!
        Animation15.MaxTime = 1.0!
        Animation15.MinTime = 0.0!
        Animation15.MosaicCoeff = CType(resources.GetObject("Animation15.MosaicCoeff"), System.Drawing.PointF)
        Animation15.MosaicShift = CType(resources.GetObject("Animation15.MosaicShift"), System.Drawing.PointF)
        Animation15.MosaicSize = 0
        Animation15.Padding = New System.Windows.Forms.Padding(0)
        Animation15.RotateCoeff = 0.0!
        Animation15.RotateLimit = 0.0!
        Animation15.ScaleCoeff = CType(resources.GetObject("Animation15.ScaleCoeff"), System.Drawing.PointF)
        Animation15.SlideCoeff = CType(resources.GetObject("Animation15.SlideCoeff"), System.Drawing.PointF)
        Animation15.TimeCoeff = 0.0!
        Animation15.TransparencyCoeff = 0.0!
        Me.sogodSPEDanimator.DefaultAnimation = Animation15
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(676, 472)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.sideMenu)
        Me.Controls.Add(Me.Header)
        Me.LogoAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.panelAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.attendanceAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.monitoringAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.sogodSPEDanimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Header.ResumeLayout(False)
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sideMenu.ResumeLayout(False)
        Me.sideMenu.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Body.ResumeLayout(False)
        Me.Body.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMaximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents sideMenu As System.Windows.Forms.Panel
    Friend WithEvents lblAttendance As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblSogodSpeed As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblMonitoring As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Body As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCheckbox1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtIDnumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents monitoringAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents LogoAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents panelAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents attendanceAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents sogodSPEDanimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
