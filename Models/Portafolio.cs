using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PortafolioASA.Models
{
     public class PortafolioModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{get; set;} = string.Empty;
        
        [BsonElement("nombre")]
        public string Nombre {get;set;} = string.Empty;

        [BsonElement("Edad")]
        public int Edad {get; set;}
        [BsonElement("Telefono")]
        public string Telefono {get; set;} = string.Empty;

        [BsonElement("Correo")]
         public string Correo {get; set;} = string.Empty;

    }
}