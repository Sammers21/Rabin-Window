using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateKeyWindow
{
    public partial class Form1 : Form
    {

        public int Key1
        {
            get
            {
                return int.Parse(tbtKeyLength1.Text);
            }
            set
            {
                tbtKeyLength1.Text = value + "";
            }
        }
        public int Key2
        {
            get
            {
                return int.Parse(tbtkeylength2.Text);
            }
            set
            {
                tbtkeylength2.Text = value + "";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbtkeylength2_TextChanged(object sender, EventArgs e)
        {
            /*if (Key2>50)
                MessageBox.Show(")*/
        }

        private void tbtKeyLength1_TextChanged(object sender, EventArgs e)
        {
            /*if (Key2>50)
           MessageBox.Show(")*/
        }
    }
}
