using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using airplain.adminreis;

namespace airplain
{
    public partial class admReis : Form
    {
        public admReis()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            addReis add = new addReis();
            this.Hide();
            add.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            updateReis update = new updateReis();
            this.Hide();
            update.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            deleteReis delete = new deleteReis();
            this.Hide();
            delete.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reis reis = new Reis();
            this.Hide();
            reis.Show();
        }
    }
}
