namespace Control_panel_test
{
    partial class uc_keysight
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
            this.txt_history = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_snd_read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_command = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_history
            // 
            this.txt_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txt_history.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_history.ForeColor = System.Drawing.Color.White;
            this.txt_history.Location = new System.Drawing.Point(428, 162);
            this.txt_history.Multiline = true;
            this.txt_history.Name = "txt_history";
            this.txt_history.ReadOnly = true;
            this.txt_history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_history.Size = new System.Drawing.Size(851, 392);
            this.txt_history.TabIndex = 0;
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_read.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.ForeColor = System.Drawing.Color.Black;
            this.btn_read.Location = new System.Drawing.Point(428, 560);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(157, 41);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "READ";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.Black;
            this.btn_send.Location = new System.Drawing.Point(591, 560);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(157, 41);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_snd_read
            // 
            this.btn_snd_read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.btn_snd_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_snd_read.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_snd_read.ForeColor = System.Drawing.Color.Black;
            this.btn_snd_read.Location = new System.Drawing.Point(754, 560);
            this.btn_snd_read.Name = "btn_snd_read";
            this.btn_snd_read.Size = new System.Drawing.Size(178, 41);
            this.btn_snd_read.TabIndex = 3;
            this.btn_snd_read.Text = "SEND READ";
            this.btn_snd_read.UseVisualStyleBackColor = false;
            this.btn_snd_read.Click += new System.EventHandler(this.btn_snd_read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Console history";
            // 
            // cmb_command
            // 
            this.cmb_command.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_command.FormattingEnabled = true;
            this.cmb_command.Items.AddRange(new object[] {
            "ROUTe:CLOSe (@ 911, 912, 913, 914)",
            "ROUTe:CLOSe (@)",
            "ROUTe:CLOSe? (@)",
            "ROUTe:OPEN? (@)",
            "MEASure:VOLTage:DC? 1,0.001, (@)",
            "MEASure:VOLTage:DC? 10,0.001, (@)",
            "MEASure:VOLTage:DC? 100,0.001, (@)",
            "INITiate",
            "FETCh?",
            "CONFigure:VOLTage:DC 10,0.003,(@",
            "ROUTe:SCAN (@)",
            "MEASure:CURRent:DC? (@)",
            "SYSTem:MODule:WIRE:MODE WIRE",
            "DIAGnostic:RELay:CYCLes? (@)",
            "DIAGnostic:RELay:CYCLes:CLEar (@)",
            "SYSTem:CPON 1",
            "ROUT:OPEN (@)",
            "ROUT:CLOS (@)",
            "",
            ""});
            this.cmb_command.Location = new System.Drawing.Point(428, 616);
            this.cmb_command.Name = "cmb_command";
            this.cmb_command.Size = new System.Drawing.Size(688, 28);
            this.cmb_command.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(10)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(938, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "CLEAR HISTORY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc_keysight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_command);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_snd_read);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.txt_history);
            this.Name = "uc_keysight";
            this.Size = new System.Drawing.Size(1712, 945);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_history;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_snd_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_command;
        private System.Windows.Forms.Button button1;
    }
}
