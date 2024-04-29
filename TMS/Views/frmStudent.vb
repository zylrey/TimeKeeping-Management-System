Imports DevExpress.XtraEditors


Public Class frmStudent
	Private ctrlStudent As ctrlStudent

	Sub New(ByRef ctStudent As ctrlStudent)
		InitializeComponent()
		ctrlStudent = ctStudent

		'cmbCourse.Properties.Items.AddRange({"BSIT", "BSCS"})
		'cmbSection.Properties.Items.AddRange({"A", "B"})
	End Sub

	Public Sub DisplayWarningMessage(ByVal message As String)
		XtraMessageBox.Show(message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
	End Sub

	Public Sub DisplayMessageBox(ByVal message As String)
		XtraMessageBox.Show(message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Public Function IsInputValid() As Boolean
		' Validate input fields
		If String.IsNullOrEmpty(txtFirstname.Text) OrElse
		   txtMiddlename.Text Is Nothing Then	'OrElse
			'String.IsNullOrEmpty(cmbLevel.EditValue.ToString) OrElse
			'String.IsNullOrEmpty(cmbStatus.EditValue.ToString) Then
			Return False
		Else
			Return True
		End If
	End Function

	Private Sub btnAddStudent_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddStudent.ItemClick
		ctrlStudent.Add()
	End Sub

	Private Sub btnGenerate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenerate.ItemClick
		' Check if the input is valid
		If IsInputValid() Then
			' Open frmQRCodeViewer to display QR code
			Dim qrCodeViewerForm As New frmQRCodeViewer(txtSid.Text)
			qrCodeViewerForm.ShowDialog()
		Else
			DisplayWarningMessage("Please fill in all required fields.")
		End If
	End Sub

End Class