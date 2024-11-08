namespace _1002_UTSPBO.Views
{
    partial class AddTugas
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
            lblNamaTugas = new Label();
            lblDeskripsi = new Label();
            lblDL = new Label();
            txbNamaTugas = new TextBox();
            txbDeskripsi = new TextBox();
            txbDeadline = new TextBox();
            btnTambah = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // lblNamaTugas
            // 
            lblNamaTugas.AutoSize = true;
            lblNamaTugas.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaTugas.Location = new Point(96, 86);
            lblNamaTugas.Name = "lblNamaTugas";
            lblNamaTugas.Size = new Size(128, 26);
            lblNamaTugas.TabIndex = 0;
            lblNamaTugas.Text = "Nama Tugas";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeskripsi.Location = new Point(96, 174);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(99, 26);
            lblDeskripsi.TabIndex = 1;
            lblDeskripsi.Text = "Deskripsi";
            lblDeskripsi.Click += lblDeskripsi_Click;
            // 
            // lblDL
            // 
            lblDL.AutoSize = true;
            lblDL.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDL.Location = new Point(96, 282);
            lblDL.Name = "lblDL";
            lblDL.Size = new Size(96, 26);
            lblDL.TabIndex = 2;
            lblDL.Text = "Deadline";
            // 
            // txbNamaTugas
            // 
            txbNamaTugas.Location = new Point(391, 87);
            txbNamaTugas.Name = "txbNamaTugas";
            txbNamaTugas.Size = new Size(125, 27);
            txbNamaTugas.TabIndex = 3;
            txbNamaTugas.TextChanged += textBox1_TextChanged;
            // 
            // txbDeskripsi
            // 
            txbDeskripsi.Location = new Point(391, 175);
            txbDeskripsi.Name = "txbDeskripsi";
            txbDeskripsi.Size = new Size(300, 27);
            txbDeskripsi.TabIndex = 4;
            txbDeskripsi.TextChanged += textBox2_TextChanged;
            // 
            // txbDeadline
            // 
            txbDeadline.Location = new Point(391, 283);
            txbDeadline.Name = "txbDeadline";
            txbDeadline.Size = new Size(125, 27);
            txbDeadline.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(651, 380);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(539, 380);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += button2_Click;
            // 
            // AddTugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatal);
            Controls.Add(btnTambah);
            Controls.Add(txbDeadline);
            Controls.Add(txbDeskripsi);
            Controls.Add(txbNamaTugas);
            Controls.Add(lblDL);
            Controls.Add(lblDeskripsi);
            Controls.Add(lblNamaTugas);
            Name = "AddTugas";
            Text = "AddTugas";
            Load += AddTugas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamaTugas;
        private Label lblDeskripsi;
        private Label lblDL;
        private TextBox txbNamaTugas;
        private TextBox txbDeskripsi;
        private TextBox txbDeadline;
        private Button btnTambah;
        private Button btnBatal;
    }
}