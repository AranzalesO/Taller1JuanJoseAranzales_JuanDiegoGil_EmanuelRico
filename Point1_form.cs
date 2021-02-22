using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop1JuanJoseAranzales_JuanDiegoGil_EmanuelRico
{
    public partial class Point1_form : Form
    {
        public Point1_form()
        {
            InitializeComponent();
        }

        private void btn_return_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_home form_home = new Form_home();
            form_home.Show();
        }
    }
}
