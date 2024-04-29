Public Class ctrlSection
	Private mSection As mdlSection
	Private vFrmSection As frmSection
	Private isNew As Boolean
	Private dc As tmsdcDataContext

	Sub New(ByVal dataContext As tmsdcDataContext)
		dc = dataContext
	End Sub

	Sub New()
		isNew = True

		' Instantiate user model and form
		dc = New tmsdcDataContext
		mSection = New mdlSection(dc)
		vFrmSection = New frmSection(Me)

		' Show the form
		vFrmSection.ShowDialog()
	End Sub

	Sub New(ByVal id As Integer)
		isNew = False

		' Instantiate user model and form with existing user data
		dc = New tmsdcDataContext
		mSection = New mdlSection(id, dc)
		vFrmSection = New frmSection(Me)

		' Set form fields with existing user data
		With vFrmSection
			.btnAddSection.Caption = "Update"

			' Set other form fields
			.txtSname.EditValue = mSection.sName
		End With

		' Show the form
		vFrmSection.ShowDialog()
	End Sub

	Sub Add()
		If dc IsNot Nothing Then
			With vFrmSection
				If Not .IsInputValid() Then
					.DisplayWarningMessage("Please fill in all required fields and add at least one item.")
					Exit Sub
				End If

				' Populate mUser properties from the form fields
				mSection.sName = .txtSname.Text

				mSection.datecreated = DateTime.Now

				If isNew Then
					mSection.add()
				Else
					mSection.update()
				End If

				' Close the form after successful save
				.DisplayMessageBox("Data has been saved.")
				.Close()
			End With
		Else
			vFrmSection.DisplayWarningMessage("Data context is not initialized.")
		End If
	End Sub
End Class
