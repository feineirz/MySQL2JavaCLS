Imports MySqlConnector

Public Class MySQLDB

	Private _connectionInfo As MySQLConnector.ConnectionInfo
	Private _connString As String

	Public Structure DatabaseInfo
		Dim DatabaseName As String
		Dim TableList As List(Of DataTableInfo)
	End Structure

	Public Structure DataTableInfo
		Dim TableName As String
		Dim Collation As String
		Dim ColumnList As List(Of DataColumnInfo)
	End Structure

	Public Structure DataColumnInfo
		Dim ColumnName As String
		Dim DataType As String
		Dim IsNullable As String
		Dim Key As String
	End Structure

	Public Sub New(connectionInfo As MySQLConnector.ConnectionInfo)

		_connectionInfo = connectionInfo
		_connString = "Server=" + connectionInfo.Host + ";Port=" + connectionInfo.Port + ";Database=" + connectionInfo.Database + ";Uid=" + connectionInfo.User + ";Pwd=" + connectionInfo.Password + ";"

	End Sub

	ReadOnly Property connectionString() As String
		Get
			Return _connString
		End Get
	End Property

	ReadOnly Property connectionInfo() As MySQLConnector.ConnectionInfo
		Get
			Return _connectionInfo
		End Get
	End Property

	Public Function TestConnection() As Boolean

		Dim conn = MySQLConnector.getConnection(connectionInfo)

		Try
			conn.Open()
			conn.Close()

		Catch ex As Exception
			Console.Write(ex.Message)
			Return False
		End Try

		Return True

	End Function

	Public Function getDatabaseInfo() As DatabaseInfo

		Dim dbi As DatabaseInfo
		dbi.DatabaseName = connectionInfo.Database
		dbi.TableList = ListTables()

		Return dbi

	End Function

	Public Function getTableInfo(TableName As String, Optional LowercaseColumnName As Boolean = False) As DataTableInfo

		Dim conn = MySQLConnector.getConnection(connectionInfo)
		Dim cmd As MySqlCommand
		Dim rd As MySqlDataReader

		Dim dti As DataTableInfo = Nothing
		Dim qry As String

		Try
			conn.Open()
			qry = "SELECT TABLE_NAME, TABLE_COLLATION"
			qry += " FROM information_schema.TABLES"
			qry += " WHERE TABLE_SCHEMA = '" + connectionInfo.Database + "'"
			qry += "  AND TABLE_NAME = '" + TableName + "'"

			cmd = New MySqlCommand(qry, conn)
			rd = cmd.ExecuteReader

			If rd.HasRows Then
				While rd.Read()
					dti.TableName = rd!TABLE_NAME
					dti.Collation = rd!TABLE_COLLATION
					dti.ColumnList = ListColumn(dti.TableName, LowercaseColumnName)
				End While
			End If

			conn.Close()

		Catch ex As Exception
			conn.Close()
			Console.Write(ex.Message)
		End Try

		Return dti

	End Function

	Public Function ListTables(Optional LowercaseColumnName As Boolean = False) As List(Of DataTableInfo)

		Dim conn = MySQLConnector.getConnection(connectionInfo)
		Dim cmd As MySqlCommand
		Dim rd As MySqlDataReader

		Dim res As New List(Of DataTableInfo)
		Dim dti As DataTableInfo
		Dim qry As String

		Try
			conn.Open()
			qry = "SELECT TABLE_NAME, TABLE_COLLATION"
			qry += " FROM information_schema.TABLES"
			qry += " WHERE TABLE_SCHEMA = '" + connectionInfo.Database + "'"

			cmd = New MySqlCommand(qry, conn)
			rd = cmd.ExecuteReader

			If rd.HasRows Then
				While rd.Read()
					dti.TableName = rd!TABLE_NAME
					dti.Collation = rd!TABLE_COLLATION
					dti.ColumnList = ListColumn(dti.TableName, LowercaseColumnName)
					res.Add(dti)
				End While
			End If

			conn.Close()

		Catch ex As Exception
			conn.Close()
			Console.Write(ex.Message)
		End Try

		Return res

	End Function

	Public Function ListColumn(TableName As String, Optional LowercaseColumnName As Boolean = False) As List(Of DataColumnInfo)

		Dim conn = MySQLConnector.getConnection(connectionInfo)
		Dim cmd As MySqlCommand
		Dim rd As MySqlDataReader

		Dim res As New List(Of DataColumnInfo)
		Dim dci As DataColumnInfo
		Dim qry As String

		Try
			conn.Open()
			qry = "SELECT COLUMN_NAME,DATA_TYPE,IS_NULLABLE,COLUMN_KEY"
			qry += " FROM information_schema.COLUMNS"
			qry += " WHERE TABLE_SCHEMA = '" + connectionInfo.Database + "'"
			qry += "  AND TABLE_NAME = '" + TableName + "'"

			cmd = New MySqlCommand(qry, conn)
			rd = cmd.ExecuteReader

			If rd.HasRows Then
				While rd.Read()
					dci.ColumnName = rd!COLUMN_NAME
					If LowercaseColumnName Then dci.ColumnName = dci.ColumnName.ToLower
					dci.DataType = rd!DATA_TYPE
					dci.IsNullable = rd!IS_NULLABLE
					dci.Key = rd!COLUMN_KEY
					res.Add(dci)
				End While
			End If

			conn.Close()

		Catch ex As Exception
			conn.Close()
			Console.Write(ex.Message)
		End Try

		Return res

	End Function

End Class
