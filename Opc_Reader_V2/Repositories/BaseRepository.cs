using LiteDB;
using Opc_Reader_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opc_Reader_V2.Repositories
{
    public class BaseRepository
    {
        public void AddDb<T>(T model) where T : BaseModel
        {
            using (var db= new LiteDatabase(ProjectConfig.PrConfig.dbPath))
            {
                var collection= db.GetCollection<T>(model.TableName);
                collection.Insert(model);
            }
        } 
    }
}
