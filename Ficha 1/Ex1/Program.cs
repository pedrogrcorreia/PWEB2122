using System;
using System.Collections.Generic;

namespace Ex1{
    class Program{
        static void Main(string[] args){
            User u = new User("Pedro", new List<Task>());

            u.AddTask();
            u.AddTask("Grocery", category: Category.Personal);
            u.AddTask("Exam", Priority.Medium, limitDate: "21/10/2021 09:30");
            u.AddTask("Another exame", Priority.Medium);
            u.AddTask(limitDate: "21/10/2021 10:30");
            u.AddTask(limitDate: "15/10/2021 14:30");
            u.AddTask(name: "Done", state: State.Done);
            u.AddTask(name: "Personal", category: Category.Personal);
            u.AddTask(name: "low", priority: Priority.Low);

            u.ShowTasks(u.Tasks, "\nAll Tasks\n");

            string date = "14/10/2021 09:30";
            DateTime dateTime;
            DateTime.TryParse(date, out dateTime);

            u.ShowTasks(u.DelayedTasks(dateTime), "\nDelayed Tasks\n");
            u.ShowTasks(u.ListTasks(priority: Priority.Low), "\nLow Priority Tasks\n");

            foreach(Category type in Enum.GetValues(typeof(Category))){
                u.ShowTasks(u.ListTasks(type), $"\nCategory: {type.ToString()}\n");
            }

            foreach(State type in Enum.GetValues(typeof(State))){
                u.ShowTasks(u.ListTasks(type), $"\nState: {type.ToString()}\n");
            }

            u.ShowTasks(u.RemoveTasks(State.Done), "\nRemove done tasks\n");
        }
    }
}
