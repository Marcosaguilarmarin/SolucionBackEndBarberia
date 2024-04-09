using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entidades
{
    public class Services_Categories
    {
        #region Propiedades

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }

        [BsonElement("category_id")]
        public int category_id { get; set; }

        [BsonElement("category_name")]
        public string category_name { get; set; }

        #endregion

        #region Constructores

        public Services_Categories()
        {

            Id = string.Empty;
            category_id = 0;
            category_name = string.Empty;
        }
        #endregion

    }
}
