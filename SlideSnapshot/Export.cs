using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace SlideSnapshot
{
    public partial class Export
    {
        private void Export_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void exportBtn_Click(object sender, RibbonControlEventArgs e)
        {

            var pptApplication = new Microsoft.Office.Interop.PowerPoint.Application();
            var activeWindow = pptApplication.ActiveWindow;
            var slide = activeWindow.View.Slide;
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                slide.Export(saveFileDialog.FileName, "PNG");
            }

        }
    }
}
