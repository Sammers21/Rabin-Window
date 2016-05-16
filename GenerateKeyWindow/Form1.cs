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

    public interface IGenerateKeyWindow
    {
        int Key1 { get; set; }
        int Key2 { get; set; }
        String path { get; set; }

        void ShowForm();
        void CloseFrom();

        

        event EventHandler PressOk;
    }
    public partial class Form1 : Form, IGenerateKeyWindow
    {
        public String path { get; set; }

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

        public event EventHandler PressOk;

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Cекретный ключ|*.secretkey";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                if (PressOk != null)
                {
                    PressOk(this, EventArgs.Empty);
                }
            }
        }

        private void tbtkeylength2_TextChanged(object sender, EventArgs e)
        {
            if (Key1 > 50)
            {
                Key1 = 10;
                MessageBox.Show("Слишком большое количество симовов в ключе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } }

        private void tbtKeyLength1_TextChanged(object sender, EventArgs e)
        {
            if (Key2 > 50)
            {
                Key2 = 10;
                MessageBox.Show("Слишком большое количество симовов в ключе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowForm()
        {
            Visible = true;
            tbtKeyLength1.Text = "";
            tbtkeylength2.Text = "";
        }

        public void CloseFrom()
        {
            Visible = false;
        }
        public string Gen2Keys(int lenght1, int length2)
        {
            string res = "";
            return res;
        }
    }
}
