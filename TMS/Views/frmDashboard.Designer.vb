<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
		Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
		Me.btnDashboard = New DevExpress.XtraBars.BarButtonItem()
		Me.btnUser = New DevExpress.XtraBars.BarButtonItem()
		Me.statusBarUser = New DevExpress.XtraBars.BarStaticItem()
		Me.btnStudents = New DevExpress.XtraBars.BarButtonItem()
		Me.btnReports = New DevExpress.XtraBars.BarButtonItem()
		Me.btnCourse = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSection = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSearch = New DevExpress.XtraBars.BarButtonItem()
		Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
		Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
		Me.xtratabMain = New DevExpress.XtraTab.XtraTabControl()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.xtratabMain, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RibbonControl
		'
		Me.RibbonControl.ExpandCollapseItem.Id = 0
		Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnDashboard, Me.btnUser, Me.statusBarUser, Me.btnStudents, Me.btnReports, Me.btnCourse, Me.btnSection, Me.btnSearch})
		Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
		Me.RibbonControl.MaxItemId = 6
		Me.RibbonControl.Name = "RibbonControl"
		Me.RibbonControl.PageHeaderItemLinks.Add(Me.statusBarUser)
		Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
		Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
		Me.RibbonControl.Size = New System.Drawing.Size(763, 147)
		Me.RibbonControl.StatusBar = Me.RibbonStatusBar
		'
		'btnDashboard
		'
		Me.btnDashboard.Caption = "Dashboard"
		Me.btnDashboard.Glyph = CType(resources.GetObject("btnDashboard.Glyph"), System.Drawing.Image)
		Me.btnDashboard.Id = 1
		Me.btnDashboard.LargeGlyph = CType(resources.GetObject("btnDashboard.LargeGlyph"), System.Drawing.Image)
		Me.btnDashboard.Name = "btnDashboard"
		'
		'btnUser
		'
		Me.btnUser.Caption = "User settings"
		Me.btnUser.Glyph = CType(resources.GetObject("btnUser.Glyph"), System.Drawing.Image)
		Me.btnUser.Id = 2
		Me.btnUser.LargeGlyph = CType(resources.GetObject("btnUser.LargeGlyph"), System.Drawing.Image)
		Me.btnUser.Name = "btnUser"
		'
		'statusBarUser
		'
		Me.statusBarUser.Caption = "BarStaticItem1"
		Me.statusBarUser.Id = 3
		Me.statusBarUser.Name = "statusBarUser"
		Me.statusBarUser.TextAlignment = System.Drawing.StringAlignment.Near
		'
		'btnStudents
		'
		Me.btnStudents.Caption = "Students"
		Me.btnStudents.Glyph = CType(resources.GetObject("btnStudents.Glyph"), System.Drawing.Image)
		Me.btnStudents.Id = 1
		Me.btnStudents.LargeGlyph = CType(resources.GetObject("btnStudents.LargeGlyph"), System.Drawing.Image)
		Me.btnStudents.Name = "btnStudents"
		'
		'btnReports
		'
		Me.btnReports.Caption = "Reports"
		Me.btnReports.Glyph = CType(resources.GetObject("btnReports.Glyph"), System.Drawing.Image)
		Me.btnReports.Id = 2
		Me.btnReports.LargeGlyph = CType(resources.GetObject("btnReports.LargeGlyph"), System.Drawing.Image)
		Me.btnReports.Name = "btnReports"
		'
		'btnCourse
		'
		Me.btnCourse.Caption = "Course"
		Me.btnCourse.Glyph = CType(resources.GetObject("btnCourse.Glyph"), System.Drawing.Image)
		Me.btnCourse.Id = 3
		Me.btnCourse.LargeGlyph = CType(resources.GetObject("btnCourse.LargeGlyph"), System.Drawing.Image)
		Me.btnCourse.Name = "btnCourse"
		'
		'btnSection
		'
		Me.btnSection.Caption = "Section"
		Me.btnSection.Glyph = CType(resources.GetObject("btnSection.Glyph"), System.Drawing.Image)
		Me.btnSection.Id = 4
		Me.btnSection.LargeGlyph = CType(resources.GetObject("btnSection.LargeGlyph"), System.Drawing.Image)
		Me.btnSection.Name = "btnSection"
		'
		'btnSearch
		'
		Me.btnSearch.Caption = "Search"
		Me.btnSearch.Glyph = CType(resources.GetObject("btnSearch.Glyph"), System.Drawing.Image)
		Me.btnSearch.Id = 5
		Me.btnSearch.LargeGlyph = CType(resources.GetObject("btnSearch.LargeGlyph"), System.Drawing.Image)
		Me.btnSearch.Name = "btnSearch"
		'
		'RibbonPage1
		'
		Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
		Me.RibbonPage1.Name = "RibbonPage1"
		Me.RibbonPage1.Text = "TMS"
		'
		'RibbonPageGroup1
		'
		Me.RibbonPageGroup1.AllowTextClipping = False
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDashboard)
		Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
		Me.RibbonPageGroup1.ShowCaptionButton = False
		'
		'RibbonPageGroup2
		'
		Me.RibbonPageGroup2.AllowTextClipping = False
		Me.RibbonPageGroup2.ItemLinks.Add(Me.btnStudents)
		Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCourse)
		Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSection)
		Me.RibbonPageGroup2.ItemLinks.Add(Me.btnReports)
		Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
		Me.RibbonPageGroup2.ShowCaptionButton = False
		Me.RibbonPageGroup2.Text = "ADD/UPDATE/GENERATE"
		'
		'RibbonPageGroup3
		'
		Me.RibbonPageGroup3.AllowTextClipping = False
		Me.RibbonPageGroup3.ItemLinks.Add(Me.btnUser)
		Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
		Me.RibbonPageGroup3.ShowCaptionButton = False
		'
		'RibbonPageGroup4
		'
		Me.RibbonPageGroup4.AllowTextClipping = False
		Me.RibbonPageGroup4.ItemLinks.Add(Me.btnSearch)
		Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
		Me.RibbonPageGroup4.ShowCaptionButton = False
		'
		'RibbonStatusBar
		'
		Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 386)
		Me.RibbonStatusBar.Name = "RibbonStatusBar"
		Me.RibbonStatusBar.Ribbon = Me.RibbonControl
		Me.RibbonStatusBar.Size = New System.Drawing.Size(763, 23)
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.xtratabMain)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.Location = New System.Drawing.Point(0, 147)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(763, 239)
		Me.LayoutControl1.TabIndex = 2
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'xtratabMain
		'
		Me.xtratabMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
		Me.xtratabMain.Location = New System.Drawing.Point(12, 12)
		Me.xtratabMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.xtratabMain.Name = "xtratabMain"
		Me.xtratabMain.Size = New System.Drawing.Size(739, 215)
		Me.xtratabMain.TabIndex = 6
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(763, 239)
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.xtratabMain
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(743, 219)
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem1.TextVisible = False
		'
		'DefaultLookAndFeel1
		'
		Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray"
		'
		'frmDashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(763, 409)
		Me.Controls.Add(Me.LayoutControl1)
		Me.Controls.Add(Me.RibbonStatusBar)
		Me.Controls.Add(Me.RibbonControl)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmDashboard"
		Me.Ribbon = Me.RibbonControl
		Me.StatusBar = Me.RibbonStatusBar
		Me.Text = "TimeKeeping Management System"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.xtratabMain, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
	Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
	Friend WithEvents btnDashboard As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents xtratabMain As DevExpress.XtraTab.XtraTabControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents btnUser As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents statusBarUser As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	Friend WithEvents btnStudents As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnReports As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents btnCourse As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnSection As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents btnSearch As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup


End Class
