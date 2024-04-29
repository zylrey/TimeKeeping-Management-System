Partial Class tmsdcDataContext
	Public Function GetDate() As Date
		Return ExecuteQuery(Of Date)("SELECT GETDATE()").First
	End Function
End Class

