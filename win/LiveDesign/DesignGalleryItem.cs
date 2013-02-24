using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiveDesign
{
    public partial class DesignGalleryItem : UserControl
    {
        public DesignGalleryItem()
        {
            InitializeComponent();
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
                Zgke.MyImage.ImageFile.ImagePsd _Psd = new Zgke.MyImage.ImageFile.ImagePsd(path);
                this.previewPicuture.Image = _Psd.PSDImage;

                //CloudUtility.UpLoadFile(path, "http://services.sketchbook.cn/livedesign/data/design/psd/", true);
                //CloudUtility.test();
            }
        }
    }
}
