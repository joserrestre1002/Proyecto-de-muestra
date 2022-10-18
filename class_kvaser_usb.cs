using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kvaser.CanLib;
namespace Control_panel_test
{
    internal class class_kvaser_usb
    {
        public int handle = 0;
        Canlib.canStatus status;

        public bool check_for_error(string cmd, Canlib.canStatus start)
        {
            if(start != Canlib.canStatus.canOK)
            {
                Canlib.canGetErrorText(start, out string buf);
                return true;    
            }

            return false;
        }

        public void check_status(Canlib.canStatus status, string method)
        {
            
            if (status > 0)
            {
                string error_test;
                Canlib.canGetErrorText(status, out error_test);
            }
        }


      
        public void send_messge(int adress, byte[]data )
        {
            status = Canlib.canWrite(handle, adress, data, 8, 0);
            check_status(status, "canWrite");
            status = Canlib.canWriteSync(handle, 1000);
            check_status(status, "canWriteSync");
        }

        public void open_can_channel(int channel_number)
        {
            Canlib.canInitializeLibrary();
            handle = Canlib.canOpenChannel(channel_number, Canlib.canOPEN_ACCEPT_VIRTUAL);
            check_status((Canlib.canStatus)handle, "canOpenChannel");
            status = Canlib.canSetBusParams(handle, Canlib.canBITRATE_250K, 0, 0, 0, 0);
            check_status(status, "canSetBusParams");
            status = Canlib.canBusOn(handle);
            check_status(status, "canBusOn");

        }

        public void close_can_channel()
        {
            status = Canlib.canBusOn(handle);
            check_status(status, "canBusOff");
            status = Canlib.canClose(handle);
            check_status(status, "canClose");
        }

        public struct channels_data
        {
            public int channel_number;
            public object[] device_name;
            public object[] device_channel;
            
        }

        public channels_data list_channels()
        {
            Canlib.canInitializeLibrary();
            Canlib.canStatus status_2;
        
            channels_data _channel_Data = new channels_data();
            status_2 = Canlib.canGetNumberOfChannels(out int number_of_channels);
            _channel_Data.channel_number = number_of_channels;
            _channel_Data.device_name = new object[number_of_channels];
            _channel_Data.device_channel = new object[number_of_channels];

            if (check_for_error("canGetNumberOfChannels", status_2))
                return _channel_Data;

            string a = "Found" + number_of_channels + "channels";

            for (int i = 0; i < number_of_channels; i++)
            {
                status_2 = Canlib.canGetChannelData(i, Canlib.canCHANNELDATA_DEVDESCR_ASCII, out object device_name);
                if (check_for_error("canGetChannelData", status_2))
                    return _channel_Data;
                status_2 = Canlib.canGetChannelData(i, Canlib.canCHANNELDATA_CHAN_NO_ON_CARD, out object device_channel);
                if (check_for_error("canGetChannelData", status_2))
                    return _channel_Data;

                _channel_Data.device_name[i] = device_name;
                _channel_Data.device_channel[i] = device_channel;
            }

            return _channel_Data;
        }
    }
}
