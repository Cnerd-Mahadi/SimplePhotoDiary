using SimplePhotoDiary.Data_Access_Layer;
using SimplePhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhotoDiary.Service_Layer
{
    class EventDataService
    {
        EventDataAccess eventDataAccess ;

        public EventDataService ()
        {
            this.eventDataAccess = new EventDataAccess();
        }

        public List<Event> GetEventList (int userid)
        {
            return this.eventDataAccess.GetEvents(userid);
        }

        public Event GetTheEvent(int id, int userid)
        {
            return this.eventDataAccess.GetEvent(id, userid);
        }

        public int AddEvent(string eventName, string importance, string creationDate, int userId)
        {
            Event events = new Event() { EventName = eventName, Importance = importance, CreationDate = creationDate, UserId = userId };
            return this.eventDataAccess.AddAnEvent(events);
          
        }

        public int UpdateEvent(string eventName, string importance, int eventid, int userid)
        {
            Event events = new Event() { EventName = eventName, Importance = importance, EventId = eventid, UserId = userid };
            return this.eventDataAccess.UpdateAnEvent(events);
        }

        public int DeleteEvent(int eventId, int userid)
        {
            return this.eventDataAccess.DeleteAnEvent(eventId, userid);
        }
    }
}
