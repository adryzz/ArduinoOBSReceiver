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
    public partial class Form1 : Form
    {
        List<Arduino> Arduinos = new List<Arduino>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listBox1.SelectedIndex >= 0;
            button3.Enabled = listBox1.SelectedIndex >= 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewArduinoWindow window = new NewArduinoWindow();
            window.ShowDialog();
            if (window.IsOK)
            {
                Arduinos.Add(window.Returned);
                listBox1.Items.Add(window.Returned.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduinos.ElementAt(listBox1.SelectedIndex).Connection.Dispose();
            Arduinos.ElementAt(listBox1.SelectedIndex).Window.Close();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arduinos.ElementAt(listBox1.SelectedIndex).Connection.Connect();
            Arduinos.ElementAt(listBox1.SelectedIndex).Window.Show();
        }
    }
}
