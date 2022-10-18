namespace Control_panel_test
{
    partial class parameters_test_uc
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
            this.txt_readed_firmware = new System.Windows.Forms.TextBox();
            this.txt_manual_firmware = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_readed_firmware
            // 
            this.txt_readed_firmware.Location = new System.Drawing.Point(3, 34);
            this.txt_readed_firmware.Name = "txt_readed_firmware";
            this.txt_readed_firmware.Size = new System.Drawing.Size(153, 20);
            this.txt_readed_firmware.TabIndex = 0;
            this.txt_readed_firmware.TextChanged += new System.EventHandler(this.txt_readed_firmware_TextChanged);
            // 
            // txt_manual_firmware
            // 
            this.txt_manual_firmware.Location = new System.Drawing.Point(0, 60);
            this.txt_manual_firmware.Name = "txt_manual_firmware";
            this.txt_manual_firmware.Size = new System.Drawing.Size(156, 20);
            this.txt_manual_firmware.TabIndex = 1;
            this.txt_manual_firmware.Text = "21/06/05";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firmware setup ";
            // 
            // parameters_test_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_manual_firmware);
            this.Controls.Add(this.txt_readed_firmware);
            this.Name = "parameters_test_uc";
            this.Size = new System.Drawing.Size(1659, 754);
            this.Load += new System.EventHandler(this.parameters_test_uc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_readed_firmware;
        public System.Windows.Forms.TextBox txt_manual_firmware;
        private System.Windows.Forms.Label label1;
    }
}
