<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim btnLogout As Bunifu.Framework.UI.BunifuFlatButton
        Dim btnSearch As Bunifu.Framework.UI.BunifuFlatButton
        Dim btnRegistration As Bunifu.Framework.UI.BunifuFlatButton
        Dim btnHome As Bunifu.Framework.UI.BunifuFlatButton
        Dim btnAttendance As Bunifu.Framework.UI.BunifuFlatButton
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Headerrrrr = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMaximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Tops = New System.Windows.Forms.Panel()
        Me.lblAttendance = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMonitoring = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.sideMenu = New System.Windows.Forms.Panel()
        Me.Body = New System.Windows.Forms.Panel()
        Me.HomeTab1 = New Daily_Time_Record.HomeTab()
        Me.AttedanceTab1 = New Daily_Time_Record.AttedanceTab()
        Me.SearchTab1 = New Daily_Time_Record.SearchTab()
        Me.RegistrationTab1 = New Daily_Time_Record.RegistrationTab()
        Me.panelAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.HomeTab2 = New Daily_Time_Record.HomeTab()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        btnLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        btnRegistration = New Bunifu.Framework.UI.BunifuFlatButton()
        btnHome = New Bunifu.Framework.UI.BunifuFlatButton()
        btnAttendance = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Headerrrrr.SuspendLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tops.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sideMenu.SuspendLayout()
        Me.Body.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        btnLogout.Activecolor = System.Drawing.Color.Gainsboro
        btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnLogout.BorderRadius = 0
        btnLogout.ButtonText = "               Logout"
        btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelAnimator.SetDecoration(btnLogout, BunifuAnimatorNS.DecorationType.None)
        btnLogout.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnLogout.ForeColor = System.Drawing.Color.DarkBlue
        btnLogout.Iconcolor = System.Drawing.Color.Transparent
        btnLogout.Iconimage = CType(resources.GetObject("btnLogout.Iconimage"), System.Drawing.Image)
        btnLogout.Iconimage_right = Nothing
        btnLogout.Iconimage_right_Selected = Nothing
        btnLogout.Iconimage_Selected = Nothing
        btnLogout.IconMarginLeft = 0
        btnLogout.IconMarginRight = 0
        btnLogout.IconRightVisible = True
        btnLogout.IconRightZoom = 0.0R
        btnLogout.IconVisible = True
        btnLogout.IconZoom = 60.0R
        btnLogout.IsTab = False
        btnLogout.Location = New System.Drawing.Point(0, 255)
        btnLogout.Name = "btnLogout"
        btnLogout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        btnLogout.OnHoverTextColor = System.Drawing.Color.Black
        btnLogout.selected = False
        btnLogout.Size = New System.Drawing.Size(248, 48)
        btnLogout.TabIndex = 10
        btnLogout.Text = "               Logout"
        btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        btnLogout.Textcolor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        btnLogout.TextFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddHandler btnLogout.Click, AddressOf Me.btnLogout_Click
        '
        'btnSearch
        '
        btnSearch.Activecolor = System.Drawing.Color.Gainsboro
        btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnSearch.BorderRadius = 0
        btnSearch.ButtonText = "               Search"
        btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelAnimator.SetDecoration(btnSearch, BunifuAnimatorNS.DecorationType.None)
        btnSearch.DisabledColor = System.Drawing.Color.Gray
        btnSearch.ForeColor = System.Drawing.Color.DarkBlue
        btnSearch.Iconcolor = System.Drawing.Color.Transparent
        btnSearch.Iconimage = CType(resources.GetObject("btnSearch.Iconimage"), System.Drawing.Image)
        btnSearch.Iconimage_right = Nothing
        btnSearch.Iconimage_right_Selected = Nothing
        btnSearch.Iconimage_Selected = Nothing
        btnSearch.IconMarginLeft = 0
        btnSearch.IconMarginRight = 0
        btnSearch.IconRightVisible = True
        btnSearch.IconRightZoom = 0.0R
        btnSearch.IconVisible = True
        btnSearch.IconZoom = 60.0R
        btnSearch.IsTab = True
        btnSearch.Location = New System.Drawing.Point(0, 203)
        btnSearch.Name = "btnSearch"
        btnSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        btnSearch.OnHoverTextColor = System.Drawing.Color.Black
        btnSearch.selected = False
        btnSearch.Size = New System.Drawing.Size(248, 48)
        btnSearch.TabIndex = 9
        btnSearch.Text = "               Search"
        btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        btnSearch.Textcolor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        btnSearch.TextFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddHandler btnSearch.Click, AddressOf Me.btnSearch_Click
        '
        'btnRegistration
        '
        btnRegistration.Activecolor = System.Drawing.Color.Gainsboro
        btnRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnRegistration.BorderRadius = 0
        btnRegistration.ButtonText = "               Registration"
        btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelAnimator.SetDecoration(btnRegistration, BunifuAnimatorNS.DecorationType.None)
        btnRegistration.DisabledColor = System.Drawing.Color.Gray
        btnRegistration.ForeColor = System.Drawing.Color.DarkBlue
        btnRegistration.Iconcolor = System.Drawing.Color.Transparent
        btnRegistration.Iconimage = CType(resources.GetObject("btnRegistration.Iconimage"), System.Drawing.Image)
        btnRegistration.Iconimage_right = Nothing
        btnRegistration.Iconimage_right_Selected = Nothing
        btnRegistration.Iconimage_Selected = Nothing
        btnRegistration.IconMarginLeft = 0
        btnRegistration.IconMarginRight = 0
        btnRegistration.IconRightVisible = True
        btnRegistration.IconRightZoom = 0.0R
        btnRegistration.IconVisible = True
        btnRegistration.IconZoom = 60.0R
        btnRegistration.IsTab = True
        btnRegistration.Location = New System.Drawing.Point(0, 151)
        btnRegistration.Name = "btnRegistration"
        btnRegistration.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnRegistration.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        btnRegistration.OnHoverTextColor = System.Drawing.Color.Black
        btnRegistration.selected = False
        btnRegistration.Size = New System.Drawing.Size(248, 48)
        btnRegistration.TabIndex = 8
        btnRegistration.Text = "               Registration"
        btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        btnRegistration.Textcolor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        btnRegistration.TextFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddHandler btnRegistration.Click, AddressOf Me.btnRegistration_Click
        '
        'btnHome
        '
        btnHome.Activecolor = System.Drawing.Color.Gainsboro
        btnHome.BackColor = System.Drawing.Color.Gainsboro
        btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnHome.BorderRadius = 0
        btnHome.ButtonText = "               Home"
        btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelAnimator.SetDecoration(btnHome, BunifuAnimatorNS.DecorationType.None)
        btnHome.DisabledColor = System.Drawing.Color.Gray
        btnHome.ForeColor = System.Drawing.Color.Black
        btnHome.Iconcolor = System.Drawing.Color.Transparent
        btnHome.Iconimage = CType(resources.GetObject("btnHome.Iconimage"), System.Drawing.Image)
        btnHome.Iconimage_right = Nothing
        btnHome.Iconimage_right_Selected = Nothing
        btnHome.Iconimage_Selected = Nothing
        btnHome.IconMarginLeft = 0
        btnHome.IconMarginRight = 0
        btnHome.IconRightVisible = True
        btnHome.IconRightZoom = 0.0R
        btnHome.IconVisible = True
        btnHome.IconZoom = 60.0R
        btnHome.IsTab = True
        btnHome.Location = New System.Drawing.Point(0, 50)
        btnHome.Name = "btnHome"
        btnHome.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnHome.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        btnHome.OnHoverTextColor = System.Drawing.Color.Black
        btnHome.selected = True
        btnHome.Size = New System.Drawing.Size(248, 48)
        btnHome.TabIndex = 7
        btnHome.Text = "               Home"
        btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        btnHome.Textcolor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        btnHome.TextFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddHandler btnHome.Click, AddressOf Me.btnHome_Click
        '
        'btnAttendance
        '
        btnAttendance.Activecolor = System.Drawing.Color.Transparent
        btnAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnAttendance.BorderRadius = 0
        btnAttendance.ButtonText = "               Attendance"
        btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelAnimator.SetDecoration(btnAttendance, BunifuAnimatorNS.DecorationType.None)
        btnAttendance.DisabledColor = System.Drawing.Color.Gray
        btnAttendance.ForeColor = System.Drawing.Color.DarkBlue
        btnAttendance.Iconcolor = System.Drawing.Color.Transparent
        btnAttendance.Iconimage = CType(resources.GetObject("btnAttendance.Iconimage"), System.Drawing.Image)
        btnAttendance.Iconimage_right = Nothing
        btnAttendance.Iconimage_right_Selected = Nothing
        btnAttendance.Iconimage_Selected = Nothing
        btnAttendance.IconMarginLeft = 0
        btnAttendance.IconMarginRight = 0
        btnAttendance.IconRightVisible = True
        btnAttendance.IconRightZoom = 0.0R
        btnAttendance.IconVisible = True
        btnAttendance.IconZoom = 60.0R
        btnAttendance.IsTab = False
        btnAttendance.Location = New System.Drawing.Point(-1, 100)
        btnAttendance.Name = "btnAttendance"
        btnAttendance.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        btnAttendance.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        btnAttendance.OnHoverTextColor = System.Drawing.Color.Black
        btnAttendance.selected = False
        btnAttendance.Size = New System.Drawing.Size(248, 48)
        btnAttendance.TabIndex = 11
        btnAttendance.Text = "               Attendance"
        btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        btnAttendance.Textcolor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        btnAttendance.TextFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddHandler btnAttendance.Click, AddressOf Me.btnAttendance_Click
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 6
        Me.BunifuElipse1.TargetControl = Me
        '
        'Headerrrrr
        '
        Me.Headerrrrr.BackgroundImage = CType(resources.GetObject("Headerrrrr.BackgroundImage"), System.Drawing.Image)
        Me.Headerrrrr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Headerrrrr.Controls.Add(Me.BunifuImageButton4)
        Me.Headerrrrr.Controls.Add(Me.btnMinimize)
        Me.Headerrrrr.Controls.Add(Me.btnMaximize)
        Me.Headerrrrr.Controls.Add(Me.btnExit)
        Me.panelAnimator.SetDecoration(Me.Headerrrrr, BunifuAnimatorNS.DecorationType.None)
        Me.Headerrrrr.Dock = System.Windows.Forms.DockStyle.Top
        Me.Headerrrrr.GradientBottomLeft = System.Drawing.Color.Black
        Me.Headerrrrr.GradientBottomRight = System.Drawing.Color.Gray
        Me.Headerrrrr.GradientTopLeft = System.Drawing.Color.Black
        Me.Headerrrrr.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Headerrrrr.Location = New System.Drawing.Point(0, 0)
        Me.Headerrrrr.Name = "Headerrrrr"
        Me.Headerrrrr.Quality = 10
        Me.Headerrrrr.Size = New System.Drawing.Size(1267, 27)
        Me.Headerrrrr.TabIndex = 3
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.panelAnimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(1240, 3)
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
        Me.panelAnimator.SetDecoration(Me.btnMinimize, BunifuAnimatorNS.DecorationType.None)
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
        Me.panelAnimator.SetDecoration(Me.btnMaximize, BunifuAnimatorNS.DecorationType.None)
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
        Me.panelAnimator.SetDecoration(Me.btnExit, BunifuAnimatorNS.DecorationType.None)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(6, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 1
        Me.btnExit.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnExit, "Logout")
        Me.btnExit.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.White
        Me.BunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelAnimator.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = CType(resources.GetObject("BunifuImageButton3.ImageActive"), System.Drawing.Image)
        Me.BunifuImageButton3.Location = New System.Drawing.Point(1216, 21)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(30, 25)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 12
        Me.BunifuImageButton3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton3, "Change Something?")
        Me.BunifuImageButton3.Zoom = 10
        '
        'Tops
        '
        Me.Tops.BackColor = System.Drawing.Color.White
        Me.Tops.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tops.Controls.Add(Me.lblAttendance)
        Me.Tops.Controls.Add(Me.BunifuImageButton3)
        Me.Tops.Controls.Add(Me.PictureBox1)
        Me.Tops.Controls.Add(Me.lblMonitoring)
        Me.Tops.Controls.Add(Me.btnMenu)
        Me.panelAnimator.SetDecoration(Me.Tops, BunifuAnimatorNS.DecorationType.None)
        Me.Tops.Dock = System.Windows.Forms.DockStyle.Top
        Me.Tops.Location = New System.Drawing.Point(0, 27)
        Me.Tops.Name = "Tops"
        Me.Tops.Size = New System.Drawing.Size(1267, 71)
        Me.Tops.TabIndex = 4
        '
        'lblAttendance
        '
        Me.lblAttendance.AutoSize = True
        Me.lblAttendance.BackColor = System.Drawing.Color.Transparent
        Me.panelAnimator.SetDecoration(Me.lblAttendance, BunifuAnimatorNS.DecorationType.None)
        Me.lblAttendance.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance.ForeColor = System.Drawing.Color.Black
        Me.lblAttendance.Location = New System.Drawing.Point(139, 15)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(267, 21)
        Me.lblAttendance.TabIndex = 8
        Me.lblAttendance.Text = "Pandan San Miguel Elementary School"
        '
        'PictureBox1
        '
        Me.panelAnimator.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(69, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lblMonitoring
        '
        Me.lblMonitoring.AutoSize = True
        Me.lblMonitoring.BackColor = System.Drawing.Color.Transparent
        Me.panelAnimator.SetDecoration(Me.lblMonitoring, BunifuAnimatorNS.DecorationType.None)
        Me.lblMonitoring.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitoring.ForeColor = System.Drawing.Color.Black
        Me.lblMonitoring.Location = New System.Drawing.Point(141, 35)
        Me.lblMonitoring.Name = "lblMonitoring"
        Me.lblMonitoring.Size = New System.Drawing.Size(178, 21)
        Me.lblMonitoring.TabIndex = 9
        Me.lblMonitoring.Text = "Sogod Southern Leyte"
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMenu.BackColor = System.Drawing.Color.White
        Me.panelAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageActive = Nothing
        Me.btnMenu.Location = New System.Drawing.Point(22, 21)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(37, 24)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 5
        Me.btnMenu.TabStop = False
        Me.btnMenu.Zoom = 10
        '
        'sideMenu
        '
        Me.sideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.sideMenu.Controls.Add(btnAttendance)
        Me.sideMenu.Controls.Add(btnLogout)
        Me.sideMenu.Controls.Add(btnSearch)
        Me.sideMenu.Controls.Add(btnRegistration)
        Me.sideMenu.Controls.Add(btnHome)
        Me.panelAnimator.SetDecoration(Me.sideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.sideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideMenu.Location = New System.Drawing.Point(0, 98)
        Me.sideMenu.Name = "sideMenu"
        Me.sideMenu.Size = New System.Drawing.Size(248, 605)
        Me.sideMenu.TabIndex = 6
        '
        'Body
        '
        Me.Body.Controls.Add(Me.HomeTab1)
        Me.Body.Controls.Add(Me.AttedanceTab1)
        Me.Body.Controls.Add(Me.SearchTab1)
        Me.Body.Controls.Add(Me.RegistrationTab1)
        Me.panelAnimator.SetDecoration(Me.Body, BunifuAnimatorNS.DecorationType.None)
        Me.Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Body.Location = New System.Drawing.Point(248, 98)
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(1019, 605)
        Me.Body.TabIndex = 7
        '
        'HomeTab1
        '
        Me.HomeTab1.BackColor = System.Drawing.Color.White
        Me.panelAnimator.SetDecoration(Me.HomeTab1, BunifuAnimatorNS.DecorationType.None)
        Me.HomeTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeTab1.Location = New System.Drawing.Point(0, 0)
        Me.HomeTab1.Name = "HomeTab1"
        Me.HomeTab1.Size = New System.Drawing.Size(1019, 605)
        Me.HomeTab1.TabIndex = 0
        '
        'AttedanceTab1
        '
        Me.AttedanceTab1.BackColor = System.Drawing.Color.White
        Me.panelAnimator.SetDecoration(Me.AttedanceTab1, BunifuAnimatorNS.DecorationType.None)
        Me.AttedanceTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AttedanceTab1.Location = New System.Drawing.Point(0, 0)
        Me.AttedanceTab1.Name = "AttedanceTab1"
        Me.AttedanceTab1.Size = New System.Drawing.Size(1019, 605)
        Me.AttedanceTab1.TabIndex = 3
        '
        'SearchTab1
        '
        Me.SearchTab1.BackColor = System.Drawing.Color.White
        Me.panelAnimator.SetDecoration(Me.SearchTab1, BunifuAnimatorNS.DecorationType.None)
        Me.SearchTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchTab1.Location = New System.Drawing.Point(0, 0)
        Me.SearchTab1.Name = "SearchTab1"
        Me.SearchTab1.Size = New System.Drawing.Size(1019, 605)
        Me.SearchTab1.TabIndex = 2
        '
        'RegistrationTab1
        '
        Me.RegistrationTab1.BackColor = System.Drawing.Color.White
        Me.panelAnimator.SetDecoration(Me.RegistrationTab1, BunifuAnimatorNS.DecorationType.None)
        Me.RegistrationTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegistrationTab1.Location = New System.Drawing.Point(0, 0)
        Me.RegistrationTab1.Name = "RegistrationTab1"
        Me.RegistrationTab1.Size = New System.Drawing.Size(1019, 605)
        Me.RegistrationTab1.TabIndex = 1
        '
        'panelAnimator
        '
        Me.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.panelAnimator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.panelAnimator.DefaultAnimation = Animation1
        '
        'HomeTab2
        '
        Me.HomeTab2.BackColor = System.Drawing.Color.White
        Me.panelAnimator.SetDecoration(Me.HomeTab2, BunifuAnimatorNS.DecorationType.None)
        Me.HomeTab2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeTab2.Location = New System.Drawing.Point(0, 0)
        Me.HomeTab2.Name = "HomeTab2"
        Me.HomeTab2.Size = New System.Drawing.Size(1019, 605)
        Me.HomeTab2.TabIndex = 4
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Headerrrrr
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.Headerrrrr
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuDragControl3
        '
        Me.BunifuDragControl3.Fixed = True
        Me.BunifuDragControl3.Horizontal = True
        Me.BunifuDragControl3.TargetControl = Me.Headerrrrr
        Me.BunifuDragControl3.Vertical = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1267, 703)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.sideMenu)
        Me.Controls.Add(Me.Tops)
        Me.Controls.Add(Me.Headerrrrr)
        Me.panelAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.Headerrrrr.ResumeLayout(False)
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tops.ResumeLayout(False)
        Me.Tops.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sideMenu.ResumeLayout(False)
        Me.Body.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Headerrrrr As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMaximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Tops As System.Windows.Forms.Panel
    Friend WithEvents lblAttendance As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMonitoring As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents sideMenu As System.Windows.Forms.Panel
    Friend WithEvents Body As System.Windows.Forms.Panel
    Friend WithEvents panelAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents HomeTab1 As Daily_Time_Record.HomeTab
    Friend WithEvents RegistrationTab1 As Daily_Time_Record.RegistrationTab
    Friend WithEvents SearchTab1 As Daily_Time_Record.SearchTab
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents AttedanceTab1 As Daily_Time_Record.AttedanceTab
    Friend WithEvents HomeTab2 As Daily_Time_Record.HomeTab
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl3 As Bunifu.Framework.UI.BunifuDragControl
End Class
