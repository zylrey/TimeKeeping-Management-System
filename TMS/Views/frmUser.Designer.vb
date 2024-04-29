<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
		Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
		Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
		Me.btnStatus = New DevExpress.XtraBars.BarButtonItem()
		Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
		Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
		Me.cmbLevel = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
		Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.cmbLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RibbonControl
		'
		Me.RibbonControl.ExpandCollapseItem.Id = 0
		Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnAdd, Me.btnStatus})
		Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
		Me.RibbonControl.MaxItemId = 3
		Me.RibbonControl.Name = "RibbonControl"
		Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
		Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
		Me.RibbonControl.Size = New System.Drawing.Size(389, 147)
		Me.RibbonControl.StatusBar = Me.RibbonStatusBar
		'
		'btnAdd
		'
		Me.btnAdd.Caption = "ADD"
		Me.btnAdd.Glyph = CType(resources.GetObject("btnAdd.Glyph"), System.Drawing.Image)
		Me.btnAdd.Id = 1
		Me.btnAdd.LargeGlyph = CType(resources.GetObject("btnAdd.LargeGlyph"), System.Drawing.Image)
		Me.btnAdd.Name = "btnAdd"
		'
		'btnStatus
		'
		Me.btnStatus.Caption = "BarButtonItem2"
		Me.btnStatus.Glyph = Global.TMS.My.Resources.Resources.apply_16x16
		Me.btnStatus.Id = 2
		Me.btnStatus.LargeGlyph = CType(resources.GetObject("btnStatus.LargeGlyph"), System.Drawing.Image)
		Me.btnStatus.Name = "btnStatus"
		'
		'RibbonPage1
		'
		Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
		Me.RibbonPage1.Name = "RibbonPage1"
		Me.RibbonPage1.Text = "Add user"
		'
		'RibbonPageGroup1
		'
		Me.RibbonPageGroup1.AllowTextClipping = False
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAdd)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnStatus)
		Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
		'
		'RibbonStatusBar
		'
		Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 253)
		Me.RibbonStatusBar.Name = "RibbonStatusBar"
		Me.RibbonStatusBar.Ribbon = Me.RibbonControl
		Me.RibbonStatusBar.Size = New System.Drawing.Size(389, 23)
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.cmbLevel)
		Me.LayoutControl1.Controls.Add(Me.txtPassword)
		Me.LayoutControl1.Controls.Add(Me.txtUsername)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.Location = New System.Drawing.Point(0, 147)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(389, 106)
		Me.LayoutControl1.TabIndex = 2
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'cmbLevel
		'
		Me.cmbLevel.Location = New System.Drawing.Point(69, 60)
		Me.cmbLevel.MenuManager = Me.RibbonControl
		Me.cmbLevel.Name = "cmbLevel"
		Me.cmbLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.cmbLevel.Size = New System.Drawing.Size(308, 20)
		Me.cmbLevel.StyleController = Me.LayoutControl1
		Me.cmbLevel.TabIndex = 6
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(69, 36)
		Me.txtPassword.MenuManager = Me.RibbonControl
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(308, 20)
		Me.txtPassword.StyleController = Me.LayoutControl1
		Me.txtPassword.TabIndex = 5
		'
		'txtUsername
		'
		Me.txtUsername.Location = New System.Drawing.Point(69, 12)
		Me.txtUsername.MenuManager = Me.RibbonControl
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(308, 20)
		Me.txtUsername.StyleController = Me.LayoutControl1
		Me.txtUsername.TabIndex = 4
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem1})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(389, 106)
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtPassword
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(369, 24)
		Me.LayoutControlItem2.Text = "Password:"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(54, 13)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.cmbLevel
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(369, 38)
		Me.LayoutControlItem3.Text = "User Level:"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(54, 13)
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtUsername
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(369, 24)
		Me.LayoutControlItem1.Text = "Username:"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(54, 13)
		'
		'frmUser
		'
		Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(389, 276)
		Me.Controls.Add(Me.LayoutControl1)
		Me.Controls.Add(Me.RibbonStatusBar)
		Me.Controls.Add(Me.RibbonControl)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmUser"
		Me.Ribbon = Me.RibbonControl
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.StatusBar = Me.RibbonStatusBar
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.cmbLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
	Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
	Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnStatus As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents cmbLevel As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem


End Class
