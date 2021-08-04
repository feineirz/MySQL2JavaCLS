Public Class frmExportConnectionSettings
  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    Me.Dispose()

  End Sub

	Private Sub btnGetDBConnector_Click(sender As Object, e As EventArgs) Handles btnGetDBConnector.Click

		Dim dlg As New SaveFileDialog
		dlg.FileName = "MySQLDBConnector.java"

		Dim content = MySQL2JavaCLSBuilder.getMySQLDBConnector(frmMain.ConnectionInfo)


		content = content.Replace("@PACKAGENAME@", frmMain.tbxPackageName.Text.Trim)

		If cmbForMySQLVersion.SelectedIndex = 0 Then
			content = content.Replace("@MySQLVersionShift@", "mysql")
		Else
			content = content.Replace("@MySQLVersionShift@", "mysql.cj")
		End If

		content = content.Replace("@useJDBCCompliantTimezoneShiftOption@", chkUseJDBCCompliantTimezoneShift.Checked.ToString.ToLower)
		content = content.Replace("@useLegacyDatetimeCodeOption@", chkUseLegacyDatetimeCode.Checked.ToString.ToLower)
		content = content.Replace("@useSSLOption@", chkUseSSL.Checked.ToString.ToLower)
		content = content.Replace("@autoReconnectOption@", chkAutoReconnect.Checked.ToString.ToLower)
		content = content.Replace("@useUnicodeOption@", chkUseUnicode.Checked.ToString.ToLower)
		content = content.Replace("@characterEncodingOption@", tbxCharacterEncoding.Text.Trim)
		content = content.Replace("@serverTimezoneOption@", tbxServerTimezone.Text.Trim)

		If dlg.ShowDialog = DialogResult.OK Then
			IO.File.WriteAllText(dlg.FileName, content)
			Me.Dispose()
		End If

	End Sub

	Private Sub frmExportConnectionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		cmbForMySQLVersion.SelectedItem = cmbForMySQLVersion.Items(0)

	End Sub
End Class