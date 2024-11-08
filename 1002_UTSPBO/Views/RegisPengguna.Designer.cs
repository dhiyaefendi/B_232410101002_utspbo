namespace _1002_UTSPBO.Views
{
    partial class RegisPengguna
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
            lblRegisUser = new Label();
            lblEmail = new Label();
            lblPWUser = new Label();
            txbEmail = new TextBox();
            txbPasswordUser = new TextBox();
            btnDaftar = new Button();
            SuspendLayout();
            // 
            // lblRegisUser
            // 
            lblRegisUser.AutoSize = true;
            lblRegisUser.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisUser.Location = new Point(305, 55);
            lblRegisUser.Name = "lblRegisUser";
            lblRegisUser.Size = new Size(154, 45);
            lblRegisUser.TabIndex = 0;
            lblRegisUser.Text = "Register";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(144, 153);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 26);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPWUser
            // 
            lblPWUser.AutoSize = true;
            lblPWUser.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPWUser.Location = new Point(144, 211);
            lblPWUser.Name = "lblPWUser";
            lblPWUser.Size = new Size(97, 26);
            lblPWUser.TabIndex = 2;
            lblPWUser.Text = "Password";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(315, 154);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(207, 27);
            txbEmail.TabIndex = 3;
            // 
            // txbPasswordUser
            // 
            txbPasswordUser.Location = new Point(315, 212);
            txbPasswordUser.Name = "txbPasswordUser";
            txbPasswordUser.Size = new Size(207, 27);
            txbPasswordUser.TabIndex = 4;
            txbPasswordUser.TextChanged += textBox2_TextChanged;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(558, 302);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(94, 29);
            btnDaftar.TabIndex = 5;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            // 
            // RegisPengguna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDaftar);
            Controls.Add(txbPasswordUser);
            Controls.Add(txbEmail);
            Controls.Add(lblPWUser);
            Controls.Add(lblEmail);
            Controls.Add(lblRegisUser);
            Name = "RegisPengguna";
            Text = "RegisPengguna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegisUser;
        private Label lblEmail;
        private Label lblPWUser;
        private TextBox txbEmail;
        private TextBox txbPasswordUser;
        private Button btnDaftar;
    }
}