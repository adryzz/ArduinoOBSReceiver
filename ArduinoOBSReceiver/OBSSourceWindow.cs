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
    public partial class OBSSourceWindow : Form
    {
        public Font TextFont { get => label1.Font; set => label1.Font = value; }
        public Color TextColor { get => label1.ForeColor; set => label1.ForeColor = value; }
        public Color BackgroundColor { get => BackColor; set => BackColor = value; }
        public OBSSourceWindow()
        {
            InitializeComponent();
        }

        private void OBSSourceWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetText(string text)
        {
            if (!InvokeRequired)
            {
                label1.Text = text;
            }
            else
            {
                label1.Invoke(new SetTextHandler(() => { label1.Text = text; }));
            }
        }

        delegate void SetTextHandler();
    }
}
