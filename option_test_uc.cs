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
    public partial class option_test_uc : UserControl
    {
        public option_test_uc()
        {
            InitializeComponent();
        }

        private void btn_panel_test_Click(object sender, EventArgs e)
        {
            Form1.Instace.panel2.Visible  = true;
            Form1.Instace.label1.Text = "Prueba panel de control";
            Form1.Instace.label1.Visible = true;

            
            if (!Form1.Instace.pnl_container.Controls.ContainsKey("panel_test_uc"))
            {

               panel_test_uc uC_PDM_Test = new panel_test_uc();
                uC_PDM_Test.Dock = DockStyle.Fill;
                Form1.Instace.pnl_container.Controls.Add(uC_PDM_Test);
            }


            Form1.Instace.pnl_container.Controls["panel_test_uc"].BringToFront();
            
        }

        private void btn_pdm_Click(object sender, EventArgs e)
        {
            Form1.Instace.panel2.Visible = true;
            Form1.Instace.label1.Text = "Prueba  de pdm";
            Form1.Instace.label1.Visible = true;


            if (!Form1.Instace.pnl_container.Controls.ContainsKey("uc_pdm_container"))
            {

               uc_pdm_container uc_Pdm_Container = new uc_pdm_container();
                uc_Pdm_Container.Dock = DockStyle.Fill;
                Form1.Instace.pnl_container.Controls.Add(uc_Pdm_Container);
            }


            Form1.Instace.pnl_container.Controls["uc_pdm_container"].BringToFront();


        }
    }
}
