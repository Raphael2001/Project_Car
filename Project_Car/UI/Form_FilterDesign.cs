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
    public partial class Form_FilterDesign : Form
    {
        public Form_FilterDesign()
        {
            InitializeComponent();

            CarColorArrToForm(null);
            ColorTypesArrToForm(null);
            BodyDesignArrToForm(null);

            ComboBoxSet();
        }

        public void CarColorArrToForm(CarColor curcarColor)
        {
            CarColorArr carColorArr = new CarColorArr();
            carColorArr.Fill();

            cmb_Color.DataSource = carColorArr;
            cmb_Color.ValueMember = "Id";
            cmb_Color.DisplayMember = "Name";

            if (curcarColor != null)
            {
                cmb_Color.SelectedValue = curcarColor.Id;
            }

        }

        public void ColorTypesArrToForm(ColorType curColorType)
        {
            ColorTypeArr colrTypeArr = new ColorTypeArr();
            colrTypeArr.Fill();

            cmb_ColorType.ValueMember = "Id";
            cmb_ColorType.DisplayMember = "Name";
            cmb_ColorType.DataSource = colrTypeArr;


            if (curColorType != null)
            {
                cmb_ColorType.SelectedValue = curColorType.Id;
            }


        }

        public void BodyDesignArrToForm(BodyDesign curBodyDesign)
        {
            BodyDesignArr BodyDesignArr = new BodyDesignArr();
            BodyDesignArr.Fill();

            cmb_Body.DataSource = BodyDesignArr;
            cmb_Body.ValueMember = "Id";
            cmb_Body.DisplayMember = "Name";

            if (curBodyDesign != null)
            {
                cmb_Body.SelectedValue = curBodyDesign.Id;
            }


        }

        public CarDesignArr GetDesigns()
        {
            CarColor carColor = null;
            ColorType colorTypes = null;
            BodyDesign bodyDesign = null;

            CarDesignArr carDesignArr = new CarDesignArr();
            carDesignArr.Fill();

            if(cmb_Color.SelectedIndex !=-1)
            {
                carColor = cmb_Color.SelectedItem as CarColor;
            }
            if(cmb_ColorType.SelectedIndex !=-1)
            {
                colorTypes = cmb_ColorType.SelectedItem as ColorType;
            }
            if(cmb_Body.SelectedIndex !=-1)
            {
                bodyDesign = cmb_Body.SelectedItem as BodyDesign;
            }

            return carDesignArr.Filter(carColor, colorTypes, bodyDesign);

        }

        private void Form_Filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ComboBoxSet()
        {
            foreach (Control c1 in this.Controls)

            {
                if (c1 is ComboBox)
                {

                    (c1 as ComboBox).DropDownStyle = ComboBoxStyle.DropDownList;

                    (c1 as ComboBox).DropDownHeight = (c1 as ComboBox).Font.Height * 10;

                    (c1 as ComboBox).SelectedIndex = -1;
                }
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
