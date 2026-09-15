using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkDbFirstProduct
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(txtProductId.Text));
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductStok = int.Parse(txtProductStock.Text);
            value.ProductName = txtProductName.Text;
            value.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
            db.SaveChanges();
            ProductList();
        }
          

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productId;

            if (!int.TryParse(txtProductId.Text, out productId))
            {
                MessageBox.Show("Lütfen geçerli bir ürün ID giriniz.");
                return;
            }

            var value = db.TblProduct.Find(productId);

            if (value == null)
            {
                MessageBox.Show("Bu ID'ye sahip ürün bulunamadı.");
                return;
            }

            db.TblProduct.Remove(value);
            db.SaveChanges();

            MessageBox.Show("Ürün başarıyla silindi.");

            ProductList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            decimal price;
            int stock;
            int categoryId;

            if (!decimal.TryParse(txtProductPrice.Text, out price))
            {
                MessageBox.Show("Ürün fiyatını doğru giriniz. Örnek: 150,50");
                return;
            }

            if (!int.TryParse(txtProductStock.Text, out stock))
            {
                MessageBox.Show("Stok miktarını tam sayı olarak giriniz. Örnek: 50");
                return;
            }

            if (cmbProductCategory.SelectedValue == null ||
                !int.TryParse(cmbProductCategory.SelectedValue.ToString(), out categoryId))
            {
                MessageBox.Show("Lütfen kategori seçiniz.");
                return;
            }

            TblProduct tblProduct = new TblProduct();

            tblProduct.ProductPrice = price;
            tblProduct.ProductStok = stock;
            tblProduct.ProductName = txtProductName.Text;
            tblProduct.CategoryId = categoryId;

            db.TblProduct.Add(tblProduct);
            db.SaveChanges();

            MessageBox.Show("Ürün başarıyla eklendi.");

            ProductList();
        }   

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {

        }
        Db2Project20Entities db = new Db2Project20Entities();
        void ProductList()
        {
            var values = db.TblProduct
       .Join(db.TblCategory,
           product => product.CategoryId,
           category => category.CategoryId,
           (product, category) => new
           {
               ProductId = product.ProductId,
               ProductName = product.ProductName,
               ProductPrice = product.ProductPrice,
               ProductStok = product.ProductStok,
               CategoryName = category.CategoryName
           })
       .ToList();

            dataGridView1.DataSource = values;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = db.TblCategory.ToList();
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
            cmbProductCategory.DataSource = values;
        }

        private void cmbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnProductListWithCategory_Click(object sender, EventArgs e)
        {
            var values = db.TblProduct
                .Join(db.TblCategory,
                product => product.CategoryId,
                category => category.CategoryId,
                (product, category) => new
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    ProductPrice = product.ProductPrice,
                    ProductStock = product.ProductStok,
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                })
                .ToList();
            dataGridView1.DataSource = values;
        }
    }
}
