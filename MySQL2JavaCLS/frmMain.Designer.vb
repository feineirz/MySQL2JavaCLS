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
		Me.Label16 = New System.Windows.Forms.Label()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.lblSubTitle = New System.Windows.Forms.Label()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.rtbSourceCode = New System.Windows.Forms.RichTextBox()
		Me.pnlDatabaseConnection = New System.Windows.Forms.Panel()
		Me.btnSaveProfile = New System.Windows.Forms.Button()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.cmbConnectionProfile = New System.Windows.Forms.ComboBox()
		Me.picLinkIcon = New System.Windows.Forms.PictureBox()
		Me.tbxDatabase = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnConnect = New System.Windows.Forms.Button()
		Me.tbxPass = New System.Windows.Forms.TextBox()
		Me.tbxUser = New System.Windows.Forms.TextBox()
		Me.tbxPort = New System.Windows.Forms.TextBox()
		Me.tbxHost = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnGetDBConnector = New System.Windows.Forms.Button()
		Me.picServerIcon = New System.Windows.Forms.PictureBox()
		Me.pnlDatabaseProperties = New System.Windows.Forms.Panel()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.lblTableCollation = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.lvwColumnList = New System.Windows.Forms.ListView()
		Me.colColumnName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colDataType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colNullable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colKey = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.cmbTableList = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.btnBuild = New System.Windows.Forms.Button()
		Me.pnlClassProperties = New System.Windows.Forms.Panel()
		Me.lblPrimaryKeyDataType = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.chkReadOnlyPrimaryKey = New System.Windows.Forms.CheckBox()
		Me.cmbPrimaryKey = New System.Windows.Forms.ComboBox()
		Me.picClassIcon = New System.Windows.Forms.PictureBox()
		Me.tbxClassName = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.pnlCommand = New System.Windows.Forms.Panel()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.rdbForVersion8 = New System.Windows.Forms.RadioButton()
		Me.rdbForVersion5 = New System.Windows.Forms.RadioButton()
		Me.btnSaveClassFile = New System.Windows.Forms.Button()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.chkLowercaseColumnName = New System.Windows.Forms.CheckBox()
		Me.btnChangeFont = New System.Windows.Forms.Button()
		Me.lblAppVersion = New System.Windows.Forms.Label()
		Me.pnlHeader.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlDatabaseConnection.SuspendLayout()
		CType(Me.picLinkIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picServerIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlDatabaseProperties.SuspendLayout()
		Me.pnlClassProperties.SuspendLayout()
		CType(Me.picClassIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlCommand.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlHeader
		'
		Me.pnlHeader.BackColor = System.Drawing.Color.DimGray
		Me.pnlHeader.Controls.Add(Me.Label16)
		Me.pnlHeader.Controls.Add(Me.btnExit)
		Me.pnlHeader.Controls.Add(Me.picIcon)
		Me.pnlHeader.Controls.Add(Me.lblSubTitle)
		Me.pnlHeader.Controls.Add(Me.lblTitle)
		Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(1500, 60)
		Me.pnlHeader.TabIndex = 0
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.ForeColor = System.Drawing.Color.White
		Me.Label16.Location = New System.Drawing.Point(399, 13)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(76, 18)
		Me.Label16.TabIndex = 100
		Me.Label16.Text = "(Beta 2)"
		'
		'btnExit
		'
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnExit.FlatAppearance.BorderSize = 0
		Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
		Me.btnExit.Location = New System.Drawing.Point(1469, 3)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(26, 26)
		Me.btnExit.TabIndex = 99
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'picIcon
		'
		Me.picIcon.BackColor = System.Drawing.Color.White
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
		Me.lblSubTitle.Location = New System.Drawing.Point(62, 33)
		Me.lblSubTitle.Name = "lblSubTitle"
		Me.lblSubTitle.Size = New System.Drawing.Size(296, 16)
		Me.lblSubTitle.TabIndex = 1
		Me.lblSubTitle.Text = "Java class generator for MySQL databases."
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(60, 7)
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
		Me.rtbSourceCode.BackColor = System.Drawing.Color.WhiteSmoke
		Me.rtbSourceCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtbSourceCode.Font = New System.Drawing.Font("Source Code Pro", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rtbSourceCode.ForeColor = System.Drawing.Color.Black
		Me.rtbSourceCode.Location = New System.Drawing.Point(12, 71)
		Me.rtbSourceCode.Name = "rtbSourceCode"
		Me.rtbSourceCode.ReadOnly = True
		Me.rtbSourceCode.Size = New System.Drawing.Size(1102, 825)
		Me.rtbSourceCode.TabIndex = 1
		Me.rtbSourceCode.Text = ""
		'
		'pnlDatabaseConnection
		'
		Me.pnlDatabaseConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlDatabaseConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.pnlDatabaseConnection.Controls.Add(Me.btnSaveProfile)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label9)
		Me.pnlDatabaseConnection.Controls.Add(Me.cmbConnectionProfile)
		Me.pnlDatabaseConnection.Controls.Add(Me.picLinkIcon)
		Me.pnlDatabaseConnection.Controls.Add(Me.tbxDatabase)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label6)
		Me.pnlDatabaseConnection.Controls.Add(Me.btnConnect)
		Me.pnlDatabaseConnection.Controls.Add(Me.tbxPass)
		Me.pnlDatabaseConnection.Controls.Add(Me.tbxUser)
		Me.pnlDatabaseConnection.Controls.Add(Me.tbxPort)
		Me.pnlDatabaseConnection.Controls.Add(Me.tbxHost)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label5)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label4)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label3)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label2)
		Me.pnlDatabaseConnection.Controls.Add(Me.Label1)
		Me.pnlDatabaseConnection.Location = New System.Drawing.Point(1120, 71)
		Me.pnlDatabaseConnection.Name = "pnlDatabaseConnection"
		Me.pnlDatabaseConnection.Size = New System.Drawing.Size(368, 256)
		Me.pnlDatabaseConnection.TabIndex = 0
		'
		'btnSaveProfile
		'
		Me.btnSaveProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSaveProfile.Enabled = False
		Me.btnSaveProfile.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveProfile.Image = CType(resources.GetObject("btnSaveProfile.Image"), System.Drawing.Image)
		Me.btnSaveProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSaveProfile.Location = New System.Drawing.Point(141, 210)
		Me.btnSaveProfile.Name = "btnSaveProfile"
		Me.btnSaveProfile.Size = New System.Drawing.Size(116, 29)
		Me.btnSaveProfile.TabIndex = 16
		Me.btnSaveProfile.Text = "Save Profile"
		Me.btnSaveProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnSaveProfile.UseVisualStyleBackColor = True
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(127, 38)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(52, 13)
		Me.Label9.TabIndex = 15
		Me.Label9.Text = "Profile :"
		'
		'cmbConnectionProfile
		'
		Me.cmbConnectionProfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbConnectionProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbConnectionProfile.Enabled = False
		Me.cmbConnectionProfile.FormattingEnabled = True
		Me.cmbConnectionProfile.Location = New System.Drawing.Point(185, 35)
		Me.cmbConnectionProfile.Name = "cmbConnectionProfile"
		Me.cmbConnectionProfile.Size = New System.Drawing.Size(164, 21)
		Me.cmbConnectionProfile.TabIndex = 14
		'
		'picLinkIcon
		'
		Me.picLinkIcon.Image = CType(resources.GetObject("picLinkIcon.Image"), System.Drawing.Image)
		Me.picLinkIcon.Location = New System.Drawing.Point(18, 35)
		Me.picLinkIcon.Name = "picLinkIcon"
		Me.picLinkIcon.Size = New System.Drawing.Size(64, 64)
		Me.picLinkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picLinkIcon.TabIndex = 12
		Me.picLinkIcon.TabStop = False
		'
		'tbxDatabase
		'
		Me.tbxDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxDatabase.Location = New System.Drawing.Point(185, 121)
		Me.tbxDatabase.Name = "tbxDatabase"
		Me.tbxDatabase.Size = New System.Drawing.Size(164, 21)
		Me.tbxDatabase.TabIndex = 2
		Me.tbxDatabase.Text = "database"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(109, 124)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(70, 13)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Database :"
		'
		'btnConnect
		'
		Me.btnConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnConnect.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnConnect.Image = CType(resources.GetObject("btnConnect.Image"), System.Drawing.Image)
		Me.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnConnect.Location = New System.Drawing.Point(263, 210)
		Me.btnConnect.Name = "btnConnect"
		Me.btnConnect.Size = New System.Drawing.Size(86, 29)
		Me.btnConnect.TabIndex = 5
		Me.btnConnect.Text = "Connect"
		Me.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnConnect.UseVisualStyleBackColor = True
		'
		'tbxPass
		'
		Me.tbxPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxPass.Location = New System.Drawing.Point(185, 175)
		Me.tbxPass.Name = "tbxPass"
		Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.tbxPass.Size = New System.Drawing.Size(164, 21)
		Me.tbxPass.TabIndex = 4
		'
		'tbxUser
		'
		Me.tbxUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxUser.Location = New System.Drawing.Point(185, 148)
		Me.tbxUser.Name = "tbxUser"
		Me.tbxUser.Size = New System.Drawing.Size(164, 21)
		Me.tbxUser.TabIndex = 3
		Me.tbxUser.Text = "root"
		'
		'tbxPort
		'
		Me.tbxPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxPort.Location = New System.Drawing.Point(185, 94)
		Me.tbxPort.Name = "tbxPort"
		Me.tbxPort.Size = New System.Drawing.Size(164, 21)
		Me.tbxPort.TabIndex = 1
		Me.tbxPort.Text = "3306"
		'
		'tbxHost
		'
		Me.tbxHost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxHost.Location = New System.Drawing.Point(185, 67)
		Me.tbxHost.Name = "tbxHost"
		Me.tbxHost.Size = New System.Drawing.Size(164, 21)
		Me.tbxHost.TabIndex = 0
		Me.tbxHost.Text = "localhost"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(109, 178)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(70, 13)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Password :"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(105, 151)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(74, 13)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Username :"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(140, 97)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(39, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Port :"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(138, 70)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(41, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Host :"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(1, 1)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(153, 14)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Connection Properties"
		'
		'btnGetDBConnector
		'
		Me.btnGetDBConnector.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnGetDBConnector.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGetDBConnector.Image = CType(resources.GetObject("btnGetDBConnector.Image"), System.Drawing.Image)
		Me.btnGetDBConnector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnGetDBConnector.Location = New System.Drawing.Point(18, 14)
		Me.btnGetDBConnector.Name = "btnGetDBConnector"
		Me.btnGetDBConnector.Size = New System.Drawing.Size(164, 29)
		Me.btnGetDBConnector.TabIndex = 0
		Me.btnGetDBConnector.Text = "Export DBConnector"
		Me.btnGetDBConnector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnGetDBConnector.UseVisualStyleBackColor = True
		'
		'picServerIcon
		'
		Me.picServerIcon.Image = CType(resources.GetObject("picServerIcon.Image"), System.Drawing.Image)
		Me.picServerIcon.Location = New System.Drawing.Point(18, 35)
		Me.picServerIcon.Name = "picServerIcon"
		Me.picServerIcon.Size = New System.Drawing.Size(64, 64)
		Me.picServerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picServerIcon.TabIndex = 9
		Me.picServerIcon.TabStop = False
		'
		'pnlDatabaseProperties
		'
		Me.pnlDatabaseProperties.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlDatabaseProperties.BackColor = System.Drawing.Color.Gainsboro
		Me.pnlDatabaseProperties.Controls.Add(Me.chkLowercaseColumnName)
		Me.pnlDatabaseProperties.Controls.Add(Me.Label13)
		Me.pnlDatabaseProperties.Controls.Add(Me.lblTableCollation)
		Me.pnlDatabaseProperties.Controls.Add(Me.Label8)
		Me.pnlDatabaseProperties.Controls.Add(Me.lvwColumnList)
		Me.pnlDatabaseProperties.Controls.Add(Me.cmbTableList)
		Me.pnlDatabaseProperties.Controls.Add(Me.Label7)
		Me.pnlDatabaseProperties.Controls.Add(Me.picServerIcon)
		Me.pnlDatabaseProperties.Enabled = False
		Me.pnlDatabaseProperties.Location = New System.Drawing.Point(1120, 333)
		Me.pnlDatabaseProperties.Name = "pnlDatabaseProperties"
		Me.pnlDatabaseProperties.Size = New System.Drawing.Size(368, 315)
		Me.pnlDatabaseProperties.TabIndex = 1
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(113, 68)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(66, 13)
		Me.Label13.TabIndex = 13
		Me.Label13.Text = "Collation :"
		'
		'lblTableCollation
		'
		Me.lblTableCollation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTableCollation.Location = New System.Drawing.Point(185, 68)
		Me.lblTableCollation.Name = "lblTableCollation"
		Me.lblTableCollation.Size = New System.Drawing.Size(164, 16)
		Me.lblTableCollation.TabIndex = 12
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(94, 38)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(85, 13)
		Me.Label8.TabIndex = 11
		Me.Label8.Text = "Select Table :"
		'
		'lvwColumnList
		'
		Me.lvwColumnList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
						Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwColumnList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colColumnName, Me.colDataType, Me.colNullable, Me.colKey})
		Me.lvwColumnList.FullRowSelect = True
		Me.lvwColumnList.GridLines = True
		Me.lvwColumnList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvwColumnList.HideSelection = False
		Me.lvwColumnList.Location = New System.Drawing.Point(18, 115)
		Me.lvwColumnList.Name = "lvwColumnList"
		Me.lvwColumnList.Size = New System.Drawing.Size(331, 182)
		Me.lvwColumnList.TabIndex = 1
		Me.lvwColumnList.UseCompatibleStateImageBehavior = False
		Me.lvwColumnList.View = System.Windows.Forms.View.Details
		'
		'colColumnName
		'
		Me.colColumnName.Text = "Name"
		Me.colColumnName.Width = 120
		'
		'colDataType
		'
		Me.colDataType.Text = "Type"
		Me.colDataType.Width = 70
		'
		'colNullable
		'
		Me.colNullable.Text = "Nullable"
		'
		'colKey
		'
		Me.colKey.Text = "Key"
		'
		'cmbTableList
		'
		Me.cmbTableList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbTableList.BackColor = System.Drawing.Color.WhiteSmoke
		Me.cmbTableList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTableList.FormattingEnabled = True
		Me.cmbTableList.Location = New System.Drawing.Point(185, 35)
		Me.cmbTableList.Name = "cmbTableList"
		Me.cmbTableList.Size = New System.Drawing.Size(164, 21)
		Me.cmbTableList.TabIndex = 0
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(1, 1)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(142, 14)
		Me.Label7.TabIndex = 1
		Me.Label7.Text = "Database Properties"
		'
		'btnBuild
		'
		Me.btnBuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnBuild.Enabled = False
		Me.btnBuild.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBuild.Image = CType(resources.GetObject("btnBuild.Image"), System.Drawing.Image)
		Me.btnBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnBuild.Location = New System.Drawing.Point(188, 14)
		Me.btnBuild.Name = "btnBuild"
		Me.btnBuild.Size = New System.Drawing.Size(161, 29)
		Me.btnBuild.TabIndex = 1
		Me.btnBuild.Text = "Start Build"
		Me.btnBuild.UseVisualStyleBackColor = True
		'
		'pnlClassProperties
		'
		Me.pnlClassProperties.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlClassProperties.BackColor = System.Drawing.Color.Gainsboro
		Me.pnlClassProperties.Controls.Add(Me.lblPrimaryKeyDataType)
		Me.pnlClassProperties.Controls.Add(Me.Label14)
		Me.pnlClassProperties.Controls.Add(Me.chkReadOnlyPrimaryKey)
		Me.pnlClassProperties.Controls.Add(Me.cmbPrimaryKey)
		Me.pnlClassProperties.Controls.Add(Me.picClassIcon)
		Me.pnlClassProperties.Controls.Add(Me.tbxClassName)
		Me.pnlClassProperties.Controls.Add(Me.Label11)
		Me.pnlClassProperties.Controls.Add(Me.Label12)
		Me.pnlClassProperties.Controls.Add(Me.Label10)
		Me.pnlClassProperties.Enabled = False
		Me.pnlClassProperties.Location = New System.Drawing.Point(1120, 654)
		Me.pnlClassProperties.Name = "pnlClassProperties"
		Me.pnlClassProperties.Size = New System.Drawing.Size(368, 143)
		Me.pnlClassProperties.TabIndex = 2
		'
		'lblPrimaryKeyDataType
		'
		Me.lblPrimaryKeyDataType.BackColor = System.Drawing.Color.WhiteSmoke
		Me.lblPrimaryKeyDataType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrimaryKeyDataType.Location = New System.Drawing.Point(185, 90)
		Me.lblPrimaryKeyDataType.Name = "lblPrimaryKeyDataType"
		Me.lblPrimaryKeyDataType.Size = New System.Drawing.Size(164, 16)
		Me.lblPrimaryKeyDataType.TabIndex = 14
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(105, 90)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(74, 13)
		Me.Label14.TabIndex = 13
		Me.Label14.Text = "Data Type :"
		'
		'chkReadOnlyPrimaryKey
		'
		Me.chkReadOnlyPrimaryKey.AutoSize = True
		Me.chkReadOnlyPrimaryKey.Checked = True
		Me.chkReadOnlyPrimaryKey.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkReadOnlyPrimaryKey.Location = New System.Drawing.Point(185, 111)
		Me.chkReadOnlyPrimaryKey.Name = "chkReadOnlyPrimaryKey"
		Me.chkReadOnlyPrimaryKey.Size = New System.Drawing.Size(156, 17)
		Me.chkReadOnlyPrimaryKey.TabIndex = 2
		Me.chkReadOnlyPrimaryKey.Text = "ReadOnly Primary Key"
		Me.chkReadOnlyPrimaryKey.UseVisualStyleBackColor = True
		'
		'cmbPrimaryKey
		'
		Me.cmbPrimaryKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbPrimaryKey.BackColor = System.Drawing.Color.WhiteSmoke
		Me.cmbPrimaryKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPrimaryKey.FormattingEnabled = True
		Me.cmbPrimaryKey.Location = New System.Drawing.Point(185, 63)
		Me.cmbPrimaryKey.Name = "cmbPrimaryKey"
		Me.cmbPrimaryKey.Size = New System.Drawing.Size(164, 21)
		Me.cmbPrimaryKey.TabIndex = 1
		'
		'picClassIcon
		'
		Me.picClassIcon.Image = CType(resources.GetObject("picClassIcon.Image"), System.Drawing.Image)
		Me.picClassIcon.Location = New System.Drawing.Point(18, 36)
		Me.picClassIcon.Name = "picClassIcon"
		Me.picClassIcon.Size = New System.Drawing.Size(64, 64)
		Me.picClassIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picClassIcon.TabIndex = 10
		Me.picClassIcon.TabStop = False
		'
		'tbxClassName
		'
		Me.tbxClassName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
						Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxClassName.Location = New System.Drawing.Point(185, 36)
		Me.tbxClassName.Name = "tbxClassName"
		Me.tbxClassName.Size = New System.Drawing.Size(164, 21)
		Me.tbxClassName.TabIndex = 0
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(92, 66)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(87, 13)
		Me.Label11.TabIndex = 6
		Me.Label11.Text = "Primary Key :"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(95, 39)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(84, 13)
		Me.Label12.TabIndex = 5
		Me.Label12.Text = "Class Name :"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(1, 2)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(115, 14)
		Me.Label10.TabIndex = 2
		Me.Label10.Text = "Class Properties"
		'
		'pnlCommand
		'
		Me.pnlCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlCommand.BackColor = System.Drawing.Color.Gainsboro
		Me.pnlCommand.Controls.Add(Me.Label17)
		Me.pnlCommand.Controls.Add(Me.rdbForVersion8)
		Me.pnlCommand.Controls.Add(Me.rdbForVersion5)
		Me.pnlCommand.Controls.Add(Me.btnSaveClassFile)
		Me.pnlCommand.Controls.Add(Me.btnGetDBConnector)
		Me.pnlCommand.Controls.Add(Me.btnBuild)
		Me.pnlCommand.Enabled = False
		Me.pnlCommand.Location = New System.Drawing.Point(1120, 803)
		Me.pnlCommand.Name = "pnlCommand"
		Me.pnlCommand.Size = New System.Drawing.Size(368, 93)
		Me.pnlCommand.TabIndex = 3
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(16, 51)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(66, 13)
		Me.Label17.TabIndex = 14
		Me.Label17.Text = "for MySQL"
		'
		'rdbForVersion8
		'
		Me.rdbForVersion8.AutoSize = True
		Me.rdbForVersion8.Location = New System.Drawing.Point(141, 49)
		Me.rdbForVersion8.Name = "rdbForVersion8"
		Me.rdbForVersion8.Size = New System.Drawing.Size(42, 17)
		Me.rdbForVersion8.TabIndex = 4
		Me.rdbForVersion8.Text = "V.8"
		Me.rdbForVersion8.UseVisualStyleBackColor = True
		'
		'rdbForVersion5
		'
		Me.rdbForVersion5.AutoSize = True
		Me.rdbForVersion5.Checked = True
		Me.rdbForVersion5.Location = New System.Drawing.Point(88, 49)
		Me.rdbForVersion5.Name = "rdbForVersion5"
		Me.rdbForVersion5.Size = New System.Drawing.Size(42, 17)
		Me.rdbForVersion5.TabIndex = 3
		Me.rdbForVersion5.TabStop = True
		Me.rdbForVersion5.Text = "V.5"
		Me.rdbForVersion5.UseVisualStyleBackColor = True
		'
		'btnSaveClassFile
		'
		Me.btnSaveClassFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSaveClassFile.Enabled = False
		Me.btnSaveClassFile.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveClassFile.Image = CType(resources.GetObject("btnSaveClassFile.Image"), System.Drawing.Image)
		Me.btnSaveClassFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSaveClassFile.Location = New System.Drawing.Point(188, 49)
		Me.btnSaveClassFile.Name = "btnSaveClassFile"
		Me.btnSaveClassFile.Size = New System.Drawing.Size(161, 29)
		Me.btnSaveClassFile.TabIndex = 2
		Me.btnSaveClassFile.Text = "Save Class File"
		Me.btnSaveClassFile.UseVisualStyleBackColor = True
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.ForeColor = System.Drawing.Color.Gray
		Me.Label15.Location = New System.Drawing.Point(1267, 905)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(227, 13)
		Me.Label15.TabIndex = 4
		Me.Label15.Text = "Any ideas? > feineirz@live.com (feinz)"
		'
		'chkLowercaseColumnName
		'
		Me.chkLowercaseColumnName.AutoSize = True
		Me.chkLowercaseColumnName.Checked = True
		Me.chkLowercaseColumnName.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkLowercaseColumnName.Location = New System.Drawing.Point(185, 92)
		Me.chkLowercaseColumnName.Name = "chkLowercaseColumnName"
		Me.chkLowercaseColumnName.Size = New System.Drawing.Size(171, 17)
		Me.chkLowercaseColumnName.TabIndex = 14
		Me.chkLowercaseColumnName.Text = "Lowercase column name."
		Me.chkLowercaseColumnName.UseVisualStyleBackColor = True
		'
		'btnChangeFont
		'
		Me.btnChangeFont.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnChangeFont.Image = CType(resources.GetObject("btnChangeFont.Image"), System.Drawing.Image)
		Me.btnChangeFont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnChangeFont.Location = New System.Drawing.Point(997, 905)
		Me.btnChangeFont.Name = "btnChangeFont"
		Me.btnChangeFont.Size = New System.Drawing.Size(117, 29)
		Me.btnChangeFont.TabIndex = 5
		Me.btnChangeFont.Text = "Change Font"
		Me.btnChangeFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnChangeFont.UseVisualStyleBackColor = True
		'
		'lblAppVersion
		'
		Me.lblAppVersion.AutoSize = True
		Me.lblAppVersion.ForeColor = System.Drawing.Color.Gray
		Me.lblAppVersion.Location = New System.Drawing.Point(12, 913)
		Me.lblAppVersion.Name = "lblAppVersion"
		Me.lblAppVersion.Size = New System.Drawing.Size(28, 13)
		Me.lblAppVersion.TabIndex = 6
		Me.lblAppVersion.Text = "ver."
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(1500, 940)
		Me.Controls.Add(Me.lblAppVersion)
		Me.Controls.Add(Me.btnChangeFont)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.pnlCommand)
		Me.Controls.Add(Me.pnlClassProperties)
		Me.Controls.Add(Me.pnlDatabaseProperties)
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
		CType(Me.picLinkIcon, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picServerIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlDatabaseProperties.ResumeLayout(False)
		Me.pnlDatabaseProperties.PerformLayout()
		Me.pnlClassProperties.ResumeLayout(False)
		Me.pnlClassProperties.PerformLayout()
		CType(Me.picClassIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlCommand.ResumeLayout(False)
		Me.pnlCommand.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

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
	Friend WithEvents tbxDatabase As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents pnlDatabaseProperties As Panel
	Friend WithEvents Label7 As Label
	Friend WithEvents picLinkIcon As PictureBox
	Friend WithEvents cmbTableList As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents lvwColumnList As ListView
	Friend WithEvents colColumnName As ColumnHeader
	Friend WithEvents colDataType As ColumnHeader
	Friend WithEvents colNullable As ColumnHeader
	Friend WithEvents colKey As ColumnHeader
	Friend WithEvents lblTableCollation As Label
	Friend WithEvents btnSaveProfile As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents cmbConnectionProfile As ComboBox
	Friend WithEvents btnBuild As Button
	Friend WithEvents pnlClassProperties As Panel
	Friend WithEvents picClassIcon As PictureBox
	Friend WithEvents tbxClassName As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents cmbPrimaryKey As ComboBox
	Friend WithEvents btnGetDBConnector As Button
	Friend WithEvents chkReadOnlyPrimaryKey As CheckBox
	Friend WithEvents Label13 As Label
	Friend WithEvents pnlCommand As Panel
	Friend WithEvents lblPrimaryKeyDataType As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents btnSaveClassFile As Button
	Friend WithEvents Label15 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents rdbForVersion8 As RadioButton
	Friend WithEvents rdbForVersion5 As RadioButton
	Friend WithEvents Label17 As Label
	Friend WithEvents chkLowercaseColumnName As CheckBox
	Friend WithEvents btnChangeFont As Button
	Friend WithEvents lblAppVersion As Label
End Class
