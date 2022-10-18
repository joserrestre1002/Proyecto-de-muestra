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
    public partial class settings_uc : UserControl
    {
        public settings_uc()
        {
            InitializeComponent();
        }

        private void btn_lang_1_Click(object sender, EventArgs e)
        {
            if (lbl_alter_lang.Text == "English")
            {
                lbl_alter_lang.Text = "Español"; 
                write_file_lang("0");
            }

            else
            {

                write_file_lang("1");
                lbl_alter_lang.Text = "English";
            }
        }

        private void btn_lang_2_Click(object sender, EventArgs e)
        {
            if (lbl_alter_lang.Text == "English")
            {
                lbl_alter_lang.Text = "Español";
                write_file_lang("1");
            }

            else
            {

                write_file_lang("0");
                lbl_alter_lang.Text = "English";
            }
        }

        public void write_file_lang(string value)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Documents\testlist\control-panel-test\lang_state.txt");
                sw.WriteLine(value);
                sw.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public void change_spaniol()
        {
            lbl_language.Text = "Lenguaje";
            
        }
    
        public void change_english()
        {
            lbl_language.Text = "Language";
        }

        private void settings_uc_Load(object sender, EventArgs e)
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Admin\Documents\testlist\control-panel-test\lang_state.txt");
                line = sr.ReadLine();
                sr.Close();
                
                //ingles 
                if(line == "1")
                {
                    lbl_alter_lang.Text= "English";
                    change_english();
                }

                //espaniol
                else
                {
                    lbl_alter_lang.Text = "Español";
                    change_spaniol();
                }    
            }

            catch
            {

            }
        }

       
    }

}
