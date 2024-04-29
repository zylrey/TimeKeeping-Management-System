Public Class mdlScan
	Public Property s_uid As Integer
	Public Property attenddate As Date
	Public Property intime As Nullable(Of TimeSpan)
	Public Property instatus As String
	Public Property outtime As Nullable(Of TimeSpan)
	Public Property outstatus As String
	Public Property fullname As String

	Public Function GetNameByUID(ByVal s_uid As Integer) As String
		Dim dc As New tmsdcDataContext()

		Dim fullName As String = (From c In dc.t_students
								   Where c.s_uid = s_uid
								   Select c.firstname & " " & c.middlename & " " & c.lastname).FirstOrDefault()

		Return If(fullName IsNot Nothing, fullName.Trim(), "")
	End Function

	Public Function SaveAttendance(ByVal s_uid As Integer, ByVal fullName As String) As Boolean
		Try
			Dim dc As New tmsdcDataContext()

			' Get existing record for the user for the current date
			Dim existingRecord = (From s In dc.t_scans
								  Where s.s_uid = s_uid And s.attenddate = DateTime.Now.Date
								  Select s).FirstOrDefault()

			If existingRecord IsNot Nothing Then
				' Check if the user has already checked out
				If existingRecord.outtime IsNot Nothing Then
					MessageBox.Show("You have already checked out for today!")
					Return False
				Else
					' Update the existing record with check-out details
					existingRecord.outtime = DateTime.Now.TimeOfDay
					existingRecord.outstatus = "Verified"

					' Calculate and update totalHours
					existingRecord.totalHours = TimeSpan.FromHours(existingRecord.outtime.Value.TotalHours - existingRecord.intime.Value.TotalHours)
				End If
			Else
				' Create a new attendance record with check-in details
				Dim newAttendance As New t_scan With {
					.s_uid = s_uid,
					.attenddate = DateTime.Now.Date,
					.fullname = fullName,
					.intime = DateTime.Now.TimeOfDay,
					.instatus = "Verified"
				}

				dc.t_scans.InsertOnSubmit(newAttendance)
			End If

			dc.SubmitChanges()
			Return True

		Catch ex As Exception
			MessageBox.Show("Error saving attendance: " & ex.Message)
			Return False
		End Try
	End Function


End Class
