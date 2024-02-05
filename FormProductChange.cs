using krasotkaa.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krasotkaa
{
    public partial class FormProductChange : Form
    {
        private Product Item;
        private FormProducts FormProducts;
        public FormProductChange(Product item, FormProducts formProducts)
        {
            InitializeComponent();
            Item = item;
            FormProducts = formProducts;
            LoadData();
            LoadItem();
            panel1.BackColor = Color.FromArgb(255, 204, 153);

        }

        private void LoadData()
        {
            using (DB_AleynikovContext db = new DB_AleynikovContext())
            {
                cmbCategory.DataSource = db.CategoryOfProducts.ToList();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";

                cmbManufacture.DataSource = db.Manufactures.ToList();
                cmbManufacture.DisplayMember = "ManufactureName";
                cmbManufacture.ValueMember = "ManufactureId";

                cmbProvider.DataSource = db.Providers.ToList();
                cmbProvider.DisplayMember = "ProviderName";
                cmbProvider.ValueMember = "ProviderId";

                cmbStatus.DataSource = db.StatusOfProducts.ToList();
                cmbStatus.DisplayMember = "StatusOfProductName";
                cmbStatus.ValueMember = "StatusOfProductId";
            }
        }

        private void LoadItem()
        {
            txtBoxArticle.Text = Item.ProductArticleNumber;
            txtBoxName.Text = Item.ProductName;
            txtBoxMeasure.Text = Item.ProductMeasurement;
            numericUpDownCost.Value = (decimal)Item.ProductCost;
            numericUpDownMaxDiscount.Value = (int)Item.ProductMaxDiscount;
            cmbManufacture.SelectedValue = Item.ProductManufacturer;
            cmbProvider.SelectedValue = Item.ProductProvider;
            cmbCategory.SelectedValue = Item.ProductCategory;
            numericUpDownDiscount.Value = (int)Item.ProductDiscountAmount;
            numericUpDownQuantityInStock.Value = Item.ProductQuantityInStock;
            cmbStatus.SelectedValue = Item.ProductStatus;
            txtBoxImage.Text = Item.ProductPhoto;
            txtBoxDescription.Text = Item.ProductDescription;
        }

        private bool Validation()
        {
            foreach (Control tb in Controls)
            {
                if (tb is TextBox && string.IsNullOrEmpty(tb.Text))
                {
                    if (tb.Name == "txtDescription") continue;
                    MessageBox.Show($"{tb.Tag} должно быть заполнено.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                using (DB_AleynikovContext db = new DB_AleynikovContext())
                {
                    Item.ProductArticleNumber = txtBoxArticle.Text;
                    Item.ProductName = txtBoxName.Text;
                    Item.ProductMeasurement = txtBoxMeasure.Text;
                    Item.ProductCost = (double)numericUpDownCost.Value;
                    Item.ProductMaxDiscount = (double)numericUpDownMaxDiscount.Value;
                    Item.ProductManufacturer = (int)cmbManufacture.SelectedValue;
                    Item.ProductProvider = (int)cmbProvider.SelectedValue;
                    Item.ProductCategory = (int)cmbCategory.SelectedValue;
                    Item.ProductDiscountAmount = (double)numericUpDownDiscount.Value;
                    Item.ProductQuantityInStock = (int)numericUpDownQuantityInStock.Value;
                    Item.ProductStatus = (int)cmbStatus.SelectedValue;
                    Item.ProductPhoto = txtBoxImage.Text;
                    Item.ProductDescription = txtBoxDescription.Text;

                    db.Products.Update(Item);
                    db.SaveChanges();
                    FormProducts.LoadData();
                    Close();
                }
            }
        }

        private void FormProductChange_Load(object sender, EventArgs e)
        {

        }


    }
}
