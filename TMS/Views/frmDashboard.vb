Imports DevExpress.XtraEditors

Public Class frmDashboard
	Public ucList As New List(Of UserControl)

	Private result As DialogResult
	Private vFrmLogin As frmLogin

	Dim applyImage As Image = My.Resources.apply_32x32
	Shared Sub New()
		'DevExpress.UserSkins.BonusSkins.Register()
		'DevExpress.Skins.SkinManager.EnableFormSkins()
	End Sub
	Public Sub New()
		InitializeComponent()

		'dInit()
	End Sub

	Public Property Username As String
		Get
			Return statusBarUser.Caption
		End Get
		Set(value As String)
			statusBarUser.Caption = value
		End Set
	End Property

	Public Property Ulevel As String
		Get
			Return statusBarUser.Caption
		End Get
		Set(value As String)
			' Concatenate the Username and Ulevel
			statusBarUser.Caption = "Login As: " & Username & " | Level: " & value
			'statusBarUser.Caption = "Login As: " & Username
			statusBarUser.Appearance.Font = New Font(statusBarUser.Appearance.Font, FontStyle.Bold)
		End Set
	End Property

	Private Sub addTab(ByVal uc As UserControl, ByVal title As String)
		ucList.Add(uc)
		xtratabMain.TabPages.Add(title)
		uc.Parent = xtratabMain.TabPages(xtratabMain.TabPages.Count - 1)
		uc.Dock = DockStyle.Fill
		xtratabMain.TabPages(ucList.IndexOf(uc)).Show()
	End Sub

	Private Function inTabs(ByVal type As String) As Integer
		If ucList.Count = 0 Then
			Return -1
		End If

		Dim thisTab = ucList.Where(Function(x) x.GetType().ToString = "GLH." + type)
		If thisTab.Count = 0 Then
			Return -1
		End If

		Return ucList.IndexOf(thisTab.First)
	End Function

	Private Sub xtratabMain_CloseButtonClick(sender As Object, e As EventArgs) Handles xtratabMain.CloseButtonClick
		ucList.RemoveAt(xtratabMain.SelectedTabPageIndex)
		xtratabMain.TabPages.RemoveAt(xtratabMain.SelectedTabPageIndex)
	End Sub

	Private Sub frmDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		' Display warning message when the form is closing
		result = DisplayWarningMessage("Are you sure to logout?")

		' If the user clicks No in the warning message box, cancel the form closing
		If result = DialogResult.No Then
			e.Cancel = True
		Else
			Dim ctrlLoginInstance As New ctrlLogin()
			Dim vFrmLogin As New frmLogin(ctrlLoginInstance)
			vFrmLogin.Show()

			Me.Hide()
		End If
	End Sub

	Private Function DisplayWarningMessage(message As String) As DialogResult
		Return XtraMessageBox.Show(message, Username, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
	End Function

	Private Sub LoadDashboard()
		Dim title = "ucDashboard"
		Dim intab = inTabs("ucDashboard")
		If intab = -1 Then
			Dim uc As New ucDashboard(title)
			addTab(uc, title)
		Else
			xtratabMain.TabPages(intab).Show()
		End If
	End Sub

	Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDashboard.ItemClick
		Dim title = "ucDashboard"
		Dim intab = inTabs("ucDashboard")
		If intab = -1 Then
			Dim uc As New ucDashboard(title)
			addTab(uc, title)
		Else
			xtratabMain.TabPages(intab).Show()
		End If
	End Sub

	Private Sub btnUser_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser.ItemClick
		Dim title = "User settings"
		Dim intab = inTabs("ucUser")
		If intab = -1 Then
			Dim uc As New ucUser(title)
			addTab(uc, title)
		Else
			xtratabMain.TabPages(intab).Show()
		End If
	End Sub

	Private Sub btnStudents_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStudents.ItemClick
		Dim title = "Students"
		Dim intab = inTabs("ucStudents")
		If intab = -1 Then
			Dim uc As New ucStudents(title)
			addTab(uc, title)
		Else
			xtratabMain.TabPages(intab).Show()
		End If
	End Sub

	Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadDashboard()
	End Sub

	Private Sub btnSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick
		' Access the currently selected UserControl within xtratabMain
		Dim uc As ucBase = CType(xtratabMain.SelectedTabPage.Controls(0), ucBase)

		' Set focus on the GridView within the selected UserControl
		uc.GridView1.Focus()

		' Wait for a short moment to ensure the GridView has focus
		Threading.Thread.Sleep(100)

		' Send Ctrl+F keys to perform a search within the GridView
		SendKeys.Send("^f")	' ^ represents Ctrl key
	End Sub

	Private Sub btnCourse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCourse.ItemClick
		Dim title = "Course"
		Dim intab = inTabs("ucCourse")
		If intab = -1 Then
			Dim uc As New ucCourse(title)
			addTab(uc, title)
		Else
			xtratabMain.TabPages(intab).Show()
		End If
	End Sub

	Private Sub btnSection_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSection.ItemClick
		Dim title = "Section"
		Dim intab = inTabs("ucSection")
		If intab = -1 Then
			Dim uc As New ucSection(title)
			addTab(uc, title)
		Else
			xtratabMain.TabPages(intab).Show()
		End If
	End Sub
End Class