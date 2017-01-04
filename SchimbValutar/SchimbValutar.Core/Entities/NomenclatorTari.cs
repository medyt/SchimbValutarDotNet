using MongoDB.Bson.Serialization.Attributes;

namespace SchimbValutar.Core.Entities
{
    public class NomenclatorTari //raport statistic pe tari trimis de BNR
    {
        [BsonId]
        public string Id { get; set; }
        public string Cod { get; set; }
        public string Denumire { get; set; }
        public int TotalCumparariEuro { get; set; } //cati euro s-au cumparat din tara respectiva
        public int TotalVanzariEuro { get; set; }
    }
}
