namespace WindowsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraUserControl11 = new WindowsApplication1.XtraUserControl1();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraUserControl21 = new WindowsApplication1.XtraUserControl2();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.previewBar1 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.previewBar3 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.xtraUserControl31 = new WindowsApplication1.XtraUserControl3();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1097, 542);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            this.xtraTabControl1.Text = "HTML View";
            this.xtraTabControl1.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.xtraTabControl1_SelectedPageChanging);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.xtraUserControl11);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1088, 508);
            this.xtraTabPage1.Text = "Design";
            // 
            // xtraUserControl11
            // 
            this.xtraUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraUserControl11.Location = new System.Drawing.Point(0, 0);
            this.xtraUserControl11.Margin = new System.Windows.Forms.Padding(5);
            this.xtraUserControl11.Name = "xtraUserControl11";
            this.xtraUserControl11.Size = new System.Drawing.Size(1088, 508);
            this.xtraUserControl11.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.xtraUserControl21);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1088, 508);
            this.xtraTabPage2.Text = "Preview";
            // 
            // xtraUserControl21
            // 
            this.xtraUserControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraUserControl21.Location = new System.Drawing.Point(0, 0);
            this.xtraUserControl21.Margin = new System.Windows.Forms.Padding(5);
            this.xtraUserControl21.Name = "xtraUserControl21";
            this.xtraUserControl21.Size = new System.Drawing.Size(1088, 508);
            this.xtraUserControl21.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.xtraUserControl31);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1088, 508);
            this.xtraTabPage3.Text = "HTML View";
            // 
            // previewBar1
            // 
            this.previewBar1.BarName = "Toolbar";
            this.previewBar1.DockCol = 0;
            this.previewBar1.DockRow = 1;
            this.previewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.previewBar1.FloatLocation = new System.Drawing.Point(44, 217);
            this.previewBar1.Text = "Toolbar";
            // 
            // previewBar3
            // 
            this.previewBar3.BarName = "Main Menu";
            this.previewBar3.DockCol = 0;
            this.previewBar3.DockRow = 0;
            this.previewBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.previewBar3.FloatLocation = new System.Drawing.Point(34, 221);
            this.previewBar3.OptionsBar.MultiLine = true;
            this.previewBar3.OptionsBar.UseWholeRow = true;
            this.previewBar3.Text = "Main Menu";
            // 
            // xtraUserControl31
            // 
            this.xtraUserControl31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraUserControl31.Location = new System.Drawing.Point(0, 0);
            this.xtraUserControl31.Name = "xtraUserControl31";
            this.xtraUserControl31.Size = new System.Drawing.Size(1088, 508);
            this.xtraUserControl31.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 542);
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private XtraUserControl1 xtraUserControl11;
        private XtraUserControl2 xtraUserControl21;
        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar1;
        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar3;
        private XtraUserControl3 xtraUserControl31;
    }
}

