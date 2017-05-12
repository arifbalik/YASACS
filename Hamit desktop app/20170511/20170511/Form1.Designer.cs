namespace _20170511
{
    partial class Form1
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblsoyadi = new System.Windows.Forms.Label();
            this.lbladi = new System.Windows.Forms.Label();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(263, 129);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(160, 129);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(73, 17);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID             ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(263, 202);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 38);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblsoyadi
            // 
            this.lblsoyadi.AutoSize = true;
            this.lblsoyadi.Location = new System.Drawing.Point(160, 89);
            this.lblsoyadi.Name = "lblsoyadi";
            this.lblsoyadi.Size = new System.Drawing.Size(51, 17);
            this.lblsoyadi.TabIndex = 3;
            this.lblsoyadi.Text = "Soyadi";
            // 
            // lbladi
            // 
            this.lbladi.AutoSize = true;
            this.lbladi.Location = new System.Drawing.Point(160, 45);
            this.lbladi.Name = "lbladi";
            this.lbladi.Size = new System.Drawing.Size(28, 17);
            this.lbladi.TabIndex = 3;
            this.lbladi.Text = "Adi";
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.Location = new System.Drawing.Point(263, 89);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(100, 22);
            this.txtsoyadi.TabIndex = 4;
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(263, 45);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(100, 22);
            this.txtadi.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(615, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.txtsoyadi);
            this.Controls.Add(this.lbladi);
            this.Controls.Add(this.lblsoyadi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblsoyadi;
        private System.Windows.Forms.Label lbladi;
        private System.Windows.Forms.TextBox txtsoyadi;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Button button1;
    }
}

