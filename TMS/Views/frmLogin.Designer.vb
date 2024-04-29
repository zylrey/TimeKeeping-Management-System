<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
		Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
		Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
		Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.PictureBox1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(193, 211)
		Me.Panel1.TabIndex = 0
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBox1.Image = Global.TMS.My.Resources.Resources.logo
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(193, 211)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
		Me.LayoutControl1.Controls.Add(Me.Label1)
		Me.LayoutControl1.Controls.Add(Me.btnLogin)
		Me.LayoutControl1.Controls.Add(Me.txtPassword)
		Me.LayoutControl1.Controls.Add(Me.txtUsername)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.Location = New System.Drawing.Point(193, 0)
		Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(271, 211)
		Me.LayoutControl1.TabIndex = 1
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'SimpleButton1
		'
		Me.SimpleButton1.Location = New System.Drawing.Point(12, 177)
		Me.SimpleButton1.Name = "SimpleButton1"
		Me.SimpleButton1.Size = New System.Drawing.Size(247, 22)
		Me.SimpleButton1.StyleController = Me.LayoutControl1
		Me.SimpleButton1.TabIndex = 8
		Me.SimpleButton1.Text = "Exit"
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(191, 67)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Login"
		'
		'btnLogin
		'
		Me.btnLogin.Location = New System.Drawing.Point(12, 151)
		Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(247, 22)
		Me.btnLogin.StyleController = Me.LayoutControl1
		Me.btnLogin.TabIndex = 6
		Me.btnLogin.Text = "Login"
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(67, 117)
		Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(192, 20)
		Me.txtPassword.StyleController = Me.LayoutControl1
		Me.txtPassword.TabIndex = 5
		'
		'txtUsername
		'
		Me.txtUsername.Location = New System.Drawing.Point(67, 83)
		Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(192, 20)
		Me.txtUsername.StyleController = Me.LayoutControl1
		Me.txtUsername.TabIndex = 4
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem4, Me.LayoutControlItem4, Me.LayoutControlItem5})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(271, 211)
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtPassword
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 105)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(251, 24)
		Me.LayoutControlItem2.Text = "Password:"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(52, 13)
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtUsername
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 71)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(251, 24)
		Me.LayoutControlItem1.Text = "Username:"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(52, 13)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.btnLogin
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 139)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(251, 26)
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem3.TextVisible = False
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 95)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(251, 10)
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 129)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(251, 10)
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'EmptySpaceItem4
		'
		Me.EmptySpaceItem4.AllowHotTrack = False
		Me.EmptySpaceItem4.Location = New System.Drawing.Point(195, 0)
		Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
		Me.EmptySpaceItem4.Size = New System.Drawing.Size(56, 71)
		Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.Label1
		Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(195, 71)
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem4.TextVisible = False
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.SimpleButton1
		Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 165)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(251, 26)
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem5.TextVisible = False
		'
		'frmLogin
		'
		Me.Appearance.Options.UseFont = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(464, 211)
		Me.Controls.Add(Me.LayoutControl1)
		Me.Controls.Add(Me.Panel1)
		Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmLogin"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
End Class
