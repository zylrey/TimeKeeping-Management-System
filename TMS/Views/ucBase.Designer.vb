<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBase
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBase))
		Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
		Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
		Me.btnFilter = New DevExpress.XtraEditors.SimpleButton()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.dtFrom = New DevExpress.XtraEditors.DateEdit()
		Me.dtTo = New DevExpress.XtraEditors.DateEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.GridControl1)
		Me.LayoutControl1.Controls.Add(Me.btnNew)
		Me.LayoutControl1.Controls.Add(Me.btnFilter)
		Me.LayoutControl1.Controls.Add(Me.LabelControl1)
		Me.LayoutControl1.Controls.Add(Me.dtFrom)
		Me.LayoutControl1.Controls.Add(Me.dtTo)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(526, 196, 376, 350)
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(775, 415)
		Me.LayoutControl1.TabIndex = 0
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'GridControl1
		'
		Me.GridControl1.Location = New System.Drawing.Point(12, 61)
		Me.GridControl1.MainView = Me.GridView1
		Me.GridControl1.Name = "GridControl1"
		Me.GridControl1.Size = New System.Drawing.Size(751, 342)
		Me.GridControl1.TabIndex = 10
		Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
		'
		'GridView1
		'
		Me.GridView1.GridControl = Me.GridControl1
		Me.GridView1.Name = "GridView1"
		'
		'btnNew
		'
		Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
		Me.btnNew.Location = New System.Drawing.Point(666, 35)
		Me.btnNew.Name = "btnNew"
		Me.btnNew.Size = New System.Drawing.Size(97, 22)
		Me.btnNew.StyleController = Me.LayoutControl1
		Me.btnNew.TabIndex = 9
		Me.btnNew.Text = "New Record"
		'
		'btnFilter
		'
		Me.btnFilter.Image = CType(resources.GetObject("btnFilter.Image"), System.Drawing.Image)
		Me.btnFilter.Location = New System.Drawing.Point(315, 35)
		Me.btnFilter.Name = "btnFilter"
		Me.btnFilter.Size = New System.Drawing.Size(75, 22)
		Me.btnFilter.StyleController = Me.LayoutControl1
		Me.btnFilter.TabIndex = 8
		Me.btnFilter.Text = "Filter"
		'
		'LabelControl1
		'
		Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(114, 19)
		Me.LabelControl1.StyleController = Me.LayoutControl1
		Me.LabelControl1.TabIndex = 6
		Me.LabelControl1.Text = "LabelControl1"
		'
		'dtFrom
		'
		Me.dtFrom.EditValue = Nothing
		Me.dtFrom.Location = New System.Drawing.Point(69, 35)
		Me.dtFrom.Name = "dtFrom"
		Me.dtFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.dtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.dtFrom.Size = New System.Drawing.Size(101, 20)
		Me.dtFrom.StyleController = Me.LayoutControl1
		Me.dtFrom.TabIndex = 4
		'
		'dtTo
		'
		Me.dtTo.EditValue = Nothing
		Me.dtTo.Location = New System.Drawing.Point(195, 35)
		Me.dtTo.Name = "dtTo"
		Me.dtTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.dtTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.dtTo.Size = New System.Drawing.Size(116, 20)
		Me.dtTo.StyleController = Me.LayoutControl1
		Me.dtTo.TabIndex = 7
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.LayoutControlItem6})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(775, 415)
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.LabelControl1
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(755, 23)
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem3.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.dtFrom
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 23)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(162, 26)
		Me.LayoutControlItem1.Text = "Date From:"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(54, 13)
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.dtTo
		Me.LayoutControlItem5.CustomizationFormText = "To:"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(162, 23)
		Me.LayoutControlItem5.MinSize = New System.Drawing.Size(75, 24)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(141, 26)
		Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.LayoutControlItem5.Text = "To:"
		Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(16, 13)
		Me.LayoutControlItem5.TextToControlDistance = 5
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.btnFilter
		Me.LayoutControlItem2.Location = New System.Drawing.Point(303, 23)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(79, 26)
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem2.TextVisible = False
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.btnNew
		Me.LayoutControlItem4.Location = New System.Drawing.Point(654, 23)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(101, 26)
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem4.TextVisible = False
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(382, 23)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(272, 26)
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.GridControl1
		Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 49)
		Me.LayoutControlItem6.MinSize = New System.Drawing.Size(104, 24)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(755, 346)
		Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem6.TextVisible = False
		'
		'SimpleButton2
		'
		Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
		Me.SimpleButton2.Location = New System.Drawing.Point(305, 35)
		Me.SimpleButton2.Name = "SimpleButton2"
		Me.SimpleButton2.Size = New System.Drawing.Size(86, 22)
		Me.SimpleButton2.TabIndex = 8
		Me.SimpleButton2.Text = "Filter"
		'
		'ucBase
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.LayoutControl1)
		Me.Name = "ucBase"
		Me.Size = New System.Drawing.Size(775, 415)
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents dtFrom As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents btnFilter As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents dtTo As DevExpress.XtraEditors.DateEdit
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

End Class
