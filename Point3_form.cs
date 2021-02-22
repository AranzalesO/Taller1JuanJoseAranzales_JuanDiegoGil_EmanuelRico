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
    public partial class Point3_form : Form
    {
        public Point3_form()
        {
            InitializeComponent();
        }

        private void btn_return_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_home home = new Form_home();
            home.Show();
        }

        private void btn_empezar_votacion_Click(object sender, EventArgs e)
        {
            this.Close();
            Point3_voto_form point3Home = new Point3_voto_form();
            point3Home.Show();
        }
    }
}
