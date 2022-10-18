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
using Kvaser.CanLib;
using SpreadsheetLight;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using ObjExcel = Microsoft.Office.Interop.Excel;

namespace Control_panel_test
{
    public partial class test_window : UserControl
    {

        int cycleCount = 0;


        class_kvaser_usb canInterface = new class_kvaser_usb();
        class_sequence_test sequence_Test = new class_sequence_test();
        public bool busStatus = false;
        int adress = 0x220;
        int DDadress = 0x227;
        byte[] message = { 0x0F, 0x02, 0xFC, 0x10, 0x3F, 0x32, 0x20, 0x1F };
        byte[] message2 = { 0x17, 0xB2, 0x0C, 0x10, 0x3E, 0xC8, 0x78, 0x3E };

        bool firm_flag = true;
        Int32[] canMesg= new Int32[8];
         public string[] arr = new string[11];
        public bool state= false;

        StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\secuencia panel control.txt");

        int read_counter = 0;
        int sequen_can_counter = 0;
        public test_window()
        {
            InitializeComponent();

            canMesg[0] = 15;
            canMesg[1] = 252;
            canMesg[2] = 06;
            canMesg[3] = 16;
            canMesg[4] = 63;
            canMesg[5] = 50;
            canMesg[6] = 32;
            canMesg[7] = 31;
        }

