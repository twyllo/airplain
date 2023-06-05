namespace airplain.adminreis
{
    partial class deleteReis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.idreis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер рейса";
            // 
            // idreis
            // 
            this.idreis.Location = new System.Drawing.Point(206, 128);
            this.idreis.Name = "idreis";
            this.idreis.Size = new System.Drawing.Size(219, 29);
            this.idreis.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteReis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(626, 336);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idreis);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "deleteReis";
            this.ShowIcon = false;
            this.Text = "Удаление рейса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idreis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}