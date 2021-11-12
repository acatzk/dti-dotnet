<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationTab
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationTab))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.picRegistrationImage = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtRegistrationID = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblRegistrationID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtRegistrationFirstname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblRegistrationFname = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtRegistrationLastname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblRegistrationLname = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtRegistrationMI = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblRegistrationMI = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtRegistrationPosition = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnEmployeesRegister = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnCancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnBrowse = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.cmbxRegistrationGender = New System.Windows.Forms.ComboBox()
        Me.cmbxRegistrationTypeOfAccout = New System.Windows.Forms.ComboBox()
        Me.txtRegistrationPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cmbxRegistration_Rank = New System.Windows.Forms.ComboBox()
        CType(Me.picRegistrationImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me.picRegistrationImage
        '
        'picRegistrationImage
        '
        Me.picRegistrationImage.BackgroundImage = CType(resources.GetObject("picRegistrationImage.BackgroundImage"), System.Drawing.Image)
        Me.picRegistrationImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRegistrationImage.Location = New System.Drawing.Point(755, 219)
        Me.picRegistrationImage.Name = "picRegistrationImage"
        Me.picRegistrationImage.Size = New System.Drawing.Size(192, 187)
        Me.picRegistrationImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRegistrationImage.TabIndex = 182
        Me.picRegistrationImage.TabStop = False
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(5, 580)
        Me.BunifuSeparator4.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(1009, 10)
        Me.BunifuSeparator4.TabIndex = 190
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.Color.Gray
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(884, 587)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(137, 17)
        Me.BunifuCustomLabel13.TabIndex = 191
        Me.BunifuCustomLabel13.Text = "Alright Reserved 2017"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(861, 587)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(25, 18)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 192
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(344, 183)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(82, 21)
        Me.BunifuCustomLabel12.TabIndex = 189
        Me.BunifuCustomLabel12.Text = "Password"
        '
        'txtRegistrationID
        '
        Me.txtRegistrationID.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationID.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtRegistrationID.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationID.BorderThickness = 1
        Me.txtRegistrationID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegistrationID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistrationID.ForeColor = System.Drawing.Color.DimGray
        Me.txtRegistrationID.isPassword = False
        Me.txtRegistrationID.Location = New System.Drawing.Point(111, 204)
        Me.txtRegistrationID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRegistrationID.Name = "txtRegistrationID"
        Me.txtRegistrationID.Size = New System.Drawing.Size(223, 35)
        Me.txtRegistrationID.TabIndex = 1
        Me.txtRegistrationID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblRegistrationID
        '
        Me.lblRegistrationID.AutoSize = True
        Me.lblRegistrationID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationID.ForeColor = System.Drawing.Color.DimGray
        Me.lblRegistrationID.Location = New System.Drawing.Point(110, 183)
        Me.lblRegistrationID.Name = "lblRegistrationID"
        Me.lblRegistrationID.Size = New System.Drawing.Size(92, 21)
        Me.lblRegistrationID.TabIndex = 160
        Me.lblRegistrationID.Text = "ID number"
        '
        'txtRegistrationFirstname
        '
        Me.txtRegistrationFirstname.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationFirstname.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtRegistrationFirstname.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationFirstname.BorderThickness = 1
        Me.txtRegistrationFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegistrationFirstname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistrationFirstname.ForeColor = System.Drawing.Color.DimGray
        Me.txtRegistrationFirstname.isPassword = False
        Me.txtRegistrationFirstname.Location = New System.Drawing.Point(345, 273)
        Me.txtRegistrationFirstname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRegistrationFirstname.Name = "txtRegistrationFirstname"
        Me.txtRegistrationFirstname.Size = New System.Drawing.Size(223, 35)
        Me.txtRegistrationFirstname.TabIndex = 4
        Me.txtRegistrationFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblRegistrationFname
        '
        Me.lblRegistrationFname.AutoSize = True
        Me.lblRegistrationFname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationFname.ForeColor = System.Drawing.Color.DimGray
        Me.lblRegistrationFname.Location = New System.Drawing.Point(344, 252)
        Me.lblRegistrationFname.Name = "lblRegistrationFname"
        Me.lblRegistrationFname.Size = New System.Drawing.Size(85, 21)
        Me.lblRegistrationFname.TabIndex = 162
        Me.lblRegistrationFname.Text = "Firstname"
        '
        'txtRegistrationLastname
        '
        Me.txtRegistrationLastname.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationLastname.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtRegistrationLastname.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationLastname.BorderThickness = 1
        Me.txtRegistrationLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegistrationLastname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistrationLastname.ForeColor = System.Drawing.Color.DimGray
        Me.txtRegistrationLastname.isPassword = False
        Me.txtRegistrationLastname.Location = New System.Drawing.Point(114, 273)
        Me.txtRegistrationLastname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRegistrationLastname.Name = "txtRegistrationLastname"
        Me.txtRegistrationLastname.Size = New System.Drawing.Size(223, 35)
        Me.txtRegistrationLastname.TabIndex = 3
        Me.txtRegistrationLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblRegistrationLname
        '
        Me.lblRegistrationLname.AutoSize = True
        Me.lblRegistrationLname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationLname.ForeColor = System.Drawing.Color.DimGray
        Me.lblRegistrationLname.Location = New System.Drawing.Point(113, 252)
        Me.lblRegistrationLname.Name = "lblRegistrationLname"
        Me.lblRegistrationLname.Size = New System.Drawing.Size(87, 21)
        Me.lblRegistrationLname.TabIndex = 164
        Me.lblRegistrationLname.Text = "Lastname"
        '
        'txtRegistrationMI
        '
        Me.txtRegistrationMI.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationMI.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtRegistrationMI.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationMI.BorderThickness = 1
        Me.txtRegistrationMI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegistrationMI.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistrationMI.ForeColor = System.Drawing.Color.DimGray
        Me.txtRegistrationMI.isPassword = False
        Me.txtRegistrationMI.Location = New System.Drawing.Point(576, 273)
        Me.txtRegistrationMI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRegistrationMI.Name = "txtRegistrationMI"
        Me.txtRegistrationMI.Size = New System.Drawing.Size(146, 35)
        Me.txtRegistrationMI.TabIndex = 5
        Me.txtRegistrationMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblRegistrationMI
        '
        Me.lblRegistrationMI.AutoSize = True
        Me.lblRegistrationMI.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationMI.ForeColor = System.Drawing.Color.DimGray
        Me.lblRegistrationMI.Location = New System.Drawing.Point(575, 252)
        Me.lblRegistrationMI.Name = "lblRegistrationMI"
        Me.lblRegistrationMI.Size = New System.Drawing.Size(109, 21)
        Me.lblRegistrationMI.TabIndex = 166
        Me.lblRegistrationMI.Text = "Middlename"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(115, 318)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(70, 21)
        Me.BunifuCustomLabel5.TabIndex = 170
        Me.BunifuCustomLabel5.Text = "Gender"
        '
        'txtRegistrationPosition
        '
        Me.txtRegistrationPosition.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationPosition.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtRegistrationPosition.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationPosition.BorderThickness = 1
        Me.txtRegistrationPosition.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegistrationPosition.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistrationPosition.ForeColor = System.Drawing.Color.DimGray
        Me.txtRegistrationPosition.isPassword = False
        Me.txtRegistrationPosition.Location = New System.Drawing.Point(579, 337)
        Me.txtRegistrationPosition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRegistrationPosition.Name = "txtRegistrationPosition"
        Me.txtRegistrationPosition.Size = New System.Drawing.Size(146, 35)
        Me.txtRegistrationPosition.TabIndex = 9
        Me.txtRegistrationPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(575, 316)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(68, 21)
        Me.BunifuCustomLabel9.TabIndex = 177
        Me.BunifuCustomLabel9.Text = "Position"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(116, 386)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(140, 21)
        Me.BunifuCustomLabel10.TabIndex = 178
        Me.BunifuCustomLabel10.Text = "Type of Account"
        '
        'btnEmployeesRegister
        '
        Me.btnEmployeesRegister.ActiveBorderThickness = 1
        Me.btnEmployeesRegister.ActiveCornerRadius = 10
        Me.btnEmployeesRegister.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEmployeesRegister.ActiveForecolor = System.Drawing.Color.White
        Me.btnEmployeesRegister.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEmployeesRegister.BackColor = System.Drawing.Color.White
        Me.btnEmployeesRegister.BackgroundImage = CType(resources.GetObject("btnEmployeesRegister.BackgroundImage"), System.Drawing.Image)
        Me.btnEmployeesRegister.ButtonText = "Register"
        Me.btnEmployeesRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployeesRegister.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeesRegister.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEmployeesRegister.IdleBorderThickness = 1
        Me.btnEmployeesRegister.IdleCornerRadius = 10
        Me.btnEmployeesRegister.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEmployeesRegister.IdleForecolor = System.Drawing.Color.White
        Me.btnEmployeesRegister.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnEmployeesRegister.Location = New System.Drawing.Point(111, 481)
        Me.btnEmployeesRegister.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEmployeesRegister.Name = "btnEmployeesRegister"
        Me.btnEmployeesRegister.Size = New System.Drawing.Size(301, 54)
        Me.btnEmployeesRegister.TabIndex = 13
        Me.btnEmployeesRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.ActiveBorderThickness = 1
        Me.btnCancel.ActiveCornerRadius = 10
        Me.btnCancel.ActiveFillColor = System.Drawing.Color.Gray
        Me.btnCancel.ActiveForecolor = System.Drawing.Color.White
        Me.btnCancel.ActiveLineColor = System.Drawing.Color.Gray
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.ButtonText = "Cancel"
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCancel.IdleBorderThickness = 1
        Me.btnCancel.IdleCornerRadius = 10
        Me.btnCancel.IdleFillColor = System.Drawing.Color.DarkGray
        Me.btnCancel.IdleForecolor = System.Drawing.Color.White
        Me.btnCancel.IdleLineColor = System.Drawing.Color.Gray
        Me.btnCancel.Location = New System.Drawing.Point(415, 481)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(307, 54)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBrowse
        '
        Me.btnBrowse.Activecolor = System.Drawing.Color.Gray
        Me.btnBrowse.BackColor = System.Drawing.Color.Gray
        Me.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrowse.BorderRadius = 3
        Me.btnBrowse.ButtonText = "       Browse"
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.DisabledColor = System.Drawing.Color.Gray
        Me.btnBrowse.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBrowse.Iconimage = CType(resources.GetObject("btnBrowse.Iconimage"), System.Drawing.Image)
        Me.btnBrowse.Iconimage_right = Nothing
        Me.btnBrowse.Iconimage_right_Selected = Nothing
        Me.btnBrowse.Iconimage_Selected = Nothing
        Me.btnBrowse.IconMarginLeft = 0
        Me.btnBrowse.IconMarginRight = 0
        Me.btnBrowse.IconRightVisible = True
        Me.btnBrowse.IconRightZoom = 0.0R
        Me.btnBrowse.IconVisible = True
        Me.btnBrowse.IconZoom = 50.0R
        Me.btnBrowse.IsTab = True
        Me.btnBrowse.Location = New System.Drawing.Point(755, 407)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Normalcolor = System.Drawing.Color.Gray
        Me.btnBrowse.OnHovercolor = System.Drawing.Color.DimGray
        Me.btnBrowse.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBrowse.selected = False
        Me.btnBrowse.Size = New System.Drawing.Size(195, 48)
        Me.btnBrowse.TabIndex = 12
        Me.btnBrowse.Text = "       Browse"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Textcolor = System.Drawing.Color.White
        Me.btnBrowse.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(112, 464)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(612, 19)
        Me.BunifuSeparator3.TabIndex = 183
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'cmbxRegistrationGender
        '
        Me.cmbxRegistrationGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxRegistrationGender.ForeColor = System.Drawing.Color.DimGray
        Me.cmbxRegistrationGender.FormattingEnabled = True
        Me.cmbxRegistrationGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbxRegistrationGender.Location = New System.Drawing.Point(116, 339)
        Me.cmbxRegistrationGender.Name = "cmbxRegistrationGender"
        Me.cmbxRegistrationGender.Size = New System.Drawing.Size(226, 29)
        Me.cmbxRegistrationGender.TabIndex = 6
        '
        'cmbxRegistrationTypeOfAccout
        '
        Me.cmbxRegistrationTypeOfAccout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxRegistrationTypeOfAccout.ForeColor = System.Drawing.Color.DimGray
        Me.cmbxRegistrationTypeOfAccout.FormattingEnabled = True
        Me.cmbxRegistrationTypeOfAccout.Items.AddRange(New Object() {"Administrator", "Employee"})
        Me.cmbxRegistrationTypeOfAccout.Location = New System.Drawing.Point(119, 407)
        Me.cmbxRegistrationTypeOfAccout.Name = "cmbxRegistrationTypeOfAccout"
        Me.cmbxRegistrationTypeOfAccout.Size = New System.Drawing.Size(226, 29)
        Me.cmbxRegistrationTypeOfAccout.TabIndex = 11
        '
        'txtRegistrationPassword
        '
        Me.txtRegistrationPassword.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationPassword.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtRegistrationPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtRegistrationPassword.BorderThickness = 1
        Me.txtRegistrationPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegistrationPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistrationPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtRegistrationPassword.isPassword = True
        Me.txtRegistrationPassword.Location = New System.Drawing.Point(345, 204)
        Me.txtRegistrationPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRegistrationPassword.Name = "txtRegistrationPassword"
        Me.txtRegistrationPassword.Size = New System.Drawing.Size(223, 35)
        Me.txtRegistrationPassword.TabIndex = 2
        Me.txtRegistrationPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(55, 102)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(103, 21)
        Me.BunifuCustomLabel3.TabIndex = 4
        Me.BunifuCustomLabel3.Text = "Registration"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 4
        Me.BunifuSeparator1.Location = New System.Drawing.Point(39, 122)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(133, 12)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Light", 31.75!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(315, 30)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(534, 59)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "EMPLOYEE'S REGISTRATION"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI Light", 11.75!)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(324, 78)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(291, 21)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "Elementary School. Sogod Southern Leyte"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(264, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1019, 131)
        Me.Panel1.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        Me.ErrorProvider2.Icon = CType(resources.GetObject("ErrorProvider2.Icon"), System.Drawing.Icon)
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(342, 315)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(49, 21)
        Me.BunifuCustomLabel4.TabIndex = 194
        Me.BunifuCustomLabel4.Text = "Rank"
        '
        'cmbxRegistration_Rank
        '
        Me.cmbxRegistration_Rank.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxRegistration_Rank.ForeColor = System.Drawing.Color.DimGray
        Me.cmbxRegistration_Rank.FormattingEnabled = True
        Me.cmbxRegistration_Rank.Items.AddRange(New Object() {"Teacher I", "Teacher II", "Teacher III"})
        Me.cmbxRegistration_Rank.Location = New System.Drawing.Point(346, 339)
        Me.cmbxRegistration_Rank.Name = "cmbxRegistration_Rank"
        Me.cmbxRegistration_Rank.Size = New System.Drawing.Size(226, 29)
        Me.cmbxRegistration_Rank.TabIndex = 7
        '
        'RegistrationTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.cmbxRegistration_Rank)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuCustomLabel13)
        Me.Controls.Add(Me.BunifuSeparator4)
        Me.Controls.Add(Me.BunifuCustomLabel12)
        Me.Controls.Add(Me.txtRegistrationPassword)
        Me.Controls.Add(Me.cmbxRegistrationTypeOfAccout)
        Me.Controls.Add(Me.cmbxRegistrationGender)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picRegistrationImage)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEmployeesRegister)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.txtRegistrationPosition)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.lblRegistrationMI)
        Me.Controls.Add(Me.txtRegistrationMI)
        Me.Controls.Add(Me.lblRegistrationLname)
        Me.Controls.Add(Me.txtRegistrationLastname)
        Me.Controls.Add(Me.lblRegistrationFname)
        Me.Controls.Add(Me.txtRegistrationFirstname)
        Me.Controls.Add(Me.lblRegistrationID)
        Me.Controls.Add(Me.txtRegistrationID)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RegistrationTab"
        Me.Size = New System.Drawing.Size(1019, 605)
        CType(Me.picRegistrationImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents picRegistrationImage As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRegistrationID As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblRegistrationID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRegistrationFirstname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblRegistrationFname As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRegistrationLastname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblRegistrationLname As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRegistrationMI As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblRegistrationMI As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtRegistrationPosition As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnEmployeesRegister As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnCancel As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents btnBrowse As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents cmbxRegistrationGender As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxRegistrationTypeOfAccout As System.Windows.Forms.ComboBox
    Friend WithEvents txtRegistrationPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbxRegistration_Rank As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel

End Class
