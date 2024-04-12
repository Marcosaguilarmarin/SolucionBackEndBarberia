using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Employees
    {
        #region Propiedades

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        [BsonElement("employee_id")]

        public int  employee_id { get; set; }

        [BsonElement("first_name")]

        public string first_name { get; set; }

        [BsonElement("last_name")]

        public string last_name { get; set; }

        [BsonElement("phone_number")]

        public string phone_number { get; set; }

        [BsonElement("Employee_email")]

        public string Employee_email { get; set; }

        [BsonElement("Estado")]

        public bool Estado { get; set; }


        #endregion

        #region Constructores
        public Employees()
        {

            Id = string.Empty;
            employee_id = 0;
            first_name = string.Empty;
            last_name = string.Empty;
            phone_number = string.Empty;
            Employee_email = string.Empty;
            Estado = true;

            

        }
        #endregion
    }
}
