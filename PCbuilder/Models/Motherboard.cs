using System;
namespace PCbuilder.Models
{
    public class Motherboard : Component
    {
        public string Socket { get; set; }      // Сокет (должен совпадать с CPU)
        public string FormFactor { get; set; }  // ATX, Micro-ATX, Mini-ITX
        public string RamType { get; set; }     // DDR4, DDR5
        public int RamSlots { get; set; }       // Количество слотов под ОЗУ
    }
}