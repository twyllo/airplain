namespace airplain
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.VhodBtn = new System.Windows.Forms.Button();
            this.Вход = new System.Windows.Forms.Label();
            this.regbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhoneTB
            // 
            this.PhoneTB.BackColor = System.Drawing.Color.Thistle;
            this.PhoneTB.Location = new System.Drawing.Point(324, 113);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(350, 29);
            this.PhoneTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.Thistle;
            this.PasswordTB.Location = new System.Drawing.Point(324, 158);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(350, 29);
            this.PasswordTB.TabIndex = 2;
            // 
            // VhodBtn
            // 
            this.VhodBtn.BackColor = System.Drawing.Color.Plum;
            this.VhodBtn.Location = new System.Drawing.Point(522, 227);
            this.VhodBtn.Name = "VhodBtn";
            this.VhodBtn.Size = new System.Drawing.Size(152, 42);
            this.VhodBtn.TabIndex = 3;
            this.VhodBtn.Text = "Войти";
            this.VhodBtn.UseVisualStyleBackColor = false;
            this.VhodBtn.Click += new System.EventHandler(this.VhodBtn_Click);
            // 
            // Вход
            // 
            this.Вход.AutoSize = true;
            this.Вход.BackColor = System.Drawing.Color.Thistle;
            this.Вход.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Вход.Location = new System.Drawing.Point(421, 54);
            this.Вход.Name = "Вход";
            this.Вход.Size = new System.Drawing.Size(157, 25);
            this.Вход.TabIndex = 2;
            this.Вход.Text = "Вход в систему";
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.Color.Plum;
            this.regbtn.Location = new System.Drawing.Point(324, 227);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(152, 42);
            this.regbtn.TabIndex = 4;
            this.regbtn.Text = "Регистрация";
            this.regbtn.UseVisualStyleBackColor = false;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 536);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.VhodBtn);
            this.Controls.Add(this.Вход);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.PhoneTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "login";
            this.Text = "Авиабилеты";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button VhodBtn;
        private System.Windows.Forms.Label Вход;
        private System.Windows.Forms.Button regbtn;
    }
}

