using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ArduinoOBSReceiver
{
    public class Arduino
    {
        public string Name = "";
        public IConnectionMethod Connection;
        public OBSSourceWindow Window = new OBSSourceWindow();
        public Timer UpdateTimer;
        public string Format = "{0} °C";
        public Arduino(IConnectionMethod method, double interval = 50)
        {
            Connection = method;
            UpdateTimer = new Timer(interval);
            UpdateTimer.Elapsed += UpdateTimer_Elapsed;
            UpdateTimer.Start();
        }

        private void UpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Window.SetText(string.Format(Format, Connection.ReceiveData()));
        }
    }
}
