namespace _1002_UTSPBO.Views
{
    partial class Tugas
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
            label1 = new Label();
            dgvDaftarTugas = new DataGridView();
            lblHalTugas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarTugas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 70);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // dgvDaftarTugas
            // 
            dgvDaftarTugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDaftarTugas.Location = new Point(68, 73);
            dgvDaftarTugas.Name = "dgvDaftarTugas";
            dgvDaftarTugas.RowHeadersWidth = 51;
            dgvDaftarTugas.Size = new Size(673, 334);
            dgvDaftarTugas.TabIndex = 1;
            dgvDaftarTugas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblHalTugas
            // 
            lblHalTugas.AutoSize = true;
            lblHalTugas.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHalTugas.Location = new Point(274, 25);
            lblHalTugas.Name = "lblHalTugas";
            lblHalTugas.Size = new Size(236, 45);
            lblHalTugas.TabIndex = 2;
            lblHalTugas.Text = "Daftar Tugas";
            // 
            // Tugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHalTugas);
            Controls.Add(dgvDaftarTugas);
            Controls.Add(label1);
            Name = "Tugas";
            Text = "Tugas";
            Load += Tugas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDaftarTugas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDaftarTugas;
        private Label lblHalTugas;
    }
}