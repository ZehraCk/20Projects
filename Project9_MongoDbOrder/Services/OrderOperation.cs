using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;
using Project9_MongoDbOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDbOrder.Services
{
    public class OrderOperation
    {
        public void AddOrder(Order order)
        {
            var connection = new MongoDbCollection();
            var orderCollection = connection.GetOrdersCollection();

            var document = new BsonDocument
            {

                { "CustomerName", order.CustomerName },
                { "District", order.District },
                { "City", order.City },
                { "TotalPrice", order.TotalPrice }
            };
            orderCollection.InsertOne(document);

        }
        public List<Order> GetAllOrders()
        {
            var connection = new MongoDbCollection();
            var orderCollection = connection.GetOrdersCollection();
            var orders = orderCollection.Find(new BsonDocument()).ToList();
            List<Order> orderList = new List<Order>();
            foreach (var order in orders)
            {
                orderList.Add(new Order
                {
                    OrderId = order["_id"].ToString(),
                    CustomerName = order["CustomerName"].ToString(),
                    District = order["District"].ToString(),
                    City = order["City"].ToString(),
                    TotalPrice = order["TotalPrice"].AsDecimal
                });

            }
            return orderList;
        }
        public void DeleteOrder(string orderId)
        {
            var connection = new MongoDbCollection();
            var orderCollection = connection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            orderCollection.DeleteOne(filter);
        }
        public void UpdateOrder(string orderId, Order updatedOrder)
        {
            var connection = new MongoDbCollection();
            var orderCollection = connection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            var update = Builders<BsonDocument>.Update
                .Set("CustomerName", updatedOrder.CustomerName)
                .Set("District", updatedOrder.District)
                .Set("City", updatedOrder.City)
                .Set("TotalPrice", updatedOrder.TotalPrice);
            orderCollection.UpdateOne(filter, update);
        }
        public Order GetOrderById(string orderId)
        {
            var connection = new MongoDbCollection();
            var orderCollection = connection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            var orderDocument = orderCollection.Find(filter).FirstOrDefault();
            if (orderDocument != null)
            {
                return new Order
                {
                    OrderId = orderDocument["_id"].ToString(),
                    CustomerName = orderDocument["CustomerName"].ToString(),
                    District = orderDocument["District"].ToString(),
                    City = orderDocument["City"].ToString(),
                    TotalPrice = orderDocument["TotalPrice"].AsDecimal
                };
            }
            else
            {
                return null;
            }
        }
    }
}
