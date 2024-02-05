namespace krasotkaa
{
    partial class FormProductChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductChange));
            btnEdit = new Button();
            label14 = new Label();
            txtBoxDescription = new TextBox();
            label13 = new Label();
            cmbStatus = new ComboBox();
            txtBoxImage = new TextBox();
            label12 = new Label();
            label11 = new Label();
            numericUpDownQuantityInStock = new NumericUpDown();
            label10 = new Label();
            numericUpDownDiscount = new NumericUpDown();
            label9 = new Label();
            cmbCategory = new ComboBox();
            label8 = new Label();
            cmbProvider = new ComboBox();
            label7 = new Label();
            cmbManufacture = new ComboBox();
            label6 = new Label();
            numericUpDownMaxDiscount = new NumericUpDown();
            numericUpDownCost = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            txtBoxMeasure = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtBoxName = new TextBox();
            txtBoxArticle = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantityInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(618, 350);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(165, 29);
            btnEdit.TabIndex = 55;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(553, 84);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 54;
            label14.Text = "Описание";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(654, 81);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(345, 172);
            txtBoxDescription.TabIndex = 53;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(51, 553);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 52;
            label13.Text = "Наличие";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(254, 550);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 51;
            // 
            // txtBoxImage
            // 
            txtBoxImage.Location = new Point(255, 506);
            txtBoxImage.Name = "txtBoxImage";
            txtBoxImage.Size = new Size(125, 27);
            txtBoxImage.TabIndex = 50;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(51, 509);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 49;
            label12.Text = "Фото";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 468);
            label11.Name = "label11";
            label11.Size = new Size(161, 20);
            label11.TabIndex = 48;
            label11.Text = "Количество на складе";
            // 
            // numericUpDownQuantityInStock
            // 
            numericUpDownQuantityInStock.Location = new Point(255, 461);
            numericUpDownQuantityInStock.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownQuantityInStock.Name = "numericUpDownQuantityInStock";
            numericUpDownQuantityInStock.Size = new Size(150, 27);
            numericUpDownQuantityInStock.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(78, 426);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 46;
            label10.Text = "Скидка";
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Location = new Point(255, 419);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(150, 27);
            numericUpDownDiscount.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 372);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 44;
            label9.Text = "Категория";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(255, 372);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 322);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 42;
            label8.Text = "Поставщик";
            // 
            // cmbProvider
            // 
            cmbProvider.FormattingEnabled = true;
            cmbProvider.Location = new Point(255, 319);
            cmbProvider.Name = "cmbProvider";
            cmbProvider.Size = new Size(151, 28);
            cmbProvider.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 277);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 40;
            label7.Text = "Производитель";
            // 
            // cmbManufacture
            // 
            cmbManufacture.FormattingEnabled = true;
            cmbManufacture.Location = new Point(255, 274);
            cmbManufacture.Name = "cmbManufacture";
            cmbManufacture.Size = new Size(151, 28);
            cmbManufacture.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 222);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 38;
            label6.Text = "Максимальная скидка";
            // 
            // numericUpDownMaxDiscount
            // 
            numericUpDownMaxDiscount.Location = new Point(238, 220);
            numericUpDownMaxDiscount.Name = "numericUpDownMaxDiscount";
            numericUpDownMaxDiscount.Size = new Size(150, 27);
            numericUpDownMaxDiscount.TabIndex = 37;
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.DecimalPlaces = 2;
            numericUpDownCost.Location = new Point(192, 175);
            numericUpDownCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(150, 27);
            numericUpDownCost.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 171);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 35;
            label5.Text = "Стоимость";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 138);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 34;
            label4.Text = "Единица измерения";
            // 
            // txtBoxMeasure
            // 
            txtBoxMeasure.Location = new Point(222, 135);
            txtBoxMeasure.Name = "txtBoxMeasure";
            txtBoxMeasure.Size = new Size(125, 27);
            txtBoxMeasure.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 105);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 32;
            label3.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 63);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 31;
            label2.Text = "Артикул";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(163, 102);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(125, 27);
            txtBoxName.TabIndex = 30;
            // 
            // txtBoxArticle
            // 
            txtBoxArticle.Location = new Point(163, 60);
            txtBoxArticle.Name = "txtBoxArticle";
            txtBoxArticle.Size = new Size(125, 27);
            txtBoxArticle.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 28;
            label1.Text = "Редактирование";
            // 
            // FormProductChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 737);
            Controls.Add(btnEdit);
            Controls.Add(label14);
            Controls.Add(txtBoxDescription);
            Controls.Add(label13);
            Controls.Add(cmbStatus);
            Controls.Add(txtBoxImage);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(numericUpDownQuantityInStock);
            Controls.Add(label10);
            Controls.Add(numericUpDownDiscount);
            Controls.Add(label9);
            Controls.Add(cmbCategory);
            Controls.Add(label8);
            Controls.Add(cmbProvider);
            Controls.Add(label7);
            Controls.Add(cmbManufacture);
            Controls.Add(label6);
            Controls.Add(numericUpDownMaxDiscount);
            Controls.Add(numericUpDownCost);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBoxMeasure);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxArticle);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProductChange";
            Text = "FromProductChange";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantityInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label label14;
        private TextBox txtBoxDescription;
        private Label label13;
        private ComboBox cmbStatus;
        private TextBox txtBoxImage;
        private Label label12;
        private Label label11;
        private NumericUpDown numericUpDownQuantityInStock;
        private Label label10;
        private NumericUpDown numericUpDownDiscount;
        private Label label9;
        private ComboBox cmbCategory;
        private Label label8;
        private ComboBox cmbProvider;
        private Label label7;
        private ComboBox cmbManufacture;
        private Label label6;
        private NumericUpDown numericUpDownMaxDiscount;
        private NumericUpDown numericUpDownCost;
        private Label label5;
        private Label label4;
        private TextBox txtBoxMeasure;
        private Label label3;
        private Label label2;
        private TextBox txtBoxName;
        private TextBox txtBoxArticle;
        private Label label1;
    }
}