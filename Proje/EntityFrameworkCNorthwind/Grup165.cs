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
    public partial class Grup165 : Form
    {
        NorthwindDbContex db = null;
        public Grup165()
        {
            InitializeComponent();
            db = new NorthwindDbContex();

        }

        private void Grup165_Load(object sender, EventArgs e)
        {
            //NorthwindDbContex db = new NorthwindDbContex();
            //dataGridView1.DataSource = db.Products.ToList();
            DataGridViewStart();
            

        }

        private void DataGridViewStart()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Ürün Adı";
            dataGridView1.Columns[1].Name = "Tedarikçiler";
            dataGridView1.Columns[2].Name = "Kategori";
            dataGridView1.Columns[3].Name = "Stok";
            dataGridView1.Columns[4].Name = "Fiyat";
            dataGridView1.Columns[5].Name = "ID";
            var list = db.Products.AsNoTracking().Include("Suppliers").Include("Categories").ToList();
            foreach (var item in list)
            {
                object[] row = new object[]
                {
                    item.ProductName,
                    item.Suppliers.CompanyName,
                    item.Categories.CategoryName,
                    item.UnitsInStock,
                    item.UnitPrice,
                    item.ProductID
                };
                dataGridView1.Rows.Add(row);
                dataGridView1.Columns[5].Visible = false;
            }
        }

        private void productGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = move.RowIndex;
            int id =(int) dataGridView1.Rows[index].Cells[5].Value;
            var product = db.Products
                .Include("Suppliers")
                .Include("Categories")
                .Single(x => x.ProductID == id);
            Güncelle güncelle = new Güncelle(product,db);
            güncelle.ShowDialog();
            
        }
        DataGridViewCellMouseEventArgs move;
        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            move = e;
        }
    }
}
