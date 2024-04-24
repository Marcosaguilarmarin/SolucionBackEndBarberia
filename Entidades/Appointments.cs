using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Appointments
    {
        #region Propiedades 
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("appointment_id")]
        public int appointment_id { get; set; }
        [BsonElement("date_created")]
        public DateTime date_created { get; set; }
        [BsonElement("client_id")]
        public int client_id { get; set; }
        [BsonElement("employee_id")]
        public int employee_id { get; set; }
        [BsonElement("start_time")]
        public DateTime start_time { get; set; }
        [BsonElement("end_time_expected")]
        public DateTime end_time_expected { get; set; }
        [BsonElement("canceled")]
        public Boolean canceled { get; set; }
        [BsonElement("cancellation_reason")]
        public string cancellation_reason { get; set; }




        #endregion

        #region Constructores
        public Appointments()
        {
            Id = string.Empty;
            appointment_id = 0;
            date_created = DateTime.MinValue;
            client_id = 0;
            employee_id = 0;
            start_time = DateTime.MinValue;
            end_time_expected = DateTime.MinValue;
            canceled = true;
            cancellation_reason = string.Empty;
        }
        #endregion
    }
}
