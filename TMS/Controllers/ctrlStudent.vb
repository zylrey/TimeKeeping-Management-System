Imports DevExpress.XtraEditors

Public Class ctrlStudent
    Private mStudent As mdlStudent
    Private vFrmStud As frmStudent
    Private isNew As Boolean
    Private dc As tmsdcDataContext

    Sub New(ByVal dataContext As tmsdcDataContext)
        dc = dataContext
    End Sub

    Sub New()
        isNew = True

        ' Instantiate user model and form
        dc = New tmsdcDataContext
        mStudent = New mdlStudent(dc)
        vFrmStud = New frmStudent(Me)

        vFrmStud.btnGenerate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        loadDataToCmbs()

        ' Show the form
        vFrmStud.ShowDialog()
    End Sub

    Sub New(ByVal id As Integer)
        isNew = False

        ' Instantiate user model and form with existing user data
        dc = New tmsdcDataContext
        mStudent = New mdlStudent(id, dc)
        vFrmStud = New frmStudent(Me)

        ' Set form fields with existing user data
        With vFrmStud
            .btnAddStudent.Caption = "Update"

            ' Set other form fields
            .txtSid.EditValue = mStudent.s_uid
            .txtFirstname.EditValue = mStudent.firstname
            .txtMiddlename.EditValue = mStudent.middlename
            .txtLastname.EditValue = mStudent.lastname
            .cmbCourse.EditValue = mStudent.course
            .cmbSection.EditValue = mStudent.section
        End With

        loadDataToCmbs()

        ' Show the form
        vFrmStud.ShowDialog()
    End Sub

    Sub Add()
        If dc IsNot Nothing Then
            With vFrmStud
                If Not .IsInputValid() Then
                    .DisplayWarningMessage("Please fill in all required fields and add at least one item.")
                    Exit Sub
                End If

                ' Populate mUser properties from the form fields
                mStudent.s_uid = .txtSid.Text
                mStudent.firstname = .txtFirstname.Text
                mStudent.middlename = .txtMiddlename.Text
                mStudent.lastname = .txtLastname.Text
                mStudent.course = .cmbCourse.Text
                mStudent.section = .cmbSection.Text

                mStudent.datecreated = DateTime.Now

                If isNew Then
                    mStudent.add()
                Else
                    mStudent.update()
                End If

                ' Close the form after successful save
                .DisplayMessageBox("Data has been saved.")
                .Close()
            End With
        Else
            vFrmStud.DisplayWarningMessage("Data context is not initialized.")
        End If
    End Sub

    Sub delete()
        ' Check if the student exists
        If mStudent.s_uid = 0 Then
            XtraMessageBox.Show("No student selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            mStudent.delete()

            ' Save changes to the database
            dc.SubmitChanges()

            ' Inform the user
            vFrmStud.DisplayMessageBox("Student has been deleted.")

            ' Optionally close the form or perform other actions
            ' For now, we won't close the form, but you can uncomment the line below if needed
            vFrmStud.Close()
        End If
    End Sub

    Sub loadDataToCmbs()
        With vFrmStud
            loadCourse(.cmbCourse)
            loadSection(.cmbSection)
        End With
    End Sub

End Class
