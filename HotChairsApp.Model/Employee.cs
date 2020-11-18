using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChairsApp.Model
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }


        [BsonElement("fullName")]
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("companyId")]
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }
    }
}
