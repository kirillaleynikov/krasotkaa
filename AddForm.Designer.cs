namespace krasotkaa
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            label1 = new Label();
            txtBoxArticle = new TextBox();
            txtBoxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtBoxMeasure = new TextBox();
            label4 = new Label();
            label5 = new Label();
            numericUpDownCost = new NumericUpDown();
            numericUpDownMaxDiscount = new NumericUpDown();
            label6 = new Label();
            cmbManufacture = new ComboBox();
            label7 = new Label();
            cmbProvider = new ComboBox();
            label8 = new Label();
            cmbCategory = new ComboBox();
            label9 = new Label();
            numericUpDownDiscount = new NumericUpDown();
            label10 = new Label();
            numericUpDownQuantityInStock = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            txtBoxImage = new TextBox();
            cmbStatus = new ComboBox();
            label13 = new Label();
            txtBoxDescription = new TextBox();
            label14 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantityInStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 4);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Добавление";
            // 
            // txtBoxArticle
            // 
            txtBoxArticle.Location = new Point(154, 55);
            txtBoxArticle.Name = "txtBoxArticle";
            txtBoxArticle.Size = new Size(125, 27);
            txtBoxArticle.TabIndex = 1;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(154, 97);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(125, 27);
            txtBoxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 58);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Артикул";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 100);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 4;
            label3.Text = "Наименование";
            // 
            // txtBoxMeasure
            // 
            txtBoxMeasure.Location = new Point(213, 130);
            txtBoxMeasure.Name = "txtBoxMeasure";
            txtBoxMeasure.Size = new Size(125, 27);
            txtBoxMeasure.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 133);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 6;
            label4.Text = "Единица измерения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 166);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 7;
            label5.Text = "Стоимость";
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.DecimalPlaces = 2;
            numericUpDownCost.Location = new Point(183, 170);
            numericUpDownCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(150, 27);
            numericUpDownCost.TabIndex = 8;
            // 
            // numericUpDownMaxDiscount
            // 
            numericUpDownMaxDiscount.Location = new Point(229, 215);
            numericUpDownMaxDiscount.Name = "numericUpDownMaxDiscount";
            numericUpDownMaxDiscount.Size = new Size(150, 27);
            numericUpDownMaxDiscount.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 217);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 10;
            label6.Text = "Максимальная скидка";
            // 
            // cmbManufacture
            // 
            cmbManufacture.FormattingEnabled = true;
            cmbManufacture.Location = new Point(246, 269);
            cmbManufacture.Name = "cmbManufacture";
            cmbManufacture.Size = new Size(151, 28);
            cmbManufacture.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 272);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 12;
            label7.Text = "Производитель";
            // 
            // cmbProvider
            // 
            cmbProvider.FormattingEnabled = true;
            cmbProvider.Location = new Point(246, 314);
            cmbProvider.Name = "cmbProvider";
            cmbProvider.Size = new Size(151, 28);
            cmbProvider.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 317);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 14;
            label8.Text = "Поставщик";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(246, 367);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 367);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 16;
            label9.Text = "Категория";
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Location = new Point(246, 414);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(150, 27);
            numericUpDownDiscount.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 421);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 18;
            label10.Text = "Скидка";
            // 
            // numericUpDownQuantityInStock
            // 
            numericUpDownQuantityInStock.Location = new Point(246, 456);
            numericUpDownQuantityInStock.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownQuantityInStock.Name = "numericUpDownQuantityInStock";
            numericUpDownQuantityInStock.Size = new Size(150, 27);
            numericUpDownQuantityInStock.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 463);
            label11.Name = "label11";
            label11.Size = new Size(161, 20);
            label11.TabIndex = 20;
            label11.Text = "Количество на складе";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 504);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 21;
            label12.Text = "Фото";
            // 
            // txtBoxImage
            // 
            txtBoxImage.Location = new Point(246, 501);
            txtBoxImage.Name = "txtBoxImage";
            txtBoxImage.Size = new Size(125, 27);
            txtBoxImage.TabIndex = 22;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(245, 545);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(42, 548);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 24;
            label13.Text = "Наличие";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(645, 76);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(345, 172);
            txtBoxDescription.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(544, 79);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 26;
            label14.Text = "Описание";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(609, 345);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 650);
            Controls.Add(btnAdd);
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
            Name = "AddForm";
            Text = "Добавление товаров";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantityInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxArticle;
        private TextBox txtBoxName;
        private Label label2;
        private Label label3;
        private TextBox txtBoxMeasure;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownCost;
        private NumericUpDown numericUpDownMaxDiscount;
        private Label label6;
        private ComboBox cmbManufacture;
        private Label label7;
        private ComboBox cmbProvider;
        private Label label8;
        private ComboBox cmbCategory;
        private Label label9;
        private NumericUpDown numericUpDownDiscount;
        private Label label10;
        private NumericUpDown numericUpDownQuantityInStock;
        private Label label11;
        private Label label12;
        private TextBox txtBoxImage;
        private ComboBox cmbStatus;
        private Label label13;
        private TextBox txtBoxDescription;
        private Label label14;
        private Button btnAdd;
    }
}