namespace krasotkaa
{
    partial class FormProducts
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            cmbFiltr = new ComboBox();
            lblUser = new Label();
            groupBox1 = new GroupBox();
            cmbSort = new ComboBox();
            label1 = new Label();
            txtBoxSearch = new TextBox();
            label2 = new Label();
            btnAddProduct = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 130);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(754, 461);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // cmbFiltr
            // 
            cmbFiltr.FormattingEnabled = true;
            cmbFiltr.Items.AddRange(new object[] { "Все диапазоны", "0 - 9,99%", "10 - 14,99%", "15% и более" });
            cmbFiltr.Location = new Point(615, 52);
            cmbFiltr.Name = "cmbFiltr";
            cmbFiltr.Size = new Size(151, 28);
            cmbFiltr.TabIndex = 1;
            cmbFiltr.SelectedIndexChanged += cmbFiltr_SelectedIndexChanged;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(550, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSort);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(785, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сортировка";
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "--Не выбрано--", "По возрастанию", "По убыванию" });
            cmbSort.Location = new Point(6, 46);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(151, 28);
            cmbSort.TabIndex = 1;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "По стоимости";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(338, 59);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(226, 27);
            txtBoxSearch.TabIndex = 4;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 66);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "Поиск";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(869, 39);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Добавить";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 603);
            Controls.Add(btnAddProduct);
            Controls.Add(label2);
            Controls.Add(txtBoxSearch);
            Controls.Add(groupBox1);
            Controls.Add(lblUser);
            Controls.Add(cmbFiltr);
            Controls.Add(flowLayoutPanel1);
            Name = "FormProducts";
            Text = "Products";
            Load += FormProducts_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cmbFiltr;
        private Label lblUser;
        private GroupBox groupBox1;
        private ComboBox cmbSort;
        private Label label1;
        private TextBox txtBoxSearch;
        private Label label2;
        private Button btnAddProduct;
    }
}