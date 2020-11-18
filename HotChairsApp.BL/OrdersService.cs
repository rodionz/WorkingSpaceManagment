using HotChairsApp.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace HotChairsApp.BL
{
    public class OrdersService
    {
        private readonly IMongoCollection<Order> _orders;
        private readonly IMongoCollection<Company> _companies;
        private readonly IMongoCollection<Employee> _employees;
        private readonly IMongoCollection<WorkStation> _workSpaces;

        public OrdersService(IConnectionConfigurations settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);
            _orders = database.GetCollection<Order>(settings.OrdersCollection);
            _companies = database.GetCollection<Company>(settings.CompaniesCollection);
            _employees = database.GetCollection<Employee>(settings.EmployeesCollection);
            _workSpaces = database.GetCollection<WorkStation>(settings.WorkStationsCollection);
        }

        public async Task<List<Order>> GetAllOrders() =>
           await _orders.Find(oreder => true).ToListAsync();

        public List<BroadOrder> GettOrdersForCompany(string companyId) {



            var query = from order in _orders.AsQueryable().Where(o => o.CompanyId == companyId)
                        join companie in _companies.AsQueryable() on order.CompanyId equals companie.Id
                        join employee in _employees.AsQueryable() on order.EmployeeId equals employee.Id


                        select new BroadOrder()
                        {
                            CompanieName = companie.Name,
                            CompanyId = companyId,
                            StartDate = order.StartDate,
                            EndDate = order.EndDate,
                            Id = order.Id,
                            WorkStationId = order.WorkStationId,
                            EmployeeId = order.EmployeeId,
                            EmployeeFullName = employee.FullName

                        };

            var result = query.ToList();

            return result;

        }



        public List<WorkStation> GetAvailiableSlots(string companyId, string dateFrom, string dateTo) {

            DateTime fromDate = DateTime.Parse(dateFrom);
            DateTime to = DateTime.Parse(dateTo);

            _workSpaces.Find()

            var query = from order in _orders.AsQueryable().Where(o => o.CompanyId == companyId).Where(o => (o.EndDate < DateTime.Now || fromDate.Date < o.StartDate))
        }



        public  List<Company> GetAllCompanies() =>
            _companies.Find(company => true).ToList();


        public IEnumerable<Order> FindOrdersOfEmployee(string employeeId) =>
            _orders.Find(order => order.EmployeeId == employeeId).ToList();

    }
}
