using MongoDB.Bson.Serialization.Attributes;

namespace Domain_Entities
{
    public class Valuta
    {
        [BsonId]
        public string Id { get; set; }
        public int NumarCurentValuta { get; set; }
        public string AcronimValuta { get; set; }
        public string DenumireValuta { get; set; }
        public int Multiplu { get; set; }
        public string TipValuta { get; set; } //cotata (i.e. se afla in tabloul BNR), necotata
        public int PozitieValuta { get; set; } //(deprecated) principala (cele mai folosite), secundara
    }
}
