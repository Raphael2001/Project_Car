using Project_Car.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Car.UI
{
    public partial class Form_ViewCarForRent : Form
    {

        Employee newemployee = new Employee();
        bool isopen = true;
        Form_Home form;

        public Form_ViewCarForRent(Employee employee, Form_Home f1)
        {
            InitializeComponent();

            newemployee = employee.CreateEmployee();

            this.FormBorderStyle = FormBorderStyle.None; // מסתיר את האופיציה של האיקס כדי לצאת    
                                                         //    this.Bounds = Screen.PrimaryScreen.Bounds;
            this.Dock = DockStyle.Fill;

            form = f1;

            lbl_Instructions.Left = (this.Width / 2) - (lbl_Instructions.Width / 2);
            lbl_Instructions.Top = (this.Height / 2) - (lbl_Instructions.Height / 2);
            lbl_Instructions.Visible = false;

            CarArrToForm();

            UpdateStyle();

            dgv_Cars.BackgroundColor = Color.FromArgb(41, 44, 51);
        }

        private void SetData(Product c)
        {
            int n;
            n = dgv_Cars.Rows.Add();

            dgv_Cars.Rows[n].Cells["col_Id"].Value = c.Id;
            dgv_Cars.Rows[n].Cells["col_Company"].Value = c.Model.Company.Name;
            dgv_Cars.Rows[n].Cells["col_Category"].Value = c.Model.Category.Name;
            dgv_Cars.Rows[n].Cells["col_Model"].Value = c.Model.Model;
            dgv_Cars.Rows[n].Cells["col_Price"].Value = c.Price;
            dgv_Cars.Rows[n].Cells["col_LicenseNumber"].Value = c.LicenseNumber;
            dgv_Cars.Rows[n].Cells["col_Engine"].Value = c.Model.Engine.Name;
            dgv_Cars.Rows[n].Cells["col_Status"].Value = c.Doesavailable;


        }

        private void ShowColumns(ProductArr carArr)
        {
            foreach (Product c in carArr)
            {
                if (c.Status == "Rent")
                {
                    SetData(c);
                }
            }
        }

        private void UpdateStyle()
        {
            dgv_Cars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Cars.Sort(this.dgv_Cars.Columns["col_Company"], ListSortDirection.Ascending);

            //Change cell font
            foreach (DataGridViewColumn c in dgv_Cars.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 15F, GraphicsUnit.Pixel);

            }
        }

        public void CarArrToForm()
        {
            ProductArr productArr = new ProductArr();
            productArr.FillRent();
            productArr.Sort();

            ShowColumns(productArr);
        }

        private void Form_ViewCarForRent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                this.TopMost = false;

                ProductArr productArr = new ProductArr();
                productArr.Fill();

                Form_FilterView newform = new Form_FilterView(productArr.MaxPriceRent().ToString());

                if (newform.ShowDialog() == DialogResult.OK)
                {
                    this.dgv_Cars.Rows.Clear();

                    ShowColumns(newform.GetCars());
                }

                this.TopMost = true;
            }

            else if (e.KeyCode == Keys.I && e.Modifiers == Keys.Control)
            {
                // Show Instructions


                lbl_Instructions.Visible = isopen;
                isopen = !isopen;
            }

            else if (e.KeyCode == Keys.Escape)
            {
                Form_MidView newform = new Form_MidView(newemployee,form);
                form.OpenForm(newform);
            }

            else if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                Form_Product newform = new Form_Product(newemployee);
                form.OpenForm(newform);
                form.MovePanel(form.btn_Product);
            }

        }
        
    }
}
