using System;
namespace PCbuilder.Models
{
    public class GPU : Component
    {
        public int VRAM { get; set; }           // Объем видеопамяти (GB)
        public double TDP { get; set; }         // Тепловыделение (Ватт)
        public int LengthMm { get; set; }       // Длина в мм (нужно для корпуса)
    }
}