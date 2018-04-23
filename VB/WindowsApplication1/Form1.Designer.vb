Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraUserControl11 = New WindowsApplication1.XtraUserControl1()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraUserControl21 = New WindowsApplication1.XtraUserControl2()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.previewBar1 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.previewBar3 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.xtraUserControl31 = New WindowsApplication1.XtraUserControl3()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			Me.xtraTabPage3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Margin = New System.Windows.Forms.Padding(4)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(1097, 542)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3})
			Me.xtraTabControl1.Text = "HTML View"
'			Me.xtraTabControl1.SelectedPageChanging += New DevExpress.XtraTab.TabPageChangingEventHandler(Me.xtraTabControl1_SelectedPageChanging);
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.xtraUserControl11)
			Me.xtraTabPage1.Margin = New System.Windows.Forms.Padding(4)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(1088, 508)
			Me.xtraTabPage1.Text = "Design"
			' 
			' xtraUserControl11
			' 
			Me.xtraUserControl11.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraUserControl11.Location = New System.Drawing.Point(0, 0)
			Me.xtraUserControl11.Margin = New System.Windows.Forms.Padding(5)
			Me.xtraUserControl11.Name = "xtraUserControl11"
			Me.xtraUserControl11.Size = New System.Drawing.Size(1088, 508)
			Me.xtraUserControl11.TabIndex = 0
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.xtraUserControl21)
			Me.xtraTabPage2.Margin = New System.Windows.Forms.Padding(4)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(1088, 508)
			Me.xtraTabPage2.Text = "Preview"
			' 
			' xtraUserControl21
			' 
			Me.xtraUserControl21.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraUserControl21.Location = New System.Drawing.Point(0, 0)
			Me.xtraUserControl21.Margin = New System.Windows.Forms.Padding(5)
			Me.xtraUserControl21.Name = "xtraUserControl21"
			Me.xtraUserControl21.Size = New System.Drawing.Size(1088, 508)
			Me.xtraUserControl21.TabIndex = 0
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.Controls.Add(Me.xtraUserControl31)
			Me.xtraTabPage3.Margin = New System.Windows.Forms.Padding(4)
			Me.xtraTabPage3.Name = "xtraTabPage3"
			Me.xtraTabPage3.Size = New System.Drawing.Size(1088, 508)
			Me.xtraTabPage3.Text = "HTML View"
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
			' xtraUserControl31
			' 
			Me.xtraUserControl31.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraUserControl31.Location = New System.Drawing.Point(0, 0)
			Me.xtraUserControl31.Name = "xtraUserControl31"
			Me.xtraUserControl31.Size = New System.Drawing.Size(1088, 508)
			Me.xtraUserControl31.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1097, 542)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			Me.xtraTabPage3.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private xtraUserControl11 As XtraUserControl1
		Private xtraUserControl21 As XtraUserControl2
		Private previewBar1 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private previewBar3 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private xtraUserControl31 As XtraUserControl3
	End Class
End Namespace

