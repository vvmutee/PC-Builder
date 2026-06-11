using System;
namespace PCbuilder.Models
{
    public class PSU : Component
    {
        public int Wattage { get; set; }        // Мощность в Ваттах
        public string Efficiency { get; set; }  // Сертификат (80 Plus Bronze, Gold)
    }
}