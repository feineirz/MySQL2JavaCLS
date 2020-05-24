Imports System.Text

Public Class MySQL2JavaCLSBuilder

	Private Shared Function dblQuote(Optional Number As Integer = 1) As String
		Dim C As String = ""
		For I = 1 To Number
			C &= Chr(34)
		Next
		Return C
	End Function
	Private Shared Function cTAB(Optional Number As Integer = 1) As String
		Dim C As String = ""
		For I = 1 To Number
			C &= Chr(9)
		Next
		Return C
	End Function
	Private Shared Function cNewLine(Optional Number As Integer = 1)
		Dim C As String = ""
		For I = 1 To Number
			C &= vbCrLf
		Next
		Return C

	End Function
	Private Shared Function FirstLetterToUpperCase(src As String) As String

		Dim rt As String = ""
		If src.Length > 0 Then

			Dim c() As Char = src.ToCharArray
			c(0) = c(0).ToString.ToUpper
			rt = New String(c)

		End If

		Return rt

	End Function

	Shared Function ConvertDataType(SQLServerDataType As String) As String

		Select Case SQLServerDataType.ToLower

			Case "byte" : Return "byte"
			Case "tinyint" : Return "byte"
			Case "binary" : Return "byte"
			Case "varbinary" : Return "byte"

			Case "bit" : Return "Boolean"

			Case "date" : Return "Date"
			Case "datetime" : Return "Date"
			Case "datetime2" : Return "Date"
			Case "DATETIMEOFFSET" : Return "DateTimeOffset"

			Case "time" : Return "TimeSpan"

			Case "real" : Return "Double"
			Case "decimal" : Return "Double"
			Case "smallmoney" : Return "float"
			Case "money" : Return "Double"
			Case "numeric" : Return "Double"

			Case "single" : Return "float"
			Case "float" : Return "float"
			Case "double" : Return "Double"

			Case "smallint" : Return "short"
			Case "int" : Return "Integer"
			Case "bigint" : Return "long"

			Case "char" : Return "String"
			Case "nchar" : Return "String"
			Case "varchar" : Return "String"
			Case "nvarchar" : Return "String"
			Case "text" : Return "String"
			Case "longtext" : Return "String"
			Case "ntext" : Return "String"
			Case "string" : Return "String"

			Case "byte[]" : Return "byte[]"
			Case "image" : Return "byte[]"
			Case "blob" : Return "byte[]"
			Case "mediumblob" : Return "byte[]"
			Case "longblob" : Return "byte[]"

			Case Else : Return SQLServerDataType
		End Select

	End Function

	Public Function getSourceCode(DataTableInfo As MySQLDB.DataTableInfo) As String

	End Function

End Class
