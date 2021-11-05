using System;

namespace planner
{
    class EventBuilder
    {
        private Calendar cal;
        private int id;
        public EventBuilder(Calendar calendar){
            this.cal = calendar;
            this.id = 0;
        }

        public void BuildEvent(string description, DateTime date){
            Event ev = new Event(this.id++, description, date);
            this.cal.AddEvent(ev);
        }
    }
}