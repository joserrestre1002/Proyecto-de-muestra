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
    public partial class Form1 : Form
    {

        
        class_slide_show slide_Show_Class = new class_slide_show();

        static Form1 _obj;
        public static Form1 Instace
        {

            get 
            {
                if(_obj == null )
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel pnl_container
        {
            get { return Panel_container; }
            set { Panel_container = value; }
        }

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            cursor_panel.Height = home_btn.Height;
            cursor_panel.Top = home_btn.Top;
        }




        private void home_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;

            cursor_panel.Height = home_btn.Height;
            cursor_panel.Top = home_btn.Top;
         

            home_uc home_ = new home_uc();
            home_.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(home_);
            Panel_container.Controls["home_uc"].BringToFront();

        }

        private void tests_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;
            cursor_panel.Height = tests_btn.Height;
            cursor_panel.Top = tests_btn.Top;
          

            option_test_uc test_Uc = new option_test_uc();
            test_Uc.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(test_Uc);
            Panel_container.Controls["option_test_uc"].BringToFront();

        }

        private void console_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;
            cursor_panel.Height = console_btn.Height;
            cursor_panel.Top = console_btn.Top;
          
            uc_keysight uc_Keysight = new uc_keysight();
            uc_Keysight.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(uc_Keysight);
            Panel_container.Controls["uc_keysight"].BringToFront();
        }

        private void manuals_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;

            cursor_panel.Height = manuals_btn.Height;
            cursor_panel.Top = manuals_btn.Top;

            uc_pdfviewer updf = new  uc_pdfviewer();
            updf.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(updf);
            Panel_container.Controls["uc_pdfviewer"].BringToFront();
        }

        private void files_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;

            cursor_panel.Height = files_btn.Height;
            cursor_panel.Top = files_btn.Top;
           
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;

            cursor_panel.Height = setting_btn.Height;
            cursor_panel.Top = setting_btn.Top;
           
            settings_uc settings_ = new settings_uc();
            settings_.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(settings_);
            Panel_container.Controls["settings_uc"].BringToFront();
        }

        private void shutdown_btn_Click(object sender, EventArgs e)

        {
            panel2.Visible = false;
            label1.Visible = false;

            cursor_panel.Height =shutdown_btn.Height;
            cursor_panel.Top = shutdown_btn.Top;

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }

      

        private void users_btn_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;

            cursor_panel.Height = users_btn.Height;
            cursor_panel.Top = users_btn.Top;
           
            
            User_uc user_Uc = new User_uc();
            user_Uc.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(user_Uc);
            Panel_container.Controls["User_uc"].BringToFront();

            reg_uc.Instace.disableVisible();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            try
            {
                serialPort1.Open();
            } 
            catch(Exception ex)
            {
                MessageBox.Show("escaner desconectado");  
            }

        }

        public void EnableButtons()
        {
            setting_btn.Enabled = true;
            files_btn.Enabled = true;
            console_btn.Enabled = true;
            manuals_btn.Enabled = true;
            shutdown_btn.Enabled = true;
            users_btn.Enabled = false;
        }

        public void usersLoginOk(string user)
        {
            lbl_user_loged.Enabled = true;
            lbl_user_loged.Visible = true;
            lbl_user_loged.Text = user;
            pnl_users.Enabled = true;
            pnl_users.Visible = true;
            btn_log_out.Enabled = true;
            btn_log_out.Visible = true;
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;

            setting_btn.Enabled = false;
            files_btn.Enabled = false;
            console_btn.Enabled = false;
            manuals_btn.Enabled = false;
            shutdown_btn.Enabled = false;
            users_btn.Enabled = false;

            lbl_user_loged.Enabled = false;
            lbl_user_loged.Visible = false;
            lbl_user_loged.Text =  "Logout";
            pnl_users.Enabled = false;
            pnl_users.Visible = false ;
            btn_log_out.Enabled = false;
            btn_log_out.Visible = false;
            users_btn.Enabled = true;

            User_uc user_Uc = new User_uc();
            user_Uc.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(user_Uc);
            Panel_container.Controls["User_uc"].BringToFront();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            string a = serialPort1.ReadTo("\r");
            test_window.Instace.enable_txt_function(a);
            uc_pdm_window.Instace.writePArt(a);
        }


        public void changeToEnglish()
        {
            tests_btn.Text = "Tests";
            console_btn.Text = "Console";
            manuals_btn.Text = "Manuals";
            files_btn.Text = "Files";
            setting_btn.Text= "Settings";
            shutdown_btn.Text = "Shutdown";
            users_btn.Text = "Users";

        }
    }
}
