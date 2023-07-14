using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opc_Reader_V2.Models
{
    public class BaseModel
    {
        public BaseModel(string tableName)
        {
            TableName= tableName;
        }
        public string TableName { get; set; }
        public Guid ID = Guid.NewGuid();
    }
}
