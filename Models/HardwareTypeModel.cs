using System;
namespace HardwareSite.Models
{
    public class HardwareTypeModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<int> parentTypes { get; set; }
        public List<int> childTypes { get; set; }

        public HardwareTypeModel(int id, string name, List<int> parentTypes, List<int> childTypes)
        {
            this.id = id;
            this.name = name;
            this.parentTypes = parentTypes;
            this.childTypes = childTypes;
        }

    }
}

