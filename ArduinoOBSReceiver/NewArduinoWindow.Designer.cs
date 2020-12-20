
namespace ArduinoOBSReceiver
{
    partial class NewArduinoWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel0 = new System.Windows.Forms.Panel();
            this.serialNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.serialLabel2 = new System.Windows.Forms.Label();
            this.serialComboBox1 = new System.Windows.Forms.ComboBox();
            this.serialLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection method:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Serial",
            "WiFi"});
            this.comboBox1.Location = new System.Drawing.Point(120, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.serialNumericUpDown1);
            this.panel0.Controls.Add(this.serialLabel2);
            this.panel0.Controls.Add(this.serialComboBox1);
            this.panel0.Controls.Add(this.serialLabel1);
            this.panel0.Location = new System.Drawing.Point(13, 62);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(387, 347);
            this.panel0.TabIndex = 4;
            this.panel0.Visible = false;
            // 
            // serialNumericUpDown1
            // 
            this.serialNumericUpDown1.Location = new System.Drawing.Point(68, 56);
            this.serialNumericUpDown1.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.serialNumericUpDown1.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.serialNumericUpDown1.Name = "serialNumericUpDown1";
            this.serialNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.serialNumericUpDown1.TabIndex = 3;
            this.serialNumericUpDown1.Value = new decimal(new int[] {
            115200,
            0,
            0,
            0});
            // 
            // serialLabel2
            // 
            this.serialLabel2.AutoSize = true;
            this.serialLabel2.Location = new System.Drawing.Point(3, 58);
            this.serialLabel2.Name = "serialLabel2";
            this.serialLabel2.Size = new System.Drawing.Size(59, 13);
            this.serialLabel2.TabIndex = 2;
            this.serialLabel2.Text = "Baud rate: ";
            // 
            // serialComboBox1
            // 
            this.serialComboBox1.FormattingEnabled = true;
            this.serialComboBox1.Location = new System.Drawing.Point(66, 7);
            this.serialComboBox1.Name = "serialComboBox1";
            this.serialComboBox1.Size = new System.Drawing.Size(121, 21);
            this.serialComboBox1.TabIndex = 1;
            // 
            // serialLabel1
            // 
            this.serialLabel1.AutoSize = true;
            this.serialLabel1.Location = new System.Drawing.Point(3, 10);
            this.serialLabel1.Name = "serialLabel1";
            this.serialLabel1.Size = new System.Drawing.Size(57, 13);
            this.serialLabel1.TabIndex = 0;
            this.serialLabel1.Text = "Serial port:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewArduinoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewArduinoWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Arduino";
            this.Load += new System.EventHandler(this.NewArduinoWindow_Load);
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox serialComboBox1;
        private System.Windows.Forms.Label serialLabel1;
        private System.Windows.Forms.NumericUpDown serialNumericUpDown1;
        private System.Windows.Forms.Label serialLabel2;
        private AddSerialControl serialControl;
    }
}