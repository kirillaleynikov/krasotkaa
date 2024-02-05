namespace krasotkaa
{
    partial class Autorization
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
            btnEnter = new Button();
            btnGuest = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(326, 212);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(94, 29);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Войти";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(326, 283);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(94, 29);
            btnGuest.TabIndex = 1;
            btnGuest.Text = "Я гость";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(328, 61);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(125, 27);
            txtLogin.TabIndex = 2;
            txtLogin.Text = "loginDEbct2018";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(328, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Qg3gff";
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnGuest);
            Controls.Add(btnEnter);
            Name = "Autorization";
            Text = "Autorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Button btnGuest;
        private TextBox txtLogin;
        private TextBox txtPassword;
    }
}