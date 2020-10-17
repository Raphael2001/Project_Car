using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Project_Car.Properties;
using Project_Car.BL;

namespace Project_Car.UI
{
    public partial class Form_CarPhoto : Form
    {
       // string Name;
        Image photo;

        List<Image> Images = new List<Image>();

        public Form_CarPhoto(string str)
        {
            InitializeComponent();

            Name = str;

            PhotoArr photoArr = new PhotoArr();
            photoArr.Fill();

            pb_PhotoCar.Image = photoArr.RandomImage();
        }

        #region Photo

        private async Task<Image> LoadImage(string name)
        {
            var chtml = Task.Run(() => GetHtmlCode(name));
            var html = await chtml;

            var curl = Task.Run(() => GetUrls(html));
            var url = await curl;

            var image = await Task.Run(() => GetImage(url));

            using (var ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }

        private string GetHtmlCode(string topic)
        {

            string url = "https://www.google.com/search?q=" + topic + "&tbm=isch";
            string data = "";
            bool flag = true;

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "text/html, application/xhtml+xml, */*";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";

                var response = (HttpWebResponse)request.GetResponse();

                using (Stream dataStream = response.GetResponseStream())
                {
                    if (dataStream == null)
                        return "";
                    using (var sr = new StreamReader(dataStream))
                    {
                        data = sr.ReadToEnd();
                    }
                }
                return data;
            }
            catch
            {
                flag = false;

                while (!flag)
                {
                    var request = (HttpWebRequest)WebRequest.Create(url);
                    request.Accept = "text/html, application/xhtml+xml, */*";
                    request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";

                    var response = (HttpWebResponse)request.GetResponse();
                    flag = true;

                    using (Stream dataStream = response.GetResponseStream())
                    {
                        if (dataStream == null)
                            return "";
                        using (var sr = new StreamReader(dataStream))
                        {
                            data = sr.ReadToEnd();
                        }
                    }
                    return data;
                }
            }
            return data;

        }

        private string GetUrls(string html)
        {
            string url = "";

            int ndx = html.IndexOf("\"ou\"", StringComparison.Ordinal);

            ndx = html.IndexOf("\"", ndx + 4, StringComparison.Ordinal);
            ndx++;
            int ndx2 = html.IndexOf("\"", ndx, StringComparison.Ordinal);
            url = html.Substring(ndx, ndx2 - ndx);
            return url;

        }

        private byte[] GetImage(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                var response = (HttpWebResponse)request.GetResponse();

                using (Stream dataStream = response.GetResponseStream())
                {
                    if (dataStream == null)
                        return null;
                    using (var sr = new BinaryReader(dataStream))
                    {
                        byte[] bytes = sr.ReadBytes(100000000);

                        return bytes;
                    }
                }
            }
            catch
            {
                if (MessageBox.Show("Couldn't load the photo", "Error in loading the photo ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error) == DialogResult.OK)
                {


                    //   Close();
                }

                return ImageToByteArray(Properties.Resources.Error);
            }
        }


        #endregion

        private async void Form_CarPhoto_Load(object sender, EventArgs e)
        {

            timer1.Start();

            var image = await Task.Run(() => LoadImage(Name));
            photo = image;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgb_LoadPhoto.Value < 100)
            {
                pgb_LoadPhoto.Increment(30);
            }
            else
            {
                pb_PhotoCar.Image = photo;
                pgb_LoadPhoto.Visible = false;
            }
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

    }
}
