using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Perfiles
    {
        #region Propiedades 
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("IdPerfil")]
        public int IdPerfil { get; set; }
        [BsonElement("NombrePerfil")]
        public string NombrePerfil { get; set; }
        [BsonElement("CodigoPerfil")]
        public int CodigoPerfil { get; set; }
        [BsonElement("EstadoPerfil")]
        public bool EstadoPerfil { get; set; }


        #endregion

        #region Constructores
        public Perfiles()
        {
            Id = string.Empty;
            IdPerfil = 0;
            NombrePerfil = string.Empty;
            CodigoPerfil = 0;
            EstadoPerfil = true;
        }
        #endregion
    }
}
