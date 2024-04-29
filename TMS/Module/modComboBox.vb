Module modComboBox
	Private dc As New tmsdcDataContext

	Public Sub clearCombo(ByRef cmb As DevExpress.XtraEditors.LookUpEdit)
		cmb.EditValue = Nothing
		cmb.Properties.Columns.Clear()
	End Sub

	Public Sub setcbproperties(ByRef cmb As DevExpress.XtraEditors.LookUpEdit, ByVal ds As System.Linq.IQueryable, _
								  Optional ByVal desc As String = "desc", Optional ByVal id As String = "id", Optional ByVal caption As String = "Record")
		clearCombo(cmb)
		If cmb.Properties.Columns.Count = 0 Then
			cmb.Properties.DataSource = ds
			cmb.Properties.DisplayMember = desc
			cmb.Properties.ValueMember = id
			cmb.Properties.CharacterCasing = CharacterCasing.Normal
			Dim Col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo(desc, caption, 100)
			Col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
			cmb.Properties.Columns.Add(Col)
		End If
	End Sub

	Public Sub loadCourse(ByRef c As DevExpress.XtraEditors.LookUpEdit)

		Dim rs = (From i In dc.t_courses Select i.c_id, i.name)
		setcbproperties(c, rs, "name", "c_id", "Course")

	End Sub

	Public Sub loadSection(ByRef c As DevExpress.XtraEditors.LookUpEdit)

		Dim rs = (From i In dc.t_sections Select i.sec_id, i.name)
		setcbproperties(c, rs, "name", "sec_id", "Section")

	End Sub

End Module
