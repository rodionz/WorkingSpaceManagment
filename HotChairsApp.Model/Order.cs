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
        public DateTime startDate { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime endDate { get; set; }

        //[BsonElement("Name")]
        //[JsonProperty("Name")]
        public string employeeId { get; set; }

        //[BsonElement("Name")]
        //[JsonProperty("Name")]
        public string workStationId { get; set; }
    }
}
