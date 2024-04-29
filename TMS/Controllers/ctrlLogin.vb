Public Class ctrlLogin

	Private mLogin As mdlLogin
	Private vFrmLogin As frmLogin
	Private vFrmDash As New frmDashboard
	Private vFrmScan As New frmScan
	Private dc As tmsdcDataContext
	Public Property IsLoggedIn As Boolean = False
	Public Property Username As String
	Public Property Ulevel As String

	Public Enum LoginResult
		Success
		Inactive
		Invalid
	End Enum


	' Constructor to initialize the data context
	Sub New(ByVal dataContext As tmsdcDataContext)
		dc = dataContext
		mLogin = New mdlLogin(dc)
		vFrmLogin = New frmLogin(Me)
	End Sub

	Sub New()
		dc = New tmsdcDataContext
		mLogin = New mdlLogin(dc)
		vFrmLogin = New frmLogin(Me)
	End Sub

	Public Function ValidateLogin() As Boolean
		Dim result As LoginResult = mLogin.ValidateLogin()

		Select Case result
			Case LoginResult.Success
				' Account is active, allow login
				vFrmLogin.DisplayMessageBox("Login successful.")
				' Determine which form to open based on ulevel
				If mLogin.Ulevel = "SYSTEMADMIN" Then
					' Open the frmDashboard form for SYSTEMADMIN
					vFrmDash.Username = mLogin.Username
					vFrmDash.Ulevel = mLogin.Ulevel
					vFrmDash.Show()
				ElseIf mLogin.Ulevel = "SYSTEMSTAFF" Then
					' Open the frmScan form for SYSTEMSTAFF
                    'vFrmScan.Username = mLogin.Username
                    'vFrmScan.Ulevel = mLogin.Ulevel
					vFrmScan.Show()
				End If
				Return True	' Return True for successful login

			Case LoginResult.Inactive
				' Account is inactive, show error message
				vFrmLogin.DisplayWarningMessage("Your account is inactive. Please ask admin for activation.")
				Return False ' Return False for inactive account

			Case LoginResult.Invalid
				' Account does not exist or invalid credentials, show error message
				vFrmLogin.DisplayErrorMessage("Invalid username or password.")
				Return False ' Return False for invalid login

			Case Else
				' Handle unexpected cases (optional)
				Return False ' Return False for unexpected cases
		End Select
	End Function




	Public Sub SetLoginDetails(username As String, password As String)
		mLogin.Username = username
		mLogin.Password = password
	End Sub

	Public Function GetLoginForm() As frmLogin
		Return vFrmLogin
	End Function

End Class
