﻿using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using krasotkaa.Context;

namespace krasotkaa
{
    public partial class FormProducts : Form
    {
        public string User;
        private int Role;
        public FormProducts(string user, int id)
        {
            InitializeComponent();
            User = user;
            Role = id;
            Init();
            LoadData();
            LoadUser();
            //LoadComboBox();
        }

        private void Init()
        {
            //cmbFiltr.SelectedIndex = 0;
        }

        public void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            using (DB_AleynikovContext db = new DB_AleynikovContext())
            {
                List<Product> products = db.Products.ToList();
                var countItems = products.Count;
                switch (cmbSort.SelectedIndex)
                {
                    case 0: products = db.Products.ToList(); break;
                    case 1: products = db.Products.OrderBy(x => x.ProductCost).ToList(); break;
                    case 2: products = db.Products.OrderByDescending(x => x.ProductCost).ToList(); break;
                }
                switch (cmbFiltr.SelectedIndex)
                {
                    case 0: products = db.Products.ToList(); break;
                    case 1: products = db.Products.Where(x => x.ProductDiscountAmount > 0 && x.ProductDiscountAmount < 9.99).ToList(); break;
                    case 2: products = db.Products.Where(x => x.ProductDiscountAmount > 10 && x.ProductDiscountAmount < 14.99).ToList(); break;
                    case 3: products = db.Products.Where(x => x.ProductDiscountAmount > 15).ToList(); break;
                }
                if (txtBoxSearch.Text != null)
                {
                    products = products.Where(x => x.ProductName.ToLower().Contains(txtBoxSearch.Text.ToLower())).ToList();
                }

                //int id = GetManufacture();
                //if (id != 0)
                //    products = products.Where(x => x.ProductManufacturer == id).ToList();

                foreach (Product item in products)
                {
                    UserControlTovar control = new UserControlTovar(item, this, Role, User/*, false, new FormOrder(new List<Product>(), new FormProducts(User, Role))*/);

                    flowLayoutPanel1.Controls.Add(control);
                }

                toolStripStatusLabel1.Text = $"Количество записей: {flowLayoutPanel1.Controls.Count} из {countItems}";

            }


        }

        private void LoadUser()
        {
            if (User != null)
                lblUser.Text = User;
            switch (Role)
            {
                case 1: btnAddProduct.Visible = false; break;
                case 2: btnAddProduct.Visible = false; break;
                case 3: btnAddProduct.Visible = true; break;
            }
        }

        //private int GetManufacture()
        //{
        //    using (DB_AleynikovContext db = new DB_AleynikovContext())
        //    {
        //        var item = db.Manufactures.FirstOrDefault(x => x.ManufactureName == cmbFiltr.SelectedItem);
        //        if (item != null)
        //            return item.ManufactureId;
        //        else
        //            return 0;
        //    }
        //}
        public string GetUser() => User;
        private void cmbFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        //private void LoadComboBox()
        //{
        //    using (DB_AleynikovContext db = new DB_AleynikovContext())
        //    {
        //        var items = db.Manufactures.ToList();
        //        foreach (var item in items)
        //            cmbFiltr.Items.Add(item.ManufactureName);
        //    }
        //}

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Form form = Application.OpenForms[0];
            form.Show();
        }
    }
}
