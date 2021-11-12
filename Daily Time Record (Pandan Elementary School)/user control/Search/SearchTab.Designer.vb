<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchTab))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.line = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblSearchEmployee = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Search_Employee1 = New Daily_Time_Record.Search_Employee()
        Me.lblSearchDTR = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Search_DTR1 = New Daily_Time_Record.Search_DTR()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSearchDTR)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.line)
        Me.Panel1.Controls.Add(Me.lblSearchEmployee)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1019, 131)
        Me.Panel1.TabIndex = 1
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
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(291, 21)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "Elementary School. Sogod Southern Leyte"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Light", 31.75!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(315, 30)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(385, 59)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "SEARCH EMPLOYEE"
        '
        'line
        '
        Me.line.BackColor = System.Drawing.Color.Transparent
        Me.line.Cursor = System.Windows.Forms.Cursors.Hand
        Me.line.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.line.LineThickness = 4
        Me.line.Location = New System.Drawing.Point(41, 122)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(98, 12)
        Me.line.TabIndex = 3
        Me.line.Transparency = 255
        Me.line.Vertical = False
        '
        'lblSearchEmployee
        '
        Me.lblSearchEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearchEmployee.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchEmployee.ForeColor = System.Drawing.Color.White
        Me.lblSearchEmployee.Location = New System.Drawing.Point(37, 105)
        Me.lblSearchEmployee.Name = "lblSearchEmployee"
        Me.lblSearchEmployee.Size = New System.Drawing.Size(102, 21)
        Me.lblSearchEmployee.TabIndex = 4
        Me.lblSearchEmployee.Text = "Search"
        Me.lblSearchEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Search_Employee1
        '
        Me.Search_Employee1.BackColor = System.Drawing.Color.White
        Me.Search_Employee1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Search_Employee1.Location = New System.Drawing.Point(0, 131)
        Me.Search_Employee1.Name = "Search_Employee1"
        Me.Search_Employee1.Size = New System.Drawing.Size(1019, 474)
        Me.Search_Employee1.TabIndex = 2
        '
        'lblSearchDTR
        '
        Me.lblSearchDTR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearchDTR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchDTR.ForeColor = System.Drawing.Color.White
        Me.lblSearchDTR.Location = New System.Drawing.Point(147, 105)
        Me.lblSearchDTR.Name = "lblSearchDTR"
        Me.lblSearchDTR.Size = New System.Drawing.Size(125, 21)
        Me.lblSearchDTR.TabIndex = 8
        Me.lblSearchDTR.Text = "Search DTR"
        Me.lblSearchDTR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Search_DTR1
        '
        Me.Search_DTR1.BackColor = System.Drawing.Color.White
        Me.Search_DTR1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Search_DTR1.Location = New System.Drawing.Point(0, 131)
        Me.Search_DTR1.Name = "Search_DTR1"
        Me.Search_DTR1.Size = New System.Drawing.Size(1019, 474)
        Me.Search_DTR1.TabIndex = 3
        '
        'SearchTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Search_Employee1)
        Me.Controls.Add(Me.Search_DTR1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SearchTab"
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
    Friend WithEvents lblSearchEmployee As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Search_Employee1 As Daily_Time_Record.Search_Employee
    Friend WithEvents lblSearchDTR As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Search_DTR1 As Daily_Time_Record.Search_DTR

End Class
