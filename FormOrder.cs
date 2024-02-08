using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using krasotkaa.Context;

namespace krasotkaa
{
    public partial class FormOrder : Form
    {
        private Product Item;
        private FormProducts FormProducts;
        private Order Order;
        public FormOrder(Product item, FormProducts formProducts)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 255, 255);
            Random r = new Random();
            int rOrderNumber = r.Next(100, 1000);
            int rOrderCode = r.Next(1000, 9000);
            lblOrderNumber.Text = rOrderNumber.ToString();
            lblOrderCode.Text = rOrderCode.ToString();
            Item = item;
            FormProducts = formProducts;
            LoadData();
            LoadItem();
        }

        private void LoadData()
        {
            using (DB_AleynikovContext db = new DB_AleynikovContext())
            {
                cmbPickPoint.DataSource = db.PickPoints.ToList();
                cmbPickPoint.DisplayMember = "PickPointAddress";
                cmbPickPoint.ValueMember = "PickPointId";
            }
        }

        private void LoadItem()
        {
            lblOrderName.Text = Item.ProductName;
            lblPrice.Text = Item.ProductCost.ToString();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            using (DB_AleynikovContext db = new DB_AleynikovContext())
            {
                Order order = new Order()
                {
                    OrderNumber = int.Parse(lblOrderNumber.Text),
                    OrderComposition = lblOrderName.Text,
                    OrderCost = Convert.ToDouble(lblPrice.Text),
                    OrderStatus = 1,
                    OrderClientFio = txtFIO.Text,
                    OrderCodeForGet = lblOrderCode.Text,
                    OrderPickPoint = (int)cmbPickPoint.SelectedValue,
                    OrderAmount = (int)numericUpDownAmount.Value,
                    OrderDate = dateTimePickerOrderDate.Value,
                    OrderDeliveryDate = dateTimePickerOrderDateDelivery.Value
                };
                db.Orders.Add(order);
                db.SaveChanges();
                MessageBox.Show($"Товар успешно добавлен в заказ", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormProducts.LoadData();
                Close();
            }
        }
    }
}
