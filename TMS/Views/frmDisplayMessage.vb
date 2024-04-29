Imports DevExpress.XtraEditors

Public Class frmDisplayMessage

	Public Sub DisplayWarningMessage(ByVal message As String)
		XtraMessageBox.Show(message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
	End Sub

	Public Sub DisplayMessageBox(ByVal message As String)
		XtraMessageBox.Show(message, "GLH Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

End Class