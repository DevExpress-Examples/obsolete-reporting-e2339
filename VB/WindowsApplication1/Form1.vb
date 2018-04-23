Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraCharts

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private ActiveReport As XtraReport
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.xtraUserControl11.xrDesignPanel1.OpenReport(New XtraReport1())
			Me.xtraUserControl11.xrDesignPanel1.SetCommandVisibility(ReportCommand.ShowPreviewTab,CommandVisibility.None)
			Me.xtraUserControl11.xrDesignPanel1.SetCommandVisibility(ReportCommand.ShowHTMLViewTab,CommandVisibility.None)
			Me.xtraUserControl11.xrDesignPanel1.SetCommandVisibility(ReportCommand.ShowDesignerTab, CommandVisibility.None)

		End Sub

		Private Sub xtraTabControl1_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles xtraTabControl1.SelectedPageChanging


			If e.PrevPage.Text = "Design" Then
				If Me.xtraUserControl11.xrDesignPanel1.Report Is Nothing Then
				e.Cancel = True
				Else
					Dim ms As New MemoryStream()
					Try
						Me.xtraUserControl11.xrDesignPanel1.Report.SaveLayout(ms)
						ms.Seek(0, SeekOrigin.Begin)
						ActiveReport = XtraReport.FromStream(ms, True)
						ActiveReport.DataSource = Me.xtraUserControl11.xrDesignPanel1.Report.DataSource
						ActiveReport.DataMember = Me.xtraUserControl11.xrDesignPanel1.Report.DataMember
					Finally
						ms.Close()
					End Try
				End If
			End If
			If e.Page.Text = "Preview" Then
				ActiveReport.CreateDocument()
				Me.xtraUserControl21.printControl1.PrintingSystem = ActiveReport.PrintingSystem

			End If
			If e.Page.Text = "HTML View" Then
				Try
					ActiveReport.ExportToHtml(Environment.CurrentDirectory & "\temp.html")
					xtraUserControl31.webBrowser1.Navigate(Environment.CurrentDirectory & "\temp.html")
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				End Try

			End If
		End Sub

	End Class
End Namespace