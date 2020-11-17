using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
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


        [BsonElement("companyName")]
        [JsonProperty("companyName")]
        public string Name { get; set; }

        [BsonElement("quantityOfWorkingSlots")]
        [JsonProperty("quantityOfWorkingSlots")]
        public int QuantityOfWorkingSlots { get; set; }

        [BsonElement("quantityOfEmployees")]
        [JsonProperty("quantityOfEmployees")]
        public int QuantityOfEmployees { get; set; }

       


    }
}
