namespace silahmagazasi_otomasyonu
{
    partial class fiyatdegistir
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
            this.button2 = new System.Windows.Forms.Button();
            this.silah_id_Textbox = new System.Windows.Forms.TextBox();
            this.fiyatdegisid_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Değiştir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // silah_id_Textbox
            // 
            this.silah_id_Textbox.Location = new System.Drawing.Point(169, 66);
            this.silah_id_Textbox.Name = "silah_id_Textbox";
            this.silah_id_Textbox.Size = new System.Drawing.Size(100, 22);
            this.silah_id_Textbox.TabIndex = 2;
            // 
            // fiyatdegisid_Textbox
            // 
            this.fiyatdegisid_Textbox.Location = new System.Drawing.Point(169, 103);
            this.fiyatdegisid_Textbox.Name = "fiyatdegisid_Textbox";
            this.fiyatdegisid_Textbox.Size = new System.Drawing.Size(100, 22);
            this.fiyatdegisid_Textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Silah ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Fiyat:";
            // 
            // fiyatdegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fiyatdegisid_Textbox);
            this.Controls.Add(this.silah_id_Textbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "fiyatdegistir";
            this.Text = "fiyatdegistir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox silah_id_Textbox;
        private System.Windows.Forms.TextBox fiyatdegisid_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}