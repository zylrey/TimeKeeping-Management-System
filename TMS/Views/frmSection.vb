Imports DevExpress.XtraEditors

Public Class frmSection
	Private ctrlSection As ctrlSection

	Sub New(ByRef ctSection As ctrlSection)
		InitializeComponent()
		ctrlSection = ctSection
	End Sub

	Public Sub DisplayWarningMessage(ByVal message As String)
		XtraMessageBox.Show(message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
	End Sub

	Public Sub DisplayMessageBox(ByVal message As String)
		XtraMessageBox.Show(message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Public Function IsInputValid() As Boolean
		' Validate input fields
		If String.IsNullOrEmpty(txtSname.Text) Then	'OrElse
			'String.IsNullOrEmpty(cmbLevel.EditValue.ToString) OrElse
			'String.IsNullOrEmpty(cmbStatus.EditValue.ToString) Then
			Return False
		Else
			Return True
		End If
	End Function

	Private Sub btnAddSection_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddSection.ItemClick
		ctrlSection.Add()
	End Sub
End Class