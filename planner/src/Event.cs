using System;

namespace planner {

    class Event {

        private DateTime date;
        private String description;
        private int id;

        public Event(int id, String description, DateTime date){
            this.id = id;
            this.description = description;
            this.date = date;
        }

        public String GetDescription(){
            return this.description;
        }

        public DateTime GetDate(){
            return this.date;
        }

        public int GetID(){
            return this.id;
        }
    }

}