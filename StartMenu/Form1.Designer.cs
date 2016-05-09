namespace StartMenu
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnGoToRabin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 365);
            this.button1.TabIndex = 0;
            this.button1.Text = "У меня есть открытый ключ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGoToRabin
            // 
            this.btnGoToRabin.Location = new System.Drawing.Point(524, 62);
            this.btnGoToRabin.Name = "btnGoToRabin";
            this.btnGoToRabin.Size = new System.Drawing.Size(340, 365);
            this.btnGoToRabin.TabIndex = 1;
            this.btnGoToRabin.Text = "У меня есть закрытый ключ";
            this.btnGoToRabin.UseVisualStyleBackColor = true;
            this.btnGoToRabin.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 508);
            this.Controls.Add(this.btnGoToRabin);
            this.Controls.Add(this.button1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGoToRabin;
    }
}

