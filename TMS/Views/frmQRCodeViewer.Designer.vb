<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRCodeViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
		Dim Code128Generator3 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQRCodeViewer))
		Me.BarCodeControl1 = New DevExpress.XtraEditors.BarCodeControl()
		Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BarCodeControl1
		'
		Me.BarCodeControl1.Location = New System.Drawing.Point(12, 12)
		Me.BarCodeControl1.Name = "BarCodeControl1"
		Me.BarCodeControl1.Size = New System.Drawing.Size(306, 99)
		Me.BarCodeControl1.Symbology = Code128Generator3
		Me.BarCodeControl1.TabIndex = 0
		Me.BarCodeControl1.Text = "BarCodeControl1"
		'
		'SimpleButton1
		'
		Me.SimpleButton1.Location = New System.Drawing.Point(12, 117)
		Me.SimpleButton1.Name = "SimpleButton1"
		Me.SimpleButton1.Size = New System.Drawing.Size(306, 23)
		Me.SimpleButton1.TabIndex = 1
		Me.SimpleButton1.Text = "Save Generated Barcode"
		'
		'PictureBox1
		'
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(306, 99)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'frmQRCodeViewer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(327, 149)
		Me.Controls.Add(Me.SimpleButton1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.BarCodeControl1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmQRCodeViewer"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "QR Code Viewer"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents BarCodeControl1 As DevExpress.XtraEditors.BarCodeControl
	Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
