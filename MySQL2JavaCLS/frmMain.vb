Imports System.Runtime.InteropServices

Public Class frmMain

  Public mysqlDB As MySQLDB = Nothing

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
    ElseIf tbxPass.Text.Trim = "" Then
      tbxPass.Focus()
      Return False
    End If

    Return True

  End Function


#End Region

  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    Application.Exit()

  End Sub

  Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

    If validateConnectionInfo() Then
      Dim connectionInfoA As MySQLConnector.ConnectionInfo
      connectionInfoA.Host = tbxHost.Text.Trim
      connectionInfoA.Port = tbxPort.Text.Trim
      connectionInfoA.Database = tbxDatabase.Text.Trim
      connectionInfoA.User = tbxUser.Text.Trim
      connectionInfoA.Password = tbxPass.Text.Trim

      If MySQLConnector.getConnection(connectionInfoA) IsNot Nothing Then
        mysqlDB = New MySQLDB(connectionInfoA)
        Dim res As MySQLDB.DatabaseInfo = mysqlDB.getDatabaseInfo
        If res.TableList.Count > 0 Then
          For Each t In res.TableList
            cmbTableList.Items.Add(t.TableName)
          Next
        End If

        pnlDatabaseConnection.Enabled = False
        pnlDatabaseProperties.Enabled = True

        MsgBox("Connection successful.")
      Else
        MsgBox("Connection failed.")
      End If

    End If

  End Sub

  Private Sub cmbTableList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTableList.SelectedIndexChanged

    If cmbTableList.Text = "" Then Return

    Dim dti As MySQLDB.DataTableInfo = mysqlDB.getTableInfo(cmbTableList.Text)

    lblTableCollation.Text = dti.Collation
    tbxClassName.Text = dti.TableName

    lvwColumnList.Items.Clear()
    cmbPrimaryKey.Items.Clear()

    Try
      If dti.ColumnList.Count > 0 Then
        Dim lvi As ListViewItem
        For Each dci In dti.ColumnList
          lvi = lvwColumnList.Items.Add(dci.ColumnName)
          lvi.SubItems.Add(dci.DataType)
          lvi.SubItems.Add(dci.IsNullable)
          lvi.SubItems.Add(dci.Key)

          cmbPrimaryKey.Items.Add(dci.ColumnName)
        Next
      End If

      cmbPrimaryKey.SelectedItem = cmbPrimaryKey.Items(0)

    Catch ex As Exception
      Console.WriteLine(ex.Message)

    End Try


  End Sub
End Class
