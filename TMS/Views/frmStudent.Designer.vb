<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudent))
		Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
		Me.btnAddStudent = New DevExpress.XtraBars.BarButtonItem()
		Me.btnGenerate = New DevExpress.XtraBars.BarButtonItem()
		Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
		Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
		Me.cmbSection = New DevExpress.XtraEditors.LookUpEdit()
		Me.cmbCourse = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtLastname = New DevExpress.XtraEditors.TextEdit()
		Me.txtMiddlename = New DevExpress.XtraEditors.TextEdit()
		Me.txtFirstname = New DevExpress.XtraEditors.TextEdit()
		Me.txtSid = New DevExpress.XtraEditors.TextEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.cmbSection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmbCourse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtLastname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMiddlename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFirstname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RibbonControl
		'
		Me.RibbonControl.ExpandCollapseItem.Id = 0
		Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnAddStudent, Me.btnGenerate})
		Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
		Me.RibbonControl.MaxItemId = 3
		Me.RibbonControl.Name = "RibbonControl"
		Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
		Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
		Me.RibbonControl.Size = New System.Drawing.Size(378, 147)
		Me.RibbonControl.StatusBar = Me.RibbonStatusBar
		'
		'btnAddStudent
		'
		Me.btnAddStudent.Caption = "ADD"
		Me.btnAddStudent.Glyph = CType(resources.GetObject("btnAddStudent.Glyph"), System.Drawing.Image)
		Me.btnAddStudent.Id = 1
		Me.btnAddStudent.LargeGlyph = CType(resources.GetObject("btnAddStudent.LargeGlyph"), System.Drawing.Image)
		Me.btnAddStudent.Name = "btnAddStudent"
		'
		'btnGenerate
		'
		Me.btnGenerate.Caption = "Generate QR"
		Me.btnGenerate.Glyph = Global.TMS.My.Resources.Resources.selectall2_16x16
		Me.btnGenerate.Id = 2
		Me.btnGenerate.LargeGlyph = Global.TMS.My.Resources.Resources.selectall2_32x32
		Me.btnGenerate.Name = "btnGenerate"
		'
		'RibbonPage1
		'
		Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
		Me.RibbonPage1.Name = "RibbonPage1"
		Me.RibbonPage1.Text = "Add student"
		'
		'RibbonPageGroup1
		'
		Me.RibbonPageGroup1.AllowTextClipping = False
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddStudent)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGenerate)
		Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
		Me.RibbonPageGroup1.ShowCaptionButton = False
		'
		'RibbonStatusBar
		'
		Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 318)
		Me.RibbonStatusBar.Name = "RibbonStatusBar"
		Me.RibbonStatusBar.Ribbon = Me.RibbonControl
		Me.RibbonStatusBar.Size = New System.Drawing.Size(378, 23)
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.cmbSection)
		Me.LayoutControl1.Controls.Add(Me.cmbCourse)
		Me.LayoutControl1.Controls.Add(Me.txtLastname)
		Me.LayoutControl1.Controls.Add(Me.txtMiddlename)
		Me.LayoutControl1.Controls.Add(Me.txtFirstname)
		Me.LayoutControl1.Controls.Add(Me.txtSid)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.Location = New System.Drawing.Point(0, 147)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(378, 171)
		Me.LayoutControl1.TabIndex = 2
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'cmbSection
		'
		Me.cmbSection.Location = New System.Drawing.Point(75, 132)
		Me.cmbSection.MenuManager = Me.RibbonControl
		Me.cmbSection.Name = "cmbSection"
		Me.cmbSection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.cmbSection.Size = New System.Drawing.Size(291, 20)
		Me.cmbSection.StyleController = Me.LayoutControl1
		Me.cmbSection.TabIndex = 11
		'
		'cmbCourse
		'
		Me.cmbCourse.Location = New System.Drawing.Point(75, 108)
		Me.cmbCourse.MenuManager = Me.RibbonControl
		Me.cmbCourse.Name = "cmbCourse"
		Me.cmbCourse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.cmbCourse.Size = New System.Drawing.Size(291, 20)
		Me.cmbCourse.StyleController = Me.LayoutControl1
		Me.cmbCourse.TabIndex = 10
		'
		'txtLastname
		'
		Me.txtLastname.Location = New System.Drawing.Point(75, 84)
		Me.txtLastname.MenuManager = Me.RibbonControl
		Me.txtLastname.Name = "txtLastname"
		Me.txtLastname.Size = New System.Drawing.Size(291, 20)
		Me.txtLastname.StyleController = Me.LayoutControl1
		Me.txtLastname.TabIndex = 7
		'
		'txtMiddlename
		'
		Me.txtMiddlename.Location = New System.Drawing.Point(75, 60)
		Me.txtMiddlename.MenuManager = Me.RibbonControl
		Me.txtMiddlename.Name = "txtMiddlename"
		Me.txtMiddlename.Size = New System.Drawing.Size(291, 20)
		Me.txtMiddlename.StyleController = Me.LayoutControl1
		Me.txtMiddlename.TabIndex = 6
		'
		'txtFirstname
		'
		Me.txtFirstname.Location = New System.Drawing.Point(75, 36)
		Me.txtFirstname.MenuManager = Me.RibbonControl
		Me.txtFirstname.Name = "txtFirstname"
		Me.txtFirstname.Size = New System.Drawing.Size(291, 20)
		Me.txtFirstname.StyleController = Me.LayoutControl1
		Me.txtFirstname.TabIndex = 5
		'
		'txtSid
		'
		Me.txtSid.Location = New System.Drawing.Point(75, 12)
		Me.txtSid.MenuManager = Me.RibbonControl
		Me.txtSid.Name = "txtSid"
		Me.txtSid.Size = New System.Drawing.Size(291, 20)
		Me.txtSid.StyleController = Me.LayoutControl1
		Me.txtSid.TabIndex = 4
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem8})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(378, 171)
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtFirstname
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(358, 24)
		Me.LayoutControlItem2.Text = "Firstname:"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(60, 13)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtMiddlename
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(358, 24)
		Me.LayoutControlItem3.Text = "Middlename:"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(60, 13)
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtSid
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(358, 24)
		Me.LayoutControlItem1.Text = "Student ID:"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(60, 13)
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtLastname
		Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(358, 24)
		Me.LayoutControlItem4.Text = "Lastname:"
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(60, 13)
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.cmbCourse
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 96)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(358, 24)
		Me.LayoutControlItem7.Text = "Course:"
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(60, 13)
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.cmbSection
		Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 120)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(358, 31)
		Me.LayoutControlItem8.Text = "Section:"
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(60, 13)
		'
		'frmStudent
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(378, 341)
		Me.Controls.Add(Me.LayoutControl1)
		Me.Controls.Add(Me.RibbonStatusBar)
		Me.Controls.Add(Me.RibbonControl)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmStudent"
		Me.Ribbon = Me.RibbonControl
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.StatusBar = Me.RibbonStatusBar
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.cmbSection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmbCourse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtLastname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMiddlename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFirstname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
	Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
	Friend WithEvents btnAddStudent As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents txtLastname As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtMiddlename As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtFirstname As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtSid As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents btnGenerate As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents cmbSection As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents cmbCourse As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem


End Class
