Module common

	Public Function FirstCaps(src As String, Optional OtherIsLower As Boolean = False) As String

		Dim rt As String = ""
		If OtherIsLower Then src = src.ToLower

		If src.Length > 0 Then

			Dim c() As Char = src.ToCharArray
			c(0) = c(0).ToString.ToUpper
			rt = New String(c)

		End If

		Return rt

	End Function





End Module


