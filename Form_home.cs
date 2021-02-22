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
    public partial class Form_home : Form
    {
        public Form_home()
        {
            InitializeComponent();
        }

        private void Form_home_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_point_1_Click(object sender, EventArgs e)
        {
            this.Close();
            Point1_form exercise1 = new Point1_form();
            exercise1.Show();
        }

        private void btn_close_program_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for use the program!");
            Application.Exit();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_team team = new Form_team();
            team.Show();
        }

        private void btn_point_2_Click(object sender, EventArgs e)
        {
            this.Close();
            Point2_form exercise2 = new Point2_form();
            exercise2.Show();
        }

        private void btn_point_3_Click(object sender, EventArgs e)
        {
            this.Close();
            Point3_form exercise3 = new Point3_form();
            exercise3.Show();
        }

        private void btn_point_4_Click(object sender, EventArgs e)
        {
            this.Close();
            Point4_form exercise4 = new Point4_form();
            exercise4.Show();
        }
    }
}
