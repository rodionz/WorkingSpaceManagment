using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChairsApp.Model
{
   public class Order : IModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public string employeeId { get; set; }

        public string slotId { get; set; }
    }
}
