Public Class ucBase
	Public title As String
	Public indexField As String

	Sub New()

		' This call is required by the designer.
		InitializeComponent()
		GridView1.OptionsBehavior.Editable = False

		' Add any initialization after the InitializeComponent() call.
		Dim dateNow = New tmsdcDataContext().GetDate
		dtFrom.EditValue = dateNow.AddDays(-30)
		dtTo.EditValue = dateNow

	End Sub
	Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles dtFrom.EditValueChanged

	End Sub

	Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
		newRecord()
	End Sub

	Overridable Sub refreshData()

	End Sub
	Overridable Sub newRecord()

	End Sub
	Overridable Sub loadRecord(ByVal id As Integer)

	End Sub

	Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
		refreshData()
	End Sub

	Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
		If GridView1.SelectedRowsCount > 0 Then
			Dim retVal As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, indexField))
			loadRecord(retVal)
		End If

	End Sub

	Private Sub gridView1_CustomDrawEmptyForeground(sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs) Handles GridView1.CustomDrawEmptyForeground
		Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
		If view.RowCount <> 0 Then
			Return
		End If
		Dim drawFormat As New StringFormat()
		drawFormat.LineAlignment = StringAlignment.Center
		drawFormat.Alignment = drawFormat.LineAlignment
		e.Graphics.DrawString("No records found", e.Appearance.Font, SystemBrushes.ControlDark, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat)
	End Sub
End Class
