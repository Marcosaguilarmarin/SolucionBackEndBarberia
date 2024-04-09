using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entidades
{
    public class Services
    {

        #region Propiedades

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        [BsonElement("service_id")]
        public int service_id { get; set; }

        [BsonElement("service_name")]
        public string service_name { get; set; }

        [BsonElement("service_description")]
        public string service_description { get; set; }

        [BsonElement("service_price")]
        public int service_price { get; set; }

        [BsonElement("service_duration")]
        public string service_duration { get; set; }

        [BsonElement("category_id")]
        public int category_id { get; set; }



        #endregion

        #region Constructores

        public Services (){

            Id = string.Empty;
            service_id = 0;
            service_name = string.Empty;
            service_description = string.Empty;
            service_price = 0;
            service_duration = string.Empty;
            category_id = 0;


        }
        #endregion
    }
}
