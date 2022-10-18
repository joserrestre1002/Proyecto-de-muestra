using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_panel_test
{
    internal class class_pdm_sequence
    {
        class_keysight_instrument keysight = new class_keysight_instrument();
        class_process_data process_Data = new class_process_data();
        int c_test5 = 0;
        int c_test9 = 0;
        public void sequence(string command)
        {
            try
            {

                switch (command)
                {
                    case "ROUT:CLOS (@3021)":

                        test("48v power supply 1 ON", command, "ROUTe:CLOSe? (@3021)");
                        break;
                    case "ROUT:CLOS (@3024)":
                        test("48v power supply 2 ON", command, "ROUTe:CLOSe? (@3024)");
                        break;
                        /*
                    case "ROUT:CLOS (@3018)":
                        test("12v power supply ON", command, "ROUTe:CLOSe? (@3018)");
                        break;*/

                    case "MEASure:VOLTage:DC? 20,0.001, (@1006)":
                        measure_test("pin 7, sensor+ Test", command, 4.75, 5.25);
                        break;

                    case "ROUT:CLOS (@3016)":
                        test("20 ohms load ON", command, "ROUTe:CLOSe? (@3016)");
                        break;

                    case "ROUT:OPEN (@3016)":
                        relay_open("20 ohms load OFF", command, "ROUTe:CLOSe? (@3016)");
                        break;
/*
                    case "MEASure:VOLTage:DC? 10,0.001, (@1002)":
                        if (c_test5 == 0)
                        {
                            measure_test("pin 5, headlight Test", command, 0, 0.5);
                            c_test5++;
                        }
                        else
                        {
                            measure_test("pin 5, headlight Test", command, 11.4, 12.6);
                            c_test5 = 0;
                        }

                        break;*/

                    case "ROUT:CLOS (@3031)":
                        test("Pin 2, headlight ON", command, "ROUTe:CLOSe? (@3031)");
                        break;

                    case "ROUT:CLOS (@3013)":
                        test("25 ohms load ON", command, "ROUTe:CLOSe? (@3013)");
                        break;

                    case "ROUT:OPEN (@3031)":
                        relay_open("Pin 2, headlight OFF", command, "ROUTe:CLOSe? (@3031)");
                        break;
                    case "ROUT:OPEN (@3013)":
                        relay_open("25 ohms load OFF", command, "ROUTe:CLOSe? (@3013)");
                        break;
                    case "MEASure:VOLTage:DC? 100,0.001, (@1003)":

                        if (c_test9 == 0)
                        {
                            measure_test("pin 9, precharge gate Test", command, 0, 0.5);
                            c_test9++;
                        }
                        else
                        {
                            measure_test("pin 9, precharge gate Test", command, 32, 50);
                            c_test9 = 0;
                        }

                        break;

                    case "ROUT:CLOS (@3002)":
                        test("Pin 8, precharge gate ON", command, "ROUTe:CLOSe? (@3002)");
                        break;

                    case "ROUT:CLOS (@3010)":
                        test("200 ohms load ON", command, "ROUTe:CLOSe? (@3010)");
                        break;

                    case "ROUT:OPEN (@3002)":
                        relay_open("Pin 8, precharge gate OFF", command, "ROUTe:CLOSe? (@3002)");
                        break;
                    case "ROUT:OPEN (@3010)":
                        relay_open("200 ohms load OFF", command, "ROUTe:CLOSe? (@3010)");
                        break;

                    case "MEASure:VOLTage:DC? 100,0.001, (@1004)":
                        measure_test("pin 11, 12v AUX Test", command, 11.4, 12.6);
                        break;
                    case "ROUT:CLOS (@3007)":
                        test("25 ohms load ON", command, "ROUTe:CLOSe? (@3007)");
                        break;
                    case "ROUT:OPEN (@3007)":
                        relay_open("25 ohms load OFF", command, "ROUTe:CLOSe? (@3007)");
                        break;
                    case "MEASure:VOLTage:DC? 100,0.001, (@1005)":
                        measure_test("pin 3, 48v AUX Test", command, 45.6, 50.4);
                        break;
                    case "ROUT:CLOS (@3032)":
                        test("pin 4, contactor gate ON", command, "ROUTe:CLOSe? (@3032) ");
                        break;
                    case "ROUT:OPEN (@3032)":
                        relay_open("pin 4, contactor gate OFF", command, "ROUTe:CLOSe? (@3032)");
                        break;
                    case "MEASure:VOLTage:DC? 100,0.001, (@1006)":
                        measure_test("pin 6, 12v OUT Test", command, 11.4, 12.6);
                        break;
                    case "ROUT:OPEN (@3021)":
                        relay_open("48v power supply 1 OFF", command, "ROUTe:CLOSe? (@3021)");
                        break;
                    case "ROUT:OPEN (@3024)":
                        relay_open("48v power supply 2 OFF", command, "ROUTe:CLOSe? (@3024)");
                        break;
                    case "ROUT:OPEN (@3018)":
                        relay_open("12v power supply  OFF", command, "ROUTe:CLOSe? (@3018)");
                        uc_pdm_window.Instace.timer_off();
                        break;
                    case "ROUT:OPEN (@1006)":
                        relay_open("open", command, "ROUT: OPEN(@1006)");
                        break;
 
                    default:
                        string a = "2";
                        break;


                }
            }
            
            catch(Exception ex)
            {
                string a = ex.Message;
            }
           




        }

        private void test(string test_name,string command, string command2)
        {
            string result;
            string value;
            keysight.Send(command);
            result = keysight.send_read(command2);
            value = result == "1\n" ? "PASS" : "FAIL";
            uc_pdm_window.Instace.fillDatagrid_fnc(test_name, "", value);
        }

        private void measure_test(string test_name, string command, double min,double max)
        {
            string result = keysight.send_read(command);
            double value_pow = process_Data.valuepow(result, result[0].ToString(), "E");
            string value;

            if (value_pow >= min & value_pow <= max)   
                value = "PASS";        
            else
                value = "FAIL";
            uc_pdm_window.Instace.fillDatagrid_fnc(test_name, value_pow.ToString(), value);

        }

        private void relay_open(string test_name, string command, string command2)
        {
            string result;
            string value;
            keysight.Send(command);
            result = keysight.send_read(command2);
            value = result == "0\n" ? "PASS" : "FAIL";
            uc_pdm_window.Instace.fillDatagrid_fnc(test_name, "", value);
        }

    }
}
