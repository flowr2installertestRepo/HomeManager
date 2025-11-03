using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HomeManager.Models;
public class Menu
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("menuName")]
    public string MenuName { get; set; }

    [BsonElement("date")]
    public DateTime Date { get; set; }

    [BsonElement("plates")]
    public List<Plate> Plates { get; set; }
}

public class Plate
{
    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("composition")]
    public List<Ingredient> Composition { get; set; }
}

public class Ingredient
{
    [BsonElement("product")]
    public string Product { get; set; }

    [BsonElement("quantity")]
    public string Quantity { get; set; }
}

