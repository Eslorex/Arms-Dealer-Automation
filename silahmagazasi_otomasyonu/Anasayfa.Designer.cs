namespace silahmagazasi_otomasyonu
{
    partial class Anasayfa
    {

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eklesil_buton = new System.Windows.Forms.Button();
            this.sorgula_buton = new System.Windows.Forms.Button();
            this.duzenle_buton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.silahidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silahadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silahmodeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silahulkesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silahfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silahatishiziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silahkalibresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silahstoksayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silahlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silahmagazaDataSet = new silahmagazasi_otomasyonu.silahmagazaDataSet();
            this.silahlarTableAdapter = new silahmagazasi_otomasyonu.silahmagazaDataSetTableAdapters.silahlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silahlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silahmagazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // eklesil_buton
            // 
            this.eklesil_buton.Location = new System.Drawing.Point(12, 21);
            this.eklesil_buton.Name = "eklesil_buton";
            this.eklesil_buton.Size = new System.Drawing.Size(157, 56);
            this.eklesil_buton.TabIndex = 0;
            this.eklesil_buton.Text = "Ekle-Sil";
            this.eklesil_buton.UseVisualStyleBackColor = true;
            this.eklesil_buton.Click += new System.EventHandler(this.ekle_buton_Click);
            // 
            // sorgula_buton
            // 
            this.sorgula_buton.Location = new System.Drawing.Point(175, 21);
            this.sorgula_buton.Name = "sorgula_buton";
            this.sorgula_buton.Size = new System.Drawing.Size(165, 56);
            this.sorgula_buton.TabIndex = 1;
            this.sorgula_buton.Text = "Sorgula";
            this.sorgula_buton.UseVisualStyleBackColor = true;
            this.sorgula_buton.Click += new System.EventHandler(this.sorgula_buton_Click);
            // 
            // duzenle_buton
            // 
            this.duzenle_buton.Location = new System.Drawing.Point(346, 21);
            this.duzenle_buton.Name = "duzenle_buton";
            this.duzenle_buton.Size = new System.Drawing.Size(168, 56);
            this.duzenle_buton.TabIndex = 1;
            this.duzenle_buton.Text = "Düzenle";
            this.duzenle_buton.UseVisualStyleBackColor = true;
            this.duzenle_buton.Click += new System.EventHandler(this.duzenle_buton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "dataGrid";
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.silahidDataGridViewTextBoxColumn,
            this.silahadiDataGridViewTextBoxColumn,
            this.silahmodeliDataGridViewTextBoxColumn,
            this.silahulkesiDataGridViewTextBoxColumn,
            this.silahfiyatiDataGridViewTextBoxColumn,
            this.silahatishiziDataGridViewTextBoxColumn,
            this.silahkalibresiDataGridViewTextBoxColumn,
            this.silahstoksayisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.silahlarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 377);
            this.dataGridView1.TabIndex = 4;
            // 
            // silahidDataGridViewTextBoxColumn
            // 
            this.silahidDataGridViewTextBoxColumn.DataPropertyName = "silah_id";
            this.silahidDataGridViewTextBoxColumn.HeaderText = "silah_id";
            this.silahidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silahidDataGridViewTextBoxColumn.Name = "silahidDataGridViewTextBoxColumn";
            this.silahidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // silahadiDataGridViewTextBoxColumn
            // 
            this.silahadiDataGridViewTextBoxColumn.DataPropertyName = "silah_adi";
            this.silahadiDataGridViewTextBoxColumn.HeaderText = "silah_adi";
            this.silahadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silahadiDataGridViewTextBoxColumn.Name = "silahadiDataGridViewTextBoxColumn";
            // 
            // silahmodeliDataGridViewTextBoxColumn
            // 
            this.silahmodeliDataGridViewTextBoxColumn.DataPropertyName = "silah_modeli";
            this.silahmodeliDataGridViewTextBoxColumn.HeaderText = "silah_modeli";
            this.silahmodeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silahmodeliDataGridViewTextBoxColumn.Name = "silahmodeliDataGridViewTextBoxColumn";
            // 
            // silahulkesiDataGridViewTextBoxColumn
            // 
            this.silahulkesiDataGridViewTextBoxColumn.DataPropertyName = "silah_ulkesi";
            this.silahulkesiDataGridViewTextBoxColumn.HeaderText = "silah_ulkesi";
            this.silahulkesiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silahulkesiDataGridViewTextBoxColumn.Name = "silahulkesiDataGridViewTextBoxColumn";
            // 
            // silahfiyatiDataGridViewTextBoxColumn
            // 
            this.silahfiyatiDataGridViewTextBoxColumn.DataPropertyName = "silah_fiyati";
            this.silahfiyatiDataGridViewTextBoxColumn.HeaderText = "silah_fiyati";
            this.silahfiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silahfiyatiDataGridViewTextBoxColumn.Name = "silahfiyatiDataGridViewTextBoxColumn";
            // 
            // silahatishiziDataGridViewTextBoxColumn
            // 
            this.silahatishiziDataGridViewTextBoxColumn.DataPropertyName = "silah_atishizi";
            this.silahatishiziDataGridViewTextBoxColumn.HeaderText = "silah_atishizi";
            this.silahatishiziDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silahatishiziDataGridViewTextBoxColumn.Name = "silahatishiziDataGridViewTextBoxColumn";
            // 
            // silahkalibresiDataGridViewTextBoxColumn
            // 
            this.silahkalibresiDataGridViewTextBoxColumn.DataPropertyName = "silah_kalibresi";
            this.silahkalibresiDataGridViewTextBoxColumn.HeaderText = "silah_kalibresi";
            this.silahkalibresiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silahkalibresiDataGridViewTextBoxColumn.Name = "silahkalibresiDataGridViewTextBoxColumn";
            // 
            // silahstoksayisiDataGridViewTextBoxColumn
            // 
            this.silahstoksayisiDataGridViewTextBoxColumn.DataPropertyName = "silah_stoksayisi";
            this.silahstoksayisiDataGridViewTextBoxColumn.HeaderText = "silah_stoksayisi";
            this.silahstoksayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silahstoksayisiDataGridViewTextBoxColumn.Name = "silahstoksayisiDataGridViewTextBoxColumn";
            // 
            // silahlarBindingSource
            // 
            this.silahlarBindingSource.DataMember = "silahlar";
            this.silahlarBindingSource.DataSource = this.silahmagazaDataSet;
            // 
            // silahmagazaDataSet
            // 
            this.silahmagazaDataSet.DataSetName = "silahmagazaDataSet";
            this.silahmagazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // silahlarTableAdapter
            // 
            this.silahlarTableAdapter.ClearBeforeFill = true;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.duzenle_buton);
            this.Controls.Add(this.sorgula_buton);
            this.Controls.Add(this.eklesil_buton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silahlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silahmagazaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button eklesil_buton;
        public System.Windows.Forms.Button sorgula_buton;
        public System.Windows.Forms.Button duzenle_buton;
        public silahmagazaDataSet silahmagazaDataSet;
        public System.Windows.Forms.BindingSource silahlarBindingSource;
        public silahmagazaDataSetTableAdapters.silahlarTableAdapter silahlarTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn silahidDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn silahadiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn silahmodeliDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn silahulkesiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn silahfiyatiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn silahatishiziDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn silahkalibresiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn silahstoksayisiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.IContainer components;
    }
}

