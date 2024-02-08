using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using krasotkaa.Context;
using krasotkaa.Properties;
using Microsoft.EntityFrameworkCore.Metadata;
using SaleLibrary;

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
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 255, 255);
            btnChange.BackColor = Color.FromArgb(255, 204, 153);
            btnDelete.BackColor = Color.FromArgb(255, 204, 153);
            btnOrder.BackColor = Color.FromArgb(255, 204, 153);
            Item = item;
            FormProducts = form;
            Role = role;
            User = user;

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
            lblManufacture.Text = Item.ProductManufacturerNavigation.ManufactureName;
            lblPrice.Text = Item.ProductCost.ToString();
            lblDiscount.Text = Item.ProductDiscountAmount.ToString() + "%";

            if (Item.ProductDiscountAmount > 0)
            {
                lblPrice.Font = new Font(lblPrice.Font, FontStyle.Strikeout);
                Label label = new Label();
                label.Text = Math.Round(Item.ProductCost - DiscountCalculation.Discount(Item.ProductCost, (int)Item.ProductDiscountAmount), 2).ToString() + " руб";
                label.Location = new Point(lblPrice.Location.X + lblPrice.Width, lblPrice.Location.Y);
                label.Font = new Font(lblPrice.Font, FontStyle.Regular);
                label.AutoSize = true;
                this.Controls.Add(label);
            }

            //Перекраска элемента при скидке > 15%
            if (Item.ProductDiscountAmount > 15)
            {
                this.BackColor = Color.FromArgb(0x7f, 0xff, 0x00);
            }

        }

        private void RoleCheck()
        {
            if (Role == 1)
            {
                btnDelete.Visible = false;
                btnChange.Visible = false;
            }
            if (Role == 2)
            {
                btnDelete.Visible = false;
            }
            if (Role == 0)
            {
                btnDelete.Visible = false;
                btnChange.Visible = false;
            }
        }

        //private string GetManufacture()
        //{
        //    using (BloggingContext db = new BloggingContext())
        //    {
        //        var manufacture = db.Manufactures.FirstOrDefault(x => x.ManufactureId == Item.ProductManufacturer);
        //        return manufacture!.ManufactureName;
        //    }
        //}

        private void btnChange_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить товар?", "Предупржедение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (DB_AleynikovContext db = new DB_AleynikovContext())
                {
                    db.Products.Remove(Item);
                    db.SaveChanges();
                    FormProducts.LoadData();
                }
            }
        }

        private void AddToOrderContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AddToOrderContextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьКЗаказуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder(Item, FormProducts);
            formOrder.ShowDialog();
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            FormProductChange form = new FormProductChange(Item, FormProducts);
            form.ShowDialog();
        }
    }
}
