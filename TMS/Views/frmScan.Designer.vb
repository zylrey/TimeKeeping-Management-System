<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScan
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
        Me.txtScan = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtScan
        '
        Me.txtScan.Location = New System.Drawing.Point(229, 160)
        Me.txtScan.Name = "txtScan"
        Me.txtScan.Size = New System.Drawing.Size(255, 27)
        Me.txtScan.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Location = New System.Drawing.Point(250, 102)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(63, 19)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = "Label1"
        '
        'frmScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 401)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtScan)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtScan As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.Label
End Class
