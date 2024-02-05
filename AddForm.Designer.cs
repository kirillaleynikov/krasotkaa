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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantityInStock).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 67);
            label1.TabIndex = 0;
            label1.Text = "Добавление";
            // 
            // txtBoxArticle
            // 
            txtBoxArticle.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxArticle.Location = new Point(217, 113);
            txtBoxArticle.Name = "txtBoxArticle";
            txtBoxArticle.Size = new Size(220, 28);
            txtBoxArticle.TabIndex = 1;
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.Location = new Point(217, 151);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(220, 28);
            txtBoxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 116);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Артикул";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 154);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 4;
            label3.Text = "Наименование";
            // 
            // txtBoxMeasure
            // 
            txtBoxMeasure.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxMeasure.Location = new Point(217, 195);
            txtBoxMeasure.Name = "txtBoxMeasure";
            txtBoxMeasure.Size = new Size(220, 28);
            txtBoxMeasure.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 198);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 6;
            label4.Text = "Единица измерения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 245);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 7;
            label5.Text = "Стоимость";
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.DecimalPlaces = 2;
            numericUpDownCost.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCost.Location = new Point(217, 243);
            numericUpDownCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(220, 28);
            numericUpDownCost.TabIndex = 8;
            // 
            // numericUpDownMaxDiscount
            // 
            numericUpDownMaxDiscount.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownMaxDiscount.Location = new Point(217, 289);
            numericUpDownMaxDiscount.Name = "numericUpDownMaxDiscount";
            numericUpDownMaxDiscount.Size = new Size(220, 28);
            numericUpDownMaxDiscount.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 289);
            label6.Name = "label6";
            label6.Size = new Size(168, 20);
            label6.TabIndex = 10;
            label6.Text = "Максимальная скидка";
            // 
            // cmbManufacture
            // 
            cmbManufacture.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbManufacture.FormattingEnabled = true;
            cmbManufacture.Location = new Point(217, 332);
            cmbManufacture.Name = "cmbManufacture";
            cmbManufacture.Size = new Size(220, 28);
            cmbManufacture.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 335);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 12;
            label7.Text = "Производитель";
            // 
            // cmbProvider
            // 
            cmbProvider.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProvider.FormattingEnabled = true;
            cmbProvider.Location = new Point(217, 387);
            cmbProvider.Name = "cmbProvider";
            cmbProvider.Size = new Size(220, 28);
            cmbProvider.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 390);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 14;
            label8.Text = "Поставщик";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(217, 445);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(220, 28);
            cmbCategory.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(18, 448);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 16;
            label9.Text = "Категория";
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownDiscount.Location = new Point(217, 501);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(220, 28);
            numericUpDownDiscount.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(18, 503);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 18;
            label10.Text = "Скидка";
            // 
            // numericUpDownQuantityInStock
            // 
            numericUpDownQuantityInStock.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownQuantityInStock.Location = new Point(217, 559);
            numericUpDownQuantityInStock.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownQuantityInStock.Name = "numericUpDownQuantityInStock";
            numericUpDownQuantityInStock.Size = new Size(220, 28);
            numericUpDownQuantityInStock.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(18, 561);
            label11.Name = "label11";
            label11.Size = new Size(170, 20);
            label11.TabIndex = 20;
            label11.Text = "Количество на складе";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(18, 617);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 21;
            label12.Text = "Фото";
            // 
            // txtBoxImage
            // 
            txtBoxImage.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxImage.Location = new Point(217, 614);
            txtBoxImage.Name = "txtBoxImage";
            txtBoxImage.Size = new Size(220, 28);
            txtBoxImage.TabIndex = 22;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(217, 671);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(220, 28);
            cmbStatus.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(16, 674);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 24;
            label13.Text = "Наличие";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(563, 113);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(345, 172);
            txtBoxDescription.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(478, 116);
            label14.Name = "label14";
            label14.Size = new Size(83, 20);
            label14.TabIndex = 26;
            label14.Text = "Описание";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(563, 291);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(345, 29);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 89);
            panel1.TabIndex = 28;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 727);
            Controls.Add(panel1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddForm";
            Text = "Добавление товаров";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantityInStock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}