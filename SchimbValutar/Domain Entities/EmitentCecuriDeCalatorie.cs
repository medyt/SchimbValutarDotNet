using MongoDB.Bson.Serialization.Attributes;

namespace Domain_Entities
{
    public class EmitentCecuriDeCalatorie
    {
        [BsonId]
        public string Id { get; set; }
        public string Emitent { get; set; }
    }
}
