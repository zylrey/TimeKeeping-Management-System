Imports DevExpress.XtraEditors

Public Class frmLogin

	Public ctrl As ctrlLogin

	Public Sub New(ctrl As ctrlLogin)
		InitializeComponent()
		Me.ctrl = ctrl
	End Sub

	Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtPassword.Properties.PasswordChar = "•"
	End Sub


	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		' Get the username and password from the text boxes
		Dim username As String = txtUsername.Text
		Dim password As String = txtPassword.Text

		' Call the SetLoginDetails method in the controller to set the login details
		ctrl.SetLoginDetails(username, password)

		' Call the ValidateLogin method in the controller to validate the login
		If ctrl.ValidateLogin() Then
			' If validation is successful, hide the form
			Me.Hide()
		End If
	End Sub


	Public Sub DisplayWarningMessage(ByVal message As String)
		XtraMessageBox.Show(message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
	End Sub

	Public Sub DisplayErrorMessage(ByVal message As String)
		XtraMessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Sub

	Public Sub DisplayMessageBox(ByVal message As String)
		XtraMessageBox.Show(message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
		Application.Exit()
	End Sub
End Class