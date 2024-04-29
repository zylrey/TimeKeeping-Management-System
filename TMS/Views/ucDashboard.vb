Public Class ucDashboard
	Inherits ucBase

	Sub New(ByVal t As String)
		InitializeComponent()
		MyBase.title = t
		MyBase.indexField = "u_id" 'Depends on your table primary key
		LabelControl1.Text = t
		btnNew.Text = "Add New User"
	End Sub

	Private Sub InitializeComponents()
		Me.SuspendLayout()
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.Name = "ucDashboard"
		Me.ResumeLayout(False)
	End Sub

End Class
