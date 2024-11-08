namespace _1002_UTSPBO.Views
{
    partial class DashboardAdmin
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
            lblDaftarTugasAdm = new Label();
            dataGridView1 = new DataGridView();
            btnTambahTugas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDaftarTugasAdm
            // 
            lblDaftarTugasAdm.AutoSize = true;
            lblDaftarTugasAdm.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaftarTugasAdm.Location = new Point(276, 53);
            lblDaftarTugasAdm.Name = "lblDaftarTugasAdm";
            lblDaftarTugasAdm.Size = new Size(236, 45);
            lblDaftarTugasAdm.TabIndex = 0;
            lblDaftarTugasAdm.Text = "Daftar Tugas";
            lblDaftarTugasAdm.Click += lblDaftarTugasAdm_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(75, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(664, 254);
            dataGridView1.TabIndex = 1;
            // 
            // btnTambahTugas
            // 
            btnTambahTugas.Location = new Point(602, 397);
            btnTambahTugas.Name = "btnTambahTugas";
            btnTambahTugas.Size = new Size(137, 29);
            btnTambahTugas.TabIndex = 2;
            btnTambahTugas.Text = "Tambah tugas";
            btnTambahTugas.UseVisualStyleBackColor = true;
            btnTambahTugas.Click += btnTambahTugas_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambahTugas);
            Controls.Add(dataGridView1);
            Controls.Add(lblDaftarTugasAdm);
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDaftarTugasAdm;
        private DataGridView dataGridView1;
        private Button btnTambahTugas;
    }
}