namespace Control_panel_test
{
    partial class test_window
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_start = new System.Windows.Forms.Button();
            this.NoGood_Txt = new System.Windows.Forms.TextBox();
            this.TotalCycl_txt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Model_txt = new System.Windows.Forms.TextBox();
            this.Good_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data_grid_results = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer_can = new System.Windows.Forms.Timer(this.components);
            this.btn_canBusSwitch = new System.Windows.Forms.Button();
            this.btn_change_msg = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.timer_test = new System.Windows.Forms.Timer(this.components);
            this.timer_sequen_Can = new System.Windows.Forms.Timer(this.components);
            this.lbl_seque_can_count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_results)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.White;
            this.btn_start.Enabled = false;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Yu Gothic UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(484, 350);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(268, 186);
            this.btn_start.TabIndex = 74;
            this.btn_start.Text = "Iniciar Prueba";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // NoGood_Txt
            // 
            this.NoGood_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoGood_Txt.Location = new System.Drawing.Point(13, 229);
            this.NoGood_Txt.Name = "NoGood_Txt";
            this.NoGood_Txt.ReadOnly = true;
            this.NoGood_Txt.Size = new System.Drawing.Size(165, 35);
            this.NoGood_Txt.TabIndex = 65;
            this.NoGood_Txt.Text = "0";
            // 
            // TotalCycl_txt
            // 
            this.TotalCycl_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCycl_txt.Location = new System.Drawing.Point(13, 83);
            this.TotalCycl_txt.Name = "TotalCycl_txt";
            this.TotalCycl_txt.ReadOnly = true;
            this.TotalCycl_txt.Size = new System.Drawing.Size(165, 35);
            this.TotalCycl_txt.TabIndex = 69;
            this.TotalCycl_txt.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.checkBox6);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.checkBox5);
            this.groupBox6.Controls.Add(this.checkBox4);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.checkBox3);
            this.groupBox6.Controls.Add(this.checkBox2);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(13, 347);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(465, 189);
            this.groupBox6.TabIndex = 72;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Partes del ensamble";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "R TRACTION CONTROLLER";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(233, 156);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(64, 24);
            this.checkBox6.TabIndex = 33;
            this.checkBox6.Text = "####";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "R DECK CONTROLLER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "L DECK CONTROLLER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "L TRACTION CONTROLLER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "PDM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "CONTROL PANEL";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(233, 131);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(64, 24);
            this.checkBox5.TabIndex = 27;
            this.checkBox5.Text = "####";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(233, 106);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(64, 24);
            this.checkBox4.TabIndex = 26;
            this.checkBox4.Text = "####";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(233, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 24);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "####";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(233, 78);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 24);
            this.checkBox3.TabIndex = 25;
            this.checkBox3.Text = "####";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(233, 53);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 24);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "####";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Model_txt
            // 
            this.Model_txt.BackColor = System.Drawing.Color.White;
            this.Model_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model_txt.Location = new System.Drawing.Point(13, 309);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(465, 31);
            this.Model_txt.TabIndex = 67;
            // 
            // Good_TXT
            // 
            this.Good_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Good_TXT.Location = new System.Drawing.Point(13, 159);
            this.Good_TXT.Name = "Good_TXT";
            this.Good_TXT.ReadOnly = true;
            this.Good_TXT.Size = new System.Drawing.Size(165, 35);
            this.Good_TXT.TabIndex = 64;
            this.Good_TXT.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 70;
            this.label6.Text = "Total de ciclos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(957, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 86);
            this.label1.TabIndex = 61;
            this.label1.Text = "WAITING...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 68;
            this.label4.Text = "QR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 63;
            this.label2.Text = "piezas buenas";
            // 
            // data_grid_results
            // 
            this.data_grid_results.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.data_grid_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid_results.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_grid_results.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_grid_results.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.data_grid_results.Location = new System.Drawing.Point(0, 542);
            this.data_grid_results.Name = "data_grid_results";
            this.data_grid_results.Size = new System.Drawing.Size(1712, 330);
            this.data_grid_results.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "piezas malas";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 872);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1712, 10);
            this.panel2.TabIndex = 59;
            // 
            // timer_can
            // 
            this.timer_can.Interval = 50;
            this.timer_can.Tick += new System.EventHandler(this.timer_can_Tick);
            // 
            // btn_canBusSwitch
            // 
            this.btn_canBusSwitch.Location = new System.Drawing.Point(1445, 479);
            this.btn_canBusSwitch.Name = "btn_canBusSwitch";
            this.btn_canBusSwitch.Size = new System.Drawing.Size(75, 23);
            this.btn_canBusSwitch.TabIndex = 75;
            this.btn_canBusSwitch.Text = "Turn Bus On";
            this.btn_canBusSwitch.UseVisualStyleBackColor = true;
            this.btn_canBusSwitch.Visible = false;
            this.btn_canBusSwitch.Click += new System.EventHandler(this.btn_canBusSwitch_Click);
            // 
            // btn_change_msg
            // 
            this.btn_change_msg.Location = new System.Drawing.Point(1615, 479);
            this.btn_change_msg.Name = "btn_change_msg";
            this.btn_change_msg.Size = new System.Drawing.Size(75, 23);
            this.btn_change_msg.TabIndex = 76;
            this.btn_change_msg.Text = "Change msg";
            this.btn_change_msg.UseVisualStyleBackColor = true;
            this.btn_change_msg.Visible = false;
            this.btn_change_msg.Click += new System.EventHandler(this.btn_change_msg_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(1526, 479);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(75, 23);
            this.btn_scan.TabIndex = 77;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Visible = false;
            // 
            // timer_test
            // 
            this.timer_test.Tick += new System.EventHandler(this.timer_test_Tick);
            // 
            // timer_sequen_Can
            // 
            this.timer_sequen_Can.Interval = 1000;
            this.timer_sequen_Can.Tick += new System.EventHandler(this.timer_sequen_Can_Tick);
            // 
            // lbl_seque_can_count
            // 
            this.lbl_seque_can_count.AutoSize = true;
            this.lbl_seque_can_count.BackColor = System.Drawing.Color.White;
            this.lbl_seque_can_count.Location = new System.Drawing.Point(465, 289);
            this.lbl_seque_can_count.Name = "lbl_seque_can_count";
            this.lbl_seque_can_count.Size = new System.Drawing.Size(13, 13);
            this.lbl_seque_can_count.TabIndex = 80;
            this.lbl_seque_can_count.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(465, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Test name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 500;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Measure";
            this.Column2.Name = "Column2";
            this.Column2.Width = 500;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Result";
            this.Column3.Name = "Column3";
            this.Column3.Width = 500;
            // 
            // test_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.lbl_seque_can_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.btn_change_msg);
            this.Controls.Add(this.btn_canBusSwitch);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.NoGood_Txt);
            this.Controls.Add(this.TotalCycl_txt);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.Model_txt);
            this.Controls.Add(this.Good_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_grid_results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Name = "test_window";
            this.Size = new System.Drawing.Size(1712, 882);
            this.Load += new System.EventHandler(this.test_window_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox NoGood_Txt;
        private System.Windows.Forms.TextBox TotalCycl_txt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox Model_txt;
        private System.Windows.Forms.TextBox Good_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_grid_results;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer_can;
        private System.Windows.Forms.Button btn_canBusSwitch;
        private System.Windows.Forms.Button btn_change_msg;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Timer timer_test;
        private System.Windows.Forms.Timer timer_sequen_Can;
        private System.Windows.Forms.Label lbl_seque_can_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
