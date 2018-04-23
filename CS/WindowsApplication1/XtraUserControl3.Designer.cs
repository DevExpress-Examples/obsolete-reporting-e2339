namespace WindowsApplication1
{
    partial class XtraUserControl3
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.previewBar3 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.previewBar1 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
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
            // previewBar1
            // 
            this.previewBar1.BarName = "Toolbar";
            this.previewBar1.DockCol = 0;
            this.previewBar1.DockRow = 1;
            this.previewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.previewBar1.FloatLocation = new System.Drawing.Point(44, 217);
            this.previewBar1.Text = "Toolbar";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 26);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(678, 391);
            this.webBrowser1.TabIndex = 4;
            // 
            // XtraUserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "XtraUserControl3";
            this.Size = new System.Drawing.Size(678, 417);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar3;
        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar1;
        public System.Windows.Forms.WebBrowser webBrowser1;
    }
}
