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
using System.Xml.Linq;
using airplain.adminreis;

namespace airplain
{
    public partial class Reis : Form
    {
        public Reis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtgetdata = new DataTable();

            Connectionsql conSql = new Connectionsql();

            conSql.ReadXml(Application.StartupPath + "\\connection.xml");

            dtgetdata = conSql.getdata("select *from f_select();");

            dvg.DataSource = dtgetdata;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (acitybtn.Text.Trim() == string.Empty && dcitybtn.Text.Trim() == string.Empty)
                {
                    DataTable dtgetdata = new DataTable();

                    Connectionsql conSql = new Connectionsql();

                    conSql.ReadXml(Application.StartupPath + "\\connection.xml");

                    dtgetdata = conSql.getdata("select *from f_select();");

                    dvg.DataSource = dtgetdata;
                }
                else if (acitybtn.Text.Trim() != string.Empty && dcitybtn.Text.Trim() == string.Empty)
                {
                    DataTable dtgetdata = new DataTable();

                    Connectionsql conSql = new Connectionsql();

                    conSql.ReadXml(Application.StartupPath + "\\connection.xml");

                    dtgetdata = conSql.getdata($"select *from f_search2('{acitybtn.Text}%');");

                    dvg.DataSource = dtgetdata;
                }
                else if ((acitybtn.Text.Trim() == string.Empty) && dcitybtn.Text.Trim() != string.Empty)
                {
                    DataTable dtgetdata = new DataTable();

                    Connectionsql conSql = new Connectionsql();

                    conSql.ReadXml(Application.StartupPath + "\\connection.xml");

                    dtgetdata = conSql.getdata($"select *from f_search1('{dcitybtn.Text}%');");

                    dvg.DataSource = dtgetdata;
                }
                else
                {

                    DataTable dt = new DataTable();

                    Connectionsql conSql = new Connectionsql();

                    conSql.ReadXml(Application.StartupPath + "\\connection.xml");

                    dt = conSql.getdata($"SELECT * FROM public.f_search3('{dcitybtn.Text}%','{acitybtn.Text}%');");

                    dvg.DataSource = dt;


                }
            }
            catch { }
            
        }

        private void redactbtn_Click(object sender, EventArgs e)
        {
            admReis admRe = new admReis();
            this.Hide();
            admRe.Show();
        }

        
    }
}
