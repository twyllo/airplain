using airplain.Class;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airplain
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        Connectionsql sql = new Connectionsql();

        private void login_Load(object sender, EventArgs e)
        {
            PhoneTB.Text = string.Empty;
            PasswordTB.Text = string.Empty;
            PhoneTB.Focus();
        }

        private void VhodBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PhoneTB.Text.Trim() == string.Empty ||  PhoneTB.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Введите номер телефона и пароль , Пожалуйста повторите !", "Введите номер телефона и пароль , Пожалуйста повторите !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    

                    DataTable dt = new DataTable();

                    Connectionsql conSql = new Connectionsql();

                    conSql.ReadXml(Application.StartupPath + "\\connection.xml");

                    dt = conSql.getdata($"SELECT * FROM public.user \r\n WHERE u_phone = '{PhoneTB.Text}' \r\n AND u_password = '{PasswordTB.Text}';") ;

                    if (dt.Rows.Count > 0)
                    {
                        if (Int64.Parse(PhoneTB.Text) == 89966401663 || Int64.Parse(PasswordTB.Text) == 1663 )
                        {
                            this.Hide();
                            Reis frm = new Reis();
                            frm.Show();
                        }
                        else
                        {
                         this.Hide();
                        Reis frm = new Reis();
                        frm.Show();
                        }  
                    }
                    else
                    {
                        
                        MessageBox.Show("Неправильный номер телефона и пароль , Пожалуйста повторите !", "Неправильный номер телефона и пароль , Пожалуйста повторите!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regis frm = new Regis();
            frm.Show();
        }
    }
}
