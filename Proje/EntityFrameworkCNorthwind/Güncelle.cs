using EntityFrameworkDatabase.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCNorthwind
{
    public partial class Güncelle : Form
    {
        Products products1 = null;
        NorthwindDbContex db = null;
        public Güncelle(Products products,NorthwindDbContex db)
        {
            InitializeComponent();
            products1 = products;
            this.db = db;
        }

        private void Güncelle_Load(object sender, EventArgs e)
        {
            textBox_name.Text = products1.ProductName;
            numericUpDown1.Value =Convert.ToDecimal( products1.UnitsInStock);
            var suppliers = db.Suppliers.AsNoTracking().Select(x => x.CompanyName).ToList();
            comboBox_tedarikci.Items.AddRange(suppliers.ToArray());
            comboBox_tedarikci.SelectedItem = products1.Suppliers.CompanyName;
            var category = db.Categories.AsNoTracking().Select(x => x.CategoryName).ToList();
            comboBox_category.Items.AddRange(category.ToArray());
            comboBox_category.SelectedItem = products1.Categories.CategoryName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(db.Entry(products1).State.ToString());
            products1.ProductName = textBox_name.Text;
            products1.UnitsInStock =Convert.ToInt16( numericUpDown1.Value);
           // MessageBox.Show(db.Entry(products1).State.ToString());
            //db.SaveChanges();
            var s = comboBox_tedarikci.SelectedItem.ToString();
            var c = comboBox_category.SelectedItem.ToString();
            int sid = db.Suppliers.FirstOrDefault(x => x.CompanyName == s).SupplierID;
            int cid = db.Categories.FirstOrDefault(x => x.CategoryName == c).CategoryID;
            products1.CategoryID = cid;
            products1.SupplierID = sid;
            if (db.SaveChanges()>0)
            {
                MessageBox.Show(products1.ProductName + " " + "Ürünü Başarıyla Güncellendi Geçmiş Olsun Grup165");
            }

        }
    }
}
