using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opc_Reader_V2.Models
{
    public class ProjectLogs:BaseModel
    {
        public ProjectLogs():base("ProjectLogs")
        {

        }
        public int ID { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;


    }
}
