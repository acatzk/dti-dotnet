<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit))
        Me.btnEmploDetails_Update = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.picEmployeeDetailsShow = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblI = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.picEmployeeDetailsShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmploDetails_Update
        '
        Me.btnEmploDetails_Update.Activecolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEmploDetails_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEmploDetails_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmploDetails_Update.BorderRadius = 7
        Me.btnEmploDetails_Update.ButtonText = "Save Changes"
        Me.btnEmploDetails_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmploDetails_Update.DisabledColor = System.Drawing.Color.Gray
        Me.btnEmploDetails_Update.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmploDetails_Update.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEmploDetails_Update.Iconimage = CType(resources.GetObject("btnEmploDetails_Update.Iconimage"), System.Drawing.Image)
        Me.btnEmploDetails_Update.Iconimage_right = Nothing
        Me.btnEmploDetails_Update.Iconimage_right_Selected = Nothing
        Me.btnEmploDetails_Update.Iconimage_Selected = Nothing
        Me.btnEmploDetails_Update.IconMarginLeft = 0
        Me.btnEmploDetails_Update.IconMarginRight = 0
        Me.btnEmploDetails_Update.IconRightVisible = True
        Me.btnEmploDetails_Update.IconRightZoom = 0.0R
        Me.btnEmploDetails_Update.IconVisible = True
        Me.btnEmploDetails_Update.IconZoom = 50.0R
        Me.btnEmploDetails_Update.IsTab = True
        Me.btnEmploDetails_Update.Location = New System.Drawing.Point(312, 204)
        Me.btnEmploDetails_Update.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEmploDetails_Update.Name = "btnEmploDetails_Update"
        Me.btnEmploDetails_Update.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEmploDetails_Update.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEmploDetails_Update.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEmploDetails_Update.selected = False
        Me.btnEmploDetails_Update.Size = New System.Drawing.Size(179, 38)
        Me.btnEmploDetails_Update.TabIndex = 189
        Me.btnEmploDetails_Update.Text = "Save Changes"
        Me.btnEmploDetails_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmploDetails_Update.Textcolor = System.Drawing.Color.White
        Me.btnEmploDetails_Update.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.txtNewPass)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 90)
        Me.Panel1.TabIndex = 180
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(245, 11)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(122, 21)
        Me.BunifuCustomLabel1.TabIndex = 176
        Me.BunifuCustomLabel1.Text = "New Password"
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.Color.White
        Me.txtNewPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.ForeColor = System.Drawing.Color.DimGray
        Me.txtNewPass.Location = New System.Drawing.Point(247, 32)
        Me.txtNewPass.Multiline = True
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(223, 35)
        Me.txtNewPass.TabIndex = 175
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.Enabled = False
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.DimGray
        Me.txtPass.Location = New System.Drawing.Point(18, 32)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(223, 35)
        Me.txtPass.TabIndex = 173
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(14, 11)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(82, 21)
        Me.BunifuCustomLabel2.TabIndex = 174
        Me.BunifuCustomLabel2.Text = "Password"
        '
        'picEmployeeDetailsShow
        '
        Me.picEmployeeDetailsShow.BackgroundImage = CType(resources.GetObject("picEmployeeDetailsShow.BackgroundImage"), System.Drawing.Image)
        Me.picEmployeeDetailsShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEmployeeDetailsShow.Location = New System.Drawing.Point(33, 6)
        Me.picEmployeeDetailsShow.Name = "picEmployeeDetailsShow"
        Me.picEmployeeDetailsShow.Size = New System.Drawing.Size(100, 94)
        Me.picEmployeeDetailsShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmployeeDetailsShow.TabIndex = 190
        Me.picEmployeeDetailsShow.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 220
        Me.BunifuElipse1.TargetControl = Me.picEmployeeDetailsShow
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(139, 28)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(155, 21)
        Me.lblName.TabIndex = 191
        Me.lblName.Text = "Joshua A. Galit"
        '
        'lblI
        '
        Me.lblI.BackColor = System.Drawing.Color.Transparent
        Me.lblI.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblI.ForeColor = System.Drawing.Color.DimGray
        Me.lblI.Location = New System.Drawing.Point(139, 49)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(238, 21)
        Me.lblI.TabIndex = 192
        Me.lblI.Text = "1511444-1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(509, 252)
        Me.Controls.Add(Me.lblI)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picEmployeeDetailsShow)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEmploDetails_Update)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Something?"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picEmployeeDetailsShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnEmploDetails_Update As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents picEmployeeDetailsShow As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblI As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
