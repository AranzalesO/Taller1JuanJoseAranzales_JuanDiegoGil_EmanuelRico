using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop1JuanJoseAranzales_JuanDiegoGil_EmanuelRico
{
    //private List<Cuestionario> encuesta = new List<Cuestionario>();
    static class Program
    {
        /// <summary>
        /// As we know that the project it's build in Windows form, we put the develop of the excersices
        /// in the main entry point
        /// </summary>

        // Execute the app by Windows Forms
        public static Form1 Form1;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Form1 = new Form1());
        }
    }

}
