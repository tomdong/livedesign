using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiveDesign.Utilities;

namespace LiveDesign
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            path = path.ToLower();
            if (path.EndsWith(".psd"))
            {
                Zgke.MyImage.ImageFile.ImagePsd _Psd = new Zgke.MyImage.ImageFile.ImagePsd(path);
                this.BackgroundImage = _Psd.PSDImage;

                //CloudUtility.UpLoadFile(path, "http://services.sketchbook.cn/livedesign/data/design/psd/", true);
                CloudUtility.test();
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void MainForm_DragLeave(object sender, EventArgs e)
        {

        }

        private void MainForm_DragOver(object sender, DragEventArgs e)
        {

        }
    }
}
