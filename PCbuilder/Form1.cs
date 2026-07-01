using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms.DataVisualization.Charting;
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
        private List<Component> _allComponents;
        private List<PCBuild> _savedBuilds;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            LoadAllData();
            PopulateBuildComboBoxes();
            CalculateStatistics();
            BuildCharts();

            cmbCPU.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbGPU.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbMotherboard.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbRAM.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbStorage.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbPSU.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cmbCase.SelectedIndexChanged += (s, e) => UpdateTotalPrice();

            // Каталог обновляется автоматически: смена типа, ввод в поиск, смена фильтра цены
            cmbComponentType.SelectedIndexChanged += (s, e) => ShowCatalog();
            txtSearch.TextChanged += (s, e) => ShowCatalog();
            cmbFilterType.SelectedIndexChanged += (s, e) => ShowCatalog();

            ShowCatalog();

            // Анализ сборок: подгружаем при старте и при каждом открытии вкладки
            LoadBuildsAnalysis();
            tabControl1.SelectedIndexChanged += (s, e) =>
            {
                if (tabControl1.SelectedTab == tabPageBuilds) LoadBuildsAnalysis();
            };
        }

        private void InitializeComboBox()
        {
            cmbComponentType.Items.AddRange(new string[]
            {
                "Процессоры", "Видеокарты", "Материнские платы",
                "Оперативная память", "Накопители", "Блоки питания", "Корпуса"
            });
            cmbComponentType.SelectedIndex = 0;
        }

        private void LoadAllData()
        {
            try
            {
                _cpus = CSVService.LoadFromCSV<CPU>("Data/cpu.csv");
                _gpus = CSVService.LoadFromCSV<GPU>("Data/gpu.csv");
                _motherboards = CSVService.LoadFromCSV<Motherboard>("Data/motherboard.csv");
                _rams = CSVService.LoadFromCSV<RAM>("Data/ram.csv");
                _storages = CSVService.LoadFromCSV<Storage>("Data/storage.csv");
                _psus = CSVService.LoadFromCSV<PSU>("Data/psu.csv");
                _cases = CSVService.LoadFromCSV<Case>("Data/case.csv");

                _allComponents = new List<Component>();
                _allComponents.AddRange(_cpus);
                _allComponents.AddRange(_gpus);
                _allComponents.AddRange(_motherboards);
                _allComponents.AddRange(_rams);
                _allComponents.AddRange(_storages);
                _allComponents.AddRange(_psus);
                _allComponents.AddRange(_cases);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Показывает каталог с учётом выбранного типа, текста поиска и фильтра по цене.
        // Вызывается автоматически при любом изменении этих полей.
        private void ShowCatalog()
        {
            if (_allComponents == null || cmbComponentType.SelectedIndex == -1) return;

            List<Component> filtered = GetSelectedComponents();

            string searchText = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchText))
                filtered = filtered.Where(c => c.Name.ToLower().Contains(searchText)).ToList();

            string filterType = cmbFilterType.SelectedItem?.ToString() ?? "Все";
            filtered = ApplyPriceFilter(filtered, filterType);

            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = filtered;
            dgvCatalog.ClearSelection();
        }

        private void PopulateBuildComboBoxes()
        {
            cmbCPU.Items.Clear(); cmbCPU.Items.Add("-- Не выбрано --");
            foreach (var cpu in _cpus) cmbCPU.Items.Add(cpu);
            cmbCPU.SelectedIndex = 0;

            cmbGPU.Items.Clear(); cmbGPU.Items.Add("-- Не выбрано --");
            foreach (var gpu in _gpus) cmbGPU.Items.Add(gpu);
            cmbGPU.SelectedIndex = 0;

            cmbMotherboard.Items.Clear(); cmbMotherboard.Items.Add("-- Не выбрано --");
            foreach (var mb in _motherboards) cmbMotherboard.Items.Add(mb);
            cmbMotherboard.SelectedIndex = 0;

            cmbRAM.Items.Clear(); cmbRAM.Items.Add("-- Не выбрано --");
            foreach (var ram in _rams) cmbRAM.Items.Add(ram);
            cmbRAM.SelectedIndex = 0;

            cmbStorage.Items.Clear(); cmbStorage.Items.Add("-- Не выбрано --");
            foreach (var s in _storages) cmbStorage.Items.Add(s);
            cmbStorage.SelectedIndex = 0;

            cmbPSU.Items.Clear(); cmbPSU.Items.Add("-- Не выбрано --");
            foreach (var psu in _psus) cmbPSU.Items.Add(psu);
            cmbPSU.SelectedIndex = 0;

            cmbCase.Items.Clear(); cmbCase.Items.Add("-- Не выбрано --");
            foreach (var c in _cases) cmbCase.Items.Add(c);
            cmbCase.SelectedIndex = 0;
        }

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

            // Состав сборки изменился — старый результат проверки больше не актуален
            ResetCompatibilityHighlight();
            lblCompatibilityStatus.Text = "";
        }

        // Цвет подсветки несовместимых полей
        private static readonly System.Drawing.Color IncompatibleColor = System.Drawing.Color.FromArgb(255, 205, 210);

        private void btnCheckCompatibility_Click(object sender, EventArgs e)
        {
            ResetCompatibilityHighlight();
            var errors = new List<string>();

            if (cmbCPU.SelectedIndex == 0) errors.Add("❌ Не выбран процессор");
            if (cmbGPU.SelectedIndex == 0) errors.Add("❌ Не выбрана видеокарта");
            if (cmbMotherboard.SelectedIndex == 0) errors.Add("❌ Не выбрана материнская плата");
            if (cmbRAM.SelectedIndex == 0) errors.Add("❌ Не выбрана оперативная память");
            if (cmbStorage.SelectedIndex == 0) errors.Add("❌ Не выбран накопитель");
            if (cmbPSU.SelectedIndex == 0) errors.Add("❌ Не выбран блок питания");
            if (cmbCase.SelectedIndex == 0) errors.Add("❌ Не выбран корпус");

            if (errors.Count > 0)
            {
                lblCompatibilityStatus.Text = string.Join("\n", errors);
                lblCompatibilityStatus.ForeColor = System.Drawing.Color.Orange;
                return;
            }

            var cpu = _cpus[cmbCPU.SelectedIndex - 1];
            var mb = _motherboards[cmbMotherboard.SelectedIndex - 1];
            var c = _cases[cmbCase.SelectedIndex - 1];

            if (cpu.Socket != mb.Socket)
            {
                errors.Add($"❌ Несовместимость сокетов: CPU ({cpu.Socket}) ≠ Мат. плата ({mb.Socket})");
                cmbCPU.BackColor = IncompatibleColor;
                cmbMotherboard.BackColor = IncompatibleColor;
            }

            if (mb.FormFactor != c.FormFactor)
            {
                errors.Add($"❌ Несовместимость форм-факторов: Мат. плата ({mb.FormFactor}) ≠ Корпус ({c.FormFactor})");
                cmbMotherboard.BackColor = IncompatibleColor;
                cmbCase.BackColor = IncompatibleColor;
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

        // Сбрасывает подсветку всех полей сборки к обычному виду
        private void ResetCompatibilityHighlight()
        {
            cmbCPU.BackColor = System.Drawing.Color.White;
            cmbGPU.BackColor = System.Drawing.Color.White;
            cmbMotherboard.BackColor = System.Drawing.Color.White;
            cmbRAM.BackColor = System.Drawing.Color.White;
            cmbStorage.BackColor = System.Drawing.Color.White;
            cmbPSU.BackColor = System.Drawing.Color.White;
            cmbCase.BackColor = System.Drawing.Color.White;
        }

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
                MessageBox.Show($"✅ Сборка сохранена:\n{fileName}", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // === АНАЛИЗ ДАННЫХ ===

        private void CalculateStatistics()
        {
            if (_allComponents == null || _allComponents.Count == 0) return;

            var allPrices = _allComponents.Select(c => c.Price).ToList();
            decimal minPrice = allPrices.Min();
            decimal maxPrice = allPrices.Max();

            lblMinPrice.Text = $" Минимальная цена: {minPrice:N0} ₽";
            lblMaxPrice.Text = $" Максимальная цена: {maxPrice:N0} ₽";
            lblTotalItems.Text = $" Всего компонентов: {_allComponents.Count}";

            lblAvgCPU.Text = $" CPU (средняя): {(_cpus.Any() ? _cpus.Average(c => c.Price) : 0):N0} ₽";
            lblAvgGPU.Text = $" GPU (средняя): {(_gpus.Any() ? _gpus.Average(c => c.Price) : 0):N0} ₽";
            lblAvgMB.Text = $"🔌 Мат. платы (средняя): {(_motherboards.Any() ? _motherboards.Average(c => c.Price) : 0):N0} ₽";
            lblAvgRAM.Text = $"💾 RAM (средняя): {(_rams.Any() ? _rams.Average(c => c.Price) : 0):N0} ₽";
            lblAvgStorage.Text = $"💿 Накопители (средняя): {(_storages.Any() ? _storages.Average(c => c.Price) : 0):N0} ₽";
            lblAvgPSU.Text = $"⚡ Блоки питания (средняя): {(_psus.Any() ? _psus.Average(c => c.Price) : 0):N0} ₽";
            lblAvgCase.Text = $"📦 Корпуса (средняя): {(_cases.Any() ? _cases.Average(c => c.Price) : 0):N0} ₽";
        }

        private void BuildCharts()
        {
            // График 1: Минимальная и максимальная цена по категориям (двойная столбчатая диаграмма)
            chartPriceByCategory.Series.Clear();
            chartPriceByCategory.Titles.Clear();
            chartPriceByCategory.Titles.Add("Минимальная и максимальная цена по категориям (₽)");

            var seriesMin = new Series("Минимальная");
            seriesMin.ChartType = SeriesChartType.Column;
            seriesMin.Color = System.Drawing.Color.FromArgb(52, 168, 83);

            var seriesMax = new Series("Максимальная");
            seriesMax.ChartType = SeriesChartType.Column;
            seriesMax.Color = System.Drawing.Color.FromArgb(234, 67, 53);

            AddMinMaxPoints(seriesMin, seriesMax, "CPU", _cpus.Select(c => c.Price));
            AddMinMaxPoints(seriesMin, seriesMax, "GPU", _gpus.Select(c => c.Price));
            AddMinMaxPoints(seriesMin, seriesMax, "Мат.плата", _motherboards.Select(c => c.Price));
            AddMinMaxPoints(seriesMin, seriesMax, "RAM", _rams.Select(c => c.Price));
            AddMinMaxPoints(seriesMin, seriesMax, "Накопитель", _storages.Select(c => c.Price));
            AddMinMaxPoints(seriesMin, seriesMax, "БП", _psus.Select(c => c.Price));
            AddMinMaxPoints(seriesMin, seriesMax, "Корпус", _cases.Select(c => c.Price));

            chartPriceByCategory.Series.Add(seriesMin);
            chartPriceByCategory.Series.Add(seriesMax);
            chartPriceByCategory.Legends.Clear();
            chartPriceByCategory.Legends.Add(new Legend("Legend1"));
            chartPriceByCategory.ChartAreas.Clear();
            var area1 = new ChartArea();
            area1.AxisX.Title = "Категория";
            area1.AxisY.Title = "Цена (₽)";
            area1.AxisY.LabelStyle.Format = "{0:N0}";
            chartPriceByCategory.ChartAreas.Add(area1);

            // График 2: Количество компонентов по категориям (круговая диаграмма)
            chartDistribution.Series.Clear();
            chartDistribution.Titles.Clear();
            chartDistribution.Titles.Add("Количество компонентов по категориям");

            var series2 = new Series("Количество");
            series2.ChartType = SeriesChartType.Pie;
            series2["PieLabelStyle"] = "Outside";
            series2["PieDrawingStyle"] = "Concave";

            series2.Points.AddXY("CPU", _cpus.Count);
            series2.Points.AddXY("GPU", _gpus.Count);
            series2.Points.AddXY("Мат.плата", _motherboards.Count);
            series2.Points.AddXY("RAM", _rams.Count);
            series2.Points.AddXY("Накопитель", _storages.Count);
            series2.Points.AddXY("БП", _psus.Count);
            series2.Points.AddXY("Корпус", _cases.Count);

            // Цвета для секторов
            series2.Points[0].Color = System.Drawing.Color.FromArgb(66, 133, 244);
            series2.Points[1].Color = System.Drawing.Color.FromArgb(234, 67, 53);
            series2.Points[2].Color = System.Drawing.Color.FromArgb(52, 168, 83);
            series2.Points[3].Color = System.Drawing.Color.FromArgb(251, 188, 4);
            series2.Points[4].Color = System.Drawing.Color.FromArgb(255, 152, 0);
            series2.Points[5].Color = System.Drawing.Color.FromArgb(156, 39, 176);
            series2.Points[6].Color = System.Drawing.Color.FromArgb(0, 188, 212);

            chartDistribution.Series.Add(series2);
            chartDistribution.ChartAreas.Clear();
            var area2 = new ChartArea();
            chartDistribution.ChartAreas.Add(area2);
        }

        // Добавляет в две серии точки минимальной и максимальной цены для одной категории
        private void AddMinMaxPoints(Series seriesMin, Series seriesMax, string category, IEnumerable<decimal> prices)
        {
            var list = prices.ToList();
            seriesMin.Points.AddXY(category, list.Any() ? list.Min() : 0);
            seriesMax.Points.AddXY(category, list.Any() ? list.Max() : 0);
        }

        private void btnRefreshStats_Click(object sender, EventArgs e)
        {
            CalculateStatistics();
            BuildCharts();
            MessageBox.Show("✅ Статистика обновлена!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // === АНАЛИЗ СБОРОК ===

        // Читает сохранённые сборки из папки Builds и наполняет обе таблицы (сборки и популярность)
        private void LoadBuildsAnalysis()
        {
            _savedBuilds = BuildAnalysisService.LoadBuilds();

            dgvBuilds.DataSource = null;
            dgvBuilds.DataSource = BuildAnalysisService.GetSummaries(_savedBuilds);
            dgvBuilds.ClearSelection();

            dgvPopularity.DataSource = null;
            dgvPopularity.DataSource = BuildAnalysisService.GetPopularity(_savedBuilds);
            dgvPopularity.ClearSelection();

            lblBuildsTitle.Text = $"🛠 Анализ сохранённых сборок (всего: {_savedBuilds.Count})";
        }

        // Переключение между таблицей сборок и статистикой популярности
        private void BuildsView_Changed(object sender, EventArgs e)
        {
            bool showTable = rbBuildsTable.Checked;
            dgvBuilds.Visible = showTable;
            dgvPopularity.Visible = !showTable;
        }

        private void btnRefreshBuilds_Click(object sender, EventArgs e)
        {
            LoadBuildsAnalysis();
        }

        // === ПОИСК И ФИЛЬТРАЦИЯ ===

        private List<Component> GetSelectedComponents()
        {
            string selectedType = cmbComponentType.SelectedItem.ToString();
            switch (selectedType)
            {
                case "Процессоры": return new List<Component>(_cpus);
                case "Видеокарты": return new List<Component>(_gpus);
                case "Материнские платы": return new List<Component>(_motherboards);
                case "Оперативная память": return new List<Component>(_rams);
                case "Накопители": return new List<Component>(_storages);
                case "Блоки питания": return new List<Component>(_psus);
                case "Корпуса": return new List<Component>(_cases);
                default: return new List<Component>();
            }
        }

        private List<Component> ApplyPriceFilter(List<Component> list, string filterType)
        {
            switch (filterType)
            {
                case "До 10000 ₽": return list.Where(c => c.Price <= 10000).ToList();
                case "10000-20000 ₽": return list.Where(c => c.Price >= 10000 && c.Price <= 20000).ToList();
                case "20000-40000 ₽": return list.Where(c => c.Price >= 20000 && c.Price <= 40000).ToList();
                case "Более 40000 ₽": return list.Where(c => c.Price > 40000).ToList();
                default: return list;
            }
        }
    }
}