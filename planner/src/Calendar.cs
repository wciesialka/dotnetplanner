using System;
using System.Collections.Generic;

namespace planner
{
    class Calendar {
        /// <summary>
        /// Class that contains Events and provides methods for getting Events.
        /// </summary>
        private List<Event> events; 
        public Calendar(){
            this.events = new List<Event>();
        }

        private int IndexOfEventWithID(int target){
            ///<summary>Get the lowest index of the event with an ID matching <paramref name="target"/>.</summary>
            ///<param name="target">ID to look for</param>
            ///<returns>Lowest index the Event can be found or inserted at.</returns>
            
            int lo = 0;
            int hi = this.events.Count-1;
            int mid = 0;
            while(lo <= hi){
                mid = ((lo+hi)/2);
                Event x = this.events[mid];
                
                if(x.GetID() == target){
                    return mid;
                }
                else if(x.GetID() < target){
                    lo = mid + 1;
                } else {
                    hi = mid - 1;
                }
            }
            return mid;
        }

        public void AddEvent(Event ev){
            ///<summary>This method will add an event to the calendar. It will use the event's ID to put it in an increasing order.</summary>
            ///<param name="ev">Event to add.</param>
            
            if(this.events.Count == 0){
                this.events.Add(ev);
            }
            else
            {
                int index = this.IndexOfEventWithID(ev.GetID());
                this.events.Insert(index+1, ev);
            }
        }

        public bool RemoveEvent(int id){
            ///<summary>Remove first event with ID <paramref name="id"/>.</summary>
            ///<param name="id">ID of Event(s) to remove.</param>
            ///<returns>True if the removal is a success, False otherwise.</returns>
            
            int i = this.IndexOfEventWithID(id);
            if(this.events[i].GetID() == id){
                this.events.RemoveAt(i);
                return true;
            } else {
                return false;
            }
        }

        public Event GetEvent(int id){

            ///<summary>Get the first event with the specified ID. Retyrn null if not found.</summary>
            ///<param name="id">ID of Event to get.</param>
            ///<returns>The first event with the specified ID. If no event found, returns null.</returns>

            int i = this.IndexOfEventWithID(id);
            if(this.events[i].GetID() == id){
                return this.events[i];
            } else {
                return null;
            }
            
        }

        public List<Event> GetEventsByDate(DateTime date){
            ///<summary>Get a list of Events that the Calendar contains that are on the same Date as <paramref name="date"/>.</summary>
            ///<param name="date">Date to filter by.</param>
            List<Event> list = new List<Event>();

            for(int i = 0; i < this.events.Count; i++){
                Event x = this.events[i];
                if(x.GetDate().Date == date.Date){
                    list.Add(x);
                }
            }

            return list;
        }
    }
}