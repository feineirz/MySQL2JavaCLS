<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.lblSubTitle = New System.Windows.Forms.Label()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.rtbSourceCode = New System.Windows.Forms.RichTextBox()
		Me.pnlDatabaseConnection = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.tbxHost = New System.Windows.Forms.TextBox()
		Me.tbxPort = New System.Windows.Forms.TextBox()
		Me.tbxUser = New System.Windows.Forms.TextBox()
		Me.tbxPass = New System.Windows.Forms.TextBox()
		Me.picServerIcon = New System.Windows.Forms.PictureBox()
		Me.btnConnect = New System.Windows.Forms.Button()
		Me.pnlHeader.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlDatabaseConnection.SuspendLayout()
		CType(Me.picServerIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlHeader
		'
		Me.pnlHeader.BackColor = System.Drawing.Color.DimGray
		Me.pnlHeader.Controls.Add(Me.btnExit)
		Me.pnlHeader.Controls.Add(Me.picIcon)
		Me.pnlHeader.Controls.Add(Me.lblSubTitle)
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(1411, 60)
		Me.pnlHeader.TabIndex = 0
		'
		'btnExit
		'
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnExit.FlatAppearance.BorderSize = 0
		Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
		Me.btnExit.Location = New System.Drawing.Point(1382, 3)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(26, 26)
		Me.btnExit.TabIndex = 3
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'picIcon
		'
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.Location = New System.Drawing.Point(7, 5)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(48, 48)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 2
		Me.picIcon.TabStop = False
		'
		'lblSubTitle
		'
		Me.lblSubTitle.AutoSize = True
		Me.lblSubTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSubTitle.ForeColor = System.Drawing.Color.White
		Me.lblSubTitle.Location = New System.Drawing.Point(59, 36)
		Me.lblSubTitle.Name = "lblSubTitle"
		Me.lblSubTitle.Size = New System.Drawing.Size(365, 16)
		Me.lblSubTitle.TabIndex = 1
		Me.lblSubTitle.Text = "Java class generator from MySQL version 8 database."
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(57, 7)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(342, 25)
		Me.lblTitle.TabIndex = 0
		Me.lblTitle.Text = "MySQL to Java Class Builder"
		'
		'rtbSourceCode
		'
		Me.rtbSourceCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtbSourceCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtbSourceCode.Location = New System.Drawing.Point(12, 71)
		Me.rtbSourceCode.Name = "rtbSourceCode"
		Me.rtbSourceCode.Size = New System.Drawing.Size(1081, 687)
		Me.rtbSourceCode.TabIndex = 1
		Me.rtbSourceCode.Text = ""
		'
		'pnlDatabaseConnection
		'
		Me.pnlDatabaseConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlDatabaseConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.pnlDatabaseConnection.Controls.Add(Me.btnConnect)
		Me.pnlDatabaseConnection.Controls.Add(Me.picServerIcon)
		Me.pnlDatabaseConnection.Controls.Add(Me.tbxPass)
		Me.pnlDatabaseConnection.Controls.Add(Me.tbxUser)
		Me.pnlDatabaseConnection.Controls.Add(Me.tbxPort)
		Me.pnlDatabaseConnection.Controls.Add(Me.tbxHost)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label5)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label4)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label3)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label2)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label1)
		Me.pnlDatabaseConnection.Location = New System.Drawing.Point(1099, 71)
		Me.pnlDatabaseConnection.Name = "pnlDatabaseConnection"
		Me.pnlDatabaseConnection.Size = New System.Drawing.Size(300, 187)
		Me.pnlDatabaseConnection.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(153, 14)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Connection Properties"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(101, 35)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(44, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Host :"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(103, 62)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(42, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Port :"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(99, 89)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(45, 13)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "User :"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(99, 116)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(45, 13)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Pass :"
		'
		'tbxHost
		'
		Me.tbxHost.Location = New System.Drawing.Point(147, 32)
		Me.tbxHost.Name = "tbxHost"
		Me.tbxHost.Size = New System.Drawing.Size(126, 21)
		Me.tbxHost.TabIndex = 5
		'
		'tbxPort
		'
		Me.tbxPort.Location = New System.Drawing.Point(147, 59)
		Me.tbxPort.Name = "tbxPort"
		Me.tbxPort.Size = New System.Drawing.Size(126, 21)
		Me.tbxPort.TabIndex = 6
		'
		'tbxUser
		'
		Me.tbxUser.Location = New System.Drawing.Point(147, 86)
		Me.tbxUser.Name = "tbxUser"
		Me.tbxUser.Size = New System.Drawing.Size(126, 21)
		Me.tbxUser.TabIndex = 7
		'
		'tbxPass
		'
		Me.tbxPass.Location = New System.Drawing.Point(147, 113)
		Me.tbxPass.Name = "tbxPass"
		Me.tbxPass.Size = New System.Drawing.Size(126, 21)
		Me.tbxPass.TabIndex = 8
		'
		'picServerIcon
		'
		Me.picServerIcon.Image = CType(resources.GetObject("picServerIcon.Image"), System.Drawing.Image)
		Me.picServerIcon.Location = New System.Drawing.Point(17, 35)
		Me.picServerIcon.Name = "picServerIcon"
		Me.picServerIcon.Size = New System.Drawing.Size(64, 64)
		Me.picServerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picServerIcon.TabIndex = 9
		Me.picServerIcon.TabStop = False
		'
		'btnConnect
		'
		Me.btnConnect.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnConnect.Image = CType(resources.GetObject("btnConnect.Image"), System.Drawing.Image)
		Me.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnConnect.Location = New System.Drawing.Point(186, 143)
		Me.btnConnect.Name = "btnConnect"
		Me.btnConnect.Size = New System.Drawing.Size(87, 29)
		Me.btnConnect.TabIndex = 10
		Me.btnConnect.Text = "Connect"
		Me.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnConnect.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(1411, 770)
		Me.Controls.Add(Me.pnlDatabaseConnection)
		Me.Controls.Add(Me.rtbSourceCode)
		Me.Controls.Add(Me.pnlHeader)
		Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MySQL to Java Class Builder"
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlDatabaseConnection.ResumeLayout(False)
		Me.pnlDatabaseConnection.PerformLayout()
		CType(Me.picServerIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblSubTitle As Label
	Friend WithEvents lblTitle As Label
	Friend WithEvents rtbSourceCode As RichTextBox
	Friend WithEvents pnlDatabaseConnection As Panel
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents btnExit As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents tbxPass As TextBox
	Friend WithEvents tbxUser As TextBox
	Friend WithEvents tbxPort As TextBox
	Friend WithEvents tbxHost As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents picServerIcon As PictureBox
	Friend WithEvents btnConnect As Button
End Class
