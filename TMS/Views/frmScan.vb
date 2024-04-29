Imports DevExpress.XtraEditors

Public Class frmScan
	Private cScan As ctrlScan
	Private mScan As mdlScan
	Private result As DialogResult
	' ... rest of your properties

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Initialize controller and model
		cScan = New ctrlScan()
		mScan = New mdlScan()

		' Add the KeyDown event handler for txtScan TextBox
		AddHandler txtScan.KeyDown, AddressOf txtScan_KeyDown
	End Sub

	' ... rest of your code

	Private Sub txtScan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtScan.KeyDown
		If e.KeyCode = Keys.Enter Then
			If Not String.IsNullOrEmpty(txtScan.Text) Then
				Dim s_uid As Integer
				If Integer.TryParse(txtScan.Text, s_uid) Then
					Dim name As String = cScan.CreateDTR(s_uid)
					txtName.Text = name

					' Save attendance
					If Not String.IsNullOrEmpty(txtName.Text) Then
						Dim saved As Boolean = cScan.SaveAttendance(s_uid, txtName.Text)
						If saved Then
							MessageBox.Show("Attendance saved successfully!")
						End If
					End If

					clearTxt()
				Else
					MessageBox.Show("Invalid barcode format!")
					clearTxt()
				End If
			Else
				'MessageBox.Show("Please scan a barcode!")
			End If
		End If
	End Sub



	Sub clearTxt()
		txtScan.Text = ""
	End Sub

	Private Function DisplayWarningMessage(message As String) As DialogResult
		Return XtraMessageBox.Show(message, "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
	End Function

	Private Sub frmScan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		' Display warning message when the form is closing
		result = DisplayWarningMessage("Are you sure to logout?")

		' If the user clicks No in the warning message box, cancel the form closing
		If result = DialogResult.No Then
			e.Cancel = True
		Else
			Dim ctrlLoginInstance As New ctrlLogin()
			Dim vFrmLogin As New frmLogin(ctrlLoginInstance)
			vFrmLogin.Show()

			Me.Hide()
		End If
	End Sub

End Class
