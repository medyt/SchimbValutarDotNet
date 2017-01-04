using System;
using MongoDB.Bson;

namespace SchimbValutar.Core.Entities
{
    public class Casieri
    {
        public ObjectId Id { get; set; }
        public Guid CasierId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        //lista de drepturi pe care le are casierul
        public bool AccesRaportTranzactiiZilnice { get; set; }
        public bool AccesRaportTransferuriZilnice { get; set; }
        public bool AccesCasaLeiValuta { get; set; }
        public bool AccesTranzactiiLunare { get; set; }
        public bool AccesTransferuriLunare { get; set; }
        public bool AccesRaportAdaosLunar { get; set; }
        public bool AccesRaportBnrVechi { get; set; }
        public bool AccesRaportBnrNou { get; set; }
        public bool AccesOperatiiTransfer { get; set; }
        public bool AccesRaportSpecial { get; set; }
    }
}
