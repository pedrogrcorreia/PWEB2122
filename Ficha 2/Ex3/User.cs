using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex1{

    enum OrderType{
        name,
        priority,
        category,
        state,
        limit_date,
        register_date
    }
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

        public List<Task> OrderTasksBy(OrderType type, bool desc){
            List<Task> list = null;
            
            switch(type){
                case OrderType.name:
                if(desc == true){
                    list = Tasks.OrderByDescending(t => t.Name).ToList();
                }
                else{
                    list = Tasks.OrderBy(t => t.Name).ToList();
                }
                // list = (desc == true) ? Tasks.OrderByDescending(t => t.Name) : Tasks.OrderBy(t => t.Name).ToList();
                break;
                case OrderType.priority:
                if(desc == true){
                    list = Tasks.OrderByDescending(t => t.priority).ToList();
                }
                else{
                    list = Tasks.OrderBy(t => t.priority).ToList();
                }
                //list = (desc == true) ? Tasks.OrderByDescending(t => t.Priority).ToList() : Tasks.OrderBy(t => t.Priority).ToList();
                break;
                case OrderType.category:
                list = (desc == true) ? Tasks.OrderByDescending(t => t.category).ToList() : Tasks.OrderBy(t => t.category).ToList();
                break;
                case OrderType.state:
                list = (desc == true) ? Tasks.OrderByDescending(t => t.state).ToList() : Tasks.OrderBy(t => t.state).ToList();
                break;
                case OrderType.limit_date:
                list = (desc == true) ? Tasks.OrderByDescending(t => t.LimitDate).ToList() : Tasks.OrderBy(t => t.LimitDate).ToList();
                break;
                case OrderType.register_date:
                list = (desc == true) ? Tasks.OrderByDescending(t => t.RegDate).ToList() : Tasks.OrderBy(t => t.RegDate).ToList();
                break;
            }

            return list;
        }
    
        public List<Task> OrderTasksByLimitDate(){
            List<Task> list = new List<Task>();

            var tasksByDate = from x in Tasks
                            orderby x.LimitDate.Date ascending
                            group x by x.LimitDate.Date;

            foreach(var gr in tasksByDate){
                var tasksByPriority = from y in gr
                                    orderby y.priority descending
                                    select y;

                foreach(var item in tasksByPriority){
                    list.Add(item);
                }
            }

            //list = Tasks.OrderBy(t => t.LimitDate).OrderByDescending(t => t.priority).ToList();
            //list.OrderBy(t => t.priority);

            return list;
        }
    }
}