using airplain.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airplain.adminreis
{
    public partial class addReis : Form
    {
        public addReis()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(dcitybtn.Text)
                        || string.IsNullOrEmpty(acitybtn.Text)
                        || string.IsNullOrEmpty(dateTimePicker1.Text)
                        || string.IsNullOrEmpty(dateTimePicker2.Text)
                        || string.IsNullOrEmpty(idairline.Text)
                        || string.IsNullOrEmpty(idairplane.Text)))
                {

                    DataTable dt = new DataTable();

                    Connectionsql conSql = new Connectionsql();

                    conSql.ReadXml(Application.StartupPath + "\\connection.xml");

                    dt = conSql.getdata($"select * from public.f_insert ('{dateTimePicker1.Text}', '{dateTimePicker1.Text}', '{dcitybtn.Text}', '{acitybtn.Text}', {idairplane.Text}, {idairline.Text});");

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Вы успешно добавили рейс!");
                        admReis ld = new admReis();
                        this.Close();
                        ld.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка ввода!");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните данные.");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка добавления рейса: " + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reis reis = new Reis();
            this.Hide();
            reis.Show();
        }
    }
}
