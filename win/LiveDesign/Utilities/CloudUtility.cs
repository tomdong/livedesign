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
        /// <summary>
        /// WebClient上传文件至服务器
        /// </summary>
        /// <param name="fileNamePath">文件名，全路径格式</param>
        /// <param name="uriString">服务器文件夹路径</param>
        /// <param name="IsAutoRename">是否自动按照时间重命名</param>
        public static void UpLoadFile(string fileNamePath, string uriString, bool IsAutoRename)
        {
            string fileName = fileNamePath.Substring(fileNamePath.LastIndexOf("\\") + 1);
            string NewFileName = fileName;
            if (IsAutoRename)
            {
                NewFileName = DateTime.Now.ToString("yyMMddhhmmss") + DateTime.Now.Millisecond.ToString() + fileNamePath.Substring(fileNamePath.LastIndexOf("."));
            }

            string fileNameExt = fileName.Substring(fileName.LastIndexOf(".") + 1);
            if (uriString.EndsWith("/") == false) uriString = uriString + "/";

            uriString = uriString + NewFileName;
            //Utility.LogWriter log = new Utility.LogWriter();
            //log.AddLog(uriString, "Log");
            //log.AddLog(fileNamePath, "Log");
            /**/
            /// 创建WebClient实例
            WebClient myWebClient = new WebClient();
            myWebClient.Credentials = CredentialCache.DefaultCredentials;
            // 要上传的文件
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            //FileStream fs = OpenFile();
            BinaryReader r = new BinaryReader(fs);
            byte[] postArray = r.ReadBytes((int)fs.Length);
            Stream postStream = myWebClient.OpenWrite(uriString, "PUT");
            try
            {
                //使用UploadFile方法可以用下面的格式
                //myWebClient.UploadFile(uriString,"PUT",fileNamePath);
                if (postStream.CanWrite)
                {
                    postStream.Write(postArray, 0, postArray.Length);
                    postStream.Close();
                    fs.Dispose();
                    //log.AddLog("上传日志文件成功！", "Log");
                }
                else
                {
                    postStream.Close();
                    fs.Dispose();
                    //log.AddLog("上传日志文件失败，文件不可写！", "Log");
                }
            }
            catch (Exception err)
            {
                postStream.Close();
                fs.Dispose();
                //Utility.LogWriter log = new Utility.LogWriter();
                //log.AddLog(err, "上传日志文件异常！", "Log");
                throw err;
            }
            finally
            {
                postStream.Close();
                fs.Dispose();
            }
        }

        /// </summary>
        /// <param name="URL">被下载的文件地址，绝对路径</param>
        /// <param name="Dir">另存放的目录</param>
        public void Download(string URL, string Dir)
        {
            WebClient client = new WebClient();
            string fileName = URL.Substring(URL.LastIndexOf("\\") + 1);  //被下载的文件名

            string Path = Dir + fileName;   //另存为的绝对路径＋文件名
            //Utility.LogWriter log = new Utility.LogWriter();
            try
            {
                WebRequest myre = WebRequest.Create(URL);
            }
            catch (Exception err)
            {
                //MessageBox.Show(exp.Message,"Error"); 
                //log.AddLog(err, "下载日志文件异常！", "Log");
            }

            try
            {
                client.DownloadFile(URL, fileName);
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader r = new BinaryReader(fs);
                byte[] mbyte = r.ReadBytes((int)fs.Length);

                FileStream fstr = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);

                fstr.Write(mbyte, 0, (int)fs.Length);
                fstr.Close();

            }
            catch (Exception err)
            {
                //MessageBox.Show(exp.Message,"Error");
                //log.AddLog(err, "下载日志文件异常！", "Log");
            }
        }
    }
}