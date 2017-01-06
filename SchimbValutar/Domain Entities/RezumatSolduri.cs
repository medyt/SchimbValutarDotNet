using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain_Entities
{
    public class RezumatSolduri //evolutia disponibilatilor (zilnice) pe parcursul unei luni
    {
        [BsonId]
        public string Id { get; set; }
        public DateTime DataSold { get; set; }
        public int NumarCurentValuta { get; set; } //din lista de curs
        public string AcronimValuta { get; set; } //din lista de curs
        public string DenumireValuta { get; set; } //din lista de curs
        public int SoldInitial { get; set; } //soldul de la inceputul zilei = soldul final al zilei precedente
        public int SoldFinal { get; set; } //soldul de la sfarsitul zilei
        public decimal CursValutarStabilit { get; set; } //deprecated
        public decimal CursOficialBnr { get; set; } // cursul din ziua respectiva
        public int EvaluareSoldFinal { get; set; } //valoare in lei a valutei disponibile (la sfarsitul zilei)
        public int SumaDisponibila { get; set; } //suma disponibila la sfarsitul zilei
    }
}
