using HotChairsApp.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChairsApp.BL
{
    public class WorkSlotsService
    {
        private readonly IMongoCollection<WorkStation> _workSlots;
        private readonly IMongoCollection<Company> _companies;

        public WorkSlotsService(IConnectionConfigurations settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);
            _workSlots = database.GetCollection<WorkStation>(settings.OrdersCollection);
            _companies = database.GetCollection<Company>(settings.CompaniesCollection);
        }

        public void SetQuantityOfWorkingSlots(string companyId, int newQuantiy) {

            var filter = Builders<Company>.Filter.Eq("companyId", companyId);
            var update = Builders<Company>.Update.Set("quantityOfWorkingSlots", newQuantiy);
            _companies.UpdateOne(filter, update);
        }
    }
}
