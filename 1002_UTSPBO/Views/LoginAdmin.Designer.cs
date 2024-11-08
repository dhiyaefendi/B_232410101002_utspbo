namespace _1002_UTSPBO.Views
{
    partial class LoginAdmin
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
            lblUsername = new Label();
            lblPW = new Label();
            txbUsername = new TextBox();
            textBox2 = new TextBox();
            btnMasuk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 49);
            label1.Name = "label1";
            label1.Size = new Size(117, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(149, 157);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 26);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPW
            // 
            lblPW.AutoSize = true;
            lblPW.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPW.Location = new Point(157, 233);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(97, 26);
            lblPW.TabIndex = 2;
            lblPW.Text = "Password";
            lblPW.Click += lblPW_Click;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(350, 156);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(226, 27);
            txbUsername.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(350, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnMasuk
            // 
            btnMasuk.Location = new Point(597, 324);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.Size = new Size(94, 29);
            btnMasuk.TabIndex = 5;
            btnMasuk.Text = "Masuk";
            btnMasuk.UseVisualStyleBackColor = true;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMasuk);
            Controls.Add(textBox2);
            Controls.Add(txbUsername);
            Controls.Add(lblPW);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Name = "LoginAdmin";
            Text = "LoginAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private Label lblPW;
        private TextBox txbUsername;
        private TextBox textBox2;
        private Button btnMasuk;
    }
}