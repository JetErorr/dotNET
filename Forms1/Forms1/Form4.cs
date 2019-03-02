using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Forms1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ("txt files|*.txt|(All Files)|(*.*)");
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel){
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }
    }
}
