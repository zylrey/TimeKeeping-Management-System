Public Class ctrlUser
	Private mUser As mdlUser
	Private vFrmUser As frmUser
	Private vFrmDisp As frmDisplayMessage
	Private isNew As Boolean
	Private dc As tmsdcDataContext

	Dim cancelImage As Image = My.Resources.cancel_32x32
	Dim applyImage As Image = My.Resources.apply_32x32

	' Constructor to initialize the data context
	Sub New(ByVal dataContext As tmsdcDataContext)
		dc = dataContext
	End Sub

	Sub New()
		isNew = True

		' Instantiate user model and form
		dc = New tmsdcDataContext
		mUser = New mdlUser(dc)
		vFrmUser = New frmUser(Me)

		vFrmUser.btnStatus.Caption = "Activate"
		vFrmUser.btnStatus.LargeGlyph = applyImage
		vFrmUser.btnStatus.Enabled = False
		vFrmUser.btnStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
		'vFrmUser.RibbonPage1.Visible = False

		' Show the form
		vFrmUser.ShowDialog()
	End Sub

	Sub New(ByVal id As Integer)
		isNew = False

		' Instantiate user model and form with existing user data
		dc = New tmsdcDataContext
		mUser = New mdlUser(id, dc)
		vFrmUser = New frmUser(Me)

		' Set form fields with existing user data
		With vFrmUser
			.btnAdd.Caption = "Update"

			' Check the value of the active column and set btnValidation caption accordingly
			If mUser.active = True Then
				.btnStatus.Caption = "Inactive"
				.btnStatus.LargeGlyph = cancelImage
			Else
				.btnStatus.Caption = "Active"
				.btnStatus.LargeGlyph = applyImage
			End If

			' Set other form fields
			.txtUsername.EditValue = mUser.username
			.txtPassword.EditValue = mUser.password
			.cmbLevel.EditValue = mUser.ulevel
			'.btnValidation.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
			'.RibbonPage1.Visible = True
		End With

		' Show the form
		vFrmUser.ShowDialog()
	End Sub

	Sub Add()
		If dc IsNot Nothing Then
			With vFrmUser
				If Not .IsInputValid() Then
					.DisplayWarningMessage("Please fill in all required fields and add at least one item.")
					Exit Sub
				End If

				' Populate mUser properties from the form fields
				mUser.username = .txtUsername.Text
				mUser.password = .txtPassword.Text
				mUser.ulevel = .cmbLevel.Text

				' Convert status from string to Boolean
				mUser.active = True

				mUser.datecreated = DateTime.Now

				If isNew Then
					mUser.add()
				Else
					mUser.update()
				End If

				' Close the form after successful save
				.DisplayMessageBox("Data has been saved.")
				.Close()
			End With
		Else
			vFrmUser.DisplayWarningMessage("Data context is not initialized.")
		End If
	End Sub

	Sub ToggleActiveStatus(isActive As Boolean)
		If dc IsNot Nothing Then
			With vFrmUser
				mUser.username = .txtUsername.Text
				mUser.password = .txtPassword.Text
				mUser.ulevel = .cmbLevel.Text
				mUser.active = isActive

				If isNew Then
					mUser.add()
				Else
					mUser.updateActiveStatus()
				End If

				.Close()
			End With
		Else
			vFrmUser.DisplayWarningMessage("Data context is not initialized.")
		End If
	End Sub
End Class
