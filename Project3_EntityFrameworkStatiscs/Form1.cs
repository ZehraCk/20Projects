using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatiscs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Db3Project20Entities db = new Db3Project20Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Toplam KAtegori sayısı
            int categoryCount = db.TblCategory.Count();
            lblCategoryCount.Text = categoryCount.ToString();

            //Toplam Ürün sayısı
            int productCount = db.TblProduct.Count();
            lblProductCount.Text = productCount.ToString();

            //Toplam Müşteri sayısı
            int customerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = customerCount.ToString();

            //Toplam Sipariş sayısı
            int orderCount = db.TblOrder.Count();
            lblOrderCount.Text = orderCount.ToString();

            //Toplam Stok Sayısı
            var totalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
            lblProductTotalStock.Text = totalProductStockCount.ToString();

            //Ortalama Ürün Fiyatı
            var averageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
            lblProductAveragePrice.Text = averageProductPrice.ToString()+"₺";

            //Toplam Meyve Stoku Sayısı
            var totalProductCountByCategoryIsFruit = db.TblProduct.Where(x => x.CategoryId == 1).Sum(y => y.ProductStock);
            lblProductCountByCategoryIsFruit.Text = totalProductCountByCategoryIsFruit.ToString();

            //Gazoz isimli ürünün Toplam İşlem Hacmi
            var totalPriceByProductNameIsGazozGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y=>y.ProductStock).FirstOrDefault();
            var totalPriceByProductNameIsGazozGetUnitPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductPrice).FirstOrDefault();
            var totalPriceByProductNameIsGazoz = totalPriceByProductNameIsGazozGetStock * totalPriceByProductNameIsGazozGetUnitPrice;
            lblTotalPriceByProductNameIsGazoz.Text = totalPriceByProductNameIsGazoz.ToString() + "₺";

            //Stok Sayısı 100 den az olan ürün sayısı
            var productCountByStockSmallerThan100 = db.TblProduct.Where(x => x.ProductStock < 100).Count();
            lblProductSmallerThen100.Text = productCountByStockSmallerThan100.ToString();

            //Kategorisi Sebze ve Durumu aktif(true) olan ürün stok toplamı
            int id = db.TblCategory.Where(x => x.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault();
            var productStockCountByCategoryNameIsSebzeAndStatusIsTrue = db.TblProduct.Where(x => x.CategoryId == (db.TblCategory.Where(w => w.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault()) && x.ProductStatus == true).Sum(y => y.ProductStock);
            lblProductByCategorySebzeAndStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusIsTrue.ToString();

            //Türkiye'den Yapılan Siparişler 
            var orderCountFromTurkiye = db.Database.SqlQuery<int>("Select count(*) From TblOrder Where CustomerId In (Select CustomerId From TblCustomer Where CustomerCountry='Türkiye')").FirstOrDefault();
            lblOrderCountFromTurkiyeBySQL.Text = orderCountFromTurkiye.ToString();

            //Türkiye'den Yapılan Siparişler EF Metodu
            var turkishCustomerIds= db.TblCustomer.Where(c => c.CustomerCountry == "Türkiye").Select(y => y.CustomerId).ToList();
            var orderCountFromTurkiyeByEF = db.TblOrder.Count(x => turkishCustomerIds.Contains(x.CustomerId.Value));
            lblOrderCountFromTurkiyeByEF.Text = orderCountFromTurkiyeByEF.ToString();

            //Siparişler içerisinde kategorisi Meyve olan ürünlerin toplam satış fiyatı SQL Metodu

            var orderTotalPriceByCategoryIsMeyve = db.Database.SqlQuery<decimal>("Select Sum(o.TotalPrice) From TblOrder o Join TblProduct p On o.ProductId=p.ProductId Join TblCategory c On p.CategoryId=c.CategoryId Where c.CategoryName='Meyve'").FirstOrDefault();
            lblOrderTotalPriceByCategoryIsMeyve.Text = orderTotalPriceByCategoryIsMeyve.ToString() + "₺";

            //Siparişler içerisinde kategorisi Meyve olan ürünlerin toplam satış fiyatı EF Metodu
            var orderTotalPriceByCategoryIsMeyveWithEF =(from o in db.TblOrder
                                                                 join p in db.TblProduct on o.ProductId equals p.ProductId
                                                                 join c in db.TblCategory on p.CategoryId equals c.CategoryId
                                                                 where c.CategoryName == "Meyve"
                                                                 select o.TotalPrice).Sum();
            lblOrderTotalPriceByCategoryIsMeyveWithEF.Text = orderTotalPriceByCategoryIsMeyveWithEF.ToString() + "₺";

            //Son Eklenen Ürün Adı
            var lastProductName = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.ProductName).FirstOrDefault();
            lblLastProductName.Text = lastProductName.ToString();

            //Son Eklenen Ürünün Kategori Adı
            var lastProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var lastProductCategoryName = db.TblCategory.Where(x => x.CategoryId == lastProductCategoryId).Select(y => y.CategoryName).FirstOrDefault();
            lblLastProductCategoryName.Text = lastProductCategoryName.ToString();

            // Aktif Ürün Sayısı
            var activeProductCount = db.TblProduct.Count(x => x.ProductStatus == true);
            lblActiveProductCount.Text = activeProductCount.ToString();

            // Toplam Kola Stok Sayılarından Kazanılan Para
            var colaStock= db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductStock).FirstOrDefault();
            var colaPrice = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductPrice).FirstOrDefault();
            var totalPriceByColaStockPrice = colaStock * colaPrice;
            lblTotalPriceWithStockByCola.Text = totalPriceByColaStockPrice.ToString() + "₺";

            // Son Sipariş Veren Müşteri Adı
            var lastCustomerId = db.TblOrder.OrderByDescending(x => x.OrderId).Select(y => y.CustomerId).FirstOrDefault();
            var lastCustomerName = db.TblCustomer.Where(x => x.CustomerId == lastCustomerId).Select(y => y.CustomerName).FirstOrDefault();
            lblLastCustomerName.Text = lastCustomerName.ToString();

            // Ülke Farklılığı Olan Müşteri Sayısı
            var countryDifferentCount = db.TblCustomer.Select(x => x.CustomerCountry).Distinct().Count();
            lblCountryDifferentCount.Text = countryDifferentCount.ToString();


        }
        //lblCountryDifferentCount

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
