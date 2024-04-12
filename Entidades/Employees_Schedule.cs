using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Employees_Schedule
    {

        #region Propiedades
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }

        [BsonElement("employees_Schedule_id")]

        public int employees_Schedule_id { get; set; }

        [BsonElement("employee_id")]
        public int employee_id { get; set; }

        [BsonElement("Dia_Semana")]

        public string Dia_Semana { get; set; }

        [BsonElement("From_Hour")]

        public DateTime From_Hour { get; set; }

        [BsonElement("to_hour")]

        public DateTime to_hour { get; set; }
        #endregion

        #region Constructor

        public Employees_Schedule()
        {

            Id = string.Empty;
            employees_Schedule_id = 0;
            employee_id = 0;
            Dia_Semana = string.Empty;
            From_Hour = DateTime.MinValue;
            to_hour = DateTime.MinValue;
        }
        #endregion
    }
}
