<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logout_PassCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logout_PassCode))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Header = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnLog = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblLog = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPassCode = New Bunifu.Framework.UI.BunifuTextbox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Header.SuspendLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Header
        '
        Me.Header.BackgroundImage = CType(resources.GetObject("Header.BackgroundImage"), System.Drawing.Image)
        Me.Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Header.Controls.Add(Me.BunifuCustomLabel1)
        Me.Header.Controls.Add(Me.BunifuImageButton4)
        Me.Header.Controls.Add(Me.btnExit)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.GradientBottomLeft = System.Drawing.Color.Black
        Me.Header.GradientBottomRight = System.Drawing.Color.Gray
        Me.Header.GradientTopLeft = System.Drawing.Color.Black
        Me.Header.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Quality = 10
        Me.Header.Size = New System.Drawing.Size(443, 27)
        Me.Header.TabIndex = 5
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(29, 4)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(237, 20)
        Me.BunifuCustomLabel1.TabIndex = 194
        Me.BunifuCustomLabel1.Text = "Warning : Authorized Personnel Only"
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(416, 3)
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
        Me.btnExit.Location = New System.Drawing.Point(6, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 1
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'txtPassword
        '
        Me.txtPassword.BorderColorFocused = System.Drawing.Color.White
        Me.txtPassword.BorderColorIdle = System.Drawing.Color.White
        Me.txtPassword.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtPassword.BorderThickness = 1
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.isPassword = True
        Me.txtPassword.Location = New System.Drawing.Point(106, 82)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(267, 29)
        Me.txtPassword.TabIndex = 198
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.Transparent
        Me.btnLog.Image = CType(resources.GetObject("btnLog.Image"), System.Drawing.Image)
        Me.btnLog.ImageActive = Nothing
        Me.btnLog.Location = New System.Drawing.Point(69, 82)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(33, 30)
        Me.btnLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLog.TabIndex = 195
        Me.btnLog.TabStop = False
        Me.btnLog.Zoom = 10
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLog.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLog.Location = New System.Drawing.Point(58, 52)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(107, 21)
        Me.lblLog.TabIndex = 197
        Me.lblLog.Text = "Enter Code :"
        '
        'txtPassCode
        '
        Me.txtPassCode.BackColor = System.Drawing.Color.White
        Me.txtPassCode.BackgroundImage = CType(resources.GetObject("txtPassCode.BackgroundImage"), System.Drawing.Image)
        Me.txtPassCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtPassCode.Enabled = False
        Me.txtPassCode.ForeColor = System.Drawing.Color.Gray
        Me.txtPassCode.Icon = CType(resources.GetObject("txtPassCode.Icon"), System.Drawing.Image)
        Me.txtPassCode.Location = New System.Drawing.Point(62, 76)
        Me.txtPassCode.Name = "txtPassCode"
        Me.txtPassCode.Size = New System.Drawing.Size(329, 42)
        Me.txtPassCode.TabIndex = 196
        Me.txtPassCode.text = ""
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Header
        Me.BunifuDragControl1.Vertical = True
        '
        'Logout_PassCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 151)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.txtPassCode)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Logout_PassCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Header As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnLog As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblLog As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPassCode As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
