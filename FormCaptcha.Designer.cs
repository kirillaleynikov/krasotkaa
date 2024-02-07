namespace krasotkaa
{
    partial class FormCaptcha
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
            pictureBox1 = new PictureBox();
            txtBoxInput = new TextBox();
            btnInput = new Button();
            btnGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(201, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 208);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtBoxInput
            // 
            txtBoxInput.Location = new Point(201, 253);
            txtBoxInput.Name = "txtBoxInput";
            txtBoxInput.Size = new Size(264, 27);
            txtBoxInput.TabIndex = 1;
            // 
            // btnInput
            // 
            btnInput.Location = new Point(201, 286);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(94, 29);
            btnInput.TabIndex = 2;
            btnInput.Text = "Войти";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(333, 286);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(132, 29);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Сгенерировать";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // FormCaptcha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerate);
            Controls.Add(btnInput);
            Controls.Add(txtBoxInput);
            Controls.Add(pictureBox1);
            Name = "FormCaptcha";
            Text = "FormCaptcha";
            Load += FormCaptcha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtBoxInput;
        private Button btnInput;
        private Button btnGenerate;
    }
}