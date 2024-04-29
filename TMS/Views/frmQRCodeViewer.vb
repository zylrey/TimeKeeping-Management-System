Imports System.IO

Public Class frmQRCodeViewer
	Public Sub New(ByVal qrCodeText As String)
		InitializeComponent()

		' Set QR code text
		BarCodeControl1.Text = qrCodeText

		' Generate QR code
		BarCodeControl1.Refresh()

		' Create a bitmap with the size of BarCodeControl1
		Dim bitmap As New Bitmap(BarCodeControl1.Width, BarCodeControl1.Height)

		' Render BarCodeControl1 onto the bitmap
		BarCodeControl1.DrawToBitmap(bitmap, New Rectangle(0, 0, BarCodeControl1.Width, BarCodeControl1.Height))

		' Display bitmap in PictureBox
		PictureBox1.Image = bitmap
	End Sub

	Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
		' Save QR code image to PNG file
		If PictureBox1.Image IsNot Nothing Then
			Dim saveFileDialog As New SaveFileDialog()
			saveFileDialog.Filter = "PNG Image|*.png"
			saveFileDialog.Title = "Save QR Code Image"
			saveFileDialog.ShowDialog()

			If saveFileDialog.FileName <> "" Then
				PictureBox1.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png)
				MessageBox.Show("QR code image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Else
			MessageBox.Show("No QR code image to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub


End Class