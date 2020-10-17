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
    public partial class Form_Engine : Form
    {

        Employee newemployee;
        public Form_Engine(Employee employee)
        {
            InitializeComponent();
            if (employee != null)
            {
                newemployee = employee.CreateEmployee();
            }
            else
            {
            }

            EngineArrToForm(null);
        }

        public bool CheckForm()
        {
            bool flag = true;

            InitForm();

            ClearError();

            #region Name
            if (txt_Name.Text.Length < 2)
            {
                flag = false;
                asterix_Name.ForeColor = Color.Red;
                lbl_ErrorName.Visible = true;
            }
            #endregion



            return flag;

        }

        #region KeyBorad
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsengsLetter(e.KeyChar) && !IsENGBLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
                e.KeyChar = char.MinValue;
        }

        private bool IsengsLetter(char c)
        {// אותיות קטנות באנגלית
            return (c >= 'a' && c <= 'z');
        }

        private bool IsENGBLetter(char c)
        {// אותיות גדולות באנגלית
            return (c >= 'A' && c <= 'Z');
        }

        private void textBox_Digit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }
        #endregion

        #region Clear

        private void ClearForm()
        {
            

            btn_Save.Text = "Save Engine";

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {

                    (ctrl as ComboBox).SelectedIndex = -1;

                }
                else if (ctrl is RadioButton)
                {
                    (ctrl as RadioButton).Checked = false;
                }
                else if (ctrl is Label)
                {
                    if (ctrl.Name == "lbl_Idtxt")
                    {
                        ctrl.Text = "0";
                    }

                    else if (ctrl.Name.StartsWith("lbl_Error"))
                    {
                        ctrl.Visible = false;
                    }

                    else if (ctrl.Name.StartsWith("asterix_"))
                    {
                        (ctrl as Label).ForeColor = Color.Black;
                    }
                }
            }
        }

        private void ClearError()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {

                    if (ctrl.Name.StartsWith("lbl_Error"))
                    {
                        ctrl.Visible = false;
                    }
                }
            }




        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void InitForm()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {

                    if (ctrl.Name.StartsWith("asterix_"))
                    {
                        (ctrl as Label).ForeColor = Color.Black;
                    }
                }
            }


        }

        #endregion

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_HomePage newform = new Form_HomePage(newemployee);
            Hide();
            newform.ShowDialog();
            Close();
        }

        private void EngineArrToForm(Engine curEngine)
        {
            EngineArr engineArr = new EngineArr();
            engineArr.Fill();

            listbox_Engine.DataSource = engineArr;
            listbox_Engine.ValueMember = "Id";
            listbox_Engine.DisplayMember = "Name";

            if (curEngine != null)
            {
                listbox_Engine.SelectedValue = curEngine.Id;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {

                Engine engine = new Engine();
                engine = FormToEngine();

                EngineArr oldEngineArr = new EngineArr();
                oldEngineArr.Fill();

                if (!oldEngineArr.IsContain(engine.Name))
                {
                    if (engine.Id == 0)
                    {
                        if (engine.Insert())
                        {
                            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            EngineArr engineArr = new EngineArr();
                            engineArr.Fill();
                            engine = engineArr.GetEngineWithMaxId();

                            EngineArrToForm(engine);
                        }
                    }
                    else
                    {
                        if (engine.Update())
                        {
                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();

                            EngineArr engineArr = new EngineArr();
                            engineArr.Fill();
                            engine = engineArr.GetEngineWithMaxId();
                            EngineArrToForm(engine);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Engine already exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        #region Transfer Data

        private Engine FormToEngine()
        {
            Engine engine = new Engine();

            engine.Id = int.Parse(lbl_Idtxt.Text);
            engine.Name = txt_Name.Text;

            return engine;
        }

        private void EngineToForm(Engine engine)
        {
            lbl_Idtxt.Text = engine.Id.ToString();
            txt_Name.Text = engine.Name;
        }

        #endregion

        private void listbox_Engine_DoubleClick(object sender, EventArgs e)
        {

            btn_Save.Text = "Update Engine";
            EngineToForm(listbox_Engine.SelectedItem as Engine);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Engine engine = FormToEngine();
            CarArr carArr = new CarArr();
            carArr.Fill();

            if (engine.Id == 0)
            {

            }
            else
            {
                if (carArr.DoesExist(engine))
                {
                    MessageBox.Show("You can not delete this engine, it is connected" +
                        " to 1 or more cars", "Can not delete engine",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this" +
                        " Engine? ", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        engine.Delete();
                        ClearForm();
                        EngineArrToForm(null);
                    }
                }
            }
        }

        public Engine SelectedEngine
        {
            get { return (listbox_Engine.SelectedItem as Engine); }
        }
    }
}
