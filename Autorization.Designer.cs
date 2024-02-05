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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            btnEnter = new Button();
            btnGuest = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnter.Location = new Point(314, 245);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(146, 52);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Войти";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnGuest
            // 
            btnGuest.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuest.Location = new Point(314, 316);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(146, 52);
            btnGuest.TabIndex = 1;
            btnGuest.Text = "Я гость";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(298, 132);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(184, 35);
            txtLogin.TabIndex = 2;
            txtLogin.Text = "loginDEbct2018";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(298, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(184, 35);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Qg3gff";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(504, 184);
            button1.Name = "button1";
            button1.Size = new Size(153, 35);
            button1.TabIndex = 4;
            button1.Text = "Показать";
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += button1_MouseDown;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseUp += button1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 12);
            label1.Name = "label1";
            label1.Size = new Size(320, 67);
            label1.TabIndex = 5;
            label1.Text = "Авторизация";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 94);
            panel1.TabIndex = 6;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnGuest);
            Controls.Add(btnEnter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Autorization";
            Text = "Autorization";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Button btnGuest;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button button1;
        private Label label1;
        private Panel panel1;
    }
}