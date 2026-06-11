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

            var properties = typeof(T).GetProperties();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var item = new T();

                for (int j = 0; j < properties.Length && j < values.Length; j++)
                {
                    var prop = properties[j];
                    var value = values[j].Trim();

                    if (string.IsNullOrEmpty(value)) continue;

                    if (prop.PropertyType == typeof(bool))
                    {
                        prop.SetValue(item, value == "1" || value.ToLower() == "true");
                    }
                    else
                    {
                        try
                        {
                            prop.SetValue(item, Convert.ChangeType(value, prop.PropertyType));
                        }
                        catch { }
                    }
                }
                list.Add(item);
            }

            return list;
        }
    }
}