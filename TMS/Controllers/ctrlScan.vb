Public Class ctrlScan
    Private mScan As mdlScan

    Public Sub New()
        mScan = New mdlScan()
    End Sub

    Public Function CreateDTR(ByVal s_uid As Integer) As String
        ' Assuming you have a method in mdlCourse to retrieve name by s_uid
        Return mScan.GetNameByUID(s_uid)
	End Function

	Public Function SaveAttendance(ByVal s_uid As Integer, ByVal fullName As String) As Boolean
		Return mScan.SaveAttendance(s_uid, fullName)
	End Function

End Class
