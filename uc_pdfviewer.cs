using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
namespace Control_panel_test
{
    public partial class uc_pdfviewer : UserControl
    {
        PdfiumViewer.PdfViewer view_pdf;
        public uc_pdfviewer()
        {
            InitializeComponent();
           view_pdf = new PdfViewer();

        }

        private void cmb_man_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexer = cmb_man.SelectedIndex;

            switch (indexer)
            {

                case 0:

                    break;

                case 1:
                    openFile_fnc("C:\\Users\\Admin\\Documents\\34922A Low Frequency Multiplexer Modules User’s .pdf");
                    break;

                case 2:
                    openFile_fnc("C:\\Users\\Admin\\Documents\\34939A General Purpose Switch Modules User’s.pdf");
                    break;

                case 3:
                    openFile_fnc("C:\\Users\\Admin\\Documents\\34950A Digital IO and Counter Module User’s Guide.pdf");
                    break;

            }
        }

        public void openFile_fnc(string Filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(Filepath);
            var stream = new System.IO.MemoryStream(bytes);
            PdfDocument pdfFile = PdfDocument.Load(stream);
            pdfViewer1.Document = pdfFile;

        }

    }
}
