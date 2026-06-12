using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PCbuilder.Services
{
    public static class CSVService
    {
        public static List<T> LoadFromCSV<T>(string filePath) where T : new()
        {
            var list = new List<T>();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл не найден: {filePath}");
            }

            var lines = File.ReadAllLines(filePath);
            if (lines.Length < 2) return list;

            // Читаем заголовки из первой строки
            var headers = lines[0].Split(',');
            var properties = typeof(T).GetProperties();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var item = new T();

                // Проходим по заголовкам и находим соответствующие свойства
                for (int j = 0; j < headers.Length && j < values.Length; j++)
                {
                    var headerName = headers[j].Trim();
                    var value = values[j].Trim();

                    if (string.IsNullOrEmpty(value)) continue;

                    // Ищем свойство по имени (без учета регистра)
                    var prop = Array.Find(properties, p =>
                        p.Name.Equals(headerName, StringComparison.OrdinalIgnoreCase));

                    if (prop == null) continue;

                    try
                    {
                        if (prop.PropertyType == typeof(bool))
                        {
                            prop.SetValue(item, value == "1" || value.ToLower() == "true");
                        }
                        else if (prop.PropertyType == typeof(int))
                        {
                            if (int.TryParse(value, out int intValue))
                                prop.SetValue(item, intValue);
                        }
                        else if (prop.PropertyType == typeof(double))
                        {
                            if (double.TryParse(value, out double doubleValue))
                                prop.SetValue(item, doubleValue);
                        }
                        else if (prop.PropertyType == typeof(decimal))
                        {
                            if (decimal.TryParse(value, out decimal decimalValue))
                                prop.SetValue(item, decimalValue);
                        }
                        else
                        {
                            prop.SetValue(item, Convert.ChangeType(value, prop.PropertyType));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка парсинга {headerName}='{value}': {ex.Message}");
                    }
                }
                list.Add(item);
            }

            return list;
        }
    }
}