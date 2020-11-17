using HotChairsApp.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChairsApp.BL
{
   
    public class EmployeesService
    {
        private readonly IMongoCollection<Employee> _employees;

        public EmployeesService(IConnectionConfigurations settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);
            _employees = database.GetCollection<Employee>(settings.OrdersCollection);
        }


        public Employee GetEmployeeByIdAndCompany(string id, string companyId) =>
            _employees.Find<Employee>(employe => employe.Id == id && employe.CompanyId == companyId).FirstOrDefault();


        public Employee AddEmployeeToCompany(Employee newWorker)
        {
            _employees.InsertOne(newWorker);
            return newWorker;
        }

        public void RemoveEmployee(Employee badWorker) =>
            _employees.DeleteOne(e => e.Id == badWorker.Id);
            
    }
}
 