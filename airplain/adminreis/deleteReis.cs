using airplain.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace airplain.adminreis
{
    public partial class deleteReis : Form
    {
        public deleteReis()
        {
            InitializeComponent();
        }

        Connectionsql sql = new Connectionsql();
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (idreis.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Введите id, который хотите удалить !", "Введите id, который хотите удалить !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    DataTable dt = new DataTable();

                    Connectionsql conSql = new Connectionsql();


                    conSql.ReadXml(Application.StartupPath + "\\connection.xml");
                    dt = null;

                    dt = conSql.getdata($"SELECT * FROM public.f_delete({idreis.Text});");

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show($"Успешное удаление id{idreis.Text}");
                        Reis reis = new Reis();
                        this.Hide();
                        reis.Show();

                    } else
                    {
                        MessageBox.Show("Данный id не найден");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка удаления: " + ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reis reis = new Reis();
            this.Hide();
            reis.Show();

        }
    }
}
