namespace Control_panel_test
{
    partial class option_test_uc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pdm = new System.Windows.Forms.Button();
            this.btn_panel_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 837);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prueba para panel de cotrol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(918, 837);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prueba para pdm";
            // 
            // btn_pdm
            // 
            this.btn_pdm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdm.Image = global::Control_panel_test.Properties.Resources._4036b8f7_f0bf_4c70_a894_d367d84ba2001;
            this.btn_pdm.Location = new System.Drawing.Point(925, 184);
            this.btn_pdm.Name = "btn_pdm";
            this.btn_pdm.Size = new System.Drawing.Size(615, 650);
            this.btn_pdm.TabIndex = 1;
            this.btn_pdm.Text = "Control Panel Test";
            this.btn_pdm.UseVisualStyleBackColor = true;
            this.btn_pdm.Click += new System.EventHandler(this.btn_pdm_Click);
            // 
            // btn_panel_test
            // 
            this.btn_panel_test.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_panel_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_panel_test.Image = global::Control_panel_test.Properties.Resources._4036b8f7_f0bf_4c70_a894_d367d84ba2001;
            this.btn_panel_test.Location = new System.Drawing.Point(135, 184);
            this.btn_panel_test.Name = "btn_panel_test";
            this.btn_panel_test.Size = new System.Drawing.Size(615, 650);
            this.btn_panel_test.TabIndex = 0;
            this.btn_panel_test.Text = "Control Panel Test";
            this.btn_panel_test.UseVisualStyleBackColor = true;
            this.btn_panel_test.Click += new System.EventHandler(this.btn_panel_test_Click);
            // 
            // option_test_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pdm);
            this.Controls.Add(this.btn_panel_test);
            this.Name = "option_test_uc";
            this.Size = new System.Drawing.Size(1712, 950);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_panel_test;
        private System.Windows.Forms.Button btn_pdm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
