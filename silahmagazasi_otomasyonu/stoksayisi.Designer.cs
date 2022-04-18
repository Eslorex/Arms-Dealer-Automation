namespace silahmagazasi_otomasyonu
{
    partial class stoksayisi
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
            this.geri_buton = new System.Windows.Forms.Button();
            this.miktar_Textbox = new System.Windows.Forms.TextBox();
            this.arttir_buton = new System.Windows.Forms.Button();
            this.azalt_buton = new System.Windows.Forms.Button();
            this.silahid_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // geri_buton
            // 
            this.geri_buton.Location = new System.Drawing.Point(12, 12);
            this.geri_buton.Name = "geri_buton";
            this.geri_buton.Size = new System.Drawing.Size(70, 26);
            this.geri_buton.TabIndex = 0;
            this.geri_buton.Text = "Geri";
            this.geri_buton.UseVisualStyleBackColor = true;
            this.geri_buton.Click += new System.EventHandler(this.geri_buton_Click);
            // 
            // miktar_Textbox
            // 
            this.miktar_Textbox.Location = new System.Drawing.Point(142, 76);
            this.miktar_Textbox.Name = "miktar_Textbox";
            this.miktar_Textbox.Size = new System.Drawing.Size(100, 22);
            this.miktar_Textbox.TabIndex = 1;
            // 
            // arttir_buton
            // 
            this.arttir_buton.Location = new System.Drawing.Point(50, 119);
            this.arttir_buton.Name = "arttir_buton";
            this.arttir_buton.Size = new System.Drawing.Size(100, 42);
            this.arttir_buton.TabIndex = 3;
            this.arttir_buton.Text = "Arttır";
            this.arttir_buton.UseVisualStyleBackColor = true;
            this.arttir_buton.Click += new System.EventHandler(this.arttir_buton_Click);
            // 
            // azalt_buton
            // 
            this.azalt_buton.Location = new System.Drawing.Point(228, 119);
            this.azalt_buton.Name = "azalt_buton";
            this.azalt_buton.Size = new System.Drawing.Size(100, 42);
            this.azalt_buton.TabIndex = 4;
            this.azalt_buton.Text = "Azalt";
            this.azalt_buton.UseVisualStyleBackColor = true;
            this.azalt_buton.Click += new System.EventHandler(this.azalt_buton_Click);
            // 
            // silahid_Textbox
            // 
            this.silahid_Textbox.Location = new System.Drawing.Point(142, 48);
            this.silahid_Textbox.Name = "silahid_Textbox";
            this.silahid_Textbox.Size = new System.Drawing.Size(100, 22);
            this.silahid_Textbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Silah ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Miktar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // stoksayisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 203);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silahid_Textbox);
            this.Controls.Add(this.azalt_buton);
            this.Controls.Add(this.arttir_buton);
            this.Controls.Add(this.miktar_Textbox);
            this.Controls.Add(this.geri_buton);
            this.Name = "stoksayisi";
            this.Text = "stoksayisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri_buton;
        private System.Windows.Forms.TextBox miktar_Textbox;
        private System.Windows.Forms.Button arttir_buton;
        private System.Windows.Forms.Button azalt_buton;
        private System.Windows.Forms.TextBox silahid_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}