Public Class ctrlCourse
	Private mCourse As mdlCourse
	Private vFrmCourse As frmCourse
	Private isNew As Boolean
	Private dc As tmsdcDataContext

	Sub New(ByVal dataContext As tmsdcDataContext)
		dc = dataContext
	End Sub

	Sub New()
		isNew = True

		' Instantiate user model and form
		dc = New tmsdcDataContext
		mCourse = New mdlCourse(dc)
		vFrmCourse = New frmCourse(Me)

		' Show the form
		vFrmCourse.ShowDialog()
	End Sub

	Sub New(ByVal id As Integer)
		isNew = False

		' Instantiate user model and form with existing user data
		dc = New tmsdcDataContext
		mCourse = New mdlCourse(id, dc)
		vFrmCourse = New frmCourse(Me)

		' Set form fields with existing user data
		With vFrmCourse
			.btnAddCourse.Caption = "Update"

			' Set other form fields
			.txtName.EditValue = mCourse.cName
		End With

		' Show the form
		vFrmCourse.ShowDialog()
	End Sub

	Sub Add()
		If dc IsNot Nothing Then
			With vFrmCourse
				If Not .IsInputValid() Then
					.DisplayWarningMessage("Please fill in all required fields and add at least one item.")
					Exit Sub
				End If

				' Populate mUser properties from the form fields
				mCourse.cName = .txtName.Text

				mCourse.datecreated = DateTime.Now

				If isNew Then
					mCourse.add()
				Else
					mCourse.update()
				End If

				' Close the form after successful save
				.DisplayMessageBox("Data has been saved.")
				.Close()
			End With
		Else
			vFrmCourse.DisplayWarningMessage("Data context is not initialized.")
		End If
	End Sub

End Class
