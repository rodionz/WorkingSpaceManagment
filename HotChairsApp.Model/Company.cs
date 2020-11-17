using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChairsApp.Model
{
    public class Company
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string CompanyName { get; set; }

        public int QuantityOfEmployees { get; set; }

        public int QuantityOfWorkingSlots { get; set; }


    }
}
