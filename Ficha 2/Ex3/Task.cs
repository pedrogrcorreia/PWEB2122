using System;
using System.Linq;

namespace Ex1{
    enum Priority{
        Low,
        Medium,
        High
    }

    enum Category{
        Personal, 
        Work
    }

    enum State{
        NotDone,
        Doing,
        Done
    }

    class Task{
        public string Name {get; set;}

        public DateTime RegDate {get; set;}

        public DateTime LimitDate {get; set;}

        public Category category {get; set;}

        public Priority priority {get; set;}

        public State state {get; set;}

        public Task(string name,
            Priority priority,
            Category category,
            State state,
            DateTime regDate,
            DateTime limitDate){

            Name = name;
            this.priority = priority;
            this.category = category;
            this.state = state;
            RegDate = regDate;
            LimitDate = limitDate;
        }

        public override string ToString()
        {
            string s = $@"Name: {Name}  Priority: {priority}    Category: {category}
State: {state}   Register Date: {RegDate}   Limit Date: {LimitDate}"+"\n";
            
            return s;
        }
    }
}