namespace GenerateKeyWindow
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTypeLegth = new System.Windows.Forms.Label();
            this.tbtKeyLength1 = new System.Windows.Forms.TextBox();
            this.lblType2 = new System.Windows.Forms.Label();
            this.tbtkeylength2 = new System.Windows.Forms.TextBox();
            this.btnGENERATEMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeLegth
            // 
            this.lblTypeLegth.AutoSize = true;
            this.lblTypeLegth.Location = new System.Drawing.Point(28, 24);
            this.lblTypeLegth.Name = "lblTypeLegth";
            this.lblTypeLegth.Size = new System.Drawing.Size(222, 13);
            this.lblTypeLegth.TabIndex = 0;
            this.lblTypeLegth.Text = "Введите длинну первого закрытого ключа";
            // 
            // tbtKeyLength1
            // 
            this.tbtKeyLength1.Location = new System.Drawing.Point(31, 52);
            this.tbtKeyLength1.Name = "tbtKeyLength1";
            this.tbtKeyLength1.Size = new System.Drawing.Size(61, 20);
            this.tbtKeyLength1.TabIndex = 1;
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Location = new System.Drawing.Point(28, 106);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(221, 13);
            this.lblType2.TabIndex = 2;
            this.lblType2.Text = "Введите длинну второго закрытого ключа";
            // 
            // tbtkeylength2
            // 
            this.tbtkeylength2.Location = new System.Drawing.Point(31, 131);
            this.tbtkeylength2.Name = "tbtkeylength2";
            this.tbtkeylength2.Size = new System.Drawing.Size(61, 20);
            this.tbtkeylength2.TabIndex = 3;
            // 
            // btnGENERATEMK
            // 
            this.btnGENERATEMK.Location = new System.Drawing.Point(31, 193);
            this.btnGENERATEMK.Name = "btnGENERATEMK";
            this.btnGENERATEMK.Size = new System.Drawing.Size(283, 66);
            this.btnGENERATEMK.TabIndex = 4;
            this.btnGENERATEMK.Text = "Сгенерировать!";
            this.btnGENERATEMK.UseVisualStyleBackColor = true;
            this.btnGENERATEMK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 291);
            this.Controls.Add(this.btnGENERATEMK);
            this.Controls.Add(this.tbtkeylength2);
            this.Controls.Add(this.lblType2);
            this.Controls.Add(this.tbtKeyLength1);
            this.Controls.Add(this.lblTypeLegth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeLegth;
        private System.Windows.Forms.TextBox tbtKeyLength1;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.TextBox tbtkeylength2;
        private System.Windows.Forms.Button btnGENERATEMK;
    }
}

