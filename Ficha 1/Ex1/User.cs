using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1{
    class User{
        public string Name {get;}
        public List<Task> Tasks {get;}

        public User(String name, List<Task> tasks = null){
            Name = name;
            if(tasks == null){
                Tasks = new List<Task>();
            }
            else{
                Tasks = tasks;
            }
        }

        public void AddTask(string name = null, 
            Priority priority = Priority.High,
            Category category = Category.Work,
            State state = State.NotDone,
            string limitDate = null){
                
            DateTime regDate = DateTime.Now;
            DateTime limDate;

            if(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)){
                name = "Task";
            }

            if(!DateTime.TryParse(limitDate, out limDate)){
                limDate = regDate.AddHours(24);
            }

            Tasks.Add(new Task(name, priority, category, state, regDate, limDate));
        }

        public void ShowTasks(List<Task> list, string title = null){
            if(title != null){
                Console.WriteLine(title);
            }

            foreach(Task task in list){
                Console.WriteLine(task);
            }
        }

        public List<Task> DelayedTasks(DateTime date){
            List<Task> ret = new List<Task>();
            foreach(Task task in Tasks){
                if(task.LimitDate < date && task.state != State.Done){
                    ret.Add(task);
                }
            }
            return ret;
        }

        public List<Task> ListTasks(Category category){
            List<Task> ret = new List<Task>();
            foreach(Task task in Tasks){
                if(task.category == category){
                    ret.Add(task);
                }
            }
            return ret;
        }

        public List<Task> ListTasks(State state){
            List<Task> ret = new List<Task>();
            foreach(Task task in Tasks){
                if(task.state == state){
                    ret.Add(task);
                }
            }
            return ret;
        }

        public List<Task> ListTasks(Priority priority){
            List<Task> ret = new List<Task>();
            foreach(Task task in Tasks){
                if(task.priority == priority){
                    ret.Add(task);
                }
            }
            return ret;
        }

        public List<Task> RemoveTasks(Category category){
            List<Task> ret = ListTasks(category);
            foreach(Task task in ret){
                Tasks.Remove(task);
            }
            return Tasks;
        }

        public List<Task> RemoveTasks(State state){
            List<Task> ret = ListTasks(state);
            foreach(Task task in ret){
                Tasks.Remove(task);
            }
            return Tasks;
        }

        public List<Task> RemoveTasks(Priority priority){
            List<Task> ret = ListTasks(priority);
            foreach(Task task in ret){
                Tasks.Remove(task);
            }
            return Tasks;
        }
    }
}