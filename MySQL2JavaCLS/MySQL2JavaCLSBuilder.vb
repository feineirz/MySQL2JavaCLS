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

			Case "date" : Return "String"
			Case "datetime" : Return "String"
			Case "datetime2" : Return "String"
			Case "DATETIMEOFFSET" : Return "String"

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

	Shared Function ConvertGetSetDataType(SQLServerDataType As String) As String

		Select Case SQLServerDataType.ToLower

			Case "byte" : Return "Byte"
			Case "tinyint" : Return "Byte"
			Case "binary" : Return "Byte"
			Case "varbinary" : Return "Byte"

			Case "bit" : Return "Boolean"

			Case "date" : Return "String"
			Case "datetime" : Return "String"
			Case "datetime2" : Return "String"
			Case "DATETIMEOFFSET" : Return "String"

			Case "time" : Return "TimeSpan"

			Case "real" : Return "Double"
			Case "decimal" : Return "Double"
			Case "smallmoney" : Return "float"
			Case "money" : Return "Double"
			Case "numeric" : Return "Double"

			Case "single" : Return "Float"
			Case "float" : Return "Float"
			Case "double" : Return "Double"

			Case "smallint" : Return "Int"
			Case "int" : Return "Int"
			Case "bigint" : Return "Long"

			Case "char" : Return "String"
			Case "nchar" : Return "String"
			Case "varchar" : Return "String"
			Case "nvarchar" : Return "String"
			Case "text" : Return "String"
			Case "longtext" : Return "String"
			Case "ntext" : Return "String"
			Case "string" : Return "String"

			Case "byte[]" : Return "Byte[]"
			Case "image" : Return "Byte[]"
			Case "blob" : Return "Byte[]"
			Case "mediumblob" : Return "Byte[]"
			Case "longblob" : Return "Byte[]"

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
		Dim chPrivateProperties As String = ""
		Dim chStructureProperties As String = ""
		Dim chColumnList As String = ""
		For Each dci In DataTableInfo.ColumnList

			' CLASSHEADER_PRIVATE_PROPERTIES
			If Not chPrivateProperties = "" Then chPrivateProperties += vbCrLf
			chPrivateProperties += cTAB() + "private " + ConvertDataType(dci.DataType) + " " + dci.ColumnName + ";"

			' CLASSHEADER_STRUCTURE_PROPERTIES
			If Not chStructureProperties = "" Then chStructureProperties += vbCrLf
			chStructureProperties += cTAB(2) + ConvertDataType(dci.DataType) + " " + dci.ColumnName + ";"

			If Not chColumnList = "" Then chColumnList += ", "
			chColumnList += dci.ColumnName
		Next

		Dim ClassHeader = My.Resources.JAVAforMYSQL_ClassHeader
		ClassHeader = ClassHeader.Replace("@CLASSNAME@", FirstCaps(ClassInfo.ClassName))
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_PRIVATE_PROPERTIES@", chPrivateProperties)
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_STRUCTURE_PROPERTIES@", chStructureProperties)
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_TABLENAME@", DataTableInfo.TableName)
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_COLUMNLIST@", chColumnList)

		sb.AppendLine(ClassHeader)

		'---------- Class Constructor ----------'
		Dim chClassConstructorPropertyLst As String = ""
		For Each dci In DataTableInfo.ColumnList
			If Not chClassConstructorPropertyLst = "" Then chClassConstructorPropertyLst += vbCrLf
			chClassConstructorPropertyLst += cTAB(4) + "this." + dci.ColumnName + " = rs.get" + ConvertGetSetDataType(dci.DataType) + "(" + dblQuote() + dci.ColumnName + dblQuote() + ");"
		Next
		Dim ClassConstructor As String = My.Resources.JAVAforMYSQL_ClassConstructor
		ClassConstructor = ClassConstructor.Replace("@CLASSNAME@", FirstCaps(ClassInfo.ClassName))
		ClassConstructor = ClassConstructor.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)
		ClassConstructor = ClassConstructor.Replace("@PRIMARYKEY_DATATYPE@", ConvertDataType(ClassInfo.ClassPrimaryKeyDataType))
		ClassConstructor = ClassConstructor.Replace("@PRIMARYKEY_GETSETDATATYPE@", ConvertGetSetDataType(ClassInfo.ClassPrimaryKeyDataType))
		ClassConstructor = ClassConstructor.Replace("@CLASSCONSTRUCTOR_PROPERTYLIST@", chClassConstructorPropertyLst)

		sb.AppendLine(ClassConstructor)

		'---------- Class Properties ----------'
		Dim ClassProperties As String = My.Resources.JAVAforMYSQL_ClassProperties
		Dim chClassPropertyList As String = ""
		For Each dci In DataTableInfo.ColumnList
			If Not chClassPropertyList = "" Then chClassPropertyList += vbCrLf
			chClassPropertyList += cTAB() + "public " + ConvertDataType(dci.DataType) + " get" + dci.ColumnName + "() { return this." + dci.ColumnName + "; }"
			' Waiting for set

		Next

		ClassProperties = ClassProperties.Replace("@GET_PROPERTIYLIST@", chClassPropertyList)
		sb.AppendLine(ClassProperties)

		'---------- Required Functions ----------'
		' List '
		Dim rfListContents As String = My.Resources.JAVAforMYSQL_REQFUNC_List
		rfListContents = rfListContents.Replace("@CLASSNAME@", ClassInfo.ClassName)
		rfListContents = rfListContents.Replace("@TABLENAME@", DataTableInfo.TableName)
		rfListContents = rfListContents.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)
		rfListContents = rfListContents.Replace("@PRIMARYKEY_DATATYTPE@", ConvertDataType(ClassInfo.ClassPrimaryKeyDataType))

		sb.AppendLine(rfListContents)

		' Add '
		Dim rfAddContents As String = My.Resources.JAVAforMYSQL_REQFUNC_Add
		Dim rfAdd_ColumnlistWithDatattype As String = ""
		Dim rfAdd_StructuredColomnList As String = ""
		Dim rfAdd_ColumnList As String = ""
		Dim rfAdd_StatementHolder As String = ""
		Dim rfAdd_Statement_ColumnList As String = ""
		Dim rfAdd_StatementCount As Integer = 1
		For Each dci In DataTableInfo.ColumnList
			' rfAdd_ColumnlistWithDatattype
			If Not rfAdd_ColumnlistWithDatattype = "" Then rfAdd_ColumnlistWithDatattype += ", "
			rfAdd_ColumnlistWithDatattype += ConvertDataType(dci.DataType) + " " + dci.ColumnName

			' rfAdd_StructuredColomnList
			If Not rfAdd_StructuredColomnList = "" Then rfAdd_StructuredColomnList += vbCrLf
			rfAdd_StructuredColomnList += cTAB(2) + ClassInfo.ClassName.ToLower + "Info." + dci.ColumnName + " = " + dci.ColumnName + ";"

			' rfAdd_ColumnList
			If Not rfAdd_ColumnList = "" Then rfAdd_ColumnList += ", "
			rfAdd_ColumnList += dci.ColumnName

			' rfAdd_StatementHolder
			If Not rfAdd_StatementHolder = "" Then rfAdd_StatementHolder += ","
			rfAdd_StatementHolder += "?"

			' rfAdd_Statement_ColumnList
			If Not rfAdd_Statement_ColumnList = "" Then rfAdd_Statement_ColumnList += vbCrLf
			rfAdd_Statement_ColumnList += cTAB(3) + "stmt.set" + ConvertGetSetDataType(dci.DataType) + "(" + rfAdd_StatementCount.ToString + ", " + ClassInfo.ClassName.ToLower + "Info." + dci.ColumnName + ");"
			rfAdd_StatementCount += 1
		Next

		rfAddContents = rfAddContents.Replace("@CLASSNAME@", ClassInfo.ClassName)
		rfAddContents = rfAddContents.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		rfAddContents = rfAddContents.Replace("@COLUMNLIST_WITHDATATYPE@", rfAdd_ColumnlistWithDatattype)
		rfAddContents = rfAddContents.Replace("@STRUCTURED_COLUMNLIST@", rfAdd_StructuredColomnList)
		rfAddContents = rfAddContents.Replace("@TABLENAME@", DataTableInfo.TableName)
		rfAddContents = rfAddContents.Replace("@COLUMNLIST@", rfAdd_ColumnList)
		rfAddContents = rfAddContents.Replace("@STATEMENTHOLDER@", rfAdd_StatementHolder)
		rfAddContents = rfAddContents.Replace("@STATEMENT_COLUMNLIST@", rfAdd_Statement_ColumnList)

		sb.AppendLine(rfAddContents)

		' Update '
		Dim rfUpdateContents As String = My.Resources.JAVAforMYSQL_REQFUNC_Update
		Dim rfUpdate_UpdateColumnListNonePrimaryKey As String = ""
		For i = 0 To DataTableInfo.ColumnList.Count - 1
			Dim dci = DataTableInfo.ColumnList(i)
			If Not dci.ColumnName = ClassInfo.ClassPrimaryKey Then
				If Not rfUpdate_UpdateColumnListNonePrimaryKey = "" Then rfUpdate_UpdateColumnListNonePrimaryKey += vbCrLf
				If i < DataTableInfo.ColumnList.Count - 1 Then
					rfUpdate_UpdateColumnListNonePrimaryKey += cTAB(5) + "+ " + dblQuote() + "  " + dci.ColumnName + " = ?," + dblQuote()
				Else
					rfUpdate_UpdateColumnListNonePrimaryKey += cTAB(5) + "+ " + dblQuote() + "  " + dci.ColumnName + " = ?" + dblQuote()
				End If
			End If
		Next

		rfUpdateContents = rfUpdateContents.Replace("@CLASSNAME@", ClassInfo.ClassName)
		rfUpdateContents = rfUpdateContents.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		rfUpdateContents = rfUpdateContents.Replace("@COLUMNLIST_WITHDATATYPE@", rfAdd_ColumnlistWithDatattype)
		rfUpdateContents = rfUpdateContents.Replace("@STRUCTURED_COLUMNLIST@", rfAdd_StructuredColomnList)
		rfUpdateContents = rfUpdateContents.Replace("@TABLENAME@", DataTableInfo.TableName)
		rfUpdateContents = rfUpdateContents.Replace("@UPDATE_COLUMNLIST_NONE_PRIMARYKEY@", rfUpdate_UpdateColumnListNonePrimaryKey)
		rfUpdateContents = rfUpdateContents.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)

		sb.AppendLine(rfUpdateContents)


		sb.AppendLine("}" + vbCrLf + "/////////////////////////// END CLASS ///////////////////////////")
		Return sb.ToString

	End Function

End Class
