using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Domain_Entities
{
    public class Casier
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //lista de drepturi pe care le are casierul
        public bool AccesOwner { get; set; }
        public bool AccesManager { get; set; }
        public bool AccesEmployee { get; set; }
    }
}
