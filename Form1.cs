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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_program_Click(object sender, EventArgs e)
        {
            const string exitMessage = "Thanks for use the program!";
            MessageBox.Show(exitMessage);
            Application.Exit();
        }

        private void btn_start_program_Click(object sender, EventArgs e)
        {
            string username = txt_name.Text;
            string startMessage = "Hope you'll find this test enjoyable "+ username +"!!!";
            MessageBox.Show(startMessage);
            Program.Form1.Hide();
            Form form_home = new Form_home();
            form_home.Show();
        }
    }
}


