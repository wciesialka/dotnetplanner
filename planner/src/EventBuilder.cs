using System;

namespace planner
{
    class EventBuilder
    {
        /// <summary>
        /// Builds events and adds them to the Calendar.
        /// </summary>
        private Calendar cal;
        private int id;
        public EventBuilder(Calendar calendar){
            this.cal = calendar;
            this.id = 0;
        }

        public Event BuildEvent(string description, DateTime date){
            /// <summary>
            /// Builds the Event and adds it to the Calendar.
            /// </summary>
            /// <param name="description">Description of the Event</param>
            /// <param name="date">Date of the Event</param>
            /// <returns>Built Event</returns>

            Event ev = new Event(this.id++, description, date);
            this.cal.AddEvent(ev);
            return ev;
        }
    }
}