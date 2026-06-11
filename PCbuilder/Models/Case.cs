using System;
namespace PCbuilder.Models
{
    public class Case : Component
    {
        public string FormFactor { get; set; }  // Какие материнки влезут (ATX, mATX)
        public int MaxGpuLengthMm { get; set; } // Максимальная длина видеокарты
    }
}