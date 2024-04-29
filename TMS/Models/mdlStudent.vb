Public Class mdlStudent
	Public s_id As Integer
	Public s_uid As Integer
	Public firstname As String
	Public middlename As String
	Public lastname As String
	Public course As String
	Public section As String
	Public datecreated As Date
	Public isNew As Boolean

	Private dc As tmsdcDataContext
	Private _id As Integer

	Sub New(ByRef _dc As tmsdcDataContext)
		Me.dc = _dc
		'isNew = True
	End Sub

	Sub New(ByVal s_id_ As Integer, ByRef _dc As tmsdcDataContext)
		dc = _dc
		isNew = False

		Dim us = From i In dc.t_students
				 Where i.s_id = s_id_
				 Select i

		For Each u In us
			s_id = u.s_id
			s_uid = u.s_uid
			firstname = u.firstname
			middlename = u.middlename
			lastname = u.lastname
			course = u.course
			section = u.section
		Next
	End Sub

	Sub New()

	End Sub

	Sub New(id As Integer)

		_id = id
	End Sub

	Sub add()
		Dim u As New t_student With {
			.s_uid = s_uid,
			.firstname = firstname,
			.middlename = middlename,
			.lastname = lastname,
			.course = course,
			.section = section,
		.datecreated = DateTime.Now
		}
		dc.t_students.InsertOnSubmit(u)
		dc.SubmitChanges()
		s_id = u.s_id
	End Sub

	Sub update()
		Dim us = From i In dc.t_students
				 Where i.s_id = s_id
				 Select i

		For Each u In us
			u.s_uid = s_uid
			u.firstname = firstname
			u.middlename = middlename
			u.lastname = lastname
			u.course = course
			u.section = section
		Next
		dc.SubmitChanges()
	End Sub

	Sub delete()
		Dim u = (From i In dc.t_students
				 Where i.s_id = s_id
				 Select i).FirstOrDefault()

		If u IsNot Nothing Then
			dc.t_students.DeleteOnSubmit(u)
			dc.SubmitChanges()
		End If
	End Sub


	Public Shared Function GetFilteredUsers(ByVal fromDate As Date, ByVal toDate As Date) As List(Of t_student)
		Dim dc As New tmsdcDataContext()

		Dim reqs = (From u In dc.t_students
					Where u.datecreated >= fromDate AndAlso
						  u.datecreated <= toDate
					Select u).ToList()

		Return reqs
	End Function
End Class
