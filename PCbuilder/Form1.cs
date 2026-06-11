using System;
using System.Windows.Forms;
using System.Collections.Generic;
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
                _gpus = CSVService.LoadFromCSV<GPU>("Data/gpu.csv");
                _motherboards = CSVService.LoadFromCSV<Motherboard>("Data/motherboard.csv");
                _rams = CSVService.LoadFromCSV<RAM>("Data/ram.csv");
                _storages = CSVService.LoadFromCSV<Storage>("Data/storage.csv");
                _psus = CSVService.LoadFromCSV<PSU>("Data/psu.csv");
                _cases = CSVService.LoadFromCSV<Case>("Data/case.csv");

                statusStrip1.Items.Clear();
                statusStrip1.Items.Add($"Загружено: CPU={_cpus.Count}, GPU={_gpus.Count}, MB={_motherboards.Count}, RAM={_rams.Count}, Storage={_storages.Count}, PSU={_psus.Count}, Case={_cases.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}