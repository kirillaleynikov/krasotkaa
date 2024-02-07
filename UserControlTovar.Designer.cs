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
            components = new System.ComponentModel.Container();
            picBoxTovar = new PictureBox();
            lblName = new Label();
            lblDescription = new Label();
            lblManufacture = new Label();
            lblPrice = new Label();
            lblDiscount = new Label();
            btnChange = new Button();
            btnDelete = new Button();
            btnOrder = new Button();
            label1 = new Label();
            AddToOrderContextMenuStrip1 = new ContextMenuStrip(components);
            добавитьКЗаказуToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picBoxTovar).BeginInit();
            AddToOrderContextMenuStrip1.SuspendLayout();
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
            lblName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(193, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Наименование";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(193, 23);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(83, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Описание";
            // 
            // lblManufacture
            // 
            lblManufacture.AutoSize = true;
            lblManufacture.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblManufacture.Location = new Point(193, 43);
            lblManufacture.Name = "lblManufacture";
            lblManufacture.Size = new Size(125, 20);
            lblManufacture.TabIndex = 3;
            lblManufacture.Text = "Производитель";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(193, 64);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(45, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Цена";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscount.Location = new Point(368, 64);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(114, 20);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Размер скидки";
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnChange.Location = new Point(293, 94);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(159, 29);
            btnChange.TabIndex = 6;
            btnChange.Text = "Редактировать";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(193, 94);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(458, 94);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "Заказать";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 64);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 9;
            label1.Text = "Скидка:";
            // 
            // AddToOrderContextMenuStrip1
            // 
            AddToOrderContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            AddToOrderContextMenuStrip1.Items.AddRange(new ToolStripItem[] { добавитьКЗаказуToolStripMenuItem });
            AddToOrderContextMenuStrip1.Name = "contextMenuStrip1";
            AddToOrderContextMenuStrip1.Size = new Size(211, 56);
            AddToOrderContextMenuStrip1.Opening += AddToOrderContextMenuStrip1_Opening;
            AddToOrderContextMenuStrip1.Click += AddToOrderContextMenuStrip1_Click;
            // 
            // добавитьКЗаказуToolStripMenuItem
            // 
            добавитьКЗаказуToolStripMenuItem.Name = "добавитьКЗаказуToolStripMenuItem";
            добавитьКЗаказуToolStripMenuItem.Size = new Size(210, 24);
            добавитьКЗаказуToolStripMenuItem.Text = "Добавить к заказу";
            // 
            // UserControlTovar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
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
            Size = new Size(831, 136);
            ((System.ComponentModel.ISupportInitialize)picBoxTovar).EndInit();
            AddToOrderContextMenuStrip1.ResumeLayout(false);
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
        private Label label1;
        private ContextMenuStrip AddToOrderContextMenuStrip1;
        private ToolStripMenuItem добавитьКЗаказуToolStripMenuItem;
    }
}
