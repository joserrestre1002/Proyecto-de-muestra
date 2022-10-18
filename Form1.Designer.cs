namespace Control_panel_test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.top_panel = new System.Windows.Forms.Panel();
            this.pnl_users = new System.Windows.Forms.Panel();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.lbl_user_loged = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.windowed_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.maximized_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.logo_picBox = new System.Windows.Forms.PictureBox();
            this.buttons_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.users_btn = new System.Windows.Forms.Button();
            this.cursor_panel = new System.Windows.Forms.Panel();
            this.tests_btn = new System.Windows.Forms.Button();
            this.shutdown_btn = new System.Windows.Forms.Button();
            this.setting_btn = new System.Windows.Forms.Button();
            this.files_btn = new System.Windows.Forms.Button();
            this.manuals_btn = new System.Windows.Forms.Button();
            this.console_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.Panel_container = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            this.pnl_users.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picBox)).BeginInit();
            this.buttons_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Black;
            this.top_panel.Controls.Add(this.panel1);
            this.top_panel.Controls.Add(this.logo_picBox);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1920, 95);
            this.top_panel.TabIndex = 2;
            // 
            // pnl_users
            // 
            this.pnl_users.BackColor = System.Drawing.Color.Black;
            this.pnl_users.Controls.Add(this.btn_log_out);
            this.pnl_users.Controls.Add(this.lbl_user_loged);
            this.pnl_users.Enabled = false;
            this.pnl_users.Location = new System.Drawing.Point(483, 2);
            this.pnl_users.Name = "pnl_users";
            this.pnl_users.Size = new System.Drawing.Size(424, 48);
            this.pnl_users.TabIndex = 17;
            this.pnl_users.Visible = false;
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.Black;
            this.btn_log_out.Enabled = false;
            this.btn_log_out.FlatAppearance.BorderSize = 0;
            this.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log_out.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.btn_log_out.Location = new System.Drawing.Point(363, 2);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(58, 43);
            this.btn_log_out.TabIndex = 18;
            this.btn_log_out.Text = "cerrar sesion";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Visible = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lbl_user_loged
            // 
            this.lbl_user_loged.AutoSize = true;
            this.lbl_user_loged.BackColor = System.Drawing.Color.Black;
            this.lbl_user_loged.Enabled = false;
            this.lbl_user_loged.Font = new System.Drawing.Font("Yu Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_loged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.lbl_user_loged.Location = new System.Drawing.Point(3, 6);
            this.lbl_user_loged.Name = "lbl_user_loged";
            this.lbl_user_loged.Size = new System.Drawing.Size(167, 35);
            this.lbl_user_loged.TabIndex = 0;
            this.lbl_user_loged.Text = "User Loged";
            this.lbl_user_loged.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(913, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 48);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de nuevo usuario";
            this.label1.Visible = false;
            // 
            // windowed_btn
            // 
            this.windowed_btn.BackColor = System.Drawing.Color.Black;
            this.windowed_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.windowed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowed_btn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowed_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.windowed_btn.Image = global::Control_panel_test.Properties.Resources.icons8_maximize_button_32;
            this.windowed_btn.Location = new System.Drawing.Point(1347, 2);
            this.windowed_btn.Name = "windowed_btn";
            this.windowed_btn.Size = new System.Drawing.Size(35, 32);
            this.windowed_btn.TabIndex = 14;
            this.windowed_btn.UseVisualStyleBackColor = false;
            this.windowed_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Black;
            this.minimize_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.minimize_btn.Image = global::Control_panel_test.Properties.Resources.icons8_subtract_32;
            this.minimize_btn.Location = new System.Drawing.Point(1306, 2);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(35, 32);
            this.minimize_btn.TabIndex = 13;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // maximized_btn
            // 
            this.maximized_btn.BackColor = System.Drawing.Color.Black;
            this.maximized_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximized_btn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximized_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.maximized_btn.Image = global::Control_panel_test.Properties.Resources.icons8_Enlarge_32;
            this.maximized_btn.Location = new System.Drawing.Point(1388, 2);
            this.maximized_btn.Name = "maximized_btn";
            this.maximized_btn.Size = new System.Drawing.Size(35, 32);
            this.maximized_btn.TabIndex = 12;
            this.maximized_btn.UseVisualStyleBackColor = false;
            this.maximized_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Black;
            this.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.close_btn.Image = global::Control_panel_test.Properties.Resources.icons8_close_32;
            this.close_btn.Location = new System.Drawing.Point(1429, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(35, 32);
            this.close_btn.TabIndex = 11;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // logo_picBox
            // 
            this.logo_picBox.Image = global::Control_panel_test.Properties.Resources.sss___Copy1;
            this.logo_picBox.Location = new System.Drawing.Point(0, 0);
            this.logo_picBox.Name = "logo_picBox";
            this.logo_picBox.Size = new System.Drawing.Size(460, 75);
            this.logo_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_picBox.TabIndex = 1;
            this.logo_picBox.TabStop = false;
            // 
            // buttons_panel
            // 
            this.buttons_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.buttons_panel.Controls.Add(this.button1);
            this.buttons_panel.Controls.Add(this.users_btn);
            this.buttons_panel.Controls.Add(this.cursor_panel);
            this.buttons_panel.Controls.Add(this.tests_btn);
            this.buttons_panel.Controls.Add(this.shutdown_btn);
            this.buttons_panel.Controls.Add(this.setting_btn);
            this.buttons_panel.Controls.Add(this.files_btn);
            this.buttons_panel.Controls.Add(this.manuals_btn);
            this.buttons_panel.Controls.Add(this.console_btn);
            this.buttons_panel.Controls.Add(this.home_btn);
            this.buttons_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttons_panel.Location = new System.Drawing.Point(0, 95);
            this.buttons_panel.Name = "buttons_panel";
            this.buttons_panel.Size = new System.Drawing.Size(208, 985);
            this.buttons_panel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Control_panel_test.Properties.Resources.icons8_translation_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 69);
            this.button1.TabIndex = 13;
            this.button1.Text = "Lenguaje";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // users_btn
            // 
            this.users_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.users_btn.FlatAppearance.BorderSize = 0;
            this.users_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_btn.ForeColor = System.Drawing.Color.White;
            this.users_btn.Image = global::Control_panel_test.Properties.Resources.icons8_contacts_32;
            this.users_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.users_btn.Location = new System.Drawing.Point(10, 516);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(198, 69);
            this.users_btn.TabIndex = 12;
            this.users_btn.Text = "Usuarios";
            this.users_btn.UseVisualStyleBackColor = false;
            this.users_btn.Click += new System.EventHandler(this.users_btn_Click_1);
            // 
            // cursor_panel
            // 
            this.cursor_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(1)))));
            this.cursor_panel.Location = new System.Drawing.Point(0, 0);
            this.cursor_panel.Name = "cursor_panel";
            this.cursor_panel.Size = new System.Drawing.Size(10, 69);
            this.cursor_panel.TabIndex = 0;
            // 
            // tests_btn
            // 
            this.tests_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tests_btn.FlatAppearance.BorderSize = 0;
            this.tests_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tests_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tests_btn.ForeColor = System.Drawing.Color.White;
            this.tests_btn.Image = global::Control_panel_test.Properties.Resources.icons8_test_32;
            this.tests_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tests_btn.Location = new System.Drawing.Point(7, 75);
            this.tests_btn.Name = "tests_btn";
            this.tests_btn.Size = new System.Drawing.Size(198, 69);
            this.tests_btn.TabIndex = 11;
            this.tests_btn.Text = "Pruebas";
            this.tests_btn.UseVisualStyleBackColor = false;
            this.tests_btn.Click += new System.EventHandler(this.tests_btn_Click);
            // 
            // shutdown_btn
            // 
            this.shutdown_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.shutdown_btn.Enabled = false;
            this.shutdown_btn.FlatAppearance.BorderSize = 0;
            this.shutdown_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdown_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdown_btn.ForeColor = System.Drawing.Color.White;
            this.shutdown_btn.Image = global::Control_panel_test.Properties.Resources.icons8_shutdown_32;
            this.shutdown_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shutdown_btn.Location = new System.Drawing.Point(10, 441);
            this.shutdown_btn.Name = "shutdown_btn";
            this.shutdown_btn.Size = new System.Drawing.Size(198, 69);
            this.shutdown_btn.TabIndex = 10;
            this.shutdown_btn.Text = "Apagar";
            this.shutdown_btn.UseVisualStyleBackColor = false;
            this.shutdown_btn.Click += new System.EventHandler(this.shutdown_btn_Click);
            // 
            // setting_btn
            // 
            this.setting_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.setting_btn.Enabled = false;
            this.setting_btn.FlatAppearance.BorderSize = 0;
            this.setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_btn.ForeColor = System.Drawing.Color.White;
            this.setting_btn.Image = global::Control_panel_test.Properties.Resources.icons8_settings_321;
            this.setting_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting_btn.Location = new System.Drawing.Point(10, 366);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(198, 69);
            this.setting_btn.TabIndex = 9;
            this.setting_btn.Text = "Ajustes";
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // files_btn
            // 
            this.files_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.files_btn.Enabled = false;
            this.files_btn.FlatAppearance.BorderSize = 0;
            this.files_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.files_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.files_btn.ForeColor = System.Drawing.Color.White;
            this.files_btn.Image = global::Control_panel_test.Properties.Resources.icons8_microsoft_excel_321;
            this.files_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.files_btn.Location = new System.Drawing.Point(10, 291);
            this.files_btn.Name = "files_btn";
            this.files_btn.Size = new System.Drawing.Size(198, 69);
            this.files_btn.TabIndex = 8;
            this.files_btn.Text = "Archivos ";
            this.files_btn.UseVisualStyleBackColor = false;
            this.files_btn.Click += new System.EventHandler(this.files_btn_Click);
            // 
            // manuals_btn
            // 
            this.manuals_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.manuals_btn.Enabled = false;
            this.manuals_btn.FlatAppearance.BorderSize = 0;
            this.manuals_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manuals_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuals_btn.ForeColor = System.Drawing.Color.White;
            this.manuals_btn.Image = global::Control_panel_test.Properties.Resources.icons8_pdf_322;
            this.manuals_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manuals_btn.Location = new System.Drawing.Point(10, 216);
            this.manuals_btn.Name = "manuals_btn";
            this.manuals_btn.Size = new System.Drawing.Size(198, 69);
            this.manuals_btn.TabIndex = 7;
            this.manuals_btn.Text = "Manuales";
            this.manuals_btn.UseVisualStyleBackColor = false;
            this.manuals_btn.Click += new System.EventHandler(this.manuals_btn_Click);
            // 
            // console_btn
            // 
            this.console_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.console_btn.Enabled = false;
            this.console_btn.FlatAppearance.BorderSize = 0;
            this.console_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.console_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console_btn.ForeColor = System.Drawing.Color.White;
            this.console_btn.Image = global::Control_panel_test.Properties.Resources.icons8_console_321;
            this.console_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.console_btn.Location = new System.Drawing.Point(7, 141);
            this.console_btn.Name = "console_btn";
            this.console_btn.Size = new System.Drawing.Size(198, 69);
            this.console_btn.TabIndex = 6;
            this.console_btn.Text = "Keysight";
            this.console_btn.UseVisualStyleBackColor = false;
            this.console_btn.Click += new System.EventHandler(this.console_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = global::Control_panel_test.Properties.Resources.icons8_home_321;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(10, 0);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(198, 69);
            this.home_btn.TabIndex = 5;
            this.home_btn.Text = "Inicio";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // Panel_container
            // 
            this.Panel_container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_container.Location = new System.Drawing.Point(208, 95);
            this.Panel_container.Name = "Panel_container";
            this.Panel_container.Size = new System.Drawing.Size(1712, 985);
            this.Panel_container.TabIndex = 4;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.windowed_btn);
            this.panel1.Controls.Add(this.pnl_users);
            this.panel1.Controls.Add(this.minimize_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.maximized_btn);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Location = new System.Drawing.Point(456, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 75);
            this.panel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Panel_container);
            this.Controls.Add(this.buttons_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.top_panel.ResumeLayout(false);
            this.pnl_users.ResumeLayout(false);
            this.pnl_users.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picBox)).EndInit();
            this.buttons_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo_picBox;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel buttons_panel;
        private System.Windows.Forms.Button console_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Panel cursor_panel;
        private System.Windows.Forms.Button tests_btn;
        private System.Windows.Forms.Button shutdown_btn;
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Button files_btn;
        private System.Windows.Forms.Button manuals_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button users_btn;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button maximized_btn;
        private System.Windows.Forms.Button windowed_btn;
        private System.Windows.Forms.Panel Panel_container;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_users;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Label lbl_user_loged;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
    }
}

