﻿Public Class ucSection
	Inherits ucBase

	Sub New(ByVal t As String)
		InitializeComponent()
		MyBase.title = t
		MyBase.indexField = "sec_id" 'Depends on your table primary key
		LabelControl1.Text = t
		btnNew.Text = "Add New Section"

		refreshdata()
	End Sub

	Private Sub InitializeComponents()
		Me.SuspendLayout()
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.Name = "ucSection"
		Me.ResumeLayout(False)
	End Sub

	Public Overrides Sub newRecord()
		Dim newSection As New ctrlSection
		refreshdata()
	End Sub

	Public Overrides Sub loadRecord(id As Integer)
		Dim section As New ctrlSection(id)
		refreshdata()
	End Sub

	Public Overrides Sub refreshdata()
		GridView1.Columns.Clear()

		Dim fromDate As Date = CDate(dtFrom.EditValue)
		Dim toDate As Date = CDate(dtTo.EditValue)

		Dim reqs = mdlSection.GetFilteredUsers(fromDate, toDate)

		' Assign filtered data to the GridControl
		GridControl1.DataSource = reqs

		If GridView1.Columns.Count > 0 AndAlso GridView1.Columns("datecreated") IsNot Nothing AndAlso GridView1.RowCount > 0 Then
			GridView1.OptionsView.ShowFooter = True
			GridView1.Columns("datecreated").Summary.Clear()
			GridView1.Columns("datecreated").Summary.Add(DevExpress.Data.SummaryItemType.Count, "Count", "Total Students(s): {0}")
			GridView1.Columns("sec_id").Visible = False
			GridView1.RefreshData()
		End If

		' Refresh the GridControl to reflect changes
		GridView1.RefreshData()
	End Sub

End Class
