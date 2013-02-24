using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace LiveDesign.Utilities
{
    class CloudUtility
    {
        public static void test()
        {
            string url = "http://services.sketchbook.cn/livedesign/api/test.php";
            string fileName1 = @"d:\data\test1.psd";
            string fileName2 = @"d:\data\test1.png";
            UploadFile[] files = new UploadFile[] 
            { 
                new UploadFile(fileName1, "design_psd", "image/x-photoshop"),
                new UploadFile(fileName2, "preview", "image/png")
            };

            NameValueCollection form = new NameValueCollection();

            form["ownerid"] = "tom's id";
            form["comments"] = "tom's comments";
            form["design_guid"] = "test111";

            try
            {
                HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;

                // set credentials/cookies etc.

                HttpWebResponse resp = HttpUploadHelper.Upload(req, files, form);

                using (Stream s = resp.GetResponseStream())
                using (StreamReader sr = new StreamReader(s))
                {
                    string response = sr.ReadToEnd();
                    MessageBox.Show(response);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}