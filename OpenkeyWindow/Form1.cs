﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace OpenkeyWindow
{
    public interface IOpenKeyForm
    {
        string path { get; set; }
        string Content { get; set; }
        BigInteger OpenKey { get; set; }

        void SetSymbolCount(int count);
        void SetByteCount(int count);
        void ShowForm();
        void SkipForm();

        event EventHandler FileSaveAsClick;
        event EventHandler GoToMenuClick;
    }

    public partial class OpenKeyForm : Form, IOpenKeyForm
    {
        #region IOpenKeyForm

        public string Content
        {
            get
            {
                return tbtContent.Text;
            }

            set
            {
                tbtContent.Text = value;
            }
        }

        public BigInteger OpenKey
        {
            get
            {
                return BigInteger.Parse(tbtOpenKey.Text);
            }

            set
            {
                tbtOpenKey.Text = value + "";
            }
        }

        public string path
        {
            get;

            set;
        }

        public void SetSymbolCount(int count)
        {
            lblSymbolCount.Text = count + "";
        }

        public void SetByteCount(int count)
        {
            lblByte.Text = count + "";

        }
        public void ShowForm()
        {
            Visible = true;
        }

        public void SkipForm()
        {
            Visible = false;
        }


        public event EventHandler FileSaveAsClick;
        public event EventHandler GoToMenuClick;
        #endregion
        public OpenKeyForm()
        {
            InitializeComponent();
        }

        private void lblOpenkey_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;

                if (FileSaveAsClick != null)
                    FileSaveAsClick(this, EventArgs.Empty);
            }
        }

        private void btnGoToMenu_Click(object sender, EventArgs e)
        {
            if (GoToMenuClick != null)
                GoToMenuClick(this, EventArgs.Empty);
        }

       
    }
}