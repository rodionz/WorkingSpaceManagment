﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotChairsApp.Model
{
   public class WorkSlot
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [JsonConverter(typeof(StringEnumConverter))] 
        [BsonRepresentation(BsonType.String)]
        [BsonElement("status")]
        public AvailiablityStatus AvailiablityStatus { get; set; }
    }


    public enum AvailiablityStatus { 
      
        Free,
        Booked,
        Occupied
    }
}
