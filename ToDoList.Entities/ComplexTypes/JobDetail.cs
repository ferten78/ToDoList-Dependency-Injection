using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Entities.ComplexTypes
{
    public class JobDetail
    {
        public int JobId { get; set; }
        public DateTime FinishDate { get; set; }
        public string Description { get; set; }
        public string StatusDescription { get; set; } 
        public string UserName { get; set; }
    }
}
