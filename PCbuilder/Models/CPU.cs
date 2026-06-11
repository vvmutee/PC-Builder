using System;
namespace PCbuilder.Models
{
    public class CPU : Component
    {
        public string Socket { get; set; }      // Например, LGA1700, AM5
        public int Cores { get; set; }          // Количество ядер
        public double TDP { get; set; }         // Тепловыделение в Ваттах (нужно для БП)
        public bool HasIntegratedGraphics { get; set; } // Есть ли встроенная графика
    }
}