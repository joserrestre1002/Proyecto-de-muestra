using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using Kvaser.CanLib; 
namespace Control_panel_test
{
    internal class class_sequence_test
    {
        class_keysight_instrument keysight_ = new class_keysight_instrument();
        class_process_data _Process_Data = new class_process_data();
        Int32[] can_messa = new Int32[8]; 
        string msg = "";
        public void start_test_fnc()
        {

            //encendemos fuente de pdm
            keysight_.Send("ROUT:CLOS (@3021)");
            string  result = keysight_.send_read("ROUTe:CLOSe? (@3021)");
            if (result == "1\n")
                msg = "PASS";
            else
                msg = "NO PASS";

            test_window.Instace.fillDatagrid_fnc(" ", "Powert supply 1 48v  ON", msg);
            test_window.Instace.timer_test_set(true);
        }


        public void  sequence_2_fnc(string command)
        {
            string result;
            string measure;
            string test_R;
            double m_value;
            switch (command)
            {
                case "ROUT:CLOS (@3024)":
                    keysight_.Send(command);
                    result = keysight_.send_read("ROUTe:CLOSe? (@3024)");
                    test_R = result == "1\n" ? "PASS" : "FAIL";
                    test_window.Instace.fillDatagrid_fnc("", "Power supply 2 48v  ON", test_R);
                    break;

                case "MEASure:VOLTage:DC? 100,0.001, (@1007)":
                     measure = keysight_.send_read(command);
                      m_value = _Process_Data.valuepow(measure, measure[0].ToString(), "E");
                     if (m_value >= 45.36 && m_value <= 50.4)
                       test_R = "PASS";
                      else
                      test_R = "NO PASS";
                    test_window.Instace.fillDatagrid_fnc(m_value.ToString(), "pin 10, B+ Test", test_R);
                    break;

                case "MEASure:VOLTage:DC? 100,0.001, (@1006)":
                    measure = keysight_.send_read(command);
                     m_value = _Process_Data.valuepow(measure, measure[0].ToString(), "E");
                    if (m_value >= 11.88 && m_value <= 12.12)
                        test_R = "PASS";
                    else
                        test_R = "NO PASS";
                    test_window.Instace.fillDatagrid_fnc(m_value.ToString(), "pin 6, 12v out", test_R);
                    break;

                case "MEASure:VOLTage:DC? 100,0.001, (@1004)":
                    measure = keysight_.send_read(command);
                    m_value = _Process_Data.valuepow(measure, measure[0].ToString(), "E");
                    if (m_value >= 11.88 && m_value <= 12.12)
                        test_R = "PASS";
                    else
                        test_R = "NO PASS";
                    test_window.Instace.fillDatagrid_fnc(m_value.ToString(), "pin 11, 12v AUX", test_R);
                    break;
                case "MEASure:VOLTage:DC? 100,0.001, (@1001)":
                    measure = keysight_.send_read(command);
                    m_value = _Process_Data.valuepow(measure, measure[0].ToString(), "E");
                    if (m_value >= 4.5 && m_value <= 5.5)
                        test_R = "PASS";
                    else
                        test_R = "NO PASS";
                    test_window.Instace.fillDatagrid_fnc(m_value.ToString(), "pin 7, Sensor+", test_R);
                    break;

                case "ROUT:CLOS (@3031)":
                    keysight_.Send(command);
                    result = keysight_.send_read("ROUTe:CLOSe? (@3031)");
                    test_R = result == "1\n" ? "PASS" : "FAIL";
                    test_window.Instace.fillDatagrid_fnc(" ", "pin 2, headlight gate ON", test_R);
                    break;

                case "MEASure:VOLTage:DC? 100,0.001, (@1002)":
                    measure = keysight_.send_read(command);
                    m_value = _Process_Data.valuepow(measure, measure[0].ToString(), "E");
                    if (m_value >= 4.5 && m_value <= 5.5)
                        test_R = "PASS";
                    else
                        test_R = "NO PASS";
                    test_window.Instace.fillDatagrid_fnc(m_value.ToString(), "pin 5 Headlight",test_R );
                    break;
                case "CAN BUSS":
                    break;

                case "ROUT:CLOS (@3002)":
                    keysight_.Send(command);
                    result = keysight_.send_read("ROUTe:CLOSe? (@3002)");
                    test_R = result == "1\n" ? "PASS" : "FAIL";
                    test_window.Instace.fillDatagrid_fnc("", "pin 8 precharge gate ON", test_R);
                   
                    
                    //Reportar voltaje can 

                    test_window.Instace.timer_test_set(false);
                    test_window.Instace.timer_seq_can(true);
                    break;

            }

        }


        public void can_sequense_fnc(int counter)
        {
            string result;
            string test_R;
            switch (counter)
            {
                case 4:
                    
                    keysight_.Send("ROUT:CLOS (@3032)");
                    result = keysight_.send_read("ROUTe:CLOSe? (@3032)");
                    test_R = result == "1\n" ? "PASS" : "FAIL";
                    test_window.Instace.fillDatagrid_fnc("", "pin 4 contactor gate 12v supply", test_R);
                    break;

                case 5:
                    keysight_.Send("ROUT:OPEN (@3002)");
                    result = keysight_.send_read("ROUTe:CLOSe? (@3002)");
                    test_R = result == "0\n" ? "PASS" : "FAIL";
                    test_window.Instace.fillDatagrid_fnc("", "pin 8 precharge gate OFF", test_R);
                    break;


                case 6:
                    
                    can_messa[0] =15 ;
                    can_messa[1] = 214;
                    can_messa[2] = 254;
                    can_messa[3] = 16;
                    can_messa[4] = 63;
                    can_messa[5] = 50;
                    can_messa[6] = 32;
                    can_messa[7] = 31;
 
                    test_window.Instace.change_msg_fnc(can_messa);
                  //Canlib.canFlushReceiveQueue(0);
                    break;
                case 10:
                    test_window.Instace.fillDatagrid_fnc(test_window.Instace.arr[3]+ test_window.Instace.arr[4], "RPM 25%  reverse speed", "");
                    can_messa[0] = 15;
                    can_messa[1] = 130;
                    can_messa[2] = 252;
                    can_messa[3] = 16;
                    can_messa[4] = 63;
                    can_messa[5] = 50;
                    can_messa[6] = 32;
                    can_messa[7] = 31;
                  
                    test_window.Instace.change_msg_fnc(can_messa);
                  //  Canlib.canFlushReceiveQueue(0);
                    break;

                case 16:
                    test_window.Instace.fillDatagrid_fnc(test_window.Instace.arr[3] + test_window.Instace.arr[4], "RPM 75% revers speed", "");
                    can_messa[0] = 15;
                    can_messa[1] = 0;
                    can_messa[2] = 0;
                    can_messa[3] = 16;
                    can_messa[4] = 63;
                    can_messa[5] = 50;
                    can_messa[6] = 32;
                    can_messa[7] = 31;
                    test_window.Instace.change_msg_fnc(can_messa);
                  //  Canlib.canFlushReceiveQueue(0);
                    break;

                case 17:
                   
                    can_messa[0] = 15;
                    can_messa[1] = 84;
                    can_messa[2] = 2;
                    can_messa[3] = 16;
                    can_messa[4] = 63;
                    can_messa[5] = 50;
                    can_messa[6] = 32;
                    can_messa[7] = 31;
                    test_window.Instace.change_msg_fnc(can_messa);
                   // Canlib.canFlushReceiveQueue(0);
                    break;
                case 25:
                    test_window.Instace.fillDatagrid_fnc(test_window.Instace.arr[3] + test_window.Instace.arr[4], "RPM 25%  reverse speed","");
                    
                    can_messa[0] = 15;
                    can_messa[1] = 252;
                    can_messa[2] = 06;
                    can_messa[3] = 16;
                    can_messa[4] = 63;
                    can_messa[5] = 50;
                    can_messa[6] = 32;
                    can_messa[7] = 31;
                    test_window.Instace.change_msg_fnc(can_messa);
                   // Canlib.canFlushReceiveQueue(0);
                    break;

                case 35:
                    test_window.Instace.fillDatagrid_fnc(test_window.Instace.arr[3] + test_window.Instace.arr[4], "RPM 75%  reverse speed", "");
                
                    can_messa[0] = 15;
                    can_messa[1] = 0;
                    can_messa[2] = 0;
                    can_messa[3] = 16;
                    can_messa[4] = 63;
                    can_messa[5] = 50;
                    can_messa[6] = 32;
                    can_messa[7] = 31;
                    test_window.Instace.change_msg_fnc(can_messa);
                  //  Canlib.canFlushReceiveQueue(0);
                    break;

                case 36:



                    break;

                case 37:

                    keysight_.Send("ROUT:OPEN (@3032)");
                    result = keysight_.send_read("ROUTe:OPEN? (@3032)");
                    test_R = result == "1\n" ? "PASS" : "FAIL";
                    test_window.Instace.fillDatagrid_fnc("", "pin 4 contactor gate 12v supply", test_R);
                    break;

            }

        }

    }
}