        static test_window _obj;
        public static test_window Instace
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new test_window();
                }
                return _obj;
            }
        }

        private void test_window_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        

        private void timer_can_Tick(object sender, EventArgs e)
        {
            canInterface.send_messge(adress, message);

            if (state)
            {
                canInterface.send_messge(DDadress,message2);
            }
            dump_message_loop(0);
        }

        private void Update_message()
        {
            for (int i = 0; i < 8; i++)
            {
                message[i] = decimal.ToByte(canMesg[i]);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            cycleCount += 1;
            data_grid_results.Rows.Clear();

            busSwitch_fnc();

            canMesg[0] = 15;
            canMesg[1] = 0;
            canMesg[2] = 0;
            canMesg[3] = 16;
            canMesg[4] = 63;
            canMesg[5] = 50;
            canMesg[6] = 32;
            canMesg[7] = 31;
            Update_message();
            sequence_Test.start_test_fnc();
        }

        private void btn_canBusSwitch_Click(object sender, EventArgs e)
        {
            int channelNumber = 0;

            if (busStatus == false)
            {
                canInterface.open_can_channel(0);
                
                btn_canBusSwitch.Text = "Turn bus OFF";
                busStatus = true;
            }

            else
            {
                canInterface.close_can_channel();
               
                busStatus = false;
                timer_can.Enabled = false;
               btn_canBusSwitch.Text = "Turn bus ON";
            }
        }

        public void dump_message_loop(int handle)
        {
            Canlib.canStatus status;

            byte[] data = new byte[8];
            int id;
            int dlc;
            int flags;
            long timestamp;

            status = Canlib.canReadWait(handle, out id, data, out dlc, out flags, out timestamp, 100);

            if (status == Canlib.canStatus.canOK)
            {
                DumpMessage(id, data, dlc, flags, timestamp);
            }
            else if (status != Canlib.canStatus.canERR_NOMSG)
            {
                check_status(status, "canReadWait");
                Canlib.canFlushReceiveQueue(handle);
            }

        }

        public void DumpMessage(int id, byte[] data, int dlc, int flags, long timestamp)
        {
            
            if ((flags & Canlib.canMSG_ERROR_FRAME) != 0)
            {
                
            }

            else
            {
                
               
                arr[0] = id.ToString("X");
                arr[1] = dlc.ToString();
                arr[2] = data[0].ToString("X");
                arr[3] = data[1].ToString("X");             
                arr[4] = data[2].ToString("X");
                arr[5] = data[3].ToString("X");
                arr[6] = data[4].ToString();               
                arr[7] = data[5].ToString("X");
                arr[8] = data[6].ToString("X");
                arr[9] = data[7].ToString("X");
                arr[10] = timestamp.ToString();

               Model_txt.Text = arr[0] + "/" + arr[1] + "/" + arr[2] + "/" + arr[3] + "/" + arr[4] + "/" + arr[5] + "/" + arr[6] + "/" + arr[7] + "/" + arr[8] + "/" + arr[9] + "/" + arr[10];

            }


            if (arr[0] == "310")
            {
                string completo = "";
                for (int i = 4; i <= 9; i++)
                {
                    completo += arr[i];
                }

                   parameters_test_uc.Instace.txt_readed_firmware.Text =  ConvertHex(completo);

                    

            }
        }

        public void check_status(Canlib.canStatus status, string method)
        {
            if (status < 0)
            {

            }
        }

        private void btn_change_msg_Click(object sender, EventArgs e)
        {

            canMesg[0] = 15;
            canMesg[1] = 0;
            canMesg[2] = 0;
            canMesg[3] = 16;
            canMesg[4] = 63;
            canMesg[5] = 50;
            canMesg[6] = 32;
            canMesg[7] = 31;
            Update_message();
        }

        public void start_fnc()
        {

            if (timer_can.Enabled == false)
            {
                Update_message();
                timer_can.Enabled = true;
                btn_start.Text = "Stop Message";
            }

            else
            {
                timer_can.Enabled = false;
                btn_start.Text = " Start Message";
            }
        }

        public void busSwitch_fnc()
        {
            int channelNumber = 0;

            if (busStatus == false)
            {
                canInterface.open_can_channel(0);

                btn_canBusSwitch.Text = "Turn bus OFF";
                busStatus = true;

                start_fnc();
            }

            else
            {
                canInterface.close_can_channel();

                busStatus = false;
                timer_can.Enabled = false;
                btn_canBusSwitch.Text = "Turn bus ON";
                start_fnc();
            }

        }

   
        public void fillDatagrid_fnc(string measure, string test_name, string test_result)
        {

            data_grid_results.Rows.Add(measure, test_name, test_result);
        }

        public static string ConvertHex(String hexString)
        {

            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;
                    if (i == 2 || i == 6)
                    {
                        ascii += "/";
                    }
                }

                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }

        private void timer_test_Tick(object sender, EventArgs e)
        {
            read_counter++;
            label5.Text = read_counter.ToString();
            string command = sr.ReadLine();
            sequence_Test.sequence_2_fnc(command);
        }


        public void timer_test_set(bool state)
        {

            if (state)
                timer_test.Enabled = state;
            else
                timer_test.Enabled = state;
        }

        public void timer_seq_can(bool state)
        {

            if (state)
               timer_sequen_Can.Enabled = state;
            else
                timer_sequen_Can.Enabled = state;
        }

        private void timer_sequen_Can_Tick(object sender, EventArgs e)
        {
            sequen_can_counter++;
            lbl_seque_can_count.Text = sequen_can_counter.ToString();
            string command = sr.ReadLine();
            sequence_Test.can_sequense_fnc(sequen_can_counter);
        }

        public void change_msg_fnc(Int32[] messg)
        {
            canMesg[0] = messg[0];
            canMesg[1] = messg[1];
            canMesg[2] = messg[2];
            canMesg[3] = messg[3];
            canMesg[4] = messg[4];
            canMesg[5] = messg[5];
            canMesg[6] = messg[6];
            canMesg[7] = messg[7];
            Update_message();
        }

        public string StringBetween(string Source, string Start, string End)
        {
            int StartIndex = Source.IndexOf(Start, 0) + Start.Length;
            int EndIndex = Source.IndexOf(End, StartIndex);
            return Source.Substring(StartIndex, EndIndex - StartIndex);

        }
        public void enable_txt_function(string model)
        {
            Model_txt.Text = model;

            switch(model)
                
            {
                case "[)>06P625-08977S1H31NDX0001V547623":

                    btn_start.Enabled = false;
                    if(checkBox2.Enabled == false)
                    { checkBox2.Enabled = true; }
                    checkBox5.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox1.Text = "625-08977";
                    checkBox2.Text = "625-08970";
                    checkBox3.Text = "625-08966";
                    checkBox4.Text = "625-08967";
             
                    if (StringBetween(model, "P","") == checkBox1.Text)
                    { 
                        checkBox1.Checked = true;         
                    }

                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    break;

                case "[)>06P625-08970S1B10NDX0325V547623":

                    if (StringBetween(model, "P", "") == checkBox2.Text && checkBox1.Text == "625-08977")
                    {
                        checkBox2.Checked = true;
                    }


                    if (checkBox1.Text == "625-08977" && checkBox2.Text == "625-08970" && checkBox3.Text == "625-08966" && checkBox4.Text == "625-08967" && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;

                case "[)>06S2201231A0450P625-08966V034701":

                    if (StringBetween(model, "P", "") == checkBox3.Text && checkBox1.Text == "625-08977")
                    {
                        checkBox3.Checked = true;
                    }


                    if (checkBox1.Text == "625-08977" && checkBox2.Text == "625-08970" && checkBox3.Text == "625-08966" && checkBox4.Text == "625-08967" && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;

                case "[)>06S2109161A1787P625-08967V034701":

                    if (StringBetween(model, "P", "") == checkBox4.Text && checkBox1.Text == "625-08977")
                    {
                        checkBox4.Checked = true;
                    }


                    if (checkBox1.Text == "625-08977" && checkBox2.Text == "625-08970" && checkBox3.Text == "625-08966" && checkBox4.Text == "625-08967" && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;

  //************************************************************************************************************************************************************************
  //************************************************************************************************************************************************************************
                case "[)>06P625-08838S1H31NDX0003V547623":
                    
                    btn_start.Enabled = false;
                    if (checkBox5.Enabled == false)
                    {
                         checkBox5.Enabled = true;
                    }
                    checkBox2.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox1.Text = "625-08838";                   
                    checkBox3.Text = "725-17067";
                    checkBox4.Text = "725-16205";
                    checkBox5.Text = "725-17068";

                    if (StringBetween(model, "P", "") == checkBox1.Text)
                    {
                        checkBox1.Checked = true;
                    }

                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    break;

                case "[)>06S2110181A0787P725-16205V034701":

                    if(StringBetween(model,"P", "") == checkBox4.Text && checkBox1.Text == "625-08838")
                    {
                        checkBox4.Checked = true;
                    }

                    if( checkBox1.Text == "625-08838"&& checkBox3.Text == "725-17067" && checkBox4.Text == "725-16205" && checkBox5.Text == "725-17068" && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                    {
                        if(btn_start.Enabled == false)
                        btn_start.Enabled = true;
                    }
                    break;

                case "[)>06S2110211A0275RP725-17068V034701":

                    if (StringBetween(model, "P", "") == checkBox5.Text && checkBox1.Text == "625-08838")
                    {
                        checkBox5.Checked = true;
                    }

                    if (checkBox1.Text == "625-08838" && checkBox3.Text == "725-17067" && checkBox4.Text == "725-16205" && checkBox5.Text == "725-17068" && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;

                case "[)>06S2107041A2356LP725-17067V034701":

                    if (StringBetween(model, "P", "") == checkBox3.Text && checkBox1.Text == "625-08838")
                    {
                        checkBox3.Checked = true;
                    }

                    if (checkBox1.Text == "625-08838" && checkBox3.Text == "725-17067" && checkBox4.Text == "725-16205" && checkBox5.Text == "725-17068" && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;

                //************************************************************************************************************************************************************************************************************************************************************************************
                //************************************************************************************************************************************************************************************************************************************************************************************

                case "[)>06P625-08980S1K23MDX0726V547623":
                   
                    btn_start.Enabled = false;
                    if (checkBox5.Enabled == false)
                    {
                        checkBox5.Enabled = true;
                    }
                    if(checkBox2.Enabled == false)
                    {
                        checkBox2.Enabled= true;
                    }

                    if (checkBox6.Enabled == false)
                    {
                        checkBox6.Enabled = true;
                    }

                    checkBox1.Text = "625-08980";  //panel
                    checkBox2.Text = "625-08823"; //pdm
                    checkBox3.Text = "725-17065"; //left deck
                    checkBox4.Text = "725-16205"; // left traction controller
                    checkBox5.Text = "725-17066"; //right deck  controller
                    checkBox6.Text = "725-16206";
                    if (StringBetween(model, "P", "") == checkBox1.Text)
                    {
                        checkBox1.Checked = true;
                    }

                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    break;

                case "[)>06S2106221A0647LP725-17065V034701":

                    if (StringBetween(model, "P", "") == checkBox3.Text && checkBox1.Text == "625-08980")
                    {
                        checkBox3.Checked = true;
                    }

                    if (checkBox1.Text == "625-08980" && checkBox2.Text == "625-08823" && checkBox3.Text == "725-17065" && checkBox4.Text == "725-16205" && checkBox5.Text == "725-17066" && checkBox6.Text == "725-16206" && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;

                case "[)>06P625-08823S1L22MDX0099V547623":

                    if (StringBetween(model, "P", "") == checkBox2.Text && checkBox1.Text == "625-08980")
                    {
                        checkBox2.Checked = true;
                    }

                    if (checkBox1.Text == "625-08980" && checkBox2.Text == "625-08823" && checkBox3.Text == "725-17065" && checkBox4.Text == "725-16205" && checkBox5.Text == "725-17066" && checkBox6.Text == "725-16206" && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;

                case "[)>06S2101191A0157RP725-17066V034701":

                    if (StringBetween(model, "P", "") == checkBox5.Text && checkBox1.Text == "625-08980")
                    {
                        checkBox5.Checked = true;
                    }

                    if (checkBox1.Text == "625-08980" && checkBox2.Text == "625-08823" && checkBox3.Text == "725-17065" && checkBox4.Text == "725-16205" && checkBox5.Text == "725-17066" && checkBox6.Text == "725-16206" && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;

                case "[)>06S2107051A2397P725-16205V034701":

                    if (StringBetween(model, "P", "") == checkBox4.Text && checkBox1.Text == "625-08980")
                    {
                        checkBox4.Checked = true;
                    }

                    if (checkBox1.Text == "625-08980" && checkBox2.Text == "625-08823" && checkBox3.Text == "725-17065" && checkBox4.Text == "725-16205" && checkBox5.Text == "725-17066" && checkBox6.Text == "725-16206" && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;
                case "[)>06S2012281A0674P725-16206V034701":

                    if (StringBetween(model, "P", "") == checkBox6.Text && checkBox1.Text == "625-08980")
                    {
                        checkBox6.Checked = true;
                    }

                    if (checkBox1.Text == "625-08980" && checkBox2.Text == "625-08823" && checkBox3.Text == "725-17065" && checkBox4.Text == "725-16205" && checkBox5.Text == "725-17066" && checkBox6.Text == "725-16206" && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true)
                    {
                        if (btn_start.Enabled == false)
                            btn_start.Enabled = true;
                    }
                    break;

            }

        }
        private void CreateExcel_fnc(string ruta)
        {
            ObjExcel.Application application = new ObjExcel.Application();
            Workbook BookObject = application.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet SheetObject = (Worksheet)application.ActiveSheet;

            application.Visible = false;

            foreach (DataGridViewColumn columna in data_grid_results.Columns )
            {
                SheetObject.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in data_grid_results.Rows)
                {
                    SheetObject.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;

                }
            }
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string Hour =DateTime.Now.ToString("hh mm tt");
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
            btn_start.Text = "Start tests";
            groupBox6.Text = "Control panel assembly";
            label1.Text = "WAITING...";
        }

        public void changeEspaniol()
        {

            label6.Text = "Total de ciclos (PCS)";
            label2.Text = "piezas buenas (PCS)";
            label3.Text = "peizas malas (PCS";
            label4.Text = "No. de parte";
            btn_start.Text = "Iniciar prueba";
            groupBox6.Text = "Ensamble panel de control";
            label1.Text = "ESPERANDO";
        }


        

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
