using System;
namespace PCbuilder.Models
{
    public class RAM : Component
    {
        public int CapacityGB { get; set; }     // Объем (GB)
        public int FrequencyMHz { get; set; }   // Частота (MHz)
        public string Type { get; set; }        // DDR4, DDR5 (должна совпадать с материнкой)
    }
}