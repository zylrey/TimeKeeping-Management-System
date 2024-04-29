Imports DevExpress.XtraEditors

Public Class frmUser
	Private ctrlUser As ctrlUser

	Dim applyImage As Image = My.Resources.apply_32x32
	Dim cancelImage As Image = My.Resources.cancel_32x32

	Sub New(ByRef ctUser As ctrlUser)
		InitializeComponent()
		ctrlUser = ctUser

		cmbLevel.Properties.Items.AddRange({"SYSTEMADMIN", "SYSTEMSTAFF"})
	End Sub

	Private Sub RibbonForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Public Sub DisplayWarningMessage(ByVal message As String)
		XtraMessageBox.Show(message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
	End Sub

	Public Sub DisplayMessageBox(ByVal message As String)
		XtraMessageBox.Show(message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	Public Function IsInputValid() As Boolean
		' Validate input fields
		If String.IsNullOrEmpty(txtUsername.Text) OrElse
		   txtPassword.Text Is Nothing Then	'OrElse
			'String.IsNullOrEmpty(cmbLevel.EditValue.ToString) OrElse
			'String.IsNullOrEmpty(cmbStatus.EditValue.ToString) Then
			Return False
		Else
			Return True
		End If
	End Function

	Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
		ctrlUser.Add()
	End Sub

	Private Sub btnStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStatus.ItemClick
		If btnStatus.Caption = "Active" Then
			btnStatus.Caption = "Inactive"
			btnStatus.LargeGlyph = cancelImage
			DisplayMessageBox("Account Deactivate!")

			' Update the active status without changing other details
			ctrlUser.ToggleActiveStatus(False)
		Else
			btnStatus.Caption = "Active"
			btnStatus.LargeGlyph = applyImage
			DisplayMessageBox("Account Activate!")

			' Update the active status without changing other details
			ctrlUser.ToggleActiveStatus(True)
		End If
	End Sub
End Class