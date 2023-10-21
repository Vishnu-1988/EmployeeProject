using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Shared.Mappings.Base
{
    public static class BsonClassMapHelper
    {
        private static object LockObj= new object();
        public static void Register<T>() where T:BsonClassMap,new()
        {
            lock (LockObj)
            {
                var mapping = new T();
                if(BsonClassMap.GetRegisteredClassMaps().SingleOrDefault(e=>e.ClassType==mapping.ClassType)!=null)
                {
                    return;
                }
                BsonClassMap.RegisterClassMap(mapping);
            }
        }
    }
}
