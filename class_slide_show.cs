using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_panel_test
{
    internal class class_slide_show
    {
        public void alert_fnc(string msg)
        {
            slide_show_form frm = new slide_show_form();
            frm.show_alert(msg);
        }
    }
}
