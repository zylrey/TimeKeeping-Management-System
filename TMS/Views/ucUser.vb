Public Class ucUser
	Inherits ucBase

	Sub New(ByVal t As String)
		InitializeComponent()
		MyBase.title = t
		MyBase.indexField = "u_id" 'Depends on your table primary key
		LabelControl1.Text = t
		btnNew.Text = "Add New User"

		refreshdata()
	End Sub

	Private Sub InitializeComponents()
		Me.SuspendLayout()
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.Name = "ucUser"
		Me.ResumeLayout(False)
	End Sub

	Public Overrides Sub newRecord()
		Dim newUser As New ctrlUser
		refreshdata()
	End Sub

	Public Overrides Sub loadRecord(id As Integer)
		Dim user As New ctrlUser(id)
		refreshdata()
	End Sub

	Public Overrides Sub refreshdata()
		GridView1.Columns.Clear()

		Dim fromDate As Date = CDate(dtFrom.EditValue)
		Dim toDate As Date = CDate(dtTo.EditValue)

		Dim reqs = mdlUser.GetFilteredUsers(fromDate, toDate)

		' Assign filtered data to the GridControl
		GridControl1.DataSource = reqs

		If GridView1.Columns.Count > 0 AndAlso GridView1.Columns("datecreated") IsNot Nothing AndAlso GridView1.RowCount > 0 Then
			GridView1.OptionsView.ShowFooter = True
			GridView1.Columns("datecreated").Summary.Clear()
			GridView1.Columns("datecreated").Summary.Add(DevExpress.Data.SummaryItemType.Count, "Count", "Total User(s): {0}")
			GridView1.Columns("u_id").Visible = False
			GridView1.RefreshData()
		End If

		' Refresh the GridControl to reflect changes
		GridView1.RefreshData()
	End Sub

	Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
		If e.Column.FieldName = "active" Then ' Replace "your_column_name_here" with the actual column name
			If e.Value IsNot Nothing AndAlso e.Value.ToString() = "1" Then
				e.DisplayText = "Active"
			ElseIf e.Value IsNot Nothing AndAlso e.Value.ToString() = "0" Then
				e.DisplayText = "Inactive"
			End If
		End If
	End Sub

End Class
