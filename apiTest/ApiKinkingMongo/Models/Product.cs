using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiKinkingMongo.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Marca")]
        public string Marca { get; set; }
        [BsonElement("Cor")]
        public string Cor { get; set; }
        public int Ano { get; set; }
        public string Colecao { get; set; }
    }
}