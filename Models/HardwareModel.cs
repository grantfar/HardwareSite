using System;

namespace HardwareSite.Models{
    public class HardwareModel {
        public HardwareModel(int id, string name, string modelNumber, int hardWareType)
        {
            this.id = id;
            this.name = name;
            this.modelNumber = modelNumber;
            this.hardWareType = hardWareType;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string modelNumber { get; set; }
        public int hardWareType { get; set; }
    }
}