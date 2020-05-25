Imports System.Text

Public Class MySQL2JavaCLSBuilder

	Public Structure ClassInfo
		Dim ClassName As String
		Dim ClassPrimaryKey As String
		Dim ClassPrimaryKeyDataType As String
		Dim IsPrimaryKeyReadOnly As Boolean
	End Structure

	Public Shared Function dblQuote(Optional Number As Integer = 1) As String
		Dim C As String = ""
		For I = 1 To Number
			C &= Chr(34)
		Next
		Return C
	End Function
	Public Shared Function cTAB(Optional Number As Integer = 1) As String
		Dim C As String = ""
		For I = 1 To Number
			C &= Chr(9)
		Next
		Return C
	End Function
	Public Shared Function cNewLine(Optional Number As Integer = 1)
		Dim C As String = ""
		For I = 1 To Number
			C &= vbCrLf
		Next
		Return C

	End Function
	Public Shared Function FirstCaps(src As String) As String

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

	Public Shared Function getMySQLDBConnector(ConnectionInfoA As MySQLConnector.ConnectionInfo) As String

		Dim rt = My.Resources.JAVAforMYSQL_MySQLDBConnector.ToString

		' Fill Data
		rt = rt.Replace("@HOST@", ConnectionInfoA.Host)
		rt = rt.Replace("@PORT@", ConnectionInfoA.Port)
		rt = rt.Replace("@DATABASE@", ConnectionInfoA.Database)
		rt = rt.Replace("@USER@", ConnectionInfoA.User)
		rt = rt.Replace("@PASS@", ConnectionInfoA.Password)

		Return rt

	End Function

	Public Shared Function getSourceCode(DataTableInfo As MySQLDB.DataTableInfo, ClassInfo As ClassInfo) As String

		Dim sb As New StringBuilder

		'---------- Class Header ----------'
		Dim chPrivateProperties As String
		Dim chColumnList As String = ""
		For Each dci In DataTableInfo.ColumnList

			' CLASSHEADER_PRIVATE_PROPERTIES
			If Not chPrivateProperties = "" Then chPrivateProperties += vbCrLf
			chPrivateProperties += cTAB() + "private " + ConvertDataType(dci.DataType) + " " + dci.ColumnName + ";"


			If Not chColumnList = "" Then chColumnList += ", "
			chColumnList += dci.ColumnName
		Next

		Dim ClassHeader = My.Resources.JAVAforMYSQL_ClassHeader
		ClassHeader = ClassHeader.Replace("@CLASSNAME@", FirstCaps(ClassInfo.ClassName))
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_PRIVATE_PROPERTIES@", chPrivateProperties)
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_TABLENAME@", DataTableInfo.TableName)
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_COLUMNLIST@", chColumnList)

		sb.AppendLine(ClassHeader)
		sb.AppendLine("")

		'---------- Class Constructor ----------'
		Dim chClassConstructorPropertyLst As String = ""
		For Each dci In DataTableInfo.ColumnList
			If Not chClassConstructorPropertyLst = "" Then chClassConstructorPropertyLst += vbCrLf
			chClassConstructorPropertyLst += cTAB(4) + "this." + dci.ColumnName + " = rs.get" + ConvertDataType(dci.DataType).Replace("Integer", "int") + "(" + dblQuote() + dci.ColumnName + dblQuote() + ");"
		Next
		Dim ClassConstructor As String = My.Resources.JAVAforMYSQL_ClassConstructor
		ClassConstructor = ClassConstructor.Replace("@CLASSNAME@", FirstCaps(ClassInfo.ClassName))
		ClassConstructor = ClassConstructor.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)
		ClassConstructor = ClassConstructor.Replace("@PRIMARYKEYDATATYPE@", ConvertDataType(ClassInfo.ClassPrimaryKeyDataType))
		ClassConstructor = ClassConstructor.Replace("@CLASSCONSTRUCTORPROPERTYLIST@", chClassConstructorPropertyLst)


		sb.AppendLine(ClassConstructor)

		Return sb.ToString

	End Function

End Class
