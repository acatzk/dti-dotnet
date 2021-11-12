<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttedanceTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttedanceTab))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.line = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblAttendance = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Body = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.line)
        Me.Panel1.Controls.Add(Me.lblAttendance)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1019, 131)
        Me.Panel1.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(837, 105)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(64, 25)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "Time :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(264, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI Light", 11.75!)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(324, 78)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(246, 21)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "Pandan Elementary School Records"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Light", 31.75!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(315, 30)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(401, 59)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "DAILY TIME RECORD"
        '
        'line
        '
        Me.line.BackColor = System.Drawing.Color.Transparent
        Me.line.Cursor = System.Windows.Forms.Cursors.Hand
        Me.line.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line.LineThickness = 4
        Me.line.Location = New System.Drawing.Point(39, 122)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(132, 12)
        Me.line.TabIndex = 3
        Me.line.Transparency = 255
        Me.line.Vertical = False
        '
        'lblAttendance
        '
        Me.lblAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAttendance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance.ForeColor = System.Drawing.Color.White
        Me.lblAttendance.Location = New System.Drawing.Point(39, 105)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(132, 21)
        Me.lblAttendance.TabIndex = 4
        Me.lblAttendance.Text = "Attendance"
        Me.lblAttendance.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Body
        '
        Me.Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Body.Location = New System.Drawing.Point(0, 131)
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(1019, 474)
        Me.Body.TabIndex = 3
        '
        'Timer1
        '
        '
        'AttedanceTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AttedanceTab"
        Me.Size = New System.Drawing.Size(1019, 605)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents line As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblAttendance As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Body As System.Windows.Forms.Panel
    ' Friend WithEvents Attendance1 As Daily_Time_Record__Pandan_Elementary_School_.Attendance
    ' Friend WithEvents Dtr1 As Daily_Time_Record__Pandan_Elementary_School_.DTR
    Friend WithEvents lblTime As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
