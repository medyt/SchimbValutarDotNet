using MongoDB.Bson.Serialization.Attributes;

namespace Domain_Entities
{
    public class Tara
    {
        [BsonId]
        public string Id { get; set; }
        public string Cod { get; set; }
        public string Denumire { get; set; }
        public int TotalCumparariEuro { get; set; } //cati euro s-au cumparat din tara respectiva
        public int TotalVanzariEuro { get; set; }
    }
}
