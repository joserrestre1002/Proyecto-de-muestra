using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Control_panel_test
{
    public partial class panel_test_uc : UserControl
    {
        
        public panel_test_uc()
        {
            InitializeComponent();
        }

        static panel_test_uc _obj;
        public static panel_test_uc Instace
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new panel_test_uc();
                }
                return _obj;
            }
        }

        private void panel_test_uc_Load(object sender, EventArgs e)
        {
            _obj = this;

            
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
            
            if (!panel_test_uc.Instace.pnl_container_2.Controls.ContainsKey("test_window"))
            {
                test_window test_Window = new test_window();
                test_Window.Dock = DockStyle.Fill;
                panel_test_uc.Instace.pnl_container_2.Controls.Add(test_Window);
            }

            panel_test_uc.Instace.pnl_container_2.Controls["test_window"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!panel_test_uc.Instace.pnl_container_2.Controls.ContainsKey("parameters_test_uc"))
            {
                parameters_test_uc parameters_ = new parameters_test_uc();
                parameters_.Dock = DockStyle.Fill;
                panel_test_uc.Instace.pnl_container_2.Controls.Add(parameters_);
            }

            panel_test_uc.Instace.pnl_container_2.Controls["parameters_test_uc"].BringToFront();
        }
    
    }
}
