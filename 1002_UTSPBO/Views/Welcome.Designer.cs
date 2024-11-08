namespace _1002_UTSPBO
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            cbxTugas = new CheckBox();
            cbxDaftarPengguna = new CheckBox();
            cbxLogin = new CheckBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(250, 68);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(292, 45);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Selamat Datang!";
            // 
            // cbxTugas
            // 
            cbxTugas.AutoSize = true;
            cbxTugas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxTugas.Location = new Point(79, 193);
            cbxTugas.Name = "cbxTugas";
            cbxTugas.Size = new Size(85, 32);
            cbxTugas.TabIndex = 1;
            cbxTugas.Text = "Tugas";
            cbxTugas.UseVisualStyleBackColor = true;
            cbxTugas.CheckedChanged += this.checkBox1_CheckedChanged;
            // 
            // cbxDaftarPengguna
            // 
            cbxDaftarPengguna.AutoSize = true;
            cbxDaftarPengguna.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxDaftarPengguna.Location = new Point(329, 193);
            cbxDaftarPengguna.Name = "cbxDaftarPengguna";
            cbxDaftarPengguna.Size = new Size(109, 32);
            cbxDaftarPengguna.TabIndex = 2;
            cbxDaftarPengguna.Text = "Register ";
            cbxDaftarPengguna.UseVisualStyleBackColor = true;
            cbxDaftarPengguna.CheckedChanged += this.checkBox2_CheckedChanged;
            // 
            // cbxLogin
            // 
            cbxLogin.AutoSize = true;
            cbxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxLogin.Location = new Point(598, 193);
            cbxLogin.Name = "cbxLogin";
            cbxLogin.Size = new Size(83, 32);
            cbxLogin.TabIndex = 3;
            cbxLogin.Text = "Login";
            cbxLogin.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(616, 323);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(cbxLogin);
            Controls.Add(cbxDaftarPengguna);
            Controls.Add(cbxTugas);
            Controls.Add(lblWelcome);
            Name = "Welcome";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private CheckBox cbxTugas;
        private CheckBox cbxDaftarPengguna;
        private CheckBox cbxLogin;
        private Button btnNext;
    }
}
