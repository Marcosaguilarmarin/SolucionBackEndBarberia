using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Entidades
{
    public class Usuarios
    {
        #region Propiedades 
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("IdUsuario")]
        public int IdUsuario { get; set; }
        [BsonElement("NombreUsuario")]
        public string NombreUsuario { get; set; }
        [BsonElement("Clave")]
        public string Clave { get; set; }
        [BsonElement("IdLogueo")]
        public string IdLogueo { get; set; }
        [BsonElement("Estado")]
        public bool Estado { get; set; }


        #endregion

        #region Constructores
        public Usuarios()
        {
            Id = string.Empty;
            IdUsuario = 0;
            NombreUsuario = string.Empty;
            Clave = string.Empty;
            Estado = true;
        }
        #endregion
    }
}

