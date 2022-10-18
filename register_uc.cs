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
    public partial class reg_uc : UserControl
    {
        public reg_uc()
        {
            InitializeComponent();
        }


        static reg_uc _obj;
        public static reg_uc Instace
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new reg_uc();
                }
                return _obj;
            }
        }

        private void regsiter_btn_Click(object sender, EventArgs e)
        {
           
            if(name_txt.Text == "" || last_name_txt.Text == "" || number_txt.Text == "" || charge_txt.Text == "" || turn_txt.Text == "" || password_txt.Text == "" || admin_pass_txt.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos e intente nuevamente ");
                
            }
            else
            {
                if (admin_pass_txt.Text == "22051993")
                {
                    try
                    {
                        try
                        {
                            int acceso = Int32.Parse(txt_level.Text);

                            if (acceso > 0 && acceso < 4)
                            {

                                txt_level.Text = acceso.ToString();
                                StreamWriter sw = File.AppendText(@"C:\Program Files (x86)\FilesToReadC#_Poyect\users.txt");


                                sw.WriteLine(name_txt.Text + "/" + last_name_txt.Text + "/" + password_txt.Text + "/" + number_txt.Text + "/" + charge_txt.Text + "/" + turn_txt.Text + "/" + txt_level.Text + "/" + admin_pass_txt.Text);
                                sw.Close();
                                MessageBox.Show("Usuario agregado correctamente!");
                                cleanTxtBox();
                                show_login();
                                Form1.Instace.panel2.Visible = false;
                                Form1.Instace.label1.Visible = false;

                            }
                            else
                            {
                                MessageBox.Show("el nivel de acceso es del 1 al 3, 1 como menor nivel");
                                txt_level.Focus();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Introduce un numero del 1 al 4" + ex.Message);
                            txt_level.Focus();
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exepcion: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("La clave del administrador es incorrecta, No se puede agregar usuario");
                    admin_pass_txt.Clear();
                    admin_pass_txt.Focus();
                   

                }
            }

            

            disableVisible();
        }

        private void check_pass_btn_Click(object sender, EventArgs e)
        {
            if (password_txt.UseSystemPasswordChar == true)
                password_txt.UseSystemPasswordChar = false;
            else
                password_txt.UseSystemPasswordChar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instace.panel2.Visible = false;
            Form1.Instace.label1.Visible = false;

            if (!Form1.Instace.pnl_container.Controls.ContainsKey("User_uc"))
            {

                User_uc user_Uc = new User_uc();
                user_Uc.Dock = DockStyle.Fill;
                Form1.Instace.pnl_container.Controls.Add(user_Uc);
            }


            Form1.Instace.pnl_container.Controls["User_uc"].BringToFront();

            disableVisible();
            cleanTxtBox();
            
        }

        private void reg_uc_Load(object sender, EventArgs e)
        {
            _obj = this;
        }
    
          public void disableVisible()
          {
            error_pic7.Visible = false;
            error_pic6.Visible = false;
            error_pic5.Visible = false;
            error_pic4.Visible = false;
            error_pic3.Visible = false;
            error_pic2.Visible = false;
            error_pic.Visible = false;

          }
        public void cleanTxtBox()
        {
            name_txt.Clear();
            last_name_txt.Clear();
            password_txt.Clear();
            number_txt.Clear();
            charge_txt.Clear();
            turn_txt.Clear();
            admin_pass_txt.Clear();
        }

        public void show_login()
        {
            Form1.Instace.panel2.Visible = true;
            Form1.Instace.label1.Visible = true;

            if (!Form1.Instace.pnl_container.Controls.ContainsKey("User_uc"))
            {

               User_uc user_ = new User_uc();
                user_.Dock = DockStyle.Fill;
                Form1.Instace.pnl_container.Controls.Add(user_);
            }


            Form1.Instace.pnl_container.Controls["User_uc"].BringToFront();
        }

        private void txt_level_TextChanged(object sender, EventArgs e)
        {
         
           
           
        }
    }
}
