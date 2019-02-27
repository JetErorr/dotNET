using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cmb_car_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_car.SelectedItem.ToString() == "Car1")
            {
                cmb_color.Text = "Please Select";
                cmb_color.Items.Add("R");
                cmb_color.Items.Add("G");
                cmb_color.Items.Add("B");
                lst_model.Items.Add("CarModel1");
                lst_model.Items.Add("CarModel2");
            }
            else
            {
                cmb_color.Text = "Please Select";
                cmb_color.Items.Add("RG");
                cmb_color.Items.Add("GB");
                cmb_color.Items.Add("BR");
                lst_model.Items.Add("Car2Model1");
                lst_model.Items.Add("Car2Model2");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmb_car.Text = "Please Select.!";
            cmb_car.Items.Add("Car1");
            cmb_car.Items.Add("Car2");
        }

        private void lst_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_car.SelectedItem.ToString() == "Car1")
            {
                if (lst_model.SelectedItem.ToString() == "CarModel1")
                {
                    textBox1.Text= "1000";
                }
                else if (lst_model.SelectedItem.ToString() == "CarModel2")
                {
                    textBox1.Text = "1000";
                }
            }
            if (cmb_car.SelectedItem.ToString() == "Car2")
            {
                if (lst_model.SelectedItem.ToString() == "Car2Model1")
                {
                    textBox1.Text = "1000";
                }
                else if (lst_model.SelectedItem.ToString() == "Car2Model2")
                {
                    textBox1.Text = "1000";
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello.!");
        }
    }
}
