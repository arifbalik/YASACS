namespace _20170511
{
    partial class Anasayfa
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
            this.btnkayıt = new System.Windows.Forms.Button();
            this.btnyoklama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkayıt
            // 
            this.btnkayıt.BackColor = System.Drawing.Color.Cyan;
            this.btnkayıt.Location = new System.Drawing.Point(12, 12);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(136, 38);
            this.btnkayıt.TabIndex = 0;
            this.btnkayıt.Text = "Yoklama";
            this.btnkayıt.UseVisualStyleBackColor = false;
            this.btnkayıt.Click += new System.EventHandler(this.btnkayıt_Click);
            // 
            // btnyoklama
            // 
            this.btnyoklama.BackColor = System.Drawing.Color.Cyan;
            this.btnyoklama.Location = new System.Drawing.Point(12, 56);
            this.btnyoklama.Name = "btnyoklama";
            this.btnyoklama.Size = new System.Drawing.Size(136, 38);
            this.btnyoklama.TabIndex = 0;
            this.btnyoklama.Text = "Kayıt Formu";
            this.btnyoklama.UseVisualStyleBackColor = false;
            this.btnyoklama.Click += new System.EventHandler(this.btnyoklama_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(152, 112);
            this.Controls.Add(this.btnyoklama);
            this.Controls.Add(this.btnkayıt);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkayıt;
        private System.Windows.Forms.Button btnyoklama;
    }
}