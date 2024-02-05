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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            flowLayoutPanel1 = new FlowLayoutPanel();
            cmbFiltr = new ComboBox();
            lblUser = new Label();
            groupBox1 = new GroupBox();
            cmbSort = new ComboBox();
            label1 = new Label();
            txtBoxSearch = new TextBox();
            btnAddProduct = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnExit = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(19, 130);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(879, 461);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // cmbFiltr
            // 
            cmbFiltr.FormattingEnabled = true;
            cmbFiltr.Items.AddRange(new object[] { "Все диапазоны", "0 - 9,99%", "10 - 14,99%", "15% и более" });
            cmbFiltr.Location = new Point(6, 46);
            cmbFiltr.Name = "cmbFiltr";
            cmbFiltr.Size = new Size(172, 28);
            cmbFiltr.TabIndex = 1;
            cmbFiltr.SelectedIndexChanged += cmbFiltr_SelectedIndexChanged;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(19, 29);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(42, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSort);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(904, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 90);
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
            cmbSort.Size = new Size(172, 28);
            cmbSort.TabIndex = 1;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "По стоимости";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(6, 35);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(172, 28);
            txtBoxSearch.TabIndex = 4;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.Location = new Point(904, 418);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(184, 29);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Добавить товар";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbFiltr);
            groupBox2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(904, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(184, 90);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фильтрация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 0;
            label3.Text = "По скидке";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBoxSearch);
            groupBox3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(904, 322);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(184, 90);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Поиск";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(904, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 9);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 9;
            label2.Text = "Пользователь:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(753, 9);
            label4.Name = "label4";
            label4.Size = new Size(145, 42);
            label4.TabIndex = 10;
            label4.Text = "Красотка";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(541, 51);
            label5.Name = "label5";
            label5.Size = new Size(357, 20);
            label5.TabIndex = 11;
            label5.Text = "Магазин по продаже косметики и парфюмерии";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(19, 52);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Выйти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 619);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1100, 26);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(163, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 645);
            Controls.Add(statusStrip1);
            Controls.Add(btnExit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnAddProduct);
            Controls.Add(groupBox1);
            Controls.Add(lblUser);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProducts";
            Text = "Products";
            Load += FormProducts_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private Button btnAddProduct;
        private GroupBox groupBox2;
        private Label label3;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btnExit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}