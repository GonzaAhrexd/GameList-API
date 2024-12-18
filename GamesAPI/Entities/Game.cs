using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GamesAPI.Entities
{
    public class Game
    {   
        [BsonId]
        [BsonElement("id"), BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }

        [BsonElement("nombre")]
        public string? nombre { get; set; }
        [BsonElement("imagen")]
        public string? imagen { get; set; }
        [BsonElement("genero")]
        public string? genero { get; set; }


    }
}
