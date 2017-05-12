namespace _20170511
{
    partial class Yoklama_Formu
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
            this.components = new System.ComponentModel.Container();
            this.btnyoklama = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnyoklama
            // 
            this.btnyoklama.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnyoklama.Location = new System.Drawing.Point(124, 174);
            this.btnyoklama.Name = "btnyoklama";
            this.btnyoklama.Size = new System.Drawing.Size(119, 36);
            this.btnyoklama.TabIndex = 11;
            this.btnyoklama.Text = "Yoklama Al";
            this.btnyoklama.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // Yoklama_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(320, 262);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnyoklama);
            this.Name = "Yoklama_Formu";
            this.Text = "Yoklama_Formu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnyoklama;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}