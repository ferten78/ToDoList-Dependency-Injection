using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Entities.Concrete
{
    public class Job: IEntity
    {
        public int id { get; set; }
        public DateTime finishDate { get; set; }
        public string description { get; set; }
        public int statusId { get; set; }
        public int userId { get; set; }
    }
}
