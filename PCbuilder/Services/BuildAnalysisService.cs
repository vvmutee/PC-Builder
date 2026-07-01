using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using PCbuilder.Models;

namespace PCbuilder.Services
{
    // Строка таблицы сравнения сохранённых сборок.
    // Свойства названы по-русски — DataGridView использует их как заголовки колонок.
    public class BuildSummary
    {
        public string Сборка { get; set; }
        public string Дата { get; set; }
        public string Процессор { get; set; }
        public string Видеокарта { get; set; }
        public string МатПлата { get; set; }
        public string ОЗУ { get; set; }
        public string Накопитель { get; set; }
        public string БлокПитания { get; set; }
        public string Корпус { get; set; }
        public string Итого { get; set; }
    }

    // Строка статистики популярности по одной категории комплектующих.
    public class ComponentPopularity
    {
        public string Категория { get; set; }
        public string СамыйПопулярный { get; set; }
        public int КоличествоСборок { get; set; }
    }

    // Читает сохранённые сборки из папки Builds и считает по ним аналитику.
    public static class BuildAnalysisService
    {
        public static List<PCBuild> LoadBuilds(string folder = "Builds")
        {
            var builds = new List<PCBuild>();
            if (!Directory.Exists(folder)) return builds;

            var serializer = new JavaScriptSerializer();
            foreach (var file in Directory.GetFiles(folder, "*.json"))
            {
                try
                {
                    var build = serializer.Deserialize<PCBuild>(File.ReadAllText(file));
                    if (build != null) builds.Add(build);
                }
                catch
                {
                    // Повреждённые или несовместимые файлы просто пропускаем
                }
            }
            return builds;
        }

        // Вариант 1: каждая сборка — строка таблицы со всеми компонентами и итоговой ценой.
        public static List<BuildSummary> GetSummaries(List<PCBuild> builds)
        {
            return builds.Select(b => new BuildSummary
            {
                Сборка = b.BuildName,
                Дата = b.CreatedDate.ToString("dd.MM.yyyy HH:mm"),
                Процессор = b.SelectedCPU?.Name ?? "—",
                Видеокарта = b.SelectedGPU?.Name ?? "—",
                МатПлата = b.SelectedMotherboard?.Name ?? "—",
                ОЗУ = b.SelectedRAM?.Name ?? "—",
                Накопитель = b.SelectedStorage?.Name ?? "—",
                БлокПитания = b.SelectedPSU?.Name ?? "—",
                Корпус = b.SelectedCase?.Name ?? "—",
                Итого = b.GetTotalPrice().ToString("N0") + " ₽"
            }).ToList();
        }

        // Вариант 2: по каждой категории — самый часто встречающийся компонент.
        public static List<ComponentPopularity> GetPopularity(List<PCBuild> builds)
        {
            var result = new List<ComponentPopularity>();
            AddTop(result, "Процессор", builds.Select(b => b.SelectedCPU?.Name));
            AddTop(result, "Видеокарта", builds.Select(b => b.SelectedGPU?.Name));
            AddTop(result, "Мат. плата", builds.Select(b => b.SelectedMotherboard?.Name));
            AddTop(result, "Оперативная память", builds.Select(b => b.SelectedRAM?.Name));
            AddTop(result, "Накопитель", builds.Select(b => b.SelectedStorage?.Name));
            AddTop(result, "Блок питания", builds.Select(b => b.SelectedPSU?.Name));
            AddTop(result, "Корпус", builds.Select(b => b.SelectedCase?.Name));
            return result;
        }

        private static void AddTop(List<ComponentPopularity> result, string category, IEnumerable<string> names)
        {
            var top = names
                .Where(n => !string.IsNullOrEmpty(n))
                .GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            result.Add(new ComponentPopularity
            {
                Категория = category,
                СамыйПопулярный = top?.Key ?? "—",
                КоличествоСборок = top?.Count() ?? 0
            });
        }
    }
}
