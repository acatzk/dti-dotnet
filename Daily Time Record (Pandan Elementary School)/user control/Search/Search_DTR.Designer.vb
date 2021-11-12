<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_DTR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_DTR))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPrintDTR = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.dataGridLRecordsEmploo = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Morning_In = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Morning_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Afternoon_In = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Afternoon_Out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Undertime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtIDnumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cmbxYear = New System.Windows.Forms.ComboBox()
        Me.cmbxMonth = New System.Windows.Forms.ComboBox()
        Me.lblTypeOfAccount = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblIDnumber = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblEmployeeName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PanelIdentity = New System.Windows.Forms.Panel()
        Me.picShow = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dataGridLRecordsEmploo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIdentity.SuspendLayout()
        CType(Me.picShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrintDTR
        '
        Me.btnPrintDTR.Activecolor = System.Drawing.Color.Gray
        Me.btnPrintDTR.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPrintDTR.BackColor = System.Drawing.Color.Gray
        Me.btnPrintDTR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintDTR.BorderRadius = 3
        Me.btnPrintDTR.ButtonText = "    Print DTR"
        Me.btnPrintDTR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintDTR.DisabledColor = System.Drawing.Color.Gray
        Me.btnPrintDTR.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrintDTR.Iconimage = CType(resources.GetObject("btnPrintDTR.Iconimage"), System.Drawing.Image)
        Me.btnPrintDTR.Iconimage_right = Nothing
        Me.btnPrintDTR.Iconimage_right_Selected = Nothing
        Me.btnPrintDTR.Iconimage_Selected = Nothing
        Me.btnPrintDTR.IconMarginLeft = 0
        Me.btnPrintDTR.IconMarginRight = 0
        Me.btnPrintDTR.IconRightVisible = True
        Me.btnPrintDTR.IconRightZoom = 0.0R
        Me.btnPrintDTR.IconVisible = True
        Me.btnPrintDTR.IconZoom = 50.0R
        Me.btnPrintDTR.IsTab = True
        Me.btnPrintDTR.Location = New System.Drawing.Point(843, 431)
        Me.btnPrintDTR.Name = "btnPrintDTR"
        Me.btnPrintDTR.Normalcolor = System.Drawing.Color.Gray
        Me.btnPrintDTR.OnHovercolor = System.Drawing.Color.DimGray
        Me.btnPrintDTR.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrintDTR.selected = False
        Me.btnPrintDTR.Size = New System.Drawing.Size(167, 38)
        Me.btnPrintDTR.TabIndex = 183
        Me.btnPrintDTR.Text = "    Print DTR"
        Me.btnPrintDTR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintDTR.Textcolor = System.Drawing.Color.White
        Me.btnPrintDTR.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 7
        Me.BunifuElipse2.TargetControl = Me.dataGridLRecordsEmploo
        '
        'dataGridLRecordsEmploo
        '
        Me.dataGridLRecordsEmploo.AllowUserToAddRows = False
        Me.dataGridLRecordsEmploo.AllowUserToDeleteRows = False
        Me.dataGridLRecordsEmploo.AllowUserToResizeColumns = False
        Me.dataGridLRecordsEmploo.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridLRecordsEmploo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridLRecordsEmploo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridLRecordsEmploo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridLRecordsEmploo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dataGridLRecordsEmploo.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridLRecordsEmploo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridLRecordsEmploo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dataGridLRecordsEmploo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridLRecordsEmploo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridLRecordsEmploo.ColumnHeadersHeight = 34
        Me.dataGridLRecordsEmploo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Day, Me.Morning_In, Me.Morning_out, Me.Afternoon_In, Me.Afternoon_Out, Me.Column1, Me.Column2, Me.Undertime})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridLRecordsEmploo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridLRecordsEmploo.DoubleBuffered = True
        Me.dataGridLRecordsEmploo.EnableHeadersVisualStyles = False
        Me.dataGridLRecordsEmploo.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dataGridLRecordsEmploo.HeaderBgColor = System.Drawing.Color.LightGray
        Me.dataGridLRecordsEmploo.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataGridLRecordsEmploo.Location = New System.Drawing.Point(295, 76)
        Me.dataGridLRecordsEmploo.Name = "dataGridLRecordsEmploo"
        Me.dataGridLRecordsEmploo.ReadOnly = True
        Me.dataGridLRecordsEmploo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridLRecordsEmploo.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridLRecordsEmploo.RowHeadersVisible = False
        Me.dataGridLRecordsEmploo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dataGridLRecordsEmploo.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridLRecordsEmploo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridLRecordsEmploo.Size = New System.Drawing.Size(715, 351)
        Me.dataGridLRecordsEmploo.TabIndex = 180
        '
        'Day
        '
        Me.Day.HeaderText = "Date"
        Me.Day.Name = "Day"
        Me.Day.ReadOnly = True
        '
        'Morning_In
        '
        Me.Morning_In.HeaderText = "Arrival"
        Me.Morning_In.Name = "Morning_In"
        Me.Morning_In.ReadOnly = True
        '
        'Morning_out
        '
        Me.Morning_out.HeaderText = "Departure"
        Me.Morning_out.Name = "Morning_out"
        Me.Morning_out.ReadOnly = True
        '
        'Afternoon_In
        '
        Me.Afternoon_In.HeaderText = "Arrival"
        Me.Afternoon_In.Name = "Afternoon_In"
        Me.Afternoon_In.ReadOnly = True
        '
        'Afternoon_Out
        '
        Me.Afternoon_Out.HeaderText = "Departure"
        Me.Afternoon_Out.Name = "Afternoon_Out"
        Me.Afternoon_Out.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Total AM"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Total PM"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Undertime
        '
        Me.Undertime.HeaderText = "Undertime"
        Me.Undertime.Name = "Undertime"
        Me.Undertime.ReadOnly = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'txtIDnumber
        '
        Me.txtIDnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDnumber.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIDnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIDnumber.HintForeColor = System.Drawing.Color.Gray
        Me.txtIDnumber.HintText = "ID number"
        Me.txtIDnumber.isPassword = False
        Me.txtIDnumber.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtIDnumber.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtIDnumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.txtIDnumber.LineThickness = 2
        Me.txtIDnumber.Location = New System.Drawing.Point(33, 25)
        Me.txtIDnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDnumber.Name = "txtIDnumber"
        Me.txtIDnumber.Size = New System.Drawing.Size(178, 33)
        Me.txtIDnumber.TabIndex = 177
        Me.txtIDnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmbxYear
        '
        Me.cmbxYear.BackColor = System.Drawing.Color.White
        Me.cmbxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbxYear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxYear.ForeColor = System.Drawing.Color.DimGray
        Me.cmbxYear.FormattingEnabled = True
        Me.cmbxYear.Location = New System.Drawing.Point(391, 29)
        Me.cmbxYear.Name = "cmbxYear"
        Me.cmbxYear.Size = New System.Drawing.Size(148, 28)
        Me.cmbxYear.TabIndex = 179
        Me.cmbxYear.Text = "Year"
        '
        'cmbxMonth
        '
        Me.cmbxMonth.BackColor = System.Drawing.Color.White
        Me.cmbxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbxMonth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxMonth.ForeColor = System.Drawing.Color.DimGray
        Me.cmbxMonth.FormattingEnabled = True
        Me.cmbxMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbxMonth.Location = New System.Drawing.Point(232, 29)
        Me.cmbxMonth.Name = "cmbxMonth"
        Me.cmbxMonth.Size = New System.Drawing.Size(148, 28)
        Me.cmbxMonth.TabIndex = 178
        Me.cmbxMonth.Text = "Month"
        '
        'lblTypeOfAccount
        '
        Me.lblTypeOfAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTypeOfAccount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblTypeOfAccount.Location = New System.Drawing.Point(0, 2)
        Me.lblTypeOfAccount.Name = "lblTypeOfAccount"
        Me.lblTypeOfAccount.Size = New System.Drawing.Size(204, 21)
        Me.lblTypeOfAccount.TabIndex = 15
        '
        'lblIDnumber
        '
        Me.lblIDnumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIDnumber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblIDnumber.Location = New System.Drawing.Point(60, 209)
        Me.lblIDnumber.Name = "lblIDnumber"
        Me.lblIDnumber.Size = New System.Drawing.Size(153, 21)
        Me.lblIDnumber.TabIndex = 14
        Me.lblIDnumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.Gray
        Me.lblEmployeeName.Location = New System.Drawing.Point(8, 234)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(259, 75)
        Me.lblEmployeeName.TabIndex = 13
        Me.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelIdentity
        '
        Me.PanelIdentity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelIdentity.Controls.Add(Me.lblTypeOfAccount)
        Me.PanelIdentity.Controls.Add(Me.lblIDnumber)
        Me.PanelIdentity.Controls.Add(Me.lblEmployeeName)
        Me.PanelIdentity.Controls.Add(Me.picShow)
        Me.PanelIdentity.Controls.Add(Me.BunifuSeparator4)
        Me.PanelIdentity.Location = New System.Drawing.Point(13, 76)
        Me.PanelIdentity.Name = "PanelIdentity"
        Me.PanelIdentity.Size = New System.Drawing.Size(276, 309)
        Me.PanelIdentity.TabIndex = 181
        '
        'picShow
        '
        Me.picShow.BackgroundImage = CType(resources.GetObject("picShow.BackgroundImage"), System.Drawing.Image)
        Me.picShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShow.Location = New System.Drawing.Point(48, 30)
        Me.picShow.Name = "picShow"
        Me.picShow.Size = New System.Drawing.Size(176, 177)
        Me.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShow.TabIndex = 12
        Me.picShow.TabStop = False
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(40, 226)
        Me.BunifuSeparator4.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(199, 10)
        Me.BunifuSeparator4.TabIndex = 203
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me.picShow
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(548, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 33)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 182
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.PanelIdentity
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(37, 58)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(494, 10)
        Me.BunifuSeparator1.TabIndex = 204
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(950, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 206
        Me.PictureBox1.TabStop = False
        '
        'Search_DTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.btnPrintDTR)
        Me.Controls.Add(Me.txtIDnumber)
        Me.Controls.Add(Me.cmbxYear)
        Me.Controls.Add(Me.cmbxMonth)
        Me.Controls.Add(Me.PanelIdentity)
        Me.Controls.Add(Me.dataGridLRecordsEmploo)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "Search_DTR"
        Me.Size = New System.Drawing.Size(1019, 474)
        CType(Me.dataGridLRecordsEmploo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIdentity.ResumeLayout(False)
        CType(Me.picShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnPrintDTR As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents dataGridLRecordsEmploo As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtIDnumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cmbxYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxMonth As System.Windows.Forms.ComboBox
    Friend WithEvents PanelIdentity As System.Windows.Forms.Panel
    Friend WithEvents lblTypeOfAccount As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblIDnumber As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblEmployeeName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents picShow As System.Windows.Forms.PictureBox
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Day As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Morning_In As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Morning_out As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Afternoon_In As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Afternoon_Out As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Undertime As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
