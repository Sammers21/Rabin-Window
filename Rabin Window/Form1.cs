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

namespace Rabin_Window
{
    interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        BigInteger SecretKeyOne { get; set; }
        BigInteger SecretKeyTwo { get; set; }
        
        void SetSymbolCount(int count);
        void SetByteCount(int count);
        void ShowForm();
        void SkipForm();
        void ToOpneKeyMode();
        void ToSecretKeyMode();
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
        event EventHandler GoToMenuClick;
        event EventHandler FileSaveAsClick;

    }

    public partial class MainForm : Form, IMainForm
    {
        #region IMainForm
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

        public string FilePath
        {
            get
            {
                return tbtFilePath.Text;
            }
        }

        public BigInteger SecretKeyOne
        {
            get
            {
                return BigInteger.Parse(tbtSecretKey1.Text);
            }

            set
            {
                tbtSecretKey1.Text = value + "";
            }
        }

        public BigInteger SecretKeyTwo
        {
            get
            {
                return BigInteger.Parse(tbtSecretKey2.Text);
            }

            set
            {
                tbtSecretKey2.Text = value + "";
            }
        }

        public event EventHandler ContentChanged;
        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler GoToMenuClick;
        public event EventHandler FileSaveAsClick;

        public void SetSymbolCount(int count)
        {
            lblNuberCount.Text = count + "";
        }
        public void SetByteCount(int count)
        {
            lblbyteCountNumber.Text = count + "";
        }
        public void ShowForm()
        {
            Visible = true;
        }
        public void SkipForm()
        {
            Visible = false;
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }



        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbtFilePath.Text = openFileDialog.FileName;

                if (FileOpenClick != null)
                    FileOpenClick(this, EventArgs.Empty);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null)
                FileOpenClick(this, EventArgs.Empty);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null)
                FileSaveClick(this, EventArgs.Empty);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (GoToMenuClick != null)
                GoToMenuClick(this, EventArgs.Empty);
          

        }

        private void tbtContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(this, EventArgs.Empty);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbtFilePath.Text = saveFileDialog.FileName;

                if (FileSaveAsClick != null)
                    FileSaveAsClick(this, EventArgs.Empty);
            }

        }
    }
}
