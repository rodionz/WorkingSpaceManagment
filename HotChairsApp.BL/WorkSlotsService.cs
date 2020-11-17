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

        public WorkSlotsService(IConnectionConfigurations settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);
            _workSlots = database.GetCollection<WorkStation>(settings.OrdersCollection);
        }
    }
}
