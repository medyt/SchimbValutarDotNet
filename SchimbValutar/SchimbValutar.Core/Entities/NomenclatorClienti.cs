﻿using MongoDB.Bson.Serialization.Attributes;

namespace SchimbValutar.Core.Entities
{
    public class NomenclatorClienti
    {
        [BsonId]
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string DenumireTara { get; set; }
        public string CodTara { get; set; }
        public string TipDocumentIdentitate { get; set; }
        public string SerieDocumentIdentitate { get; set; }
        public int NumarDocumentIdentitate { get; set; }
    }
}
