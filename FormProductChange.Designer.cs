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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtBoxImage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownQuantityInStock = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbManufacture = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMaxDiscount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMeasure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxArticle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 54);
            this.label1.TabIndex = 28;
            this.label1.Text = "Редактирование";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 86);
            this.panel1.TabIndex = 56;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(494, 238);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(302, 36);
            this.btnEdit.TabIndex = 83;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(420, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 82;
            this.label14.Text = "Описание";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDescription.Location = new System.Drawing.Point(494, 105);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(302, 130);
            this.txtBoxDescription.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(16, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 80;
            this.label13.Text = "Наличие";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(192, 524);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(193, 25);
            this.cmbStatus.TabIndex = 79;
            // 
            // txtBoxImage
            // 
            this.txtBoxImage.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxImage.Location = new System.Drawing.Point(192, 481);
            this.txtBoxImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxImage.Name = "txtBoxImage";
            this.txtBoxImage.Size = new System.Drawing.Size(193, 24);
            this.txtBoxImage.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(18, 483);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 77;
            this.label12.Text = "Фото";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 76;
            this.label11.Text = "Количество на складе";
            // 
            // numericUpDownQuantityInStock
            // 
            this.numericUpDownQuantityInStock.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownQuantityInStock.Location = new System.Drawing.Point(192, 440);
            this.numericUpDownQuantityInStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownQuantityInStock.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownQuantityInStock.Name = "numericUpDownQuantityInStock";
            this.numericUpDownQuantityInStock.Size = new System.Drawing.Size(192, 24);
            this.numericUpDownQuantityInStock.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "Скидка";
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownDiscount.Location = new System.Drawing.Point(192, 396);
            this.numericUpDownDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(192, 24);
            this.numericUpDownDiscount.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(18, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 72;
            this.label9.Text = "Категория";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(192, 354);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(193, 25);
            this.cmbCategory.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(18, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "Поставщик";
            // 
            // cmbProvider
            // 
            this.cmbProvider.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(192, 310);
            this.cmbProvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(193, 25);
            this.cmbProvider.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(18, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 68;
            this.label7.Text = "Производитель";
            // 
            // cmbManufacture
            // 
            this.cmbManufacture.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbManufacture.FormattingEnabled = true;
            this.cmbManufacture.Location = new System.Drawing.Point(192, 269);
            this.cmbManufacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbManufacture.Name = "cmbManufacture";
            this.cmbManufacture.Size = new System.Drawing.Size(193, 25);
            this.cmbManufacture.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Максимальная скидка";
            // 
            // numericUpDownMaxDiscount
            // 
            this.numericUpDownMaxDiscount.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownMaxDiscount.Location = new System.Drawing.Point(192, 237);
            this.numericUpDownMaxDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMaxDiscount.Name = "numericUpDownMaxDiscount";
            this.numericUpDownMaxDiscount.Size = new System.Drawing.Size(192, 24);
            this.numericUpDownMaxDiscount.TabIndex = 65;
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.DecimalPlaces = 2;
            this.numericUpDownCost.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownCost.Location = new System.Drawing.Point(192, 202);
            this.numericUpDownCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(192, 24);
            this.numericUpDownCost.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Единица измерения";
            // 
            // txtBoxMeasure
            // 
            this.txtBoxMeasure.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMeasure.Location = new System.Drawing.Point(192, 166);
            this.txtBoxMeasure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxMeasure.Name = "txtBoxMeasure";
            this.txtBoxMeasure.Size = new System.Drawing.Size(193, 24);
            this.txtBoxMeasure.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Артикул";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxName.Location = new System.Drawing.Point(192, 134);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(193, 24);
            this.txtBoxName.TabIndex = 58;
            // 
            // txtBoxArticle
            // 
            this.txtBoxArticle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxArticle.Location = new System.Drawing.Point(192, 105);
            this.txtBoxArticle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxArticle.Name = "txtBoxArticle";
            this.txtBoxArticle.Size = new System.Drawing.Size(193, 24);
            this.txtBoxArticle.TabIndex = 57;
            // 
            // FormProductChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 553);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtBoxImage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownQuantityInStock);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbProvider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbManufacture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownMaxDiscount);
            this.Controls.Add(this.numericUpDownCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxMeasure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxArticle);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProductChange";
            this.Text = "FromProductChange";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Panel panel1;
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
    }
}