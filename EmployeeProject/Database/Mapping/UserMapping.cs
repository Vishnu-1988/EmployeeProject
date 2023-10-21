using Employee.Shared.Mappings.Base;
using Employee.Shared.Model;

namespace EmployeeProject.Database.Mapping
{
    public class UserMapping:BsonClassMapping<Users>
    {
        public UserMapping() {
            AutoMap();
            SetIgnoreExtraElements(true);
            UnmapProperty(e => e.Id);
            MapProperty(e=>e.Id).SetElementName("Id");
        }
    }
}
