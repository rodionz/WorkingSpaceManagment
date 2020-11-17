using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChairsApp.Model
{
   public class Order 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("startDate")]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("endDate")]
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("employeeId")]
        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("workStationId")]
        [JsonProperty("workStationId")]
        public string WorkStationId { get; set; }
    }
}
