using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using PCbuilder.Models;
using PCbuilder.Services;

namespace PCbuilder
{
    public partial class Form1 : Form
    {
        private List<CPU> _cpus;
        private List<GPU> _gpus;
        private List<Motherboard> _motherboards;
        private List<RAM> _rams;
        private List<Storage> _storages;
        private List<PSU> _psus;
        private List<Case> _cases;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            LoadAllData();
            PopulateBuildComboBoxes();

            // Подписываемся на изменения выбора компонентов
            cmbCPU.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbGPU.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbMotherboard.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbRAM.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbStorage.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbPSU.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbCase.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
        }

        private void InitializeComboBox()
        {
            cmbComponentType.Items.AddRange(new string[]
            {
                "Процессоры",
                "Видеокарты",
                "Материнские платы",
                "Оперативная память",
                "Накопители",
                "Блоки питания",
                "Корпуса"
            });
            cmbComponentType.SelectedIndex = 0;
        }

        private void LoadAllData()
        {
            try
            {
                _cpus = CSVService.LoadFromCSV<CPU>("Data/cpu.csv");

                // Проверка что данные загрузились
                if (_cpus == null || _cpus.Count == 0)
                {
                    MessageBox.Show("Не удалось загрузить процессоры!\nПроверьте путь к файлу Data/cpu.csv",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Загружено процессоров: {_cpus.Count}\n" +
                                  $"Первый: {_cpus[0].Name}\n" +
                                  $"Цена: {_cpus[0].Price}",
                        "Отладка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _gpus = CSVService.LoadFromCSV<GPU>("Data/gpu.csv");
                _motherboards = CSVService.LoadFromCSV<Motherboard>("Data/motherboard.csv");
                _rams = CSVService.LoadFromCSV<RAM>("Data/ram.csv");
                _storages = CSVService.LoadFromCSV<Storage>("Data/storage.csv");
                _psus = CSVService.LoadFromCSV<PSU>("Data/psu.csv");
                _cases = CSVService.LoadFromCSV<Case>("Data/case.csv");

                statusStrip1.Items.Clear();
                statusStrip1.Items.Add($"✅ Загружено: CPU={_cpus.Count}, GPU={_gpus.Count}, MB={_motherboards.Count}, RAM={_rams.Count}, Storage={_storages.Count}, PSU={_psus.Count}, Case={_cases.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}\n\nStack Trace: {ex.StackTrace}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbComponentType.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип компонента!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedType = cmbComponentType.SelectedItem.ToString();

            switch (selectedType)
            {
                case "Процессоры":
                    dgvCatalog.DataSource = null;
                    dgvCatalog.DataSource = _cpus;
                    break;
                case "Видеокарты":
                    dgvCatalog.DataSource = null;
                    dgvCatalog.DataSource = _gpus;
                    break;
                case "Материнские платы":
                    dgvCatalog.DataSource = null;
                    dgvCatalog.DataSource = _motherboards;
                    break;
                case "Оперативная память":
                    dgvCatalog.DataSource = null;
                    dgvCatalog.DataSource = _rams;
                    break;
                case "Накопители":
                    dgvCatalog.DataSource = null;
                    dgvCatalog.DataSource = _storages;
                    break;
                case "Блоки питания":
                    dgvCatalog.DataSource = null;
                    dgvCatalog.DataSource = _psus;
                    break;
                case "Корпуса":
                    dgvCatalog.DataSource = null;
                    dgvCatalog.DataSource = _cases;
                    break;
            }
        }

        // Заполняем ComboBox на вкладке "Сборка ПК"
        // Заполняем ComboBox на вкладке "Сборка ПК"
        // Заполняем ComboBox на вкладке "Сборка ПК"
        private void PopulateBuildComboBoxes()
        {
            cmbCPU.Items.Clear();
            cmbCPU.Items.Add("-- Не выбрано --");
            if (_cpus != null)
            {
                foreach (var cpu in _cpus)
                {
                    cmbCPU.Items.Add(cpu); // ToString() автоматически вызовется
                }
            }
            cmbCPU.SelectedIndex = 0;

            cmbGPU.Items.Clear();
            cmbGPU.Items.Add("-- Не выбрано --");
            if (_gpus != null)
            {
                foreach (var gpu in _gpus)
                    cmbGPU.Items.Add(gpu);
            }
            cmbGPU.SelectedIndex = 0;

            cmbMotherboard.Items.Clear();
            cmbMotherboard.Items.Add("-- Не выбрано --");
            if (_motherboards != null)
            {
                foreach (var mb in _motherboards)
                    cmbMotherboard.Items.Add(mb);
            }
            cmbMotherboard.SelectedIndex = 0;

            cmbRAM.Items.Clear();
            cmbRAM.Items.Add("-- Не выбрано --");
            if (_rams != null)
            {
                foreach (var ram in _rams)
                    cmbRAM.Items.Add(ram);
            }
            cmbRAM.SelectedIndex = 0;

            cmbStorage.Items.Clear();
            cmbStorage.Items.Add("-- Не выбрано --");
            if (_storages != null)
            {
                foreach (var storage in _storages)
                    cmbStorage.Items.Add(storage);
            }
            cmbStorage.SelectedIndex = 0;

            cmbPSU.Items.Clear();
            cmbPSU.Items.Add("-- Не выбрано --");
            if (_psus != null)
            {
                foreach (var psu in _psus)
                    cmbPSU.Items.Add(psu);
            }
            cmbPSU.SelectedIndex = 0;

            cmbCase.Items.Clear();
            cmbCase.Items.Add("-- Не выбрано --");
            if (_cases != null)
            {
                foreach (var c in _cases)
                    cmbCase.Items.Add(c);
            }
            cmbCase.SelectedIndex = 0;
        }

        // Обновляем итоговую цену
        // Обновляем итоговую цену
        private void UpdateTotalPrice()
        {
            decimal total = 0;

            if (cmbCPU.SelectedIndex > 0) total += _cpus[cmbCPU.SelectedIndex - 1].Price;
            if (cmbGPU.SelectedIndex > 0) total += _gpus[cmbGPU.SelectedIndex - 1].Price;
            if (cmbMotherboard.SelectedIndex > 0) total += _motherboards[cmbMotherboard.SelectedIndex - 1].Price;
            if (cmbRAM.SelectedIndex > 0) total += _rams[cmbRAM.SelectedIndex - 1].Price;
            if (cmbStorage.SelectedIndex > 0) total += _storages[cmbStorage.SelectedIndex - 1].Price;
            if (cmbPSU.SelectedIndex > 0) total += _psus[cmbPSU.SelectedIndex - 1].Price;
            if (cmbCase.SelectedIndex > 0) total += _cases[cmbCase.SelectedIndex - 1].Price;

            lblTotalPriceValue.Text = $"{total:N0} ₽";
        }

        // Проверка совместимости
        private void btnCheckCompatibility_Click(object sender, EventArgs e)
        {
            var errors = new List<string>();

            // Проверка: выбраны ли все компоненты
            if (cmbCPU.SelectedIndex == 0) errors.Add("❌ Не выбран процессор");
            if (cmbGPU.SelectedIndex == 0) errors.Add(" Не выбрана видеокарта");
            if (cmbMotherboard.SelectedIndex == 0) errors.Add(" Не выбрана материнская плата");
            if (cmbRAM.SelectedIndex == 0) errors.Add(" Не выбрана оперативная память");
            if (cmbStorage.SelectedIndex == 0) errors.Add(" Не выбран накопитель");
            if (cmbPSU.SelectedIndex == 0) errors.Add("❌ Не выбран блок питания");
            if (cmbCase.SelectedIndex == 0) errors.Add("❌ Не выбран корпус");

            if (errors.Count > 0)
            {
                lblCompatibilityStatus.Text = " Не все компоненты выбраны!";
                lblCompatibilityStatus.ForeColor = System.Drawing.Color.Orange;
                return;
            }

            // Проверка сокета CPU и материнской платы
            var cpu = _cpus[cmbCPU.SelectedIndex - 1];
            var mb = _motherboards[cmbMotherboard.SelectedIndex - 1];

            if (cpu.Socket != mb.Socket)
            {
                errors.Add($" Несовместимость сокетов: CPU ({cpu.Socket}) ≠ Мат. плата ({mb.Socket})");
            }

            // Проверка форм-фактора корпуса и материнской платы
            var c = _cases[cmbCase.SelectedIndex - 1];
            if (mb.FormFactor != c.FormFactor)
            {
                errors.Add($"❌ Несовместимость форм-факторов: Мат. плата ({mb.FormFactor}) ≠ Корпус ({c.FormFactor})");
            }

            if (errors.Count == 0)
            {
                lblCompatibilityStatus.Text = "✅ Все компоненты совместимы!";
                lblCompatibilityStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblCompatibilityStatus.Text = string.Join("\n", errors);
                lblCompatibilityStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Сохранение сборки в JSON
        private void btnSaveBuild_Click(object sender, EventArgs e)
        {
            if (cmbCPU.SelectedIndex == 0 || cmbMotherboard.SelectedIndex == 0)
            {
                MessageBox.Show("Выберите хотя бы процессор и материнскую плату!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var build = new PCBuild
            {
                BuildName = $"Сборка {DateTime.Now:dd.MM.yyyy HH:mm}",
                CreatedDate = DateTime.Now,
                SelectedCPU = _cpus[cmbCPU.SelectedIndex - 1],
                SelectedGPU = cmbGPU.SelectedIndex > 0 ? _gpus[cmbGPU.SelectedIndex - 1] : null,
                SelectedMotherboard = _motherboards[cmbMotherboard.SelectedIndex - 1],
                SelectedRAM = cmbRAM.SelectedIndex > 0 ? _rams[cmbRAM.SelectedIndex - 1] : null,
                SelectedStorage = cmbStorage.SelectedIndex > 0 ? _storages[cmbStorage.SelectedIndex - 1] : null,
                SelectedPSU = cmbPSU.SelectedIndex > 0 ? _psus[cmbPSU.SelectedIndex - 1] : null,
                SelectedCase = cmbCase.SelectedIndex > 0 ? _cases[cmbCase.SelectedIndex - 1] : null
            };

            try
            {
                var json = new JavaScriptSerializer().Serialize(build);
                var fileName = $"Builds/build_{DateTime.Now:yyyyMMdd_HHmmss}.json";

                Directory.CreateDirectory("Builds");
                File.WriteAllText(fileName, json);

                MessageBox.Show($"✅ Сборка сохранена в файл:\n{fileName}", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}