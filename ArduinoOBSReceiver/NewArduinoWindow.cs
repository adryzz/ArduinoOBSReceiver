using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoOBSReceiver
{
    public partial class NewArduinoWindow : Form
    {
        public bool IsOK = false;
        public Arduino Returned;
        public NewArduinoWindow()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        panel0.Visible = true;
                        serialComboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        SerialConnectionMethod serial = new SerialConnectionMethod();
                        serial.Initialize(serialComboBox1.SelectedItem.ToString(), Convert.ToInt32(serialNumericUpDown1.Value));
                        Returned = new Arduino(serial)
                        {
                            Name = textBox1.Text
                        };
                        IsOK = true;
                        Close();
                        break;
                    }
            }
        }

        private void NewArduinoWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
