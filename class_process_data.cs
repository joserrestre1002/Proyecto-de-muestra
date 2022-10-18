using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_panel_test
{
    internal class class_process_data
    {

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
       

        public double valuepow(string string_source,string start_char, string end_char)
        {
            char sign = string_source[string_source.Length - 4];
            char exp = string_source[string_source.Length - 2];

            double result;
            int exp_to_int = int.Parse(exp.ToString());
            if (sign == '+')

                result = double.Parse(string_between(string_source, start_char.ToString(), end_char)) * Math.Pow(10, exp_to_int);
            else
                result = double.Parse(string_between(string_source, start_char.ToString(), end_char)) / Math.Pow(10, exp_to_int);
            return result;
        }

        public string string_between(string string_source, string start_char, string end_char)
        {
            int index_start = string_source.IndexOf(start_char, 0) + start_char.Length;
            int index_end = string_source.IndexOf(end_char, index_start);
            return string_source.Substring(index_start, index_end - index_start);
        }


       

    }
}
