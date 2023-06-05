using System.Windows.Forms;

namespace airplain
{
    partial class Reis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reis));
            this.dvg = new System.Windows.Forms.DataGridView();
            this.acitybtn = new System.Windows.Forms.TextBox();
            this.dcitybtn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.redactbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg
            // 
            this.dvg.AllowUserToOrderColumns = true;
            this.dvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dvg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Location = new System.Drawing.Point(37, 82);
            this.dvg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvg.Name = "dvg";
            this.dvg.RowHeadersWidth = 72;
            this.dvg.RowTemplate.Height = 31;
            this.dvg.Size = new System.Drawing.Size(795, 332);
            this.dvg.TabIndex = 0;
            this.dvg.TabStop = false;
            
            // 
            // acitybtn
            // 
            this.acitybtn.Location = new System.Drawing.Point(148, 53);
            this.acitybtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acitybtn.Name = "acitybtn";
            this.acitybtn.Size = new System.Drawing.Size(176, 20);
            this.acitybtn.TabIndex = 2;
            // 
            // dcitybtn
            // 
            this.dcitybtn.Location = new System.Drawing.Point(148, 20);
            this.dcitybtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dcitybtn.Name = "dcitybtn";
            this.dcitybtn.Size = new System.Drawing.Size(176, 20);
            this.dcitybtn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Город вылета";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Город прилёта";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 3;
            this.button1.Tag = "";
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redactbtn
            // 
            this.redactbtn.Location = new System.Drawing.Point(740, 428);
            this.redactbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redactbtn.Name = "redactbtn";
            this.redactbtn.Size = new System.Drawing.Size(92, 28);
            this.redactbtn.TabIndex = 5;
            this.redactbtn.Tag = "";
            this.redactbtn.Text = "Редактировать";
            this.redactbtn.UseVisualStyleBackColor = true;
            this.redactbtn.Click += new System.EventHandler(this.redactbtn_Click);
            // 
            // Reis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 463);
            this.Controls.Add(this.redactbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dcitybtn);
            this.Controls.Add(this.acitybtn);
            this.Controls.Add(this.dvg);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Reis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рейсы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.dvg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.TextBox acitybtn;
        private System.Windows.Forms.TextBox dcitybtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button redactbtn;
    }
}