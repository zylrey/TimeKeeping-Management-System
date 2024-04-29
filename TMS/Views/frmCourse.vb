Imports DevExpress.XtraEditors

Public Class frmCourse
	Private ctrlCourse As ctrlCourse
	
	Sub New(ByRef ctCourse As ctrlCourse)
		InitializeComponent()
		ctrlCourse = ctCourse
	End Sub

	Public Sub DisplayWarningMessage(ByVal message As String)
		XtraMessageBox.Show(message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
	End Sub

	Public Sub DisplayMessageBox(ByVal message As String)
		XtraMessageBox.Show(message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Public Function IsInputValid() As Boolean
		' Validate input fields
		If String.IsNullOrEmpty(txtName.Text) Then	'OrElse
			'String.IsNullOrEmpty(cmbLevel.EditValue.ToString) OrElse
			'String.IsNullOrEmpty(cmbStatus.EditValue.ToString) Then
			Return False
		Else
			Return True
		End If
	End Function

	Private Sub btnAddCourse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddCourse.ItemClick
		ctrlCourse.Add()
	End Sub
End Class