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
    public partial class FormOrder : Form
    {
        private List<Product>? ProductsInOrder;
        private FormProducts FormProducts;
        public FormOrder(List<Product> products, FormProducts formProducts)
        {
            InitializeComponent();
            ProductsInOrder = products;
            this.FormProducts = formProducts;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void Fill_panel_products()
        {
            //flowLayoutPanel1.Controls.Clear();
            //if(ProductsInOrder != null)
            //{
            //    foreach(var product in ProductsInOrder)
            //    {
            //        UserControlTovar userControlTovar = new UserControlTovar(product, FormProducts, Role, UserNam);
            //        flowLayoutPanel1.Controls.Add(userControlTovar);
            //    }
            //}
        }
    }
}
