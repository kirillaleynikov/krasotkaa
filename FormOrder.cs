using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public FormOrder(Product item, FormProducts formProducts)
        {
            InitializeComponent();
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
    }
}
