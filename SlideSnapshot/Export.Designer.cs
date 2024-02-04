namespace SlideSnapshot
{
    partial class Export : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Export()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.exportpng = this.Factory.CreateRibbonGroup();
            this.exportBtn = this.Factory.CreateRibbonButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tab1.SuspendLayout();
            this.exportpng.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabHome";
            this.tab1.Groups.Add(this.exportpng);
            this.tab1.Label = "TabHome";
            this.tab1.Name = "tab1";
            // 
            // exportpng
            // 
            this.exportpng.Items.Add(this.exportBtn);
            this.exportpng.Label = "导出封面";
            this.exportpng.Name = "exportpng";
            // 
            // exportBtn
            // 
            this.exportBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.exportBtn.Label = "导出";
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.OfficeImageId = "AutoThumbnail";
            this.exportBtn.ShowImage = true;
            this.exportBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.exportBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.FileName = "SlideSnapshot";
            this.saveFileDialog.Filter = "PNG|*.png";
            // 
            // Export
            // 
            this.Name = "Export";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Export_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.exportpng.ResumeLayout(false);
            this.exportpng.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup exportpng;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton exportBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }

    partial class ThisRibbonCollection
    {
        internal Export Export
        {
            get { return this.GetRibbon<Export>(); }
        }
    }
}
