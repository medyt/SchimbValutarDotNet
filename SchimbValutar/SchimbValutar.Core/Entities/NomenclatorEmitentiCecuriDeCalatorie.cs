using MongoDB.Bson.Serialization.Attributes;

namespace SchimbValutar.Core.Entities
{
    public class NomenclatorEmitentiCecuriDeCalatorie
    {
        [BsonId]
        public string Id { get; set; }
        public string Emitent { get; set; }
    }
}
