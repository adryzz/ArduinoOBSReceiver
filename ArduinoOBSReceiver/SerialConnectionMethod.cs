using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ArduinoOBSReceiver
{
    class SerialConnectionMethod : IConnectionMethod
    {
        private SerialPort Port;
        private string Buffer = "";
        public bool ReadFullBuffer = false;

        public bool IsConnected  => Port.IsOpen;

        public ConnectionMethods Method => ConnectionMethods.Serial;

        public void Initialize(params object[] parameters)
        {
            string portName = (parameters[0]).ToString();
            int baudRate = (int)parameters[1];
            Port = new SerialPort(portName, baudRate);
        }

        public void Connect()
        {
            if (Port != null)
            {
                if (!Port.IsOpen)
                {
                    Port.DataReceived += Port_DataReceived;
                    Port.Open();
                }
            }
            else
            {

            }
        }

        public void Disconnect()
        {
            if (Port != null)
            {
                if (Port.IsOpen)
                {
                    Port.Close();
                }
            }
            else
            {

            }
        }

        public string ReceiveData()
        {
            return Buffer;
        }

        public void Dispose()
        {
            Port.Dispose();
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (ReadFullBuffer)
            {
                Buffer = Port.ReadExisting();
            }
            else
            {
                Buffer = Port.ReadLine().Replace("\n", "").Replace("\r", "");
            }
        }
    }
}
