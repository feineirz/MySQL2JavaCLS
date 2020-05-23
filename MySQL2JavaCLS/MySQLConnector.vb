Imports MySql.Data.MySqlClient

Public Class MySQLConnector

	'Connection String : Server=myServerAddress;Port=1234;Database=myDataBase;Uid=myUsername;Pwd=myPassword;

	Private _connString As String

	Structure ConnectionInfo
		Dim Host As String
		Dim Port As String
		Dim Database As String
		Dim User As String
		Dim Password As String
	End Structure

	Public Shared Function getConnection(ConnectionInfo As ConnectionInfo) As MySqlConnection

		Dim connString = "Server=" + ConnectionInfo.Host + ";Port=" + ConnectionInfo.Port + ";Database=" + ConnectionInfo.Database + ";Uid=" + ConnectionInfo.User + ";Pwd=" + ConnectionInfo.Password + ";"
		Return New MySqlConnection(connString)

	End Function

End Class
