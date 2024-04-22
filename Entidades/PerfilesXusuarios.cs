using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class PerfilesXusuarios
    {
        #region Propiedades 
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("IdPerfilesUsuario")]
        public int IdPerfilesUsuario { get; set; }
        [BsonElement("IdUsuario")]
        public int IdUsuario { get; set; }
        [BsonElement("IdPerfil")]
        public int IdPerfil { get; set; }
        [BsonElement("StatusPerfilesUsuario")]
        public bool StatusPerfilesUsuario { get; set; }


        #endregion

        #region Constructores
        public PerfilesXusuarios()
        {
            Id = string.Empty;
            IdPerfilesUsuario = 0;
            IdUsuario = 0;
            IdPerfil = 0;
            StatusPerfilesUsuario = true;
        }
        #endregion
    }
}
