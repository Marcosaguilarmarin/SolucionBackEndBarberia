using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Clients
    {

        #region Propiedades
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Client_Id")]
        public int Client_Id { get; set; }
        [BsonElement("First_Name")]
        public string First_Name { get; set; }
        [BsonElement("Last_Name")]
        public string Last_Name { get; set; }
        [BsonElement("Client_email")]
        public string Client_email { get; set; }
        [BsonElement("IdUsuariocliente")]
        public string IdUsuariocliente { get; set; }
        [BsonElement("Contrasenacliente")]
        public string Contrasenacliente { get; set; }
        [BsonElement("Telefono")]
        public string Telefono { get; set; }
        [BsonElement("EstadoCliente")]
        public bool EstadoCliente { get; set; }

        #endregion

        #region constructores
        public Clients()
        {
            Id = string.Empty;
            Client_Id = 0;
            First_Name = string.Empty;
            Last_Name = string.Empty;
            Client_email = string.Empty;
            IdUsuariocliente = string.Empty;
            Contrasenacliente = string.Empty;
            Telefono = string.Empty;
            EstadoCliente = true;
        }


        #endregion
    }
}
