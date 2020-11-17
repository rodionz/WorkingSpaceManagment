using System;

namespace HotChairsApp.Model
{
    public class ConnectionConfigurations : IConnectionConfigurations
    {
        public string CompaniesCollection { get; set; }
        public string OrdersCollection { get; set; }
        public string EmployeesCollection { get; set; }
        public string WorkStationsCollection { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        
    }


    public interface IConnectionConfigurations
    {
        string OrdersCollection { get; set; }
        string EmployeesCollection { get; set; }
        string CompaniesCollection { get; set; }
        string WorkStationsCollection { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

