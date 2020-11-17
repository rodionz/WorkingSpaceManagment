using HotChairsApp.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotChairsApp.BL
{
    public class OrdersService
    {
        private readonly IMongoCollection<Order> _orders;
        private readonly IMongoCollection<Company> _companies;

        public OrdersService(IConnectionConfigurations settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);
            _orders = database.GetCollection<Order>(settings.OrdersCollection);
            _companies = database.GetCollection<Company>(settings.CompaniesCollection);
        }

        public async Task<List<Order>> GetAllOrders() =>
           await _orders.Find(oreder => true).ToListAsync();

        public async Task<List<Company>> GetAllCompanies() =>
            await _companies.Find(company => true).ToListAsync();


        public IEnumerable<Order> FindOrdersOfEmployee(string employeeId) =>
            _orders.Find(order => order.EmployeeId == employeeId).ToList();

    }
}
