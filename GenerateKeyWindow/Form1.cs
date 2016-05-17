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
        string Key1 { get; set; }
        string Key2 { get; set; }
        String pathOpenKey { get; set; }
        String pathSecretkey { get; set; }

        void ShowForm();
        void CloseFrom();



        event EventHandler PressOk;
    }
    public partial class Form1 : Form, IGenerateKeyWindow
    {
        public String pathOpenKey { get; set; }
        public String pathSecretkey { get; set; }

        public string Key1
        {
            get
            {
                return tbtKeyLength1.Text;
            }
            set
            {
                tbtKeyLength1.Text = value;
            }
        }
        public string Key2
        {
            get
            {
                return tbtkeylength2.Text;
            }
            set
            {
                tbtkeylength2.Text = value;
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
                pathSecretkey = saveFileDialog.FileName;
            }
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();

            saveFileDialog2.Filter = "Открытый ключ|*.openkey";

            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pathOpenKey = saveFileDialog2.FileName;
                if(PressOk!=null)
                {
                    PressOk(this, EventArgs.Empty);
                }
            }
        }

        private void tbtkeylength2_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Key1) > 50)
            {
                Key1 = 10+"";
                MessageBox.Show("Слишком большое количество симовов в ключе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtKeyLength1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Key2) > 50)
            {
                Key2 = 10+"";
                MessageBox.Show("Слишком большое количество симовов в ключе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowForm()
        {
            Visible = true;
            Key1 = 10+"";
            Key2 = 10+"";
        }

        public void CloseFrom()
        {
            Visible = false;
        }
     
    }
}
