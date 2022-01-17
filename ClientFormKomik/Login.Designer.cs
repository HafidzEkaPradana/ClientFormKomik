
namespace ClientFormKomik
{
    partial class Login
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
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMasuk = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btViewKomik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(117, 242);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(129, 39);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Masuk";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(306, 242);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(129, 39);
            this.btRegister.TabIndex = 1;
            this.btRegister.Text = "Daftar";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textBoxMasuk
            // 
            this.textBoxMasuk.Location = new System.Drawing.Point(117, 74);
            this.textBoxMasuk.Name = "textBoxMasuk";
            this.textBoxMasuk.Size = new System.Drawing.Size(318, 26);
            this.textBoxMasuk.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(117, 161);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(318, 26);
            this.textBoxPassword.TabIndex = 5;
            // 
            // btViewKomik
            // 
            this.btViewKomik.Location = new System.Drawing.Point(117, 303);
            this.btViewKomik.Name = "btViewKomik";
            this.btViewKomik.Size = new System.Drawing.Size(318, 39);
            this.btViewKomik.TabIndex = 6;
            this.btViewKomik.Text = "Lihat Komik";
            this.btViewKomik.UseVisualStyleBackColor = true;
            this.btViewKomik.Click += new System.EventHandler(this.btViewKomik_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 359);
            this.Controls.Add(this.btViewKomik);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxMasuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMasuk;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btViewKomik;
    }
}