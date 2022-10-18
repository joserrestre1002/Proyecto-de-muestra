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
    public partial class parameters_test_uc : UserControl
    {
        public parameters_test_uc()
        {
            InitializeComponent();
        }
        static parameters_test_uc _obj;
        public static parameters_test_uc Instace
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new parameters_test_uc();
                }
                return _obj;
            }
        }
        private void parameters_test_uc_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void txt_readed_firmware_TextChanged(object sender, EventArgs e)
        {
            if (txt_readed_firmware.Text != txt_manual_firmware.Text)
            {
                label1.Text = "El firmware no es igual";
            }

            else
                label1.Text = "Los firmware coinciden";
        }
    }
}
