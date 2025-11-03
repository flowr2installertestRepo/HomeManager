using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HomeManager.Models;

[BsonIgnoreExtraElements]
public class Movie
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("title")]
    public string Title { get; set; } = string.Empty;

    public int Year { get; set; }
}
