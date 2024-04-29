<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSection
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSection))
		Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
		Me.btnAddSection = New DevExpress.XtraBars.BarButtonItem()
		Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
		Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
		Me.txtSname = New DevExpress.XtraEditors.TextEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.txtSname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RibbonControl
		'
		Me.RibbonControl.ExpandCollapseItem.Id = 0
		Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnAddSection})
		Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
		Me.RibbonControl.MaxItemId = 2
		Me.RibbonControl.Name = "RibbonControl"
		Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
		Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
		Me.RibbonControl.Size = New System.Drawing.Size(309, 147)
		Me.RibbonControl.StatusBar = Me.RibbonStatusBar
		'
		'btnAddSection
		'
		Me.btnAddSection.Caption = "ADD"
		Me.btnAddSection.Glyph = CType(resources.GetObject("btnAddSection.Glyph"), System.Drawing.Image)
		Me.btnAddSection.Id = 1
		Me.btnAddSection.LargeGlyph = CType(resources.GetObject("btnAddSection.LargeGlyph"), System.Drawing.Image)
		Me.btnAddSection.Name = "btnAddSection"
		'
		'RibbonPage1
		'
		Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
		Me.RibbonPage1.Name = "RibbonPage1"
		Me.RibbonPage1.Text = "Add Section"
		'
		'RibbonPageGroup1
		'
		Me.RibbonPageGroup1.AllowTextClipping = False
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddSection)
		Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
		Me.RibbonPageGroup1.ShowCaptionButton = False
		'
		'RibbonStatusBar
		'
		Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 198)
		Me.RibbonStatusBar.Name = "RibbonStatusBar"
		Me.RibbonStatusBar.Ribbon = Me.RibbonControl
		Me.RibbonStatusBar.Size = New System.Drawing.Size(309, 23)
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.txtSname)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.Location = New System.Drawing.Point(0, 147)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(309, 51)
		Me.LayoutControl1.TabIndex = 2
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'txtSname
		'
		Me.txtSname.Location = New System.Drawing.Point(54, 12)
		Me.txtSname.MenuManager = Me.RibbonControl
		Me.txtSname.Name = "txtSname"
		Me.txtSname.Size = New System.Drawing.Size(243, 20)
		Me.txtSname.StyleController = Me.LayoutControl1
		Me.txtSname.TabIndex = 4
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(309, 51)
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtSname
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(289, 31)
		Me.LayoutControlItem1.Text = "Section:"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(39, 13)
		'
		'frmSection
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(309, 221)
		Me.Controls.Add(Me.LayoutControl1)
		Me.Controls.Add(Me.RibbonStatusBar)
		Me.Controls.Add(Me.RibbonControl)
		Me.Name = "frmSection"
		Me.Ribbon = Me.RibbonControl
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.StatusBar = Me.RibbonStatusBar
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.txtSname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
	Friend WithEvents btnAddSection As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents txtSname As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem


End Class
