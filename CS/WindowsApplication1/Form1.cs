using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.IO;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraCharts;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        XtraReport ActiveReport;
        private void Form1_Load(object sender, EventArgs e) {
            this.xtraUserControl11.xrDesignPanel1.OpenReport(new XtraReport1());
            this.xtraUserControl11.xrDesignPanel1.SetCommandVisibility(ReportCommand.ShowPreviewTab,CommandVisibility.None);
            this.xtraUserControl11.xrDesignPanel1.SetCommandVisibility(ReportCommand.ShowHTMLViewTab,CommandVisibility.None);
            this.xtraUserControl11.xrDesignPanel1.SetCommandVisibility(ReportCommand.ShowDesignerTab, CommandVisibility.None);
            
        }

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e) {

            
            if(e.PrevPage.Text == "Design") {
                if( this.xtraUserControl11.xrDesignPanel1.Report == null)
                e.Cancel = true;
                else {
                    MemoryStream ms = new MemoryStream();
                    try{
                        this.xtraUserControl11.xrDesignPanel1.Report.SaveLayout(ms);
                        ms.Seek(0, SeekOrigin.Begin);
                        ActiveReport = XtraReport.FromStream(ms, true);
                        ActiveReport.DataSource =   this.xtraUserControl11.xrDesignPanel1.Report.DataSource ;
                        ActiveReport.DataMember = this.xtraUserControl11.xrDesignPanel1.Report.DataMember;
                    }
                    finally {
                        ms.Close();
                    }
                }
            }
            if(e.Page.Text == "Preview") {
                ActiveReport.CreateDocument();
                this.xtraUserControl21.printControl1.PrintingSystem = ActiveReport.PrintingSystem;

            }
            if(e.Page.Text == "HTML View") {
                try
                {
                    ActiveReport.ExportToHtml(Environment.CurrentDirectory +"\\temp.html");
                    xtraUserControl31.webBrowser1.Navigate(Environment.CurrentDirectory + "\\temp.html");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                 
            }
        }

    }
}