Public Class mdlUser
	Public u_id As Integer
	Public username As String
	Public password As String
	Public ulevel As String
	Public active As Boolean
	Public datecreated As Date
	Public isNew As Boolean

	Private dc As tmsdcDataContext
	Private _id As Integer

	'Private vFrmUser As frmUser

	Sub New(ByRef _dc As tmsdcDataContext)
		Me.dc = _dc
		'isNew = True
	End Sub

	Sub New(ByVal u_id_ As Integer, ByRef _dc As tmsdcDataContext)
		dc = _dc
		isNew = False

		Dim us = From i In dc.t_users
				 Where i.u_id = u_id_
				 Select i

		For Each u In us
			u_id = u.u_id
			username = u.username
			password = u.password
			ulevel = u.ulevel
			active = CBool(u.active)
		Next
	End Sub

	Sub New()

	End Sub

	Sub New(id As Integer)

		_id = id
	End Sub

	Sub add()
		Dim u As New t_user With {
			.username = username,
			.password = password,
			.ulevel = ulevel,
			.active = 1,
			.datecreated = DateTime.Now
		}
		dc.t_users.InsertOnSubmit(u)
		dc.SubmitChanges()
		u_id = u.u_id
	End Sub

	Sub update()
		Dim us = From i In dc.t_users
				 Where i.u_id = u_id
				 Select i

		For Each u In us
			u.username = username
			u.password = password
			u.ulevel = ulevel
			'u.active = If(u.active = 1, 0, 1)
		Next
		dc.SubmitChanges()
	End Sub

	Sub updateActiveStatus()
		Dim us = From i In dc.t_users
				 Where i.u_id = u_id
				 Select i

		For Each u In us
			u.active = If(u.active = 1, 0, 1)
		Next
		dc.SubmitChanges()
	End Sub


	Public Shared Function GetFilteredUsers(ByVal fromDate As Date, ByVal toDate As Date) As List(Of t_user)
		Dim dc As New tmsdcDataContext()

		Dim reqs = (From u In dc.t_users
					Where u.datecreated >= fromDate AndAlso
						  u.datecreated <= toDate
					Select u).ToList()

		Return reqs
	End Function
End Class
