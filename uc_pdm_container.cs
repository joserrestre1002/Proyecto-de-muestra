using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_panel_test
{
    public partial class uc_pdm_container : UserControl
    {
        public uc_pdm_container()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1.Instace.panel2.Visible = false;
            Form1.Instace.label1.Visible = false;

            if (!Form1.Instace.pnl_container.Controls.ContainsKey("option_test_uc"))
            {
                option_test_uc option_Test = new option_test_uc();
                option_Test.Dock = DockStyle.Fill;
                Form1.Instace.pnl_container.Controls.Add(option_Test);
            }

            Form1.Instace.pnl_container.Controls["option_test_uc"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!pnl_container_2.Controls.ContainsKey("uc_pdm_window"))
            {
                uc_pdm_window test_Window = new uc_pdm_window();
                test_Window.Dock = DockStyle.Fill;
               pnl_container_2.Controls.Add(test_Window);
            }

             pnl_container_2.Controls["uc_pdm_window"].BringToFront();
        }



        public void changelangEspaniol()
        {
            btn_back.Text = "Regresar";
            button1.Text = "Ventana de pruebas";
            button2.Text = "Resultados y configuracion";

        }

        public void changelangEnglish()
        {
            btn_back.Text = "Back";
            button1.Text = "Test Window";
            button2.Text = "Results and settings";

        }
    }
}
