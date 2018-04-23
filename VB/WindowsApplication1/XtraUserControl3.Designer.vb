Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class XtraUserControl3
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.previewBar3 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.previewBar1 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
			Me.SuspendLayout()
			' 
			' previewBar3
			' 
			Me.previewBar3.BarName = "Main Menu"
			Me.previewBar3.DockCol = 0
			Me.previewBar3.DockRow = 0
			Me.previewBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.previewBar3.FloatLocation = New System.Drawing.Point(34, 221)
			Me.previewBar3.OptionsBar.MultiLine = True
			Me.previewBar3.OptionsBar.UseWholeRow = True
			Me.previewBar3.Text = "Main Menu"
			' 
			' previewBar1
			' 
			Me.previewBar1.BarName = "Toolbar"
			Me.previewBar1.DockCol = 0
			Me.previewBar1.DockRow = 1
			Me.previewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.previewBar1.FloatLocation = New System.Drawing.Point(44, 217)
			Me.previewBar1.Text = "Toolbar"
			' 
			' webBrowser1
			' 
			Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.webBrowser1.Location = New System.Drawing.Point(0, 26)
			Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New System.Drawing.Size(678, 391)
			Me.webBrowser1.TabIndex = 4
			' 
			' XtraUserControl3
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.webBrowser1)
			Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.Name = "XtraUserControl3"
			Me.Size = New System.Drawing.Size(678, 417)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private previewBar3 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private previewBar1 As DevExpress.XtraPrinting.Preview.PreviewBar
		Public webBrowser1 As System.Windows.Forms.WebBrowser
	End Class
End Namespace
