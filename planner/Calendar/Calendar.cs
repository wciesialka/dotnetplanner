using System;
using System.Collections.Generic;

namespace planner
{
    class Calendar {
        /**
        <summary>Container class for Events</summary>
        */
        private List<Event> events; 
        public Calendar(){
            this.events = new List<Event>();
        }

        private int IndexOfEventWithID(int target){
            /**
            <summary>Get the lowest index of the event with the specified ID.</summary>
            <param name="target">ID to look for</param>
            */
            int lo = 0;
            int hi = this.events.Count;
            int mid = 0;
            while(lo < hi){
                mid = (lo+hi)/2;
                Event x = this.events[mid];
                if(x.GetID() >= target){
                    hi = mid;
                } else {
                    lo = mid;
                }
            }
            return mid;
        }

        public void AddEvent(Event ev){
            /**
            <summary>This method will add the specified event to the calendar.</summary>
            <param name="ev">Event to add.</param>
            */
            int index = this.IndexOfEventWithID(ev.GetID());
            this.events.Insert(index,ev);
        }

        public void RemoveEvent(int id){
            /**
            <summary>Remove first event with the specified ID.</summary>
            <param name="id">ID of Event(s) to remove.</param>
            */
            int i = this.IndexOfEventWithID(id);
            if(this.events[i].GetID() == id){
                this.events.RemoveAt(i);
            }
        }

        public Event GetEvent(int id){
            /**
            <summary>Get the first event with the specified ID. Retyrn null if not found.</summary>
            <param name="id">ID of Event to get.</param>
            <returns>The first event with the specified ID. If no event found, returns null.</returns>
            */
            int i = this.IndexOfEventWithID(id);
            if(this.events[i].GetID() == id){
                return this.events[i];
            } else {
                return null;
            }
        }
    }
}