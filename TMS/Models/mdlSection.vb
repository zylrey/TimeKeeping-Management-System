Public Class mdlSection
	Public sec_id As Integer
	Public sName As String
	Public datecreated As Date
	Public isNew As Boolean

	Private dc As tmsdcDataContext
	Private _id As Integer

	Sub New(ByRef _dc As tmsdcDataContext)
		Me.dc = _dc
		'isNew = True
	End Sub

	Sub New(ByVal sec_id_ As Integer, ByRef _dc As tmsdcDataContext)
		dc = _dc
		isNew = False

		Dim us = From i In dc.t_sections
				 Where i.sec_id = sec_id_
				 Select i

		For Each u In us
			sec_id_ = u.sec_id
			sName = u.name
		Next
	End Sub

	Sub New()

	End Sub

	Sub New(id As Integer)

		_id = id
	End Sub

	Sub add()
		Dim u As New t_section With {
			.sec_id = sec_id,
			.name = sName,
		.datecreated = DateTime.Now
		}
		dc.t_sections.InsertOnSubmit(u)
		dc.SubmitChanges()
		sec_id = u.sec_id
	End Sub

	Sub update()
		Dim us = From i In dc.t_sections
				 Where i.sec_id = sec_id
				 Select i

		For Each u In us
			u.name = sName
		Next
		dc.SubmitChanges()
	End Sub
	Public Shared Function GetFilteredUsers(ByVal fromDate As Date, ByVal toDate As Date) As List(Of t_section)
		Dim dc As New tmsdcDataContext()

		Dim reqs = (From u In dc.t_sections
					Where u.datecreated >= fromDate AndAlso
						  u.datecreated <= toDate
					Select u).ToList()

		Return reqs
	End Function

End Class
