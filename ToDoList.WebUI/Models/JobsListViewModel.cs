using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Entities.Concrete;

namespace ToDoList.WebUI.Models
{
    public class JobsListViewModel
    {
        public List<Job> Jobs { get; set; }
        public List<User> Users { get; set; }
        public List<Status> Statuses { get; set; }
        public bool IsLate { get; set; }
    }
}