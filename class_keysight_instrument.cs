using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Keysight.Visa;
using Ivi.Visa;
namespace Control_panel_test
{
    internal class class_keysight_instrument
    {
        string instrument_answer;
        
        
        int index_answert = 0;
        public int pass = 0;
        
        
        static TcpipSession _obj;

       
        public static TcpipSession _sesion
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new TcpipSession("TCPIP0::192.168.0.80::inst0::INSTR", AccessModes.None,2000);
                }
                return _obj;
              
            }
        }
        public string Send(string command)
        {
            try
            {
                IMessageBasedFormattedIO io = _sesion.FormattedIO;
                io.PrintfAndFlush(command);
                return "true";
               
            }
            catch(Exception ex)
            {
               return ex.Message;
            }


        }


        public string read()
        {
            try
            {
                IMessageBasedFormattedIO io = _sesion.FormattedIO;               
                string[] answer = new string[] { "", "", "", "" };
                io.Scanf("%,s", out answer);
                
                        instrument_answer = answer[0];  
            }

            catch

             {
                instrument_answer = "read error";
             }

            return instrument_answer;
        }

        public string send_read(string command)
        {
            try
            {
                IMessageBasedFormattedIO io = _sesion.FormattedIO;
                io.PrintfAndFlush(command);
                string[] answer = new string[] {"","","",""};
                io.Scanf("%,s", out  answer);
                index_answert = answer.Length;

                if (command == "*IDN?")
                {
                       instrument_answer = "Manufacturer: " + answer[0] + "\r\n";
                   
                       if(answer.Length > 1) 
                        instrument_answer += "Instrument Model: " + answer[1] + "\r\n";
                       if(answer.Length > 2)
                        instrument_answer += "Firmaware Revision: " + answer[2] + "\r\n";
                       if(answer.Length >3) 
                        instrument_answer += "Serial Number: " + answer[3] + "\r\n";
                }
                else
                {
                    if (command[0] == 'M')
                    {
                        
                        instrument_answer = answer[0];
                    }
                    else
                    {
                        instrument_answer = answer[0];  
                    }
                }
            }

            catch
            {

                instrument_answer = "!read_comand failed";

            }

            return instrument_answer;
        }
    }
}
