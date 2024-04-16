using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Web_Blazor.Components.Data

{
    [Serializable, BsonIgnoreExtraElements]

    public class Goal
    {
        [BsonId,BsonElement("_id"),BsonRepresentation(BsonType.ObjectId)]

        public string? Id { get; set; }

        [BsonElement("objective_name"), BsonRepresentation(BsonType.String)]

        public string? Name { get; set; }

        [BsonElement("date"), BsonRepresentation(BsonType.DateTime)]

        public DateTime Date { get; set; }

        [BsonElement("status"), BsonRepresentation(BsonType.Boolean)]

        public Boolean Status { get; set; }
    }
}
