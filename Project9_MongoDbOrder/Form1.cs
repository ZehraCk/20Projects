using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OrderOperation orderOperation = new OrderOperation();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var order = new Entities.Order
            {

                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                City = txtCity.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };

            var orderOperation = new Services.OrderOperation();
            orderOperation.AddOrder(order);
            MessageBox.Show("Ekleme İşlemi Yapıldı.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Entities.Order> orders = orderOperation.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId = txtId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Silme İşlemi Yapıldı.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string orderId = txtId.Text;
            var updatedOrder = new Entities.Order
            {
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                City = txtCity.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };
            orderOperation.UpdateOrder(orderId, updatedOrder);
            MessageBox.Show("Güncelleme İşlemi Yapıldı.");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string orderId = txtId.Text;
            var order = orderOperation.GetOrderById(orderId);
            if (order != null)
            {
                txtCustomer.Text = order.CustomerName;
                txtDistrict.Text = order.District;
                txtCity.Text = order.City;
                txtTotalPrice.Text = order.TotalPrice.ToString();
            }
            else
            {
                MessageBox.Show("Sipariş bulunamadı.");
            }
        }
    }
}
