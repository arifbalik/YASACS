namespace _20170511
{
    partial class KAYITFORMU
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
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(130, 68);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(134, 22);
            this.txtid.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(9, 73);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(73, 17);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID             ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKaydet.Location = new System.Drawing.Point(172, 96);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 42);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblsoyadi
            // 
            this.lblsoyadi.AutoSize = true;
            this.lblsoyadi.Location = new System.Drawing.Point(9, 45);
            this.lblsoyadi.Name = "lblsoyadi";
            this.lblsoyadi.Size = new System.Drawing.Size(51, 17);
            this.lblsoyadi.TabIndex = 3;
            this.lblsoyadi.Text = "Soyadi";
            // 
            // lbladi
            // 
            this.lbladi.AutoSize = true;
            this.lbladi.Location = new System.Drawing.Point(9, 17);
            this.lbladi.Name = "lbladi";
            this.lbladi.Size = new System.Drawing.Size(28, 17);
            this.lbladi.TabIndex = 3;
            this.lbladi.Text = "Adi";
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.Location = new System.Drawing.Point(130, 40);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(134, 22);
            this.txtsoyadi.TabIndex = 4;
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(130, 12);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(134, 22);
            this.txtadi.TabIndex = 4;
            // 
            // KAYITFORMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(282, 144);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.txtsoyadi);
            this.Controls.Add(this.lbladi);
            this.Controls.Add(this.lblsoyadi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Name = "KAYITFORMU";
            this.Text = "KAYIT FORMU";
            this.Load += new System.EventHandler(this.KAYITFORMU_Load);
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
    }
}

