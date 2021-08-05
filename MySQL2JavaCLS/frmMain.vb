Imports System.Runtime.InteropServices
Imports System.Text

Public Class frmMain

	Public mysqlDB As MySQLDB = Nothing
	Public ConnectionInfo As MySQLConnector.ConnectionInfo = Nothing
	Public currentDataTableInfo As MySQLDB.DataTableInfo = Nothing

#Region "Dragable Form"
	<DllImportAttribute("user32.dll")>
	Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
	End Function

	<DllImportAttribute("user32.dll")> Public Shared Function ReleaseCapture() As Boolean
	End Function

	Private Sub Header_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
		Const WM_NCLBUTTONDOWN As Integer = &HA1
		Const HT_CAPTION As Integer = &H2

		If e.Button = MouseButtons.Left Then
			ReleaseCapture()
			SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
		End If

	End Sub
#End Region

#Region "SupportFunctions"

	Function validateConnectionInfo() As Boolean

		If tbxHost.Text.Trim = "" Then
			tbxHost.Focus()
			Return False
		ElseIf tbxPort.Text.Trim = "" Then
			tbxPort.Focus()
			Return False
		ElseIf tbxDatabase.Text.Trim = "" Then
			tbxDatabase.Focus()
			Return False
		ElseIf tbxUser.Text.Trim = "" Then
			tbxUser.Focus()
			Return False
		End If

		Return True

	End Function

	Sub listProfiles()

		Dim profiles = ConnProfiles.ListProfile

		cmbConnectionProfile.Items.Clear()
		For Each profile In profiles
			cmbConnectionProfile.Items.Add(profile.ProfileName)
		Next

	End Sub

	Private Sub SetConnectionInput(State As Boolean)

		Dim tbx As TextBox

		For Each ctrl As Control In pnlDatabaseConnection.Controls
			If TypeOf ctrl Is TextBox Then
				tbx = DirectCast(ctrl, TextBox)
				tbx.ReadOnly = Not State
			End If

		Next

	End Sub


#End Region

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		Application.Exit()

	End Sub

	Private Function ValidateClassData() As Boolean
		If tbxClassName.Text.Trim = "" Then Return False
		If cmbPrimaryKey.Items.Count = 0 Then Return False
		Return True
	End Function

	Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

		If btnConnect.Text = "Connect" Then

			If validateConnectionInfo() Then
				Dim connectionInfoA As MySQLConnector.ConnectionInfo
				connectionInfoA.Host = tbxHost.Text.Trim
				connectionInfoA.Port = tbxPort.Text.Trim
				connectionInfoA.Database = tbxDatabase.Text.Trim
				connectionInfoA.User = tbxUser.Text.Trim
				connectionInfoA.Password = tbxPass.Text.Trim

				If MySQLConnector.getConnection(connectionInfoA) IsNot Nothing Then

					ConnectionInfo = connectionInfoA
					mysqlDB = New MySQLDB(connectionInfoA)

					Dim res As MySQLDB.DatabaseInfo = mysqlDB.getDatabaseInfo

					cmbTableList.Items.Clear()

					If res.TableList.Count > 0 Then
						For Each t In res.TableList
							cmbTableList.Items.Add(t.TableName)
						Next
					End If

					SetConnectionInput(False)
					pnlDatabaseProperties.Enabled = True
					pnlCommand.Enabled = True
					btnExportDBConnector.Enabled = True

					MsgBox("Connection successful.")
					btnConnect.Text = "Disconnect"

					If cmbTableList.Items.Count > 0 Then
						cmbTableList.SelectedIndex = 0
					End If
				Else
					MsgBox("Connection failed.")
				End If

			End If

		Else
			SetConnectionInput(True)
			pnlDatabaseProperties.Enabled = False
			pnlCommand.Enabled = False
			btnExportDBConnector.Enabled = False
			btnConnect.Text = "Connect"

		End If

	End Sub

	Private Sub cmbTableList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTableList.SelectedIndexChanged

		rtbSourceCode.Text = ""

		If cmbTableList.Text = "" Then Return

		pnlClassProperties.Enabled = True

		Dim dti As MySQLDB.DataTableInfo = mysqlDB.getTableInfo(cmbTableList.Text, chkLowercaseColumnName.Checked)
		currentDataTableInfo = dti

		lblTableCollation.Text = dti.Collation
		tbxClassName.Text = NameCamelCase(dti.TableName)

		lvwColumnList.Items.Clear()
		cmbPrimaryKey.Items.Clear()

		Dim PrimayKey As String = ""
		Try
			If dti.ColumnList.Count > 0 Then
				Dim lvi As ListViewItem

				For Each dci In dti.ColumnList
					lvi = lvwColumnList.Items.Add(dci.ColumnName)
					lvi.SubItems.Add(dci.DataType)
					lvi.SubItems.Add(dci.IsNullable)
					lvi.SubItems.Add(dci.Key)

					If dci.Key = "PRI" Then PrimayKey = dci.ColumnName

					cmbPrimaryKey.Items.Add(dci.ColumnName)
				Next
			End If

			Dim idx As Integer = 0
			For i = 0 To cmbPrimaryKey.Items.Count - 1
				Dim s As String = cmbPrimaryKey.Items(i)
				If s = PrimayKey Then idx = i
			Next
			cmbPrimaryKey.SelectedItem = cmbPrimaryKey.Items(idx)

		Catch ex As Exception
			Console.WriteLine(ex.Message)

		End Try


	End Sub

	Private Sub btnGetDBConnector_Click(sender As Object, e As EventArgs) Handles btnExportDBConnector.Click

		frmExportConnectionSettings.ShowDialog()

	End Sub

	Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click

		Dim classInfoA As MySQL2JavaCLSBuilder.ClassInfo
		classInfoA.PackageName = tbxPackageName.Text.Trim
		classInfoA.ClassName = tbxClassName.Text.Trim
		classInfoA.ClassPrimaryKey = cmbPrimaryKey.Text
		classInfoA.ClassPrimaryKeyDataType = lblPrimaryKeyDataType.Text
		classInfoA.IsPrimaryKeyReadOnly = chkReadOnlyPrimaryKey.Checked

		Dim content As String = MySQL2JavaCLSBuilder.getSourceCode(currentDataTableInfo, classInfoA)
		rtbSourceCode.Text = content

	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		listProfiles()
		rtbSourceCode.SelectionTabs = New Integer() {40, 80, 120, 160}
		lblAppVersion.Text = "ver." + Application.ProductVersion

	End Sub

	Private Sub cmbPrimaryKey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrimaryKey.SelectedIndexChanged

		If cmbPrimaryKey.Text = "" Then Return

		If ValidateClassData() Then
			btnBuild.Enabled = True
		Else
			btnBuild.Enabled = False
		End If

		For Each dci In currentDataTableInfo.ColumnList
			If dci.ColumnName = cmbPrimaryKey.Text Then
				lblPrimaryKeyDataType.Text = dci.DataType
			End If
		Next

	End Sub

	Private Sub btnSaveClassFile_Click(sender As Object, e As EventArgs) Handles btnSaveClassFile.Click

		If rtbSourceCode.Text.Trim = "" Then Return

		Dim dlg As New SaveFileDialog
		dlg.FileName = tbxClassName.Text.Trim + ".java"
		If dlg.ShowDialog = DialogResult.OK Then
			IO.File.WriteAllText(dlg.FileName, rtbSourceCode.Text.ToString)
		End If

	End Sub

	Private Sub rtbSourceCode_TextChanged(sender As Object, e As EventArgs) Handles rtbSourceCode.TextChanged

		If rtbSourceCode.Text.Trim = "" Then
			btnSaveClassFile.Enabled = False
		Else
			btnSaveClassFile.Enabled = True
		End If

	End Sub

	Private Sub tbxClassName_LostFocus(sender As Object, e As EventArgs) Handles tbxClassName.LostFocus

		tbxClassName.Text = FirstCaps(tbxClassName.Text.Trim)

	End Sub

	Private Sub tbxClassName_TextChanged(sender As Object, e As EventArgs) Handles tbxClassName.TextChanged

		If ValidateClassData() Then
			btnBuild.Enabled = True
		Else
			btnBuild.Enabled = False
		End If

	End Sub

	Private Sub btnChangeFont_Click(sender As Object, e As EventArgs) Handles btnChangeFont.Click

		Dim dlg As New FontDialog
		If dlg.ShowDialog = DialogResult.OK Then
			rtbSourceCode.Font = dlg.Font
		End If

	End Sub

	Private Sub chkLowercaseColumnName_CheckedChanged(sender As Object, e As EventArgs) Handles chkLowercaseColumnName.CheckedChanged

		cmbTableList_SelectedIndexChanged(Nothing, Nothing)

	End Sub

	Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click

		If validateConnectionInfo() Then

			Dim profile As ConnProfiles.ProfileInfo

			Dim pname As String = tbxUser.Text.Trim + ":" + tbxDatabase.Text.Trim + "@" + tbxHost.Text.Trim
			profile.ProfileName = (pname)
			profile.Host = (tbxHost.Text.Trim)
			profile.Port = (tbxPort.Text.Trim)
			profile.Database = (tbxDatabase.Text.Trim)
			profile.Username = (tbxUser.Text.Trim)
			profile.Password = (tbxPass.Text.Trim)

			ConnProfiles.AddProfile(profile)

			listProfiles()

			MsgBox("Successful.")

		End If

	End Sub

	Private Sub cmbConnectionProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConnectionProfile.SelectedIndexChanged

		If Not cmbConnectionProfile.Text = "" Then

			Dim profileName As String = cmbConnectionProfile.Text
			Dim pfi = ConnProfiles.GetProfile(profileName)

			tbxHost.Text = pfi.Host
			tbxPort.Text = pfi.Port
			tbxDatabase.Text = pfi.Database
			tbxUser.Text = pfi.Username
			tbxPass.Text = pfi.Password

		End If

	End Sub

	Private Sub btnChangeTheme_Click(sender As Object, e As EventArgs) Handles btnChangeTheme.Click

		If rtbSourceCode.BackColor = Color.WhiteSmoke Then
			rtbSourceCode.BackColor = Color.FromArgb(40, 40, 40)
			rtbSourceCode.ForeColor = Color.LightGoldenrodYellow

		ElseIf rtbSourceCode.BackColor = Color.FromArgb(40, 40, 40) Then

			Select Case rtbSourceCode.ForeColor
				Case Color.LightGoldenrodYellow
					rtbSourceCode.ForeColor = Color.Yellow
				Case Color.Yellow
					rtbSourceCode.ForeColor = Color.LawnGreen
				Case Color.LawnGreen
					rtbSourceCode.ForeColor = Color.DeepSkyBlue
				Case Color.DeepSkyBlue
					rtbSourceCode.ForeColor = Color.Pink
				Case Color.Pink
					rtbSourceCode.ForeColor = Color.Fuchsia
				Case Else
					rtbSourceCode.BackColor = Color.WhiteSmoke
					rtbSourceCode.ForeColor = Color.FromArgb(40, 40, 40)
			End Select

		End If

	End Sub

	Private Sub btnUglyFormat_Click(sender As Object, e As EventArgs) Handles btnUglyFormat.Click

		Dim sb As New StringBuilder()
		Dim ln As Integer
		Dim maxLn = 100
		Dim tabSize As Integer = 4
		Dim appendText As String

		Dim insertContent As String() = {
			"////////////////",
			"////////////////",
			"  _.........._  ",
			" | |iomega  | | ",
			" | |100mb   | | ",
			" | |windows | | ",
			" | |98      | | ",
			" |   ______   | ",
			" |  |    | |  | ",
			" |__|____|_|__| ",
			"                ",
			"////////////////",
			"////////////////"
		}
		Dim insertCount As Integer = 0
		Dim insertWidth As Integer = insertContent(0).Length

		For Each line In rtbSourceCode.Lines
			line = line.TrimEnd
			ln = line.Length

			For Each c In line
				If c = Chr(9) Then ln += tabSize
			Next

			appendText = ""
			If line.EndsWith("*") Then
				appendText = " "
				ln += 1
			End If

			If maxLn - ln >= insertWidth Then
				appendText &= StrDup(maxLn - ln - insertWidth, "/")
				appendText &= insertContent(insertCount)
			Else
				appendText &= StrDup(maxLn - ln, "/")
			End If

			insertCount += 1
			If insertCount = insertContent.Length Then insertCount = 0

			sb.AppendLine(line + appendText)
		Next

		rtbSourceCode.Text = sb.ToString

	End Sub

End Class
