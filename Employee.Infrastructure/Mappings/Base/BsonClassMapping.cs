using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Shared.Mappings.Base
{
    public abstract class BsonClassMapping<T>:BsonClassMap<T>
    {
        protected BsonClassMapping() {
            SetIgnoreExtraElements(ignoreExtraElements: true);
        }
        protected void MapEnumToString<TEnum>(Expression<Func<T,Enum>> expression) where TEnum : struct,Enum {
         MapProperty(expression).SetSerializer(new EnumSerializer<TEnum>(MongoDB.Bson.BsonType.String));
        }
    }
}
