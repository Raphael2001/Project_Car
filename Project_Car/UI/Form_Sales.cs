using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Project_Car.Properties;
using Project_Car.BL;

namespace Project_Car.UI
{
    public partial class Form_Sales : Form
    {
        private Point point = new Point(30, 34);// 35,39
        private Size Picsize = new Size(40, 40);
        private Size Buttonsize = new Size(200, 50);
        private int Height123 = 570; //570 650
        private int Width123 = 800; //800 990
        private int PicinRow = 4;
        private int CountProducts = 0;
        int listboxOffSet = 0;
        int btnOffset = 0;
        private bool flg = false;
        private CompanyArr companyArr = new CompanyArr();
        private ProductArr productArr = new ProductArr();
        ProductArr new_productArr;


        public Form_Sales()
        {
            InitializeComponent();
            this.Size = new Size(Width123, Height123);
            panel2.BackColor = Color.FromArgb(41, 44, 51);
            companyArr.Fill();
            productArr.Fill();
            listboxOffSet = panel3.Width - listBox1.Width;



            // this.Size = new Size(800, 570);


            PicinRow = 7;

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;


            AddButton();
            flg = true;
        }

        private void AddPictureBox(int num)
        {
            CalculatePicInRow();

            this.panel1.Controls.Clear();

            //   Point p = new Point()

            Point place = point;
            bool flag = true;
            CountProducts = 0;

            while (flag)
            {

                if (num < PicinRow)
                {
                    PicinRow = num;
                }

                for (int i = 0; i < PicinRow; i++)
                {
                    CountProducts++;

                    PictureBox picture = new PictureBox
                    {
                        Size = Picsize,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = place,
                        Left = place.X + 50 * i,
                        Image = Resources.AddPhoto,
                        Tag = (new_productArr[i] as Product).Model_V2,

                        Name = "pictureBox" + CountProducts


                    };
                    this.panel1.Controls.Add(picture);
                    picture.Click += new System.EventHandler(pictureBox_Click);
                    //   LoadImage(picture, videosName[CountProducts - 1]);

                }

                place.Y += 60;

                num -= PicinRow;
                if (num <= PicinRow)
                {
                    PicinRow = num;
                }

                if (num <= 0)
                {
                    flag = false;
                }


            }



        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = (sender as PictureBox);
            //   MessageBox.Show(p.Tag.ToString());
            listBox1.Items.Add(p.Tag.ToString());
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (sender as Button);

            Company company = companyArr.GetCompany(b.Text);
            new_productArr = productArr.Filter(company);
            AddPictureBox(new_productArr.Count);

            KeepSize();

        }

        private void Form_Sales_SizeChanged(object sender, EventArgs e)
        {

            //PicinRow = panel1.Size.Width / 200;
            //      AddPictureBox(100);
            if (flg)
            {

                KeepSize();
                //  AddPictureBox(5);
            }
        }

        private void AddButton()
        {

            this.panel2.Controls.Clear();

            Point place = new Point(5, 30);


            for (int i = 0; i < companyArr.Count; i++)
            {

                Button button = new Button
                {
                    Size = Buttonsize,
                    Location = place,
                    // Left = place.X + 50 * i,
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                    Tag = i,
                    Name = "btn_" + companyArr[i].ToString(),
                    Text = companyArr[i].ToString(),


                };
                this.panel2.Controls.Add(button);
                button.Click += new System.EventHandler(button_Click);


                place.Y += 50;

            }



        }

        private void CalculatePicInRow()
        {
            PicinRow = panel2.Width / 20;
        }

        private void KeepSize()
        {
            flg = true;

            this.panel1.Size = new Size(this.Width / 2, Height123);
            this.panel2.Size = new Size(this.Width / 8, Height123);
            this.panel3.Size = new Size(this.Width / 4, Height123);




            listBox1.Size = new Size(panel3.Width- listboxOffSet, panel3.Height - btn_CheckOut.Height - 20);

            btn_CheckOut.Location = new Point(listBox1.Location.X+10, listBox1.Location.Y + listBox1.Height+5);
        }

        private void Panel1_Resize(object sender, EventArgs e)
        {
        }

        private void Panel1_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
