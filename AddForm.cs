using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using krasotkaa.Context;

namespace krasotkaa
{
    public partial class AddForm : Form
    {
        private FormProducts FormProducts;
        public AddForm(FormProducts form)
        {
            InitializeComponent();
            FormProducts = form;
            LoadData();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validation() && CheckArticle())
            {
                using (DB_AleynikovContext db = new DB_AleynikovContext())
                {
                    Product item = new Product
                    {
                        ProductArticleNumber = txtBoxArticle.Text,
                        ProductName = txtBoxName.Text,
                        ProductMeasurement = txtBoxMeasure.Text,
                        ProductCost = (double)numericUpDownCost.Value,
                        ProductMaxDiscount = (double)numericUpDownMaxDiscount.Value,
                        ProductManufacturer = (int)cmbManufacture.SelectedValue,
                        ProductProvider = (int)cmbProvider.SelectedValue,
                        ProductCategory = (int)cmbCategory.SelectedValue,
                        ProductDiscountAmount = (double)numericUpDownDiscount.Value,
                        ProductQuantityInStock = (int)numericUpDownQuantityInStock.Value,
                        ProductStatus = (int)cmbStatus.SelectedValue,
                        ProductPhoto = txtBoxImage.Text,
                        ProductDescription = txtBoxDescription.Text,


                    };
                    db.Products.Add(item);
                    db.SaveChanges();
                    FormProducts.LoadData();
                    Close();
                }
            }
        }

        private bool CheckArticle()
        {
            using (DB_AleynikovContext db = new DB_AleynikovContext())
            {
                var item = db.Products.FirstOrDefault(x => x.ProductArticleNumber == txtBoxArticle.Text);
                if (item == null)
                    return true;
                else
                {
                    MessageBox.Show($"Артикул {item.ProductArticleNumber} уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
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
    }
}
