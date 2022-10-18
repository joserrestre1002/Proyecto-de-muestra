namespace Control_panel_test
{
    partial class uc_pdfviewer
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
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.cmb_man = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(0, 68);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(1712, 874);
            this.pdfViewer1.TabIndex = 0;
            // 
            // cmb_man
            // 
            this.cmb_man.FormattingEnabled = true;
            this.cmb_man.Items.AddRange(new object[] {
            "34980A",
            "34922A",
            "34939A",
            "34950A"});
            this.cmb_man.Location = new System.Drawing.Point(3, 41);
            this.cmb_man.Name = "cmb_man";
            this.cmb_man.Size = new System.Drawing.Size(192, 21);
            this.cmb_man.TabIndex = 1;
            this.cmb_man.Text = "Manuales";
            this.cmb_man.SelectedIndexChanged += new System.EventHandler(this.cmb_man_SelectedIndexChanged);
            // 
            // uc_pdfviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.cmb_man);
            this.Controls.Add(this.pdfViewer1);
            this.Name = "uc_pdfviewer";
            this.Size = new System.Drawing.Size(1712, 945);
            this.ResumeLayout(false);

        }

        #endregion

        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.ComboBox cmb_man;
    }
}
