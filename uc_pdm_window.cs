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

using SpreadsheetLight;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using ObjExcel = Microsoft.Office.Interop.Excel;

namespace Control_panel_test
{
    public partial class uc_pdm_window : UserControl
    {
        public uc_pdm_window()
        {
            InitializeComponent();
        }
       public  bool message = false;
        StreamReader sr;
        class_pdm_sequence pdm_Sequence = new class_pdm_sequence();
        bool FinalOk = false;
        int fail_count = 0;
        int pass_count = 0;
        int total_count = 0;

        static uc_pdm_window _obj;
        public static uc_pdm_window Instace
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new uc_pdm_window();
                }
                return _obj;
            }
        }

        private void uc_pdm_window_Load(object sender, EventArgs e)
        {
            _obj = this;
            message = true;
            changeLang();

        }


        public void fillDatagrid_fnc(string test_name,string measure, string test_result)
        {
            dataGridView1.Rows.Add(test_name, measure, test_result);
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
           
            sr = new StreamReader(@"C:\Users\Admin\Desktop\pdm_sequense.txt");
            timer_pdm.Enabled = true;
            dataGridView1.Rows.Clear();
            label1.Text = "TESTING";
            label1.ForeColor = Color.FromArgb(255,219,10);
            label1.Visible = true;
        }
        private void timer_pdm_Tick(object sender, EventArgs e)
        {
            string command = sr.ReadLine();
            pdm_Sequence.sequence(command);
        }

        public void timer_off()
        {
            timer_pdm.Enabled = false;
            sr.Close();
             
            if (FinalOk)
            {
                label1.Text = "FAIL";
                label1.ForeColor = Color.Red;
                fail_count++;
               NoGood_Txt.Text = fail_count.ToString();
                total_count++;
               TotalCycl_txt.Text = total_count.ToString();
                Model_txt.Clear();
            }

            else
            {
                label1.Text = "PASS";
                label1.ForeColor = Color.LightGreen;
                pass_count++;
                Good_TXT.Text = pass_count.ToString();
                total_count++;
                TotalCycl_txt.Text=  total_count.ToString();
                Model_txt.Clear();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Column3")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        if (Convert.ToString(e.Value) == "FAIL")
                        {
                            e.CellStyle.BackColor = Color.Red;
                            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            FinalOk = true;
                        }
                        else
                        {
                            e.CellStyle.BackColor = Color.LimeGreen;
                            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
        }


        public string StringBetween(string Source, string Start, string End)
        {
            
            
                int StartIndex = Source.IndexOf(Start, 0) + Start.Length;
                int EndIndex = Source.IndexOf(End, StartIndex);
               if(StartIndex != 0)
            {
                return Source.Substring(StartIndex, EndIndex - StartIndex);
            }

            return "0";

 
        }

        private void Model_txt_TextChanged(object sender, EventArgs e)
        {
            if(Model_txt.Text == comboBox1.Text)
            {
                btn_start.Enabled = true;
            }

            
            else if (Model_txt.Text  != comboBox1.Text && Model_txt.Text != "")
            {
                if (message)
                {
                   
                    Model_txt.Clear();
                    comboBox1.Focus();
                }
                
               
            }
        }

        public void writePArt(string stringRead)
        {
            Model_txt.Text = StringBetween(stringRead, "P", "");
        }

         public void changeLang()
         {
            
            label6.Text = "Total cycles (PCS)";
            label2.Text = "PASS cycles (PCS)";
            label3.Text = "FAIL cycles (PCS";
            label4.Text = "Part No.";
            comboBox1.Text = "Select part No.";
            btn_start.Text = "Start tests";
            label1.Text = "WAITING...";
         }

        private void CreateExcel_fnc(string ruta)
        {
            ObjExcel.Application application = new ObjExcel.Application();
            Workbook BookObject = application.Workbooks.Add(XlSheetType.xlWorksheet);
           
            Worksheet SheetObject = (Worksheet)application.ActiveSheet;
            application.Visible = false;

            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                SheetObject.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    SheetObject.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string Hour = DateTime.Now.ToString("hh mm tt");
            BookObject.SaveAs(ruta);
            BookObject.Close();
            application.Quit();
        }

        public void changeEnglish()
        {

            label6.Text = "Total cycles (PCS)";
            label2.Text = "PASS cycles (PCS)";
            label3.Text = "FAIL cycles (PCS";
            label4.Text = "Part No.";
            comboBox1.Text = "Select part No.";
            btn_start.Text = "Start tests";
          
        }

        public void changeEspaniol()
        {

            label6.Text = "Total de ciclos (PCS)";
            label2.Text = "Piezas buenas (PCS)";
            label3.Text = "Piezas malas (PCS";
            label4.Text = "No. de parte";
            comboBox1.Text = "Seleccione No. de parte";
            btn_start.Text = "Iniciar Prueba";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
