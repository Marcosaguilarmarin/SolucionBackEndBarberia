using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Services_Booked
    {
        #region Services_Booked 
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("appointment_id")]
        public int appointment_id { get; set; }
        [BsonElement("service_id")]
        public int service_id { get; set; }
     


        #endregion

        #region Constructores
        public Services_Booked()
        {
            Id = string.Empty;
            appointment_id = 0;
            service_id = 0;
          
        }
        #endregion
    }
}
