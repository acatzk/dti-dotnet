<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMaximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.dataGridEmployee = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.listEm = New System.Windows.Forms.GroupBox()
        Me.txtSearchEm = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuTextbox()
        Me.lblCount = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTypeOfAccount = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRank2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMiddlename1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblLastname1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblFirstname1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblPassword1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblIDnumber1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRank = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMiddlename = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblLastname = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblFirstname = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblPassword = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblIDnumber = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.picShow = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Header.SuspendLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.listEm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.GradientBottomLeft = System.Drawing.Color.Black
        Me.Header.GradientBottomRight = System.Drawing.Color.Gray
        Me.Header.GradientTopLeft = System.Drawing.Color.Black
        Me.Header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Header.Name = "Header"
        Me.Header.Quality = 10
        Me.Header.Size = New System.Drawing.Size(1098, 27)
        Me.Header.TabIndex = 4
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(1070, 3)
        Me.BunifuImageButton4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageActive = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(47, 4)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Zoom = 10
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.Image = CType(resources.GetObject("btnMaximize.Image"), System.Drawing.Image)
        Me.btnMaximize.ImageActive = Nothing
        Me.btnMaximize.Location = New System.Drawing.Point(26, 4)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(20, 20)
        Me.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximize.TabIndex = 2
        Me.btnMaximize.TabStop = False
        Me.btnMaximize.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(6, 4)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 1
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Header
        Me.BunifuDragControl1.Vertical = True
        '
        'dataGridEmployee
        '
        Me.dataGridEmployee.AllowUserToAddRows = False
        Me.dataGridEmployee.AllowUserToDeleteRows = False
        Me.dataGridEmployee.AllowUserToResizeColumns = False
        Me.dataGridEmployee.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        Me.dataGridEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGridEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dataGridEmployee.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataGridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridEmployee.ColumnHeadersHeight = 34
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridEmployee.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridEmployee.DoubleBuffered = True
        Me.dataGridEmployee.EnableHeadersVisualStyles = False
        Me.dataGridEmployee.GridColor = System.Drawing.Color.White
        Me.dataGridEmployee.HeaderBgColor = System.Drawing.Color.LightGray
        Me.dataGridEmployee.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataGridEmployee.Location = New System.Drawing.Point(13, 89)
        Me.dataGridEmployee.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dataGridEmployee.Name = "dataGridEmployee"
        Me.dataGridEmployee.ReadOnly = True
        Me.dataGridEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridEmployee.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridEmployee.RowHeadersVisible = False
        Me.dataGridEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataGridEmployee.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridEmployee.Size = New System.Drawing.Size(546, 393)
        Me.dataGridEmployee.TabIndex = 5
        '
        'listEm
        '
        Me.listEm.Controls.Add(Me.txtSearchEm)
        Me.listEm.Controls.Add(Me.txtSearch)
        Me.listEm.Controls.Add(Me.lblCount)
        Me.listEm.Controls.Add(Me.dataGridEmployee)
        Me.listEm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listEm.Location = New System.Drawing.Point(20, 97)
        Me.listEm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.listEm.Name = "listEm"
        Me.listEm.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.listEm.Size = New System.Drawing.Size(572, 519)
        Me.listEm.TabIndex = 6
        Me.listEm.TabStop = False
        Me.listEm.Text = "List of All Employee"
        '
        'txtSearchEm
        '
        Me.txtSearchEm.BorderColorFocused = System.Drawing.Color.White
        Me.txtSearchEm.BorderColorIdle = System.Drawing.Color.White
        Me.txtSearchEm.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtSearchEm.BorderThickness = 1
        Me.txtSearchEm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchEm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEm.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearchEm.isPassword = False
        Me.txtSearchEm.Location = New System.Drawing.Point(66, 45)
        Me.txtSearchEm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearchEm.Name = "txtSearchEm"
        Me.txtSearchEm.Size = New System.Drawing.Size(477, 29)
        Me.txtSearchEm.TabIndex = 195
        Me.txtSearchEm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BackgroundImage = CType(resources.GetObject("txtSearch.BackgroundImage"), System.Drawing.Image)
        Me.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtSearch.Enabled = False
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Icon = CType(resources.GetObject("txtSearch.Icon"), System.Drawing.Image)
        Me.txtSearch.Location = New System.Drawing.Point(13, 38)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(546, 44)
        Me.txtSearch.TabIndex = 194
        Me.txtSearch.text = ""
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCount.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(336, 485)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(176, 20)
        Me.lblCount.TabIndex = 193
        Me.lblCount.Text = "Number of Employees :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.picShow)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(608, 97)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(470, 473)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quick Preview"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTypeOfAccount)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox2.Controls.Add(Me.lblRank2)
        Me.GroupBox2.Controls.Add(Me.lblMiddlename1)
        Me.GroupBox2.Controls.Add(Me.lblLastname1)
        Me.GroupBox2.Controls.Add(Me.lblFirstname1)
        Me.GroupBox2.Controls.Add(Me.lblPassword1)
        Me.GroupBox2.Controls.Add(Me.lblIDnumber1)
        Me.GroupBox2.Controls.Add(Me.lblRank)
        Me.GroupBox2.Controls.Add(Me.lblMiddlename)
        Me.GroupBox2.Controls.Add(Me.lblLastname)
        Me.GroupBox2.Controls.Add(Me.lblFirstname)
        Me.GroupBox2.Controls.Add(Me.lblPassword)
        Me.GroupBox2.Controls.Add(Me.lblIDnumber)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 287)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee's Information"
        '
        'lblTypeOfAccount
        '
        Me.lblTypeOfAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTypeOfAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTypeOfAccount.Location = New System.Drawing.Point(186, 240)
        Me.lblTypeOfAccount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTypeOfAccount.Name = "lblTypeOfAccount"
        Me.lblTypeOfAccount.Size = New System.Drawing.Size(227, 20)
        Me.lblTypeOfAccount.TabIndex = 209
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(33, 240)
        Me.BunifuCustomLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(137, 20)
        Me.BunifuCustomLabel3.TabIndex = 208
        Me.BunifuCustomLabel3.Text = "Type of Account :"
        '
        'lblRank2
        '
        Me.lblRank2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRank2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRank2.Location = New System.Drawing.Point(186, 210)
        Me.lblRank2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRank2.Name = "lblRank2"
        Me.lblRank2.Size = New System.Drawing.Size(227, 20)
        Me.lblRank2.TabIndex = 207
        '
        'lblMiddlename1
        '
        Me.lblMiddlename1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMiddlename1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddlename1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMiddlename1.Location = New System.Drawing.Point(186, 175)
        Me.lblMiddlename1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMiddlename1.Name = "lblMiddlename1"
        Me.lblMiddlename1.Size = New System.Drawing.Size(227, 20)
        Me.lblMiddlename1.TabIndex = 206
        '
        'lblLastname1
        '
        Me.lblLastname1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLastname1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLastname1.Location = New System.Drawing.Point(186, 143)
        Me.lblLastname1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastname1.Name = "lblLastname1"
        Me.lblLastname1.Size = New System.Drawing.Size(227, 20)
        Me.lblLastname1.TabIndex = 205
        '
        'lblFirstname1
        '
        Me.lblFirstname1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFirstname1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFirstname1.Location = New System.Drawing.Point(186, 110)
        Me.lblFirstname1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstname1.Name = "lblFirstname1"
        Me.lblFirstname1.Size = New System.Drawing.Size(227, 20)
        Me.lblFirstname1.TabIndex = 204
        '
        'lblPassword1
        '
        Me.lblPassword1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPassword1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPassword1.Location = New System.Drawing.Point(186, 76)
        Me.lblPassword1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword1.Name = "lblPassword1"
        Me.lblPassword1.Size = New System.Drawing.Size(227, 20)
        Me.lblPassword1.TabIndex = 203
        '
        'lblIDnumber1
        '
        Me.lblIDnumber1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIDnumber1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDnumber1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIDnumber1.Location = New System.Drawing.Point(186, 43)
        Me.lblIDnumber1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIDnumber1.Name = "lblIDnumber1"
        Me.lblIDnumber1.Size = New System.Drawing.Size(227, 20)
        Me.lblIDnumber1.TabIndex = 202
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRank.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRank.Location = New System.Drawing.Point(33, 210)
        Me.lblRank.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(53, 20)
        Me.lblRank.TabIndex = 200
        Me.lblRank.Text = "Rank :"
        '
        'lblMiddlename
        '
        Me.lblMiddlename.AutoSize = True
        Me.lblMiddlename.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMiddlename.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMiddlename.Location = New System.Drawing.Point(31, 175)
        Me.lblMiddlename.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMiddlename.Name = "lblMiddlename"
        Me.lblMiddlename.Size = New System.Drawing.Size(110, 20)
        Me.lblMiddlename.TabIndex = 199
        Me.lblMiddlename.Text = "Middlename :"
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLastname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLastname.Location = New System.Drawing.Point(31, 143)
        Me.lblLastname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(87, 20)
        Me.lblLastname.TabIndex = 198
        Me.lblLastname.Text = "Lastname :"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFirstname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFirstname.Location = New System.Drawing.Point(31, 110)
        Me.lblFirstname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(80, 20)
        Me.lblFirstname.TabIndex = 197
        Me.lblFirstname.Text = "Fistname :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(31, 76)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 20)
        Me.lblPassword.TabIndex = 196
        Me.lblPassword.Text = "Password :"
        '
        'lblIDnumber
        '
        Me.lblIDnumber.AutoSize = True
        Me.lblIDnumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIDnumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIDnumber.Location = New System.Drawing.Point(31, 43)
        Me.lblIDnumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIDnumber.Name = "lblIDnumber"
        Me.lblIDnumber.Size = New System.Drawing.Size(93, 20)
        Me.lblIDnumber.TabIndex = 195
        Me.lblIDnumber.Text = "ID number :"
        '
        'picShow
        '
        Me.picShow.BackgroundImage = CType(resources.GetObject("picShow.BackgroundImage"), System.Drawing.Image)
        Me.picShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShow.Location = New System.Drawing.Point(177, 14)
        Me.picShow.Name = "picShow"
        Me.picShow.Size = New System.Drawing.Size(153, 166)
        Me.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShow.TabIndex = 11
        Me.picShow.TabStop = False
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 220
        Me.BunifuElipse2.TargetControl = Me.picShow
        '
        'btnEdit
        '
        Me.btnEdit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.BorderRadius = 6
        Me.btnEdit.ButtonText = "   Change"
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DisabledColor = System.Drawing.Color.Gray
        Me.btnEdit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEdit.Iconimage = CType(resources.GetObject("btnEdit.Iconimage"), System.Drawing.Image)
        Me.btnEdit.Iconimage_right = Nothing
        Me.btnEdit.Iconimage_right_Selected = Nothing
        Me.btnEdit.Iconimage_Selected = Nothing
        Me.btnEdit.IconMarginLeft = 0
        Me.btnEdit.IconMarginRight = 0
        Me.btnEdit.IconRightVisible = True
        Me.btnEdit.IconRightZoom = 0.0R
        Me.btnEdit.IconVisible = True
        Me.btnEdit.IconZoom = 50.0R
        Me.btnEdit.IsTab = True
        Me.btnEdit.Location = New System.Drawing.Point(608, 576)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEdit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEdit.selected = False
        Me.btnEdit.Size = New System.Drawing.Size(155, 40)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "   Change"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Textcolor = System.Drawing.Color.White
        Me.btnEdit.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDelete
        '
        Me.btnDelete.Activecolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.BorderRadius = 6
        Me.btnDelete.ButtonText = "   Delete"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledColor = System.Drawing.Color.Gray
        Me.btnDelete.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDelete.Iconimage = CType(resources.GetObject("btnDelete.Iconimage"), System.Drawing.Image)
        Me.btnDelete.Iconimage_right = Nothing
        Me.btnDelete.Iconimage_right_Selected = Nothing
        Me.btnDelete.Iconimage_Selected = Nothing
        Me.btnDelete.IconMarginLeft = 0
        Me.btnDelete.IconMarginRight = 0
        Me.btnDelete.IconRightVisible = True
        Me.btnDelete.IconRightZoom = 0.0R
        Me.btnDelete.IconVisible = True
        Me.btnDelete.IconZoom = 50.0R
        Me.btnDelete.IsTab = True
        Me.btnDelete.Location = New System.Drawing.Point(769, 576)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnDelete.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDelete.selected = False
        Me.btnDelete.Size = New System.Drawing.Size(148, 40)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "   Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Textcolor = System.Drawing.Color.White
        Me.btnDelete.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1098, 64)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(26, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Semilight", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(77, 6)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(285, 50)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "ADMINSTRATOR"
        '
        'btnRefresh
        '
        Me.btnRefresh.Activecolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.BorderRadius = 6
        Me.btnRefresh.ButtonText = "  Refresh"
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.DisabledColor = System.Drawing.Color.Gray
        Me.btnRefresh.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRefresh.Iconimage = CType(resources.GetObject("btnRefresh.Iconimage"), System.Drawing.Image)
        Me.btnRefresh.Iconimage_right = Nothing
        Me.btnRefresh.Iconimage_right_Selected = Nothing
        Me.btnRefresh.Iconimage_Selected = Nothing
        Me.btnRefresh.IconMarginLeft = 0
        Me.btnRefresh.IconMarginRight = 0
        Me.btnRefresh.IconRightVisible = True
        Me.btnRefresh.IconRightZoom = 0.0R
        Me.btnRefresh.IconVisible = True
        Me.btnRefresh.IconZoom = 50.0R
        Me.btnRefresh.IsTab = True
        Me.btnRefresh.Location = New System.Drawing.Point(923, 576)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnRefresh.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRefresh.selected = False
        Me.btnRefresh.Size = New System.Drawing.Size(155, 40)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "  Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Textcolor = System.Drawing.Color.White
        Me.btnRefresh.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1098, 628)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.listEm)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.Header.ResumeLayout(False)
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.listEm.ResumeLayout(False)
        Me.listEm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMaximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents listEm As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridEmployee As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lblCount As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picShow As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents btnEdit As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnDelete As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFirstname As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblPassword As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblIDnumber As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRank As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMiddlename As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblLastname As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRank2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMiddlename1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblLastname1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblFirstname1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblPassword1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblIDnumber1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTypeOfAccount As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSearchEm As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnRefresh As Bunifu.Framework.UI.BunifuFlatButton
End Class
