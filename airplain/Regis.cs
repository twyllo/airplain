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
using Npgsql;

namespace airplain
{
    public partial class Regis : Form
    {
        
        
        

        public Regis()
        {
            InitializeComponent();
        }

        private void Regis_Load(object sender, EventArgs e)
        {
           
            NameTB.Text = SurenameTB.Text = PhoneTB.Text = PasswordTB.Text = null;
            NameTB.Focus();

        }
         

       
        private void btnRegis_Click(object sender, EventArgs e)
        
        {

            try
            {
                if (!(string.IsNullOrEmpty(NameTB.Text)
                        || string.IsNullOrEmpty(SurenameTB.Text)
                        || string.IsNullOrEmpty(PhoneTB.Text)
                        || string.IsNullOrEmpty(PasswordTB.Text)))
                {

                    DataTable dt = new DataTable();

                    Connectionsql conSql = new Connectionsql();

                    conSql.ReadXml(Application.StartupPath + "\\connection.xml");

                    dt = conSql.getdata($"select * from public.u_insert ('{SurenameTB.Text}', '{NameTB.Text}', '{PhoneTB.Text}', '{PasswordTB.Text}', {2});");

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Вы успешно зарегистрировались!");
                        login lg = new login();
                        this.Close();
                        lg.Show();
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
                
                MessageBox.Show("Ошибка регистрации: " + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           login reis = new login();
            this.Hide();
            reis.Show();
        }
    }
    
}
