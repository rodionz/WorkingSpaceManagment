using HotChairsApp.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChairsApp.BL
{
    public class OrdersService
    {
        private readonly IMongoCollection<Order> orders;

        public OrdersService(IConnectionConfigurations settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);
            orders = database.GetCollection<Order>(settings.OrdersCollection);
        }
    }
}
