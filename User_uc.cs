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
    public partial class User_uc : UserControl
    {
        
         
        public User_uc()
        {
            InitializeComponent();
        }

        private void regsiter_btn_Click(object sender, EventArgs e)
        {
            Form1.Instace.panel2.Visible = true;
            Form1.Instace.label1.Visible = true;
            Form1.Instace.label1.Text = "Registro de nuevo usuario";

            if (!Form1.Instace.pnl_container.Controls.ContainsKey("reg_uc"))
            {

                reg_uc uC_PDM_Test = new reg_uc();
                uC_PDM_Test.Dock = DockStyle.Fill;
                Form1.Instace.pnl_container.Controls.Add(uC_PDM_Test);
            }

            
           Form1.Instace.pnl_container.Controls["reg_uc"].BringToFront();
         
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(txt_user.Text !="" && txt_pass.Text !="")
            {
                bool userFlag = true;
                string name = txt_user.Text;
                string pass = txt_pass.Text;

                string[] keysight_commands;

                string all_command_line = "";

                try
                {
                    StreamReader sr = new StreamReader(@"C:\Program Files (x86)\FilesToReadC#_Poyect\users.txt");
                    // line = sr.ReadLine();
                    all_command_line = sr.ReadLine();
                    while (all_command_line != null && userFlag)
                    {



                        keysight_commands = all_command_line.Split('/');


                        if (keysight_commands[0] == name && keysight_commands[2] == pass)
                        {
                            MessageBox.Show("Usuario encontrado! ya puede acceder");
                            userFlag = false;
                            Form1.Instace.EnableButtons();
                            txt_user.Clear();
                            txt_pass.Clear();
                            Form1.Instace.usersLoginOk("Usuario: " + keysight_commands[0] + " " + keysight_commands[1]);
                            showhome();
                        }
                        all_command_line = sr.ReadLine();

                    }


                    sr.Close();


                   
                   


                    if (userFlag == true)
                    {
                        MessageBox.Show("El usuario ingresado no existe o la clave es incorrecta");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exeption: " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("No se agrego ningún usuario o contraseña valido");
            }
            
        }


        public void showhome()
        {
            if (!Form1.Instace.pnl_container.Controls.ContainsKey("home_uc"))
            {

                home_uc home_Uc = new home_uc();
                home_Uc.Dock = DockStyle.Fill;
                Form1.Instace.pnl_container.Controls.Add(home_Uc);
            }


            Form1.Instace.pnl_container.Controls["home_uc"].BringToFront();

        }
    }
}
