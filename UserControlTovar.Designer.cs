namespace krasotkaa
{
    partial class UserControlTovar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picBoxTovar = new PictureBox();
            lblName = new Label();
            lblDescription = new Label();
            lblManufacture = new Label();
            lblPrice = new Label();
            lblDiscount = new Label();
            btnChange = new Button();
            btnDelete = new Button();
            btnOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxTovar).BeginInit();
            SuspendLayout();
            // 
            // picBoxTovar
            // 
            picBoxTovar.Image = Properties.Resources.picture;
            picBoxTovar.Location = new Point(3, 3);
            picBoxTovar.Name = "picBoxTovar";
            picBoxTovar.Size = new Size(184, 120);
            picBoxTovar.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxTovar.TabIndex = 0;
            picBoxTovar.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(193, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(116, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Наименование";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(193, 33);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(79, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Описание";
            // 
            // lblManufacture
            // 
            lblManufacture.AutoSize = true;
            lblManufacture.Location = new Point(193, 64);
            lblManufacture.Name = "lblManufacture";
            lblManufacture.Size = new Size(118, 20);
            lblManufacture.TabIndex = 3;
            lblManufacture.Text = "Производитель";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(203, 103);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(45, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Цена";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(560, 64);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(111, 20);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Размер скидки";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(401, 161);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(159, 29);
            btnChange.TabIndex = 6;
            btnChange.Text = "Редактировать";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(269, 161);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(613, 161);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "Заказать";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // UserControlTovar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(lblDiscount);
            Controls.Add(lblPrice);
            Controls.Add(lblManufacture);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(picBoxTovar);
            Name = "UserControlTovar";
            Size = new Size(831, 209);
            ((System.ComponentModel.ISupportInitialize)picBoxTovar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxTovar;
        private Label lblName;
        private Label lblDescription;
        private Label lblManufacture;
        private Label lblPrice;
        private Label lblDiscount;
        private Button btnChange;
        private Button btnDelete;
        private Button btnOrder;
    }
}
