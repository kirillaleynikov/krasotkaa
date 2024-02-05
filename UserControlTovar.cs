using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using krasotkaa.Context;
using krasotkaa.Properties;
using Microsoft.EntityFrameworkCore.Metadata;

namespace krasotkaa
{
    public partial class UserControlTovar : UserControl
    {
        private Product Item;
        private FormProducts FormProducts;
        private int Role;
        private string User;

        public UserControlTovar(Product item, FormProducts form, int role, string user)
        {
            Item = item;
            FormProducts = form;
            Role = role;
            User = user;
            InitializeComponent();
            CreateItem();
            RoleCheck();
        }

        private void CreateItem()
        {
            try
            { picBoxTovar.Image = Image.FromFile(@"..\\..\\..\\Resources\" + Item.ProductPhoto); }
            catch
            { picBoxTovar.Image = Resources.picture; }

            lblName.Text = Item.ProductName;
            lblDescription.Text = Item.ProductDescription;
            lblManufacture.Text += " " + GetManufacture();
            lblDiscount.Text = Item.ProductDiscountAmount.ToString() + "%";

            if (Item.ProductDiscountAmount == 0)
            {
                lblPrice.Text += " " + Item.ProductCost.ToString();
            }
            else
            {
                lblPrice.Text += $" {Item.ProductCost - Item.ProductCost * Item.ProductDiscountAmount / 100}";
            }

            if (Item.ProductQuantityInStock == 0)
            {
                BackColor = Color.LightGray;
                btnOrder.Enabled = false;
            }
        }

        private void RoleCheck()
        {
            if (Role == 1)
            {
                btnDelete.Visible = true;
                btnChange.Visible = true;
            }
        }

        private string GetManufacture()
        {
            using (DB_AleynikovContext db = new DB_AleynikovContext())
            {
                var manufacture = db.Manufactures.FirstOrDefault(x => x.ManufactureId == Item.ProductManufacturer);
                return manufacture!.ManufactureName;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FormProductChange form = new FormProductChange(Item, FormProducts);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить товар?", "Предупржедение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (DB_AleynikovContext db = new DB_AleynikovContext())
                {
                    //var item = db.Orders.FirstOrDefault(x => x.OrderComposition == Item.ProductArticleNumber && x.OrderStatus == 2);
                    //if (item != null)
                    //{
                        db.Products.Remove(Item);
                        db.SaveChanges();
                        FormProducts.LoadData();
                    //}
                    //else
                    //    MessageBox.Show("Невозможно удалить, так как товар находится в заказе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
