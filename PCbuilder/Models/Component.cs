using System;
namespace PCbuilder.Models
{
    // Абстрактный класс, от которого будут наследоваться все комплектующие
    public abstract class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        
        // Переопределяем ToString, чтобы в ComboBox или ListBox красиво отображалось название
        public override string ToString()
        {
            return $"{Name} ({Manufacturer}) - {Price} ₽";
        }
    }
}