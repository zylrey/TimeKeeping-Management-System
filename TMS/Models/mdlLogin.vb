Imports System.Linq

Public Class mdlLogin
	Public Property Username As String
	Public Property Password As String
	Public Property Ulevel As String
	Private dc As tmsdcDataContext

	Public Enum LoginResult
		Success
		Inactive
		Invalid
	End Enum


	Sub New(ByVal dataContext As tmsdcDataContext)
		dc = dataContext
	End Sub

	Public Function ValidateLogin() As LoginResult
		Dim user = (From u In dc.t_users
					Where u.username = Username
					Select u).FirstOrDefault()

		If user IsNot Nothing Then
			If user.password = Password Then
				' Check if the account is active
				If user.active = 1 Then
					' Account is active
					Ulevel = user.ulevel ' Set the ulevel property
					Return LoginResult.Success
				Else
					' Account is inactive
					Return LoginResult.Inactive
				End If
			Else
				' Invalid password
				Return LoginResult.Invalid
			End If
		Else
			' Account does not exist
			Return LoginResult.Invalid
		End If
	End Function



End Class
