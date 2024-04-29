Public Class mdlCourse
	Public c_id As Integer
	Public cName As String
	Public datecreated As Date
	Public isNew As Boolean

	Private dc As tmsdcDataContext
	Private _id As Integer

	Sub New(ByRef _dc As tmsdcDataContext)
		Me.dc = _dc
		'isNew = True
	End Sub

	Sub New(ByVal c_id_ As Integer, ByRef _dc As tmsdcDataContext)
		dc = _dc
		isNew = False

		Dim us = From i In dc.t_courses
				 Where i.c_id = c_id_
				 Select i

		For Each u In us
			c_id = u.c_id
			cName = u.name
		Next
	End Sub

	Sub New()

	End Sub

	Sub New(id As Integer)

		_id = id
	End Sub

	Sub add()
		Dim u As New t_course With {
			.c_id = c_id,
			.name = cName,
		.datecreated = DateTime.Now
		}
		dc.t_courses.InsertOnSubmit(u)
		dc.SubmitChanges()
		c_id = u.c_id
	End Sub

	Sub update()
		Dim us = From i In dc.t_courses
				 Where i.c_id = c_id
				 Select i

		For Each u In us
			u.name = cName
		Next
		dc.SubmitChanges()
	End Sub
	Public Shared Function GetFilteredUsers(ByVal fromDate As Date, ByVal toDate As Date) As List(Of t_course)
		Dim dc As New tmsdcDataContext()

		Dim reqs = (From u In dc.t_courses
					Where u.datecreated >= fromDate AndAlso
						  u.datecreated <= toDate
					Select u).ToList()

		Return reqs
	End Function

End Class
