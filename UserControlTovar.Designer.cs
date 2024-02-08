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
            this.components = new System.ComponentModel.Container();
            this.picBoxTovar = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblManufacture = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToOrderContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКЗаказуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTovar)).BeginInit();
            this.AddToOrderContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxTovar
            // 
            this.picBoxTovar.Image = global::krasotkaa.Properties.Resources.picture;
            this.picBoxTovar.Location = new System.Drawing.Point(3, 2);
            this.picBoxTovar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxTovar.Name = "picBoxTovar";
            this.picBoxTovar.Size = new System.Drawing.Size(161, 90);
            this.picBoxTovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTovar.TabIndex = 0;
            this.picBoxTovar.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(169, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Наименование";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(169, 17);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Описание";
            // 
            // lblManufacture
            // 
            this.lblManufacture.AutoSize = true;
            this.lblManufacture.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManufacture.Location = new System.Drawing.Point(169, 32);
            this.lblManufacture.Name = "lblManufacture";
            this.lblManufacture.Size = new System.Drawing.Size(99, 17);
            this.lblManufacture.TabIndex = 3;
            this.lblManufacture.Text = "Производитель";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(169, 48);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Цена";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscount.Location = new System.Drawing.Point(524, 39);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(91, 17);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Размер скидки";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(256, 70);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(139, 25);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Редактировать";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(170, 70);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(401, 70);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(82, 25);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Заказать";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Скидка:";
            // 
            // AddToOrderContextMenuStrip1
            // 
            this.AddToOrderContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AddToOrderContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКЗаказуToolStripMenuItem});
            this.AddToOrderContextMenuStrip1.Name = "contextMenuStrip1";
            this.AddToOrderContextMenuStrip1.Size = new System.Drawing.Size(173, 26);
            // 
            // добавитьКЗаказуToolStripMenuItem
            // 
            this.добавитьКЗаказуToolStripMenuItem.Name = "добавитьКЗаказуToolStripMenuItem";
            this.добавитьКЗаказуToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.добавитьКЗаказуToolStripMenuItem.Text = "Добавить к заказу";
            // 
            // UserControlTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblManufacture);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picBoxTovar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlTovar";
            this.Size = new System.Drawing.Size(727, 102);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTovar)).EndInit();
            this.AddToOrderContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
