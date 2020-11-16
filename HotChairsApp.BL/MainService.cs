using HotChairsApp.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChairsApp.BL
{
    public class MainService
    {
        private readonly IMongoCollection<object> logs;

        public MainService(IConnectionConfigurations settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            logs = database.GetCollection<object>(settings.MainCollection);
        }

        public async Task<List<object>> GetAllAsync()
        {
            return await logs.Find(s => true).ToListAsync();
        }
    }
}
