using System;
namespace PCbuilder.Models
{
    public class Storage : Component
    {
        public int CapacityGB { get; set; }     // Объем (GB)
        public string Interface { get; set; }   // SATA, NVMe (M.2)
    }
}