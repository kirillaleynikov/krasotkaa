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

        }

        private void LoadData()
        {
            using (DB_AleynikovContext db = new DB_AleynikovContext())
            {

            }
        }
    }
}
