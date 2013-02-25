using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LiveDesign
{
    public partial class DesignGalleryItem : UserControl
    {
        private Thread mExtractThumbThread = null;
        public DesignGalleryItem()
        {
            InitializeComponent();
            this.progressBar.Visible = false;
            this.extractingThumbLabel.Visible = false;
        }

        private void DesignGalleryItem_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void DesignGalleryItem_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            path = path.ToLower();
            if (path.EndsWith(".psd"))
            {
                //Zgke.MyImage.ImageFile.ImagePsd _Psd = new Zgke.MyImage.ImageFile.ImagePsd(path);
                //this.previewPicuture.Image = _Psd.PSDImage;

                //CloudUtility.UpLoadFile(path, "http://services.sketchbook.cn/livedesign/data/design/psd/", true);
                //CloudUtility.test();
                startExtractThumbThread(path);
            }
        }

        private void startExtractThumbThread(String filePath)
        {
            if (null != mExtractThumbThread)
            {
                if (mExtractThumbThread.IsAlive)
                {
                    mExtractThumbThread.Abort();
                }
                mExtractThumbThread = null;
            }
            ParameterizedThreadStart pts = new ParameterizedThreadStart(extractThumb);
            mExtractThumbThread = new Thread(pts);

            this.extractingThumbLabel.Visible = true;
            //this.progressBar.Visible = true;

            mExtractThumbThread.Start(filePath);
        }

        private void extractThumb(Object obj)
        {
            String filePath = (String)obj;
            Zgke.MyImage.ImageFile.ImagePsd _Psd = new Zgke.MyImage.ImageFile.ImagePsd(filePath);
            this.previewPicuture.Image = _Psd.PSDImage;
            this.extractingThumbLabel.Visible = false;
            //this.progressBar.Visible = false;
        }

        private void DesignGalleryItem_Click(object sender, EventArgs e)
        {
            //this.extractingThumbLabel.Visible = true;
            //this.progressBar.Visible = true;
        }
    }
}
