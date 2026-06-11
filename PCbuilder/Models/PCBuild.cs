using System;
namespace PCbuilder.Models

{
    public class PCBuild
    {
        public string BuildName { get; set; }

        public DateTime CreatedDate { get; set; }

        // Выбранные компоненты (могут быть null, если пользователь еще не выбрал)
        public CPU SelectedCPU { get; set; }
        public Motherboard SelectedMotherboard { get; set; }
        public GPU SelectedGPU { get; set; }
        public RAM SelectedRAM { get; set; }
        public Storage SelectedStorage { get; set; }
        public PSU SelectedPSU { get; set; }
        public Case SelectedCase { get; set; }

        // Метод для расчета итоговой цены
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            if (SelectedCPU != null) total += SelectedCPU.Price;
            if (SelectedMotherboard != null) total += SelectedMotherboard.Price;
            if (SelectedGPU != null) total += SelectedGPU.Price;
            if (SelectedRAM != null) total += SelectedRAM.Price;
            if (SelectedStorage != null) total += SelectedStorage.Price;
            if (SelectedPSU != null) total += SelectedPSU.Price;
            if (SelectedCase != null) total += SelectedCase.Price;
            
            return total;
        }
    }
}