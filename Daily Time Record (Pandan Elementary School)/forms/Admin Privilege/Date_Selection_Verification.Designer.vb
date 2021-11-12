<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Date_Selection_Verification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Date_Selection_Verification))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.cmbxYear = New System.Windows.Forms.ComboBox()
        Me.cmbxMonth = New System.Windows.Forms.ComboBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblMonth = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblYear = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Header.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Header
        '
        Me.Header.BackgroundImage = CType(resources.GetObject("Header.BackgroundImage"), System.Drawing.Image)
        Me.Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Header.Controls.Add(Me.BunifuCustomLabel1)
        Me.Header.Controls.Add(Me.BunifuImageButton1)
        Me.Header.Controls.Add(Me.BunifuImageButton4)
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
        Me.Header.Size = New System.Drawing.Size(533, 27)
        Me.Header.TabIndex = 12
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(28, 4)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(191, 20)
        Me.BunifuCustomLabel1.TabIndex = 195
        Me.BunifuCustomLabel1.Text = "Please Select Month and Year"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(507, 4)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(22, 22)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 4
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(1033, 3)
        Me.BunifuImageButton4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(22, 22)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 3
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(7, 4)
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
        'cmbxYear
        '
        Me.cmbxYear.BackColor = System.Drawing.Color.White
        Me.cmbxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbxYear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxYear.ForeColor = System.Drawing.Color.DimGray
        Me.cmbxYear.FormattingEnabled = True
        Me.cmbxYear.Items.AddRange(New Object() {"2019", "2018", "2017"})
        Me.cmbxYear.Location = New System.Drawing.Point(280, 90)
        Me.cmbxYear.Name = "cmbxYear"
        Me.cmbxYear.Size = New System.Drawing.Size(217, 28)
        Me.cmbxYear.TabIndex = 181
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
        Me.cmbxMonth.Location = New System.Drawing.Point(58, 90)
        Me.cmbxMonth.Name = "cmbxMonth"
        Me.cmbxMonth.Size = New System.Drawing.Size(217, 28)
        Me.cmbxMonth.TabIndex = 180
        Me.cmbxMonth.Text = "Month"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.lblYear)
        Me.BunifuGradientPanel1.Controls.Add(Me.lblMonth)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnLogin)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.cmbxYear)
        Me.BunifuGradientPanel1.Controls.Add(Me.cmbxMonth)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.Window
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 27)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(533, 224)
        Me.BunifuGradientPanel1.TabIndex = 182
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 6
        Me.btnLogin.ButtonText = "      Verify Date"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogin.Iconimage = CType(resources.GetObject("btnLogin.Iconimage"), System.Drawing.Image)
        Me.btnLogin.Iconimage_right = Nothing
        Me.btnLogin.Iconimage_right_Selected = Nothing
        Me.btnLogin.Iconimage_Selected = Nothing
        Me.btnLogin.IconMarginLeft = 0
        Me.btnLogin.IconMarginRight = 0
        Me.btnLogin.IconRightVisible = True
        Me.btnLogin.IconRightZoom = 0.0R
        Me.btnLogin.IconVisible = True
        Me.btnLogin.IconZoom = 50.0R
        Me.btnLogin.IsTab = True
        Me.btnLogin.Location = New System.Drawing.Point(165, 134)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(234, 43)
        Me.btnLogin.TabIndex = 197
        Me.btnLogin.Text = "      Verify Date"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Textcolor = System.Drawing.Color.White
        Me.btnLogin.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(172, 23)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(219, 37)
        Me.BunifuCustomLabel2.TabIndex = 196
        Me.BunifuCustomLabel2.Text = "Date Verification"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblMonth.Font = New System.Drawing.Font("Segoe UI Light", 11.75!)
        Me.lblMonth.ForeColor = System.Drawing.Color.White
        Me.lblMonth.Location = New System.Drawing.Point(54, 66)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(18, 21)
        Me.lblMonth.TabIndex = 198
        Me.lblMonth.Text = ".."
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Segoe UI Light", 11.75!)
        Me.lblYear.ForeColor = System.Drawing.Color.White
        Me.lblYear.Location = New System.Drawing.Point(281, 66)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(18, 21)
        Me.lblYear.TabIndex = 199
        Me.lblYear.Text = ".."
        '
        'Date_Selection_Verification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 251)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Date_Selection_Verification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents cmbxYear As System.Windows.Forms.ComboBox
    Public WithEvents cmbxMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblYear As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMonth As Bunifu.Framework.UI.BunifuCustomLabel
End Class
