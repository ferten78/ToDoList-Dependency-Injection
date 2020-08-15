using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Entities.Concrete;

namespace ToDoList.WebUI.Models
{
    public class NewJobViewModel
    {
        public List<User> Users { get; set; }
        public List<Status> Statuses { get; set; }
    }
}