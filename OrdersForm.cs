using Microsoft.EntityFrameworkCore.Infrastructure;
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
    public partial class OrdersForm : Form
    {
        
        public OrdersForm()
        {
            InitializeComponent();
            using (var db = new DB_AleynikovContext())
            {
                dataGridView1.DataSource = db.Orders.Select(x => new Context.Order
                {
                    OrderId = x.OrderId,
                    OrderNumber = x.OrderNumber,
                    OrderAmount = x.OrderAmount,
                    OrderDate = x.OrderDate,
                    OrderDeliveryDate = x.OrderDeliveryDate,
                    OrderCost = x.OrderCost,
                    OrderPickPoint = x.OrderPickPoint,
                    OrderClientFio = x.OrderClientFio,
                    OrderCodeForGet = x.OrderCodeForGet,
                    OrderStatus = x.OrderStatus,
                }).ToList();

                var count = db.Orders.Count();
            }
        }
    }
}
