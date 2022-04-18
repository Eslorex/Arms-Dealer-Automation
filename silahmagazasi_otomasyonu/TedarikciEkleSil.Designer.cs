namespace silahmagazasi_otomasyonu
{
    partial class TedarikciEkleSil
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tedarikciTelNo_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tedarikciAdi_textbox = new System.Windows.Forms.TextBox();
            this.label_adi = new System.Windows.Forms.Label();
            this.Ekleme_butonu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.sil_buton = new System.Windows.Forms.Button();
            this.tedarikciID_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tedarikciTelNo_textbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tedarikciAdi_textbox);
            this.panel2.Controls.Add(this.label_adi);
            this.panel2.Controls.Add(this.Ekleme_butonu);
            this.panel2.Location = new System.Drawing.Point(161, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 118);
            this.panel2.TabIndex = 31;
            // 
            // tedarikciTelNo_textbox
            // 
            this.tedarikciTelNo_textbox.Location = new System.Drawing.Point(109, 65);
            this.tedarikciTelNo_textbox.Name = "tedarikciTelNo_textbox";
            this.tedarikciTelNo_textbox.Size = new System.Drawing.Size(100, 22);
            this.tedarikciTelNo_textbox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tel No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tedarikçi Ekleme Paneli";
            // 
            // tedarikciAdi_textbox
            // 
            this.tedarikciAdi_textbox.Location = new System.Drawing.Point(109, 37);
            this.tedarikciAdi_textbox.Name = "tedarikciAdi_textbox";
            this.tedarikciAdi_textbox.Size = new System.Drawing.Size(100, 22);
            this.tedarikciAdi_textbox.TabIndex = 7;
            // 
            // label_adi
            // 
            this.label_adi.AutoSize = true;
            this.label_adi.Location = new System.Drawing.Point(76, 40);
            this.label_adi.Name = "label_adi";
            this.label_adi.Size = new System.Drawing.Size(30, 16);
            this.label_adi.TabIndex = 1;
            this.label_adi.Text = "Adı:";
            // 
            // Ekleme_butonu
            // 
            this.Ekleme_butonu.Location = new System.Drawing.Point(227, 41);
            this.Ekleme_butonu.Name = "Ekleme_butonu";
            this.Ekleme_butonu.Size = new System.Drawing.Size(121, 43);
            this.Ekleme_butonu.TabIndex = 13;
            this.Ekleme_butonu.Text = "Ekle";
            this.Ekleme_butonu.UseVisualStyleBackColor = true;
            this.Ekleme_butonu.Click += new System.EventHandler(this.Ekleme_butonu_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.sil_buton);
            this.panel1.Controls.Add(this.tedarikciID_textbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(161, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 102);
            this.panel1.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tedarikçi Silme Paneli";
            // 
            // sil_buton
            // 
            this.sil_buton.Location = new System.Drawing.Point(227, 39);
            this.sil_buton.Name = "sil_buton";
            this.sil_buton.Size = new System.Drawing.Size(121, 43);
            this.sil_buton.TabIndex = 14;
            this.sil_buton.Text = "Sil";
            this.sil_buton.UseVisualStyleBackColor = true;
            this.sil_buton.Click += new System.EventHandler(this.sil_buton_Click);
            // 
            // tedarikciID_textbox
            // 
            this.tedarikciID_textbox.Location = new System.Drawing.Point(96, 49);
            this.tedarikciID_textbox.Name = "tedarikciID_textbox";
            this.tedarikciID_textbox.Size = new System.Drawing.Size(100, 22);
            this.tedarikciID_textbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tedarikçi ID:";
            // 
            // TedarikciEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "TedarikciEkleSil";
            this.Text = "TedarikciEkleSil";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tedarikciTelNo_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tedarikciAdi_textbox;
        private System.Windows.Forms.Label label_adi;
        private System.Windows.Forms.Button Ekleme_butonu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sil_buton;
        private System.Windows.Forms.TextBox tedarikciID_textbox;
        private System.Windows.Forms.Label label6;
    }
}