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
        [BsonElement("UserName")]
        public string NombreUsuario { get; set; }
        [BsonElement("Pass")]
        public string Clave { get; set; }
        [BsonElement("State")]
        public bool Estado { get; set; }
        #endregion

        #region Constructores
        public Usuarios()
        {
            Id = string.Empty;
            NombreUsuario = string.Empty;
            Clave = string.Empty;
            Estado = true;
        }
        #endregion
    }
}
