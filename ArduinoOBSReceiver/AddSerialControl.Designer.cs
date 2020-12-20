
namespace ArduinoOBSReceiver
{
    partial class AddSerialControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serialLabel1 = new System.Windows.Forms.Label();
            this.serialComboBox1 = new System.Windows.Forms.ComboBox();
            this.serialLabel2 = new System.Windows.Forms.Label();
            this.serialNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialLabel1
            // 
            this.serialLabel1.AutoSize = true;
            this.serialLabel1.Location = new System.Drawing.Point(3, 13);
            this.serialLabel1.Name = "serialLabel1";
            this.serialLabel1.Size = new System.Drawing.Size(57, 13);
            this.serialLabel1.TabIndex = 0;
            this.serialLabel1.Text = "Serial port:";
            // 
            // serialComboBox1
            // 
            this.serialComboBox1.FormattingEnabled = true;
            this.serialComboBox1.Location = new System.Drawing.Point(66, 10);
            this.serialComboBox1.Name = "serialComboBox1";
            this.serialComboBox1.Size = new System.Drawing.Size(121, 21);
            this.serialComboBox1.TabIndex = 1;
            // 
            // serialLabel2
            // 
            this.serialLabel2.AutoSize = true;
            this.serialLabel2.Location = new System.Drawing.Point(3, 61);
            this.serialLabel2.Name = "serialLabel2";
            this.serialLabel2.Size = new System.Drawing.Size(59, 13);
            this.serialLabel2.TabIndex = 2;
            this.serialLabel2.Text = "Baud rate: ";
            // 
            // serialNumericUpDown1
            // 
            this.serialNumericUpDown1.Location = new System.Drawing.Point(68, 59);
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
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.serialNumericUpDown1);
            this.Controls.Add(this.serialLabel2);
            this.Controls.Add(this.serialLabel1);
            this.Controls.Add(this.serialComboBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(387, 347);
            ((System.ComponentModel.ISupportInitialize)(this.serialNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serialLabel1;
        private System.Windows.Forms.ComboBox serialComboBox1;
        private System.Windows.Forms.Label serialLabel2;
        private System.Windows.Forms.NumericUpDown serialNumericUpDown1;
    }
}
