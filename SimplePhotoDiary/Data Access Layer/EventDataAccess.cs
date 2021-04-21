using SimplePhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhotoDiary.Data_Access_Layer
{
    class EventDataAccess : DataBaseAccess
    {
        public List<Event> GetEvents (int userid)
        {
            string sql = "SELECT * FROM Events WHERE UserId =" + userid;
            SqlDataReader reader = this.GetData(sql);
            List <Event> Events = new List <Event>();
            while (reader.Read())
            {
                Event events = new Event();
                events.EventId = (int)reader["EventId"];
                events.EventName = reader["EventName"].ToString();
                events.Importance = reader["Importance"].ToString();
                events.CreationDate = reader["CreationDate"].ToString();
                Events.Add(events);
            }
            return Events;
        }

        public Event GetEvent(int id, int userid)
        {
            string sql = "SELECT * FROM Events WHERE EventId =" + id + " AND UserId =" + userid;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Event events = new Event();
                events.EventId = (int)reader["EventId"];
                events.EventName = reader["EventName"].ToString();
                events.Importance = reader["Importance"].ToString();
                events.CreationDate = reader["CreationDate"].ToString();
                return events;
            }
            return null;
        }

        public int AddAnEvent(Event receive)
        {
            string sql = "INSERT INTO Events (EventName, Importance, CreationDate, UserId) VALUES ('" + receive.EventName + "', '" + receive.Importance + "', '" + receive.CreationDate + "', '" + receive.UserId + "')";
            return this.QueryExecution(sql);

        }

        public int UpdateAnEvent(Event receive)
        {
            string sql = "UPDATE Events SET EventName = '" + receive.EventName + "', Importance = '" + receive.Importance +  "' WHERE EventId = " + receive.EventId + " And UserId = " + receive.UserId;
            return this.QueryExecution(sql);

        }

        public int DeleteAnEvent(int id, int userid)
        {
            string sql = "DELETE FROM Events WHERE EventId =" + id + " AND UserId =" + userid;
            return this.QueryExecution(sql);

        }
    }
}
