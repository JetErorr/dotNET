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
    public partial class frmLogin : Form
    {
        public frmLogin()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Wanna buy some batteries?");
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tb_user.Text == "admin" && tb_pass.Text == "12345")
            {
                Form2 fm = new Form2();
                fm.Show();
                //this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials.!");
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
