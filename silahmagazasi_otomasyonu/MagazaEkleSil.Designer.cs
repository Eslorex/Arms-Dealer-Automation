namespace silahmagazasi_otomasyonu
{
    partial class MagazaEkleSil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.sil_buton = new System.Windows.Forms.Button();
            this.magazaid_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ekleme_butonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_adi = new System.Windows.Forms.Label();
            this.magazaadres_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.magazaTelNo_textbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.sil_buton);
            this.panel1.Controls.Add(this.magazaid_textbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(185, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 102);
            this.panel1.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mağaza Silme Paneli";
            // 
            // sil_buton
            // 
            this.sil_buton.Location = new System.Drawing.Point(246, 39);
            this.sil_buton.Name = "sil_buton";
            this.sil_buton.Size = new System.Drawing.Size(121, 43);
            this.sil_buton.TabIndex = 14;
            this.sil_buton.Text = "Sil";
            this.sil_buton.UseVisualStyleBackColor = true;
            this.sil_buton.Click += new System.EventHandler(this.sil_buton_Click);
            // 
            // magazaid_textbox
            // 
            this.magazaid_textbox.Location = new System.Drawing.Point(109, 49);
            this.magazaid_textbox.Name = "magazaid_textbox";
            this.magazaid_textbox.Size = new System.Drawing.Size(100, 22);
            this.magazaid_textbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mağaza ID:";
            // 
            // Ekleme_butonu
            // 
            this.Ekleme_butonu.Location = new System.Drawing.Point(246, 43);
            this.Ekleme_butonu.Name = "Ekleme_butonu";
            this.Ekleme_butonu.Size = new System.Drawing.Size(121, 47);
            this.Ekleme_butonu.TabIndex = 13;
            this.Ekleme_butonu.Text = "Ekle";
            this.Ekleme_butonu.UseVisualStyleBackColor = true;
            this.Ekleme_butonu.Click += new System.EventHandler(this.Ekleme_butonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mağaza Tel:";
            // 
            // label_adi
            // 
            this.label_adi.AutoSize = true;
            this.label_adi.Location = new System.Drawing.Point(7, 46);
            this.label_adi.Name = "label_adi";
            this.label_adi.Size = new System.Drawing.Size(101, 16);
            this.label_adi.TabIndex = 1;
            this.label_adi.Text = "Mağaza Adresi:";
            // 
            // magazaadres_textbox
            // 
            this.magazaadres_textbox.Location = new System.Drawing.Point(109, 43);
            this.magazaadres_textbox.Name = "magazaadres_textbox";
            this.magazaadres_textbox.Size = new System.Drawing.Size(100, 22);
            this.magazaadres_textbox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mağaza Ekleme Paneli";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.magazaTelNo_textbox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.magazaadres_textbox);
            this.panel2.Controls.Add(this.label_adi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Ekleme_butonu);
            this.panel2.Location = new System.Drawing.Point(185, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 124);
            this.panel2.TabIndex = 30;
            // 
            // magazaTelNo_textbox
            // 
            this.magazaTelNo_textbox.Location = new System.Drawing.Point(109, 68);
            this.magazaTelNo_textbox.Name = "magazaTelNo_textbox";
            this.magazaTelNo_textbox.Size = new System.Drawing.Size(100, 22);
            this.magazaTelNo_textbox.TabIndex = 22;
            // 
            // MagazaEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MagazaEkleSil";
            this.Text = "MagazaEkleSil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sil_buton;
        private System.Windows.Forms.TextBox magazaid_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Ekleme_butonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_adi;
        private System.Windows.Forms.TextBox magazaadres_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox magazaTelNo_textbox;
    }
}