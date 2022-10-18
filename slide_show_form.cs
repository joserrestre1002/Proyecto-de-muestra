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
    public partial class slide_show_form : Form
    {
        public slide_show_form()
        {
            InitializeComponent();
        }

        public enum en_actions
        {
            wait, start, close
        }

        private slide_show_form.en_actions actions;
        private int x, y;

        //bool flag = false;

        private void slide_show_form_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(actions)
            {
                case en_actions.wait:
                    timer1.Interval = 3000;
                    actions = en_actions.close;
                    break;


                    case en_actions.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }

                    else
                    {
                         if(this.Opacity == 1.0)
                        {
                            actions = en_actions.wait;
                        }
                    }
                    break;

                case en_actions.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                            {
                        base.Close();
                    }
                    break;
            }


            /*
            if (flag == true)
            {
                timer1.Interval = 1;
                this.Opacity -= 0.1;
                this.Left -= 3;
                if(base.Opacity == 0.0)
                {
                    base.Close();
                    flag = false;
                }
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            actions = en_actions.close;
        }

        public void show_alert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            fname = "alert" + 7.ToString();
            slide_show_form  frm = (slide_show_form)Application.OpenForms[fname];

            if(frm == null)
            {
                this.Name = fname;
                this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * 7;
                this.Location = new Point(210, 130);
            }
            else 
            {
                this.Name = fname;
                this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * 7;
                this.Location = new Point(210,130);
            }

            this.label1.Text = msg;
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.Show();
            this.actions = en_actions.start;
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
