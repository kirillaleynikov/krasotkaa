namespace krasotkaa
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerOrderDate = new DateTimePicker();
            dateTimePickerOrderDateDelivery = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblOrderNumber = new Label();
            lblOrderName = new Label();
            numericUpDownAmount = new NumericUpDown();
            lblPrice = new Label();
            cmbPickPoint = new ComboBox();
            txtFIO = new TextBox();
            lblOrderCode = new Label();
            lblOrderStatus = new Label();
            btnOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Оформление заказа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 70);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 103);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Количество";
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.Location = new Point(57, 139);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(250, 27);
            dateTimePickerOrderDate.TabIndex = 3;
            // 
            // dateTimePickerOrderDateDelivery
            // 
            dateTimePickerOrderDateDelivery.Location = new Point(57, 184);
            dateTimePickerOrderDateDelivery.Name = "dateTimePickerOrderDateDelivery";
            dateTimePickerOrderDateDelivery.Size = new Size(250, 27);
            dateTimePickerOrderDateDelivery.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 237);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 5;
            label4.Text = "Стоимость";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 273);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 6;
            label5.Text = "Пункт выдачи";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 321);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 7;
            label6.Text = "ФИО получателя:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 362);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 8;
            label7.Text = "Код получения";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 412);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 9;
            label8.Text = "Статус заказа";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 37);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 10;
            label9.Text = "Номер заказа";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(182, 37);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(58, 20);
            lblOrderNumber.TabIndex = 11;
            lblOrderNumber.Text = "label10";
            // 
            // lblOrderName
            // 
            lblOrderName.AutoSize = true;
            lblOrderName.Location = new Point(183, 71);
            lblOrderName.Name = "lblOrderName";
            lblOrderName.Size = new Size(58, 20);
            lblOrderName.TabIndex = 12;
            lblOrderName.Text = "label11";
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(182, 101);
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(150, 27);
            numericUpDownAmount.TabIndex = 13;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(182, 237);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 20);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "label12";
            // 
            // cmbPickPoint
            // 
            cmbPickPoint.FormattingEnabled = true;
            cmbPickPoint.Location = new Point(183, 270);
            cmbPickPoint.Name = "cmbPickPoint";
            cmbPickPoint.Size = new Size(151, 28);
            cmbPickPoint.TabIndex = 15;
            // 
            // txtFIO
            // 
            txtFIO.Location = new Point(198, 318);
            txtFIO.Name = "txtFIO";
            txtFIO.Size = new Size(152, 27);
            txtFIO.TabIndex = 16;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Location = new Point(198, 362);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(58, 20);
            lblOrderCode.TabIndex = 17;
            lblOrderCode.Text = "label13";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Location = new Point(198, 412);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(57, 20);
            lblOrderStatus.TabIndex = 18;
            lblOrderStatus.Text = "Новый";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(313, 473);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(243, 29);
            btnOrder.TabIndex = 19;
            btnOrder.Text = "Заказать";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 571);
            Controls.Add(btnOrder);
            Controls.Add(lblOrderStatus);
            Controls.Add(lblOrderCode);
            Controls.Add(txtFIO);
            Controls.Add(cmbPickPoint);
            Controls.Add(lblPrice);
            Controls.Add(numericUpDownAmount);
            Controls.Add(lblOrderName);
            Controls.Add(lblOrderNumber);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePickerOrderDateDelivery);
            Controls.Add(dateTimePickerOrderDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOrder";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerOrderDate;
        private DateTimePicker dateTimePickerOrderDateDelivery;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblOrderNumber;
        private Label lblOrderName;
        private NumericUpDown numericUpDownAmount;
        private Label lblPrice;
        private ComboBox cmbPickPoint;
        private TextBox txtFIO;
        private Label lblOrderCode;
        private Label lblOrderStatus;
        private Button btnOrder;
    }
}