Public Class MySQLConnector

	Private _connString As String

	Public Structure ConnectionInfo
		Dim Host As String
		Dim Port As String
		Dim Database As String
		Dim User As String
		Dim Password As String
	End Structure

	Public Shared Function getConnection(ConnectionInfo As ConnectionInfo) As MySqlConnection

		Dim connString = "Server=" + ConnectionInfo.Host + ";Port=" + ConnectionInfo.Port + ";Database=" + ConnectionInfo.Database + ";Uid=" + ConnectionInfo.User + ";Pwd=" + ConnectionInfo.Password + ";SslMode=none;"
		Dim conn = New MySqlConnection(connString)

		Try
			conn.Open()
			conn.Close()
		Catch ex As Exception
			Return Nothing
		End Try

		Return conn

	End Function

End Class
