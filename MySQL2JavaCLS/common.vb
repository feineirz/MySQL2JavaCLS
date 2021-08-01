﻿Module common

	Public Function FirstCaps(src As String, Optional OtherIsLower As Boolean = False) As String

		Dim rt As String = ""
		If OtherIsLower Then src = src.ToLower

		If src = Nothing Then Return ""

		If src.Length > 0 Then

			Dim c() As Char = src.ToCharArray
			c(0) = c(0).ToString.ToUpper
			rt = New String(c)

		End If

		Return rt

	End Function

	Public Function NameCamelCase(Name As String) As String

		Dim buff As String = ""
		For Each word In Name.Split("_")
			buff += FirstCaps(word)
		Next

		Return buff

	End Function

End Module


