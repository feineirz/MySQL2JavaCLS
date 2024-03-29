﻿Imports System.Text

Public Class MySQL2JavaCLSBuilder

	Public Structure ClassInfo
		Dim PackageName As String
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

	Public Shared Function FirstCaps(src As String, Optional OtherIsLower As Boolean = False) As String

		Dim rt As String = ""
		If OtherIsLower Then src = src.ToLower

		If src.Length > 0 Then

			Dim c() As Char = src.ToCharArray
			c(0) = c(0).ToString.ToUpper
			rt = New String(c)

		End If

		Return rt

	End Function

	Public Shared Function CamelCase(Name As String) As String

		Dim buff As String = ""
		Dim count As Integer = 0
		For Each word In Name.Split("_")
			If count = 0 Then
				buff += word
			Else
				buff += FirstCaps(word)
			End If
			count += 1
		Next

		Return buff

	End Function

	Public Shared Function SectionHeader(Header As String, Optional UseSingleLine As Boolean = False, Optional LineCharacter As Char = "=", Optional DefaultWidth As Integer = 100) As String

		Header = Header.Trim

		Dim content As String = ""
		Dim FullLine As String
		Dim SubLineLeft As String
		Dim SubLineRight As String = ""
		Dim HeaderLine As String

		FullLine = "/*"
		For i = 1 To DefaultWidth - 4
			FullLine += LineCharacter
		Next
		FullLine += "*/"

		SubLineLeft = "/*"
		For i = 1 To ((DefaultWidth - (Header.Length + 4)) / 2) - 2
			SubLineLeft += LineCharacter
			SubLineRight += LineCharacter
		Next
		SubLineRight += "*/"

		If Not UseSingleLine Then content += FullLine + vbCrLf + FullLine + vbCrLf
		HeaderLine = SubLineLeft + "[ " + Header + " ]" + SubLineRight
		If HeaderLine.Length < DefaultWidth Then
			HeaderLine = HeaderLine.Replace(LineCharacter + "*/", LineCharacter + LineCharacter + "*/")
		End If
		content += HeaderLine + vbCrLf
		If Not UseSingleLine Then content += FullLine + vbCrLf + FullLine + vbCrLf

		Return content

	End Function

	Public Shared Function SectionTitle(Title As String, Description As String, Optional LineCharacter As Char = "-", Optional DefaultWidth As Integer = 100) As String

		Title = Title.Trim

		Dim content As String
		Dim FullLine As String
		Dim SubLineLeft As String
		Dim SubLineRight As String
		Dim TitleLine As String
		Dim DescLine As String

		FullLine = "/*"
		For i = 1 To DefaultWidth - 4
			FullLine += LineCharacter
		Next
		FullLine += "*/"

		content = FullLine + vbCrLf

		' Title
		SubLineLeft = "/*"
		SubLineRight = ""
		For i = 1 To ((DefaultWidth - (Title.Length + 4)) / 2) - 2
			SubLineLeft += LineCharacter
			SubLineRight += LineCharacter
		Next
		SubLineRight += "*/"

		TitleLine = SubLineLeft + "[ " + Title + " ]" + SubLineRight
		If TitleLine.Length < DefaultWidth Then
			TitleLine = TitleLine.Replace(LineCharacter + "*/", LineCharacter + LineCharacter + "*/")
		End If
		content += TitleLine + vbCrLf
		content += FullLine + vbCrLf

		' Desc
		SubLineLeft = "/*"
		SubLineRight = ""
		For i = 1 To ((DefaultWidth - (Description.Length + 2)) / 2) - 2
			SubLineLeft += LineCharacter
			SubLineRight += LineCharacter
		Next
		SubLineRight += "*/"

		DescLine = SubLineLeft + " " + Description + " " + SubLineRight
		If DescLine.Length < DefaultWidth Then
			DescLine = DescLine.Replace(LineCharacter + "*/", LineCharacter + LineCharacter + "*/")
		End If
		content += DescLine + vbCrLf
		content += FullLine + vbCrLf

		Return content

	End Function

	Public Shared Function SectionLine(LineContent As String, Optional LineCharacter As Char = "=", Optional DefaultWidth As Integer = 100) As String

		LineContent = LineContent.Trim

		Dim content As String
		Dim SubLineLeft As String
		Dim SubLineRight As String = ""

		SubLineLeft = "//"
		For i = 1 To ((DefaultWidth - (LineContent.Length + 2)) / 2) - 2
			SubLineLeft += LineCharacter
			SubLineRight += LineCharacter
		Next
		SubLineRight += "//"

		content = SubLineLeft + " " + LineContent + " " + SubLineRight
		If content.Length < DefaultWidth Then
			content = content.Replace(LineCharacter + "//", LineCharacter + LineCharacter + "//")
		End If

		Return content

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
			Case "enum" : Return "String"

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
			Case "enum" : Return "String"

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
		Dim titleDesc As String

		'------------- Credits ------------'
		Dim Credits = My.Resources.JAVAforMYSQL_Credits

		Credits = Credits.Replace("@APP_VERSION@", SectionLine("< version " + Application.ProductVersion + " >", "-"))

		sb.AppendLine(Credits)

		'---------- Class Header ----------'
		Dim chPrivateProperties As String = ""
		Dim chStructureProperties As String = ""
		Dim chColumnList As String = ""
		For i = 0 To DataTableInfo.ColumnList.Count - 1
			Dim dci = DataTableInfo.ColumnList(i)

			' CLASSHEADER_PRIVATE_PROPERTIES
			If Not chPrivateProperties = "" Then chPrivateProperties += vbCrLf
			chPrivateProperties += cTAB() + "private " + ConvertDataType(dci.DataType) + " " + CamelCase(dci.ColumnName) + ";"

			' CLASSHEADER_STRUCTURE_PROPERTIES
			If Not chStructureProperties = "" Then chStructureProperties += vbCrLf
			chStructureProperties += cTAB(2) + "public " + ConvertDataType(dci.DataType) + " " + CamelCase(dci.ColumnName) + ";"

			If Not chColumnList = "" Then chColumnList += vbCrLf
			If i < DataTableInfo.ColumnList.Count - 1 Then
				chColumnList += cTAB(2) + "+ " + dblQuote() + " " + dci.ColumnName + "," + dblQuote()
			Else
				chColumnList += cTAB(2) + "+ " + dblQuote() + " " + dci.ColumnName + dblQuote()
			End If
		Next

		Dim ClassHeader = My.Resources.JAVAforMYSQL_ClassHeader
		ClassHeader = ClassHeader.Replace("@SECTIONSTART@", SectionHeader("CLASS HEADER"))
		ClassHeader = ClassHeader.Replace("@PACKAGENAME@", ClassInfo.PackageName)
		ClassHeader = ClassHeader.Replace("@CLASSNAME@", FirstCaps(ClassInfo.ClassName))
		ClassHeader = ClassHeader.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_PRIVATE_PROPERTIES@", chPrivateProperties)
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_STRUCTURE_PROPERTIES@", chStructureProperties)
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_TABLENAME@", DataTableInfo.TableName)
		ClassHeader = ClassHeader.Replace("@CLASSHEADER_COLUMNLIST@", chColumnList)
		ClassHeader = ClassHeader.Replace("@SECTIONEND@", SectionHeader("END CLASS HEADER", True))

		sb.AppendLine(ClassHeader)

		'---------- Class Constructor ----------'
		Dim chClassConstructorPropertyLst As String = ""
		For Each dci In DataTableInfo.ColumnList
			If Not chClassConstructorPropertyLst = "" Then chClassConstructorPropertyLst += vbCrLf
			chClassConstructorPropertyLst += cTAB(4) + "this." + CamelCase(dci.ColumnName) + " = rs.get" + ConvertGetSetDataType(dci.DataType) + "(" + dblQuote() + dci.ColumnName + dblQuote() + ");"
		Next
		Dim ClassConstructor As String = My.Resources.JAVAforMYSQL_ClassConstructor
		ClassConstructor = ClassConstructor.Replace("@SECTIONSTART@", SectionHeader("CLASS CONSTRUCTOR"))

		titleDesc = "Create a " + FirstCaps(ClassInfo.ClassName) + " object from the given " + ClassInfo.ClassPrimaryKey + "."
		ClassConstructor = ClassConstructor.Replace("@TITLE@", SectionTitle("CONSTRUCTOR", titleDesc))

		ClassConstructor = ClassConstructor.Replace("@CLASSNAME@", FirstCaps(ClassInfo.ClassName))
		ClassConstructor = ClassConstructor.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		ClassConstructor = ClassConstructor.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)
		ClassConstructor = ClassConstructor.Replace("@PRIMARYKEY_DATATYPE@", ConvertDataType(ClassInfo.ClassPrimaryKeyDataType))
		ClassConstructor = ClassConstructor.Replace("@PRIMARYKEY_GETSETDATATYPE@", ConvertGetSetDataType(ClassInfo.ClassPrimaryKeyDataType))
		ClassConstructor = ClassConstructor.Replace("@CLASSCONSTRUCTOR_PROPERTYLIST@", chClassConstructorPropertyLst)
		ClassConstructor = ClassConstructor.Replace("@SECTIONEND@", SectionHeader("END CLASS CONSTRUCTOR", True))

		sb.AppendLine(ClassConstructor)

		'---------- Class Properties ----------'
		Dim ClassProperties As String = My.Resources.JAVAforMYSQL_ClassProperties
		Dim chClassGetPropertyList As String = ""
		Dim chClassSetPropertyList As String = ""
		Dim JavadocsTemplate As String
		For Each dci In DataTableInfo.ColumnList
			' chClassGetPropertyList
			If Not chClassGetPropertyList = "" Then chClassGetPropertyList += vbCrLf

			' Javadocs
			JavadocsTemplate = """
	/**
	 * <pre>
	 * Get " + ClassInfo.ClassName + "." + CamelCase(dci.ColumnName) + " from a database.
	 * 
	 * Usage:
	 *  " + ClassInfo.ClassName + " " + ClassInfo.ClassName.ToLower + " = New " + ClassInfo.ClassName + "(" + ClassInfo.ClassPrimaryKey + ");
	 *  " + ConvertDataType(dci.DataType) + " " + CamelCase(dci.ColumnName) + " = " + ClassInfo.ClassName.ToLower + ".get" + CamelCase(FirstCaps(dci.ColumnName)) + "();
	 * </pre>
	 * 
	 * @return " + ClassInfo.ClassName + " " + CamelCase(dci.ColumnName) + ".
	 */
"""
			chClassGetPropertyList += JavadocsTemplate.Replace(dblQuote, "")

			chClassGetPropertyList += cTAB() + "public " + ConvertDataType(dci.DataType) + " get" + CamelCase(FirstCaps(dci.ColumnName)) + "() { " + vbCrLf
			chClassGetPropertyList += cTAB(2) + "return this." + CamelCase(dci.ColumnName) + ";" + vbCrLf
			chClassGetPropertyList += cTAB() + "}" + vbCrLf

			' chClassSetPropertyList
			If ClassInfo.IsPrimaryKeyReadOnly And dci.ColumnName = ClassInfo.ClassPrimaryKey Then Continue For

			If Not chClassSetPropertyList = "" Then chClassSetPropertyList += vbCrLf

			' Javadocs
			JavadocsTemplate = """
	/**
	 * <pre>
	 * Update " + ClassInfo.ClassName + "." + CamelCase(dci.ColumnName) + " in a database.
	 * 
	 * Usage:
	 *  " + ClassInfo.ClassName + " " + ClassInfo.ClassName.ToLower + " = New " + ClassInfo.ClassName + "(" + ClassInfo.ClassPrimaryKey + ");
	 *  boolean result = " + ClassInfo.ClassName.ToLower + ".set" + CamelCase(FirstCaps(dci.ColumnName)) + "(value);
	 * </pre>
	 * 
	 * @param value " + ClassInfo.ClassName + " " + CamelCase(dci.ColumnName) + " to update to the database.
	 * 
	 * @return True if update successful.
	 */
"""
			chClassSetPropertyList += JavadocsTemplate.Replace(dblQuote, "")
			chClassSetPropertyList += cTAB() + "public boolean" + " set" + CamelCase(FirstCaps(dci.ColumnName)) + "(" + ConvertDataType(dci.DataType) + " value) {" + vbCrLf
			chClassSetPropertyList += cTAB(2) + "if (update" + ClassInfo.ClassName + "Property(" + dblQuote() + dci.ColumnName + dblQuote() + ", value)) {" + vbCrLf
			chClassSetPropertyList += cTAB(3) + "this." + CamelCase(dci.ColumnName) + " = value;" + vbCrLf
			chClassSetPropertyList += cTAB(3) + "return true;" + vbCrLf
			chClassSetPropertyList += cTAB(2) + "} else { " + vbCrLf
			chClassSetPropertyList += cTAB(3) + "return false;" + vbCrLf
			chClassSetPropertyList += cTAB(2) + "}" + vbCrLf
			chClassSetPropertyList += cTAB() + "}" + vbCrLf

		Next

		ClassProperties = ClassProperties.Replace("@SECTIONSTART@", SectionHeader("CLASS PROPERTIES"))
		ClassProperties = ClassProperties.Replace("@GET_PROPERTIYLIST@", chClassGetPropertyList)
		ClassProperties = ClassProperties.Replace("@SET_PROPERTYLIST@", chClassSetPropertyList)
		ClassProperties = ClassProperties.Replace("@SECTIONEND@", SectionHeader("END CLASS PROPERTIES", True))
		sb.AppendLine(ClassProperties)

		'---------- Required Functions ----------'

		sb.AppendLine(SectionHeader("REQUIRED FUNCTIONS"))

		' List '
		Dim rfListContents As String = My.Resources.JAVAforMYSQL_REQFUNC_List

		titleDesc = "List " + FirstCaps(ClassInfo.ClassName) + " in a database as " + FirstCaps(ClassInfo.ClassName) + " objects."
		rfListContents = rfListContents.Replace("@TITLE@", SectionTitle("LIST", titleDesc))
		rfListContents = rfListContents.Replace("@DESC_A@", titleDesc)

		rfListContents = rfListContents.Replace("@CLASSNAME@", ClassInfo.ClassName)
		rfListContents = rfListContents.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		rfListContents = rfListContents.Replace("@TABLENAME@", DataTableInfo.TableName)
		rfListContents = rfListContents.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)
		rfListContents = rfListContents.Replace("@PRIMARYKEY_GETSETDATATYPE@", ConvertGetSetDataType(ClassInfo.ClassPrimaryKeyDataType))

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
			rfAdd_ColumnlistWithDatattype += vbCrLf + cTAB(2) + ConvertDataType(dci.DataType) + " " + dci.ColumnName

			' rfAdd_StructuredColomnList
			If Not rfAdd_StructuredColomnList = "" Then rfAdd_StructuredColomnList += vbCrLf
			rfAdd_StructuredColomnList += cTAB(2) + ClassInfo.ClassName.ToLower + "Info." + CamelCase(dci.ColumnName) + " = " + dci.ColumnName + ";"

			' rfAdd_ColumnList
			If Not rfAdd_ColumnList = "" Then rfAdd_ColumnList += ", "
			rfAdd_ColumnList += dci.ColumnName

			' rfAdd_StatementHolder
			If Not rfAdd_StatementHolder = "" Then rfAdd_StatementHolder += ","
			rfAdd_StatementHolder += "?"

			' rfAdd_Statement_ColumnList
			If Not rfAdd_Statement_ColumnList = "" Then rfAdd_Statement_ColumnList += vbCrLf
			rfAdd_Statement_ColumnList += cTAB(3) + "stmt.set" + ConvertGetSetDataType(dci.DataType) _
				+ "(" + rfAdd_StatementCount.ToString + ", " + ClassInfo.ClassName.ToLower + "Info." + CamelCase(dci.ColumnName) + ");"

			rfAdd_StatementCount += 1
		Next

		titleDesc = "Add " + FirstCaps(ClassInfo.ClassName) + " to database by giving a raw information."
		rfAddContents = rfAddContents.Replace("@TITLE_A@", SectionTitle("ADD (RAW)", titleDesc))
		rfAddContents = rfAddContents.Replace("@DESC_A@", titleDesc)

		titleDesc = "Add " + FirstCaps(ClassInfo.ClassName) + " to database by giving a structured information."
		rfAddContents = rfAddContents.Replace("@TITLE_B@", SectionTitle("ADD (STRUCTURED)", titleDesc))
		rfAddContents = rfAddContents.Replace("@DESC_B@", titleDesc)

		rfAddContents = rfAddContents.Replace("@CLASSNAME@", ClassInfo.ClassName)
		rfAddContents = rfAddContents.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		rfAddContents = rfAddContents.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)
		rfAddContents = rfAddContents.Replace("@COLUMNLIST_WITHDATATYPE@", rfAdd_ColumnlistWithDatattype)
		rfAddContents = rfAddContents.Replace("@STRUCTURED_COLUMNLIST@", rfAdd_StructuredColomnList)
		rfAddContents = rfAddContents.Replace("@TABLENAME@", DataTableInfo.TableName)
		rfAddContents = rfAddContents.Replace("@COLUMNLIST@", rfAdd_ColumnList)
		rfAddContents = rfAddContents.Replace("@STATEMENTHOLDER@", rfAdd_StatementHolder)
		rfAddContents = rfAddContents.Replace("@STATEMENT_COLUMNLIST@", rfAdd_Statement_ColumnList)
		rfAddContents = rfAddContents.Replace("@PRIMARYKEY_GETSETDATATYPE@", ConvertGetSetDataType(ClassInfo.ClassPrimaryKeyDataType))


		sb.AppendLine(rfAddContents)

		' Update '
		Dim rfUpdateContents As String = My.Resources.JAVAforMYSQL_REQFUNC_Update
		Dim rfUpdate_UpdateColumnListNonePrimaryKey As String = ""
		Dim rfUpdate_StatementColumnListNonePrimaryKey As String = ""
		Dim rfUpdate_StatementCount As Integer = 1
		For i = 0 To DataTableInfo.ColumnList.Count - 1
			Dim dci = DataTableInfo.ColumnList(i)
			If Not dci.ColumnName = ClassInfo.ClassPrimaryKey Then
				' rfUpdate_UpdateColumnListNonePrimaryKey
				If Not rfUpdate_UpdateColumnListNonePrimaryKey = "" Then rfUpdate_UpdateColumnListNonePrimaryKey += vbCrLf
				If i < DataTableInfo.ColumnList.Count - 1 Then
					rfUpdate_UpdateColumnListNonePrimaryKey += cTAB(4) + "+ " + dblQuote() + " " + dci.ColumnName + " = ?," + dblQuote()
				Else
					rfUpdate_UpdateColumnListNonePrimaryKey += cTAB(4) + "+ " + dblQuote() + " " + dci.ColumnName + " = ?" + dblQuote()
				End If

				' rfUpdate_StatementColumnListNonePrimaryKey
				rfUpdate_StatementColumnListNonePrimaryKey += cTAB(3) + "stmt.set" + ConvertGetSetDataType(dci.DataType) + "(" _
				+ rfUpdate_StatementCount.ToString + ", " + ClassInfo.ClassName.ToLower + "Info." + CamelCase(dci.ColumnName) + ");" + vbCrLf

				rfUpdate_StatementCount += 1
			End If
		Next

		rfUpdate_StatementColumnListNonePrimaryKey += cTAB(3) + "stmt.set" + ConvertGetSetDataType(ClassInfo.ClassPrimaryKeyDataType) + "(" _
			+ rfUpdate_StatementCount.ToString + ", " + ClassInfo.ClassName.ToLower + "Info." + ClassInfo.ClassPrimaryKey + ");" + vbCrLf

		titleDesc = "Update " + FirstCaps(ClassInfo.ClassName) + " information in a database by giving a raw information."
		rfUpdateContents = rfUpdateContents.Replace("@TITLE_A@", SectionTitle("UPDATE (RAW)", titleDesc))
		rfUpdateContents = rfUpdateContents.Replace("@DESC_A@", titleDesc)

		titleDesc = "Update " + FirstCaps(ClassInfo.ClassName) + " information in a database by giving a structured information."
		rfUpdateContents = rfUpdateContents.Replace("@TITLE_B@", SectionTitle("UPDATE (STRUCTURED)", titleDesc))
		rfUpdateContents = rfUpdateContents.Replace("@DESC_B@", titleDesc)

		titleDesc = "Update single property in a database by the given ColumnName and Value."
		rfUpdateContents = rfUpdateContents.Replace("@TITLE_C@", SectionTitle("UPDATE PROPERTY", titleDesc))
		rfUpdateContents = rfUpdateContents.Replace("@DESC_C@", titleDesc)

		rfUpdateContents = rfUpdateContents.Replace("@CLASSNAME@", ClassInfo.ClassName)
		rfUpdateContents = rfUpdateContents.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		rfUpdateContents = rfUpdateContents.Replace("@COLUMNLIST_WITHDATATYPE@", rfAdd_ColumnlistWithDatattype)
		rfUpdateContents = rfUpdateContents.Replace("@STRUCTURED_COLUMNLIST@", rfAdd_StructuredColomnList)
		rfUpdateContents = rfUpdateContents.Replace("@TABLENAME@", DataTableInfo.TableName)
		rfUpdateContents = rfUpdateContents.Replace("@UPDATE_COLUMNLIST_NONE_PRIMARYKEY@", rfUpdate_UpdateColumnListNonePrimaryKey)
		rfUpdateContents = rfUpdateContents.Replace("@STATEMENT_COLUMNLIST_NONE_PRIMARYKEY@", rfUpdate_StatementColumnListNonePrimaryKey)
		rfUpdateContents = rfUpdateContents.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)

		sb.AppendLine(rfUpdateContents)

		' Delete '
		Dim rfDeleteContents As String = My.Resources.JAVAforMYSQL_REQFUNC_Delete

		titleDesc = "Delete " + FirstCaps(ClassInfo.ClassName) + " from a database."
		rfDeleteContents = rfDeleteContents.Replace("@TITLE@", SectionTitle("DELETE", titleDesc))
		rfDeleteContents = rfDeleteContents.Replace("@DESC@", titleDesc)

		rfDeleteContents = rfDeleteContents.Replace("@CLASSNAME@", ClassInfo.ClassName)
		rfDeleteContents = rfDeleteContents.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		rfDeleteContents = rfDeleteContents.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)
		rfDeleteContents = rfDeleteContents.Replace("@PRIMARYKEY_DATATYPE@", ConvertDataType(ClassInfo.ClassPrimaryKeyDataType))
		rfDeleteContents = rfDeleteContents.Replace("@PRIMARYKEY_GETSETDATATYPE@", ConvertGetSetDataType(ClassInfo.ClassPrimaryKeyDataType))
		rfDeleteContents = rfDeleteContents.Replace("@TABLENAME@", DataTableInfo.TableName)

		sb.AppendLine(rfDeleteContents)

		' IsExist '
		Dim rfIsExistContents As String = My.Resources.JAVAforMYSQL_REQFUNC_IsExist

		titleDesc = "Check if record(s) from the given condition is exists in a database."
		rfIsExistContents = rfIsExistContents.Replace("@TITLE@", SectionTitle("IsEXIST", titleDesc))
		rfIsExistContents = rfIsExistContents.Replace("@DESC@", titleDesc)

		rfIsExistContents = rfIsExistContents.Replace("@CLASSNAME@", ClassInfo.ClassName)
		rfIsExistContents = rfIsExistContents.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		rfIsExistContents = rfIsExistContents.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)
		rfIsExistContents = rfIsExistContents.Replace("@PRIMARYKEY_DATATYPE@", ConvertDataType(ClassInfo.ClassPrimaryKeyDataType))
		rfIsExistContents = rfIsExistContents.Replace("@PRIMARYKEY_GETSETDATATYPE@", ConvertGetSetDataType(ClassInfo.ClassPrimaryKeyDataType))
		rfIsExistContents = rfIsExistContents.Replace("@TABLENAME@", DataTableInfo.TableName)

		sb.AppendLine(rfIsExistContents)

		' ToClassInfo '
		Dim rfToClassInfo As String = My.Resources.JAVAforMYSQL_REQFUNC_ToClassInfo
		Dim rfToClassInfo_ConvertList As String = ""
		For Each dci In DataTableInfo.ColumnList
			rfToClassInfo_ConvertList += cTAB(2) + "ci." + CamelCase(dci.ColumnName) + " = this." + CamelCase(dci.ColumnName) + ";" + vbCrLf
		Next

		titleDesc = "Convert " + FirstCaps(ClassInfo.ClassName) + " object to a " + FirstCaps(ClassInfo.ClassName) + "Info object."
		rfToClassInfo = rfToClassInfo.Replace("@TITLE@", SectionTitle("ToCLASSINFO", titleDesc))
		rfToClassInfo = rfToClassInfo.Replace("@DESC@", titleDesc)

		rfToClassInfo = rfToClassInfo.Replace("@CLASSNAME@", ClassInfo.ClassName)
		rfToClassInfo = rfToClassInfo.Replace("@CLASSNAMELOWER@", ClassInfo.ClassName.ToLower)
		rfToClassInfo = rfToClassInfo.Replace("@PRIMARYKEY@", ClassInfo.ClassPrimaryKey)
		rfToClassInfo = rfToClassInfo.Replace("@TOCLASSINFO_CONVERTLIST@", rfToClassInfo_ConvertList)

		sb.AppendLine(rfToClassInfo)

		sb.AppendLine(SectionHeader("END REQUIRED FUNCTIONS", True))

		'---------- User Custom Functions ----------' 
		Dim ucFunctionContents As String = My.Resources.JAVAforMYSQL_UCFUNC

		titleDesc = "PLACE YOUR CUSTOM FUNCTIONS HERE"
		ucFunctionContents = ucFunctionContents.Replace("@TITLE@", SectionTitle("USER CUSTOM FUNCTIONS", titleDesc))

		ucFunctionContents = ucFunctionContents.Replace("@SECTIONSTART@", SectionHeader("USER CUSTOM FUNCTIONS"))
		ucFunctionContents = ucFunctionContents.Replace("@SECTIONEND@", SectionHeader("END USER CUSTOM FUNCTIONS", True))

		sb.AppendLine(ucFunctionContents)


		sb.AppendLine("}" + vbCrLf + vbCrLf)
		sb.AppendLine("/*---------------------------------------{{{ CLASS END }}}----------------------------------------*/")
		sb.AppendLine(My.Resources.JAVAforMYSQL_EndCredits)

		Return sb.ToString

	End Function

End Class
