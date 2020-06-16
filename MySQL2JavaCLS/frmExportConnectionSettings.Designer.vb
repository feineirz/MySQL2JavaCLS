<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportConnectionSettings
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportConnectionSettings))
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.lblSubTitle = New System.Windows.Forms.Label()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.picLinkIcon = New System.Windows.Forms.PictureBox()
		Me.chkUseUnicode = New System.Windows.Forms.CheckBox()
		Me.chkUseJDBCCompliantTimezoneShift = New System.Windows.Forms.CheckBox()
		Me.chkUseLegacyDatetimeCode = New System.Windows.Forms.CheckBox()
		Me.chkAutoReconnect = New System.Windows.Forms.CheckBox()
		Me.chkUseSSL = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.cmbForMySQLVersion = New System.Windows.Forms.ComboBox()
		Me.tbxServerTimezone = New System.Windows.Forms.TextBox()
		Me.tbxCharacterEncoding = New System.Windows.Forms.TextBox()
		Me.btnGetDBConnector = New System.Windows.Forms.Button()
		Me.pnlHeader.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picLinkIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlHeader
		'
		Me.pnlHeader.BackColor = System.Drawing.Color.DimGray
		Me.pnlHeader.Controls.Add(Me.btnClose)
		Me.pnlHeader.Controls.Add(Me.picIcon)
		Me.pnlHeader.Controls.Add(Me.lblSubTitle)
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(372, 60)
		Me.pnlHeader.TabIndex = 1
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.FlatAppearance.BorderSize = 0
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
		Me.btnClose.Location = New System.Drawing.Point(338, 4)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(30, 26)
		Me.btnClose.TabIndex = 99
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'picIcon
		'
		Me.picIcon.BackColor = System.Drawing.Color.Transparent
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.Location = New System.Drawing.Point(8, 5)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(56, 48)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 2
		Me.picIcon.TabStop = False
		'
		'lblSubTitle
		'
		Me.lblSubTitle.AutoSize = True
		Me.lblSubTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSubTitle.ForeColor = System.Drawing.Color.White
		Me.lblSubTitle.Location = New System.Drawing.Point(72, 33)
		Me.lblSubTitle.Name = "lblSubTitle"
		Me.lblSubTitle.Size = New System.Drawing.Size(192, 16)
		Me.lblSubTitle.TabIndex = 1
		Me.lblSubTitle.Text = "Setting connection options."
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(70, 7)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(194, 25)
		Me.lblTitle.TabIndex = 0
		Me.lblTitle.Text = "Export Settings"
		'
		'picLinkIcon
		'
		Me.picLinkIcon.Image = CType(resources.GetObject("picLinkIcon.Image"), System.Drawing.Image)
		Me.picLinkIcon.Location = New System.Drawing.Point(14, 11)
		Me.picLinkIcon.Name = "picLinkIcon"
		Me.picLinkIcon.Size = New System.Drawing.Size(75, 64)
		Me.picLinkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picLinkIcon.TabIndex = 13
		Me.picLinkIcon.TabStop = False
		'
		'chkUseUnicode
		'
		Me.chkUseUnicode.AutoSize = True
		Me.chkUseUnicode.Checked = True
		Me.chkUseUnicode.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkUseUnicode.Location = New System.Drawing.Point(108, 107)
		Me.chkUseUnicode.Name = "chkUseUnicode"
		Me.chkUseUnicode.Size = New System.Drawing.Size(96, 17)
		Me.chkUseUnicode.TabIndex = 14
		Me.chkUseUnicode.Text = "Use Unicode"
		Me.chkUseUnicode.UseVisualStyleBackColor = True
		'
		'chkUseJDBCCompliantTimezoneShift
		'
		Me.chkUseJDBCCompliantTimezoneShift.AutoSize = True
		Me.chkUseJDBCCompliantTimezoneShift.Checked = True
		Me.chkUseJDBCCompliantTimezoneShift.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkUseJDBCCompliantTimezoneShift.Location = New System.Drawing.Point(108, 130)
		Me.chkUseJDBCCompliantTimezoneShift.Name = "chkUseJDBCCompliantTimezoneShift"
		Me.chkUseJDBCCompliantTimezoneShift.Size = New System.Drawing.Size(221, 17)
		Me.chkUseJDBCCompliantTimezoneShift.TabIndex = 15
		Me.chkUseJDBCCompliantTimezoneShift.Text = "Use JDBCCompliantTimezoneShift"
		Me.chkUseJDBCCompliantTimezoneShift.UseVisualStyleBackColor = True
		'
		'chkUseLegacyDatetimeCode
		'
		Me.chkUseLegacyDatetimeCode.AutoSize = True
		Me.chkUseLegacyDatetimeCode.Location = New System.Drawing.Point(108, 153)
		Me.chkUseLegacyDatetimeCode.Name = "chkUseLegacyDatetimeCode"
		Me.chkUseLegacyDatetimeCode.Size = New System.Drawing.Size(173, 17)
		Me.chkUseLegacyDatetimeCode.TabIndex = 16
		Me.chkUseLegacyDatetimeCode.Text = "Use LegacyDatetimeCode"
		Me.chkUseLegacyDatetimeCode.UseVisualStyleBackColor = True
		'
		'chkAutoReconnect
		'
		Me.chkAutoReconnect.AutoSize = True
		Me.chkAutoReconnect.Checked = True
		Me.chkAutoReconnect.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkAutoReconnect.Location = New System.Drawing.Point(108, 199)
		Me.chkAutoReconnect.Name = "chkAutoReconnect"
		Me.chkAutoReconnect.Size = New System.Drawing.Size(115, 17)
		Me.chkAutoReconnect.TabIndex = 17
		Me.chkAutoReconnect.Text = "Auto Reconnect"
		Me.chkAutoReconnect.UseVisualStyleBackColor = True
		'
		'chkUseSSL
		'
		Me.chkUseSSL.AutoSize = True
		Me.chkUseSSL.Location = New System.Drawing.Point(108, 176)
		Me.chkUseSSL.Name = "chkUseSSL"
		Me.chkUseSSL.Size = New System.Drawing.Size(73, 17)
		Me.chkUseSSL.TabIndex = 18
		Me.chkUseSSL.Text = "Use SSL"
		Me.chkUseSSL.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(105, 41)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(119, 13)
		Me.Label1.TabIndex = 19
		Me.Label1.Text = "Character Encoding"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(105, 67)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(105, 13)
		Me.Label2.TabIndex = 20
		Me.Label2.Text = "Server Timezone"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(105, 14)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(68, 13)
		Me.Label17.TabIndex = 23
		Me.Label17.Text = "For MySQL"
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
		Me.Panel1.Controls.Add(Me.cmbForMySQLVersion)
		Me.Panel1.Controls.Add(Me.tbxServerTimezone)
		Me.Panel1.Controls.Add(Me.tbxCharacterEncoding)
		Me.Panel1.Controls.Add(Me.picLinkIcon)
		Me.Panel1.Controls.Add(Me.chkUseUnicode)
		Me.Panel1.Controls.Add(Me.Label17)
		Me.Panel1.Controls.Add(Me.chkUseJDBCCompliantTimezoneShift)
		Me.Panel1.Controls.Add(Me.chkUseLegacyDatetimeCode)
		Me.Panel1.Controls.Add(Me.chkAutoReconnect)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.chkUseSSL)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(14, 78)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(343, 232)
		Me.Panel1.TabIndex = 24
		'
		'cmbForMySQLVersion
		'
		Me.cmbForMySQLVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbForMySQLVersion.FormattingEnabled = True
		Me.cmbForMySQLVersion.Items.AddRange(New Object() {"Version 5.x", "Version 8.x"})
		Me.cmbForMySQLVersion.Location = New System.Drawing.Point(233, 11)
		Me.cmbForMySQLVersion.Name = "cmbForMySQLVersion"
		Me.cmbForMySQLVersion.Size = New System.Drawing.Size(96, 21)
		Me.cmbForMySQLVersion.TabIndex = 27
		'
		'tbxServerTimezone
		'
		Me.tbxServerTimezone.Location = New System.Drawing.Point(233, 64)
		Me.tbxServerTimezone.Name = "tbxServerTimezone"
		Me.tbxServerTimezone.Size = New System.Drawing.Size(96, 21)
		Me.tbxServerTimezone.TabIndex = 25
		Me.tbxServerTimezone.Text = "UTC"
		'
		'tbxCharacterEncoding
		'
		Me.tbxCharacterEncoding.Location = New System.Drawing.Point(233, 38)
		Me.tbxCharacterEncoding.Name = "tbxCharacterEncoding"
		Me.tbxCharacterEncoding.Size = New System.Drawing.Size(96, 21)
		Me.tbxCharacterEncoding.TabIndex = 24
		Me.tbxCharacterEncoding.Text = "utf-8"
		'
		'btnGetDBConnector
		'
		Me.btnGetDBConnector.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnGetDBConnector.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGetDBConnector.Image = CType(resources.GetObject("btnGetDBConnector.Image"), System.Drawing.Image)
		Me.btnGetDBConnector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnGetDBConnector.Location = New System.Drawing.Point(149, 316)
		Me.btnGetDBConnector.Name = "btnGetDBConnector"
		Me.btnGetDBConnector.Size = New System.Drawing.Size(208, 29)
		Me.btnGetDBConnector.TabIndex = 26
		Me.btnGetDBConnector.Text = "Export MySQLDBConnector"
		Me.btnGetDBConnector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnGetDBConnector.UseVisualStyleBackColor = True
		'
		'frmExportConnectionSettings
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(372, 359)
		Me.Controls.Add(Me.btnGetDBConnector)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.pnlHeader)
		Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmExportConnectionSettings"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "ExportConnectionSettings"
		Me.pnlHeader.ResumeLayout(False)
		Me.pnlHeader.PerformLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picLinkIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents btnClose As Button
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents lblSubTitle As Label
	Friend WithEvents lblTitle As Label
	Friend WithEvents picLinkIcon As PictureBox
	Friend WithEvents chkUseUnicode As CheckBox
	Friend WithEvents chkUseJDBCCompliantTimezoneShift As CheckBox
	Friend WithEvents chkUseLegacyDatetimeCode As CheckBox
	Friend WithEvents chkAutoReconnect As CheckBox
	Friend WithEvents chkUseSSL As CheckBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents tbxServerTimezone As TextBox
	Friend WithEvents tbxCharacterEncoding As TextBox
	Friend WithEvents btnGetDBConnector As Button
	Friend WithEvents cmbForMySQLVersion As ComboBox
End Class
