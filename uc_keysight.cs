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
   

    public partial class uc_keysight : UserControl
    {

        class_keysight_instrument keysight_Instrument = new class_keysight_instrument();

        public uc_keysight()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
           txt_history.AppendText("->"+ keysight_Instrument.read()+"\r\n");
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            txt_history.AppendText("<- " + cmb_command.Text + "\r\n");
            keysight_Instrument.Send(cmb_command.Text + "\r\n");
        }

        private void btn_snd_read_Click(object sender, EventArgs e)
        {
            txt_history.AppendText("<- " + cmb_command.Text + "\r\n");
            txt_history.AppendText("-> " + keysight_Instrument.send_read(cmb_command.Text)+ "\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_history.Clear();
        }
    }
}
