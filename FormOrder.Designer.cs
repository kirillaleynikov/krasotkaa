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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOrderDateDelivery = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblOrderName = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbPickPoint = new System.Windows.Forms.ComboBox();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.lblOrderCode = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(189, 218);
            this.dateTimePickerOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(219, 41);
            this.dateTimePickerOrderDate.TabIndex = 3;
            // 
            // dateTimePickerOrderDateDelivery
            // 
            this.dateTimePickerOrderDateDelivery.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerOrderDateDelivery.Location = new System.Drawing.Point(189, 263);
            this.dateTimePickerOrderDateDelivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerOrderDateDelivery.Name = "dateTimePickerOrderDateDelivery";
            this.dateTimePickerOrderDateDelivery.Size = new System.Drawing.Size(219, 41);
            this.dateTimePickerOrderDateDelivery.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пункт выдачи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 33);
            this.label6.TabIndex = 7;
            this.label6.Text = "ФИО получателя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 33);
            this.label7.TabIndex = 8;
            this.label7.Text = "Код получения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 33);
            this.label8.TabIndex = 9;
            this.label8.Text = "Статус заказа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 33);
            this.label9.TabIndex = 10;
            this.label9.Text = "Номер заказа";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderNumber.Location = new System.Drawing.Point(203, 79);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(94, 33);
            this.lblOrderNumber.TabIndex = 11;
            this.lblOrderNumber.Text = "label10";
            // 
            // lblOrderName
            // 
            this.lblOrderName.AutoSize = true;
            this.lblOrderName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderName.Location = new System.Drawing.Point(203, 123);
            this.lblOrderName.Name = "lblOrderName";
            this.lblOrderName.Size = new System.Drawing.Size(90, 33);
            this.lblOrderName.TabIndex = 12;
            this.lblOrderName.Text = "label11";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownAmount.Location = new System.Drawing.Point(189, 163);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(219, 41);
            this.numericUpDownAmount.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(186, 320);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(94, 33);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "label12";
            // 
            // cmbPickPoint
            // 
            this.cmbPickPoint.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPickPoint.FormattingEnabled = true;
            this.cmbPickPoint.Location = new System.Drawing.Point(207, 362);
            this.cmbPickPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPickPoint.Name = "cmbPickPoint";
            this.cmbPickPoint.Size = new System.Drawing.Size(460, 41);
            this.cmbPickPoint.TabIndex = 15;
            // 
            // txtFIO
            // 
            this.txtFIO.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFIO.Location = new System.Drawing.Point(235, 413);
            this.txtFIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new System.Drawing.Size(432, 41);
            this.txtFIO.TabIndex = 16;
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.AutoSize = true;
            this.lblOrderCode.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderCode.Location = new System.Drawing.Point(214, 473);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(94, 33);
            this.lblOrderCode.TabIndex = 17;
            this.lblOrderCode.Text = "label13";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderStatus.Location = new System.Drawing.Point(207, 532);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(93, 33);
            this.lblOrderStatus.TabIndex = 18;
            this.lblOrderStatus.Text = "Новый";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(415, 574);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(213, 56);
            this.btnOrder.TabIndex = 19;
            this.btnOrder.Text = "Заказать";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 641);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblOrderCode);
            this.Controls.Add(this.txtFIO);
            this.Controls.Add(this.cmbPickPoint);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.lblOrderName);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerOrderDateDelivery);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOrder";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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