Imports System.IO

Public Class ConnProfiles

	Public Shared dblQuote As String = Chr(34)

	Structure ProfileInfo
		Dim ProfileName As String
		Dim Host As String
		Dim Port As Integer
		Dim Database As String
		Dim Username As String
		Dim Password As String
	End Structure

	Public Shared Function PrepareCPF() As String

		Dim profilePath As String = Path.Combine(Application.StartupPath, "profiles.cpf")
		If Not File.Exists(profilePath) Then File.WriteAllText(profilePath, "")

		Return profilePath

	End Function

	Public Shared Function GetProfile(ProfileName As String) As ProfileInfo

		Dim pfi As ProfileInfo = Nothing

		Dim splA() As String

		Dim profilePath As String = PrepareCPF()

		For Each ln As String In File.ReadLines(profilePath)
			splA = ln.Split(",")
			If splA.Length = 6 Then
				If splA(0) = ProfileName Then
					pfi.ProfileName = splA(0)
					pfi.Host = splA(1)
					pfi.Port = CInt(splA(2))
					pfi.Database = splA(3)
					pfi.Username = splA(4)
					pfi.Password = splA(5)
					Return pfi
				End If
			End If
		Next

		Return Nothing

	End Function

	Public Shared Function ListProfile() As List(Of ProfileInfo)

		Dim buff As New List(Of ProfileInfo)
		Dim pfi As ProfileInfo

		Dim splA() As String

		Dim profilePath As String = PrepareCPF()

		For Each ln As String In File.ReadLines(profilePath)
			splA = ln.Split(",")
			If splA.Length = 6 Then
				pfi.ProfileName = splA(0)
				pfi.Host = splA(1)
				pfi.Port = CInt(splA(2))
				pfi.Database = splA(3)
				pfi.Username = splA(4)
				pfi.Password = splA(5)
				buff.Add(pfi)
			End If
		Next

		Return buff

	End Function

	Public Shared Function AddProfile(ProfileInfoA As ProfileInfo) As Boolean

		If IsExist(ProfileInfoA.ProfileName) Then Return False

		Dim profilePath As String = PrepareCPF()
		Dim Content As String = ""

		Content += ProfileInfoA.ProfileName + ","
		Content += ProfileInfoA.Host + ","
		Content += ProfileInfoA.Port.ToString + ","
		Content += ProfileInfoA.Database + ","
		Content += ProfileInfoA.Username + ","
		Content += ProfileInfoA.Password + vbCrLf

		File.AppendAllText(profilePath, Content)

	End Function

	Public Shared Function IsExist(ProfileName As String) As Boolean

		Dim profilePath As String = PrepareCPF()
		Dim Content As String = File.ReadAllText(profilePath)

		Return InStr(Content, ProfileName + ",")

	End Function

End Class
