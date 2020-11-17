using HotChairsApp.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotChairsApp.BL
{
    public class MainService
    {
        //private readonly IMongoCollection<IModel> logs;

        //public MainService(IConnectionConfigurations settings)
        //{
        //    var client = new MongoClient(settings.ConnectionString);
        //    var database = client.GetDatabase(settings.DatabaseName);
        //    logs = database.GetCollection<IModel>(settings.MainCollection);
        //}

        //public async Task<List<IModel>> GetAllAsync() 
        //{
        //    return await logs.Find(s => true).ToListAsync();
        //}
    }
}
