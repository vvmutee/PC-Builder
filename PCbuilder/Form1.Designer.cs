namespace PCbuilder
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCatalog = new System.Windows.Forms.TabPage();
            this.tabPageBuild = new System.Windows.Forms.TabPage();
            this.tabPageAnalysis = new System.Windows.Forms.TabPage();
            this.cmbComponentType = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelBuild = new System.Windows.Forms.Panel();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.lblCPU = new System.Windows.Forms.Label();
            this.cmbCPU = new System.Windows.Forms.ComboBox();
            this.lblGPU = new System.Windows.Forms.Label();
            this.cmbGPU = new System.Windows.Forms.ComboBox();
            this.lblMotherboard = new System.Windows.Forms.Label();
            this.cmbMotherboard = new System.Windows.Forms.ComboBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.cmbRAM = new System.Windows.Forms.ComboBox();
            this.lblStorage = new System.Windows.Forms.Label();
            this.cmbStorage = new System.Windows.Forms.ComboBox();
            this.lblPSU = new System.Windows.Forms.Label();
            this.cmbPSU = new System.Windows.Forms.ComboBox();
            this.lblCase = new System.Windows.Forms.Label();
            this.cmbCase = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.btnCheckCompatibility = new System.Windows.Forms.Button();
            this.btnSaveBuild = new System.Windows.Forms.Button();
            this.lblCompatibilityStatus = new System.Windows.Forms.Label();

            // Элементы вкладки "Анализ"
            this.chartPriceByCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblAvgCPU = new System.Windows.Forms.Label();
            this.lblAvgGPU = new System.Windows.Forms.Label();
            this.lblAvgMB = new System.Windows.Forms.Label();
            this.lblAvgRAM = new System.Windows.Forms.Label();
            this.lblAvgStorage = new System.Windows.Forms.Label();
            this.lblAvgPSU = new System.Windows.Forms.Label();
            this.lblAvgCase = new System.Windows.Forms.Label();
            this.btnRefreshStats = new System.Windows.Forms.Button();

            // Поиск и фильтрация
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.tabPageCatalog.SuspendLayout();
            this.tabPageBuild.SuspendLayout();
            this.tabPageAnalysis.SuspendLayout();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPriceByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribution)).BeginInit();
            this.SuspendLayout();

            // tabControl1
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCatalog);
            this.tabControl1.Controls.Add(this.tabPageBuild);
            this.tabControl1.Controls.Add(this.tabPageAnalysis);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 480);
            this.tabControl1.TabIndex = 0;

            // tabPageCatalog
            this.tabPageCatalog.Controls.Add(this.dgvCatalog);
            this.tabPageCatalog.Controls.Add(this.btnLoad);
            this.tabPageCatalog.Controls.Add(this.cmbComponentType);
            this.tabPageCatalog.Controls.Add(this.lblSearch);
            this.tabPageCatalog.Controls.Add(this.txtSearch);
            this.tabPageCatalog.Controls.Add(this.cmbFilterType);
            this.tabPageCatalog.Controls.Add(this.btnApplyFilter);
            this.tabPageCatalog.Controls.Add(this.btnResetFilter);
            this.tabPageCatalog.Location = new System.Drawing.Point(4, 22);
            this.tabPageCatalog.Name = "tabPageCatalog";
            this.tabPageCatalog.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageCatalog.Size = new System.Drawing.Size(822, 454);
            this.tabPageCatalog.TabIndex = 0;
            this.tabPageCatalog.Text = " Каталог";

            // tabPageBuild
            this.tabPageBuild.Controls.Add(this.panelPrice);
            this.tabPageBuild.Controls.Add(this.panelBuild);
            this.tabPageBuild.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuild.Name = "tabPageBuild";
            this.tabPageBuild.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageBuild.Size = new System.Drawing.Size(822, 454);
            this.tabPageBuild.TabIndex = 1;
            this.tabPageBuild.Text = " Сборка ПК";

            // tabPageAnalysis
            this.tabPageAnalysis.Controls.Add(this.chartDistribution);
            this.tabPageAnalysis.Controls.Add(this.chartPriceByCategory);
            this.tabPageAnalysis.Controls.Add(this.grpStats);
            this.tabPageAnalysis.Controls.Add(this.btnRefreshStats);
            this.tabPageAnalysis.Controls.Add(this.lblStatsTitle);
            this.tabPageAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageAnalysis.Size = new System.Drawing.Size(822, 454);
            this.tabPageAnalysis.TabIndex = 2;
            this.tabPageAnalysis.Text = " Анализ";

            // cmbComponentType
            this.cmbComponentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbComponentType.FormattingEnabled = true;
            this.cmbComponentType.Location = new System.Drawing.Point(10, 10);
            this.cmbComponentType.Name = "cmbComponentType";
            this.cmbComponentType.Size = new System.Drawing.Size(200, 24);

            // btnLoad
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(220, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 30);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // dgvCatalog
            this.dgvCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Location = new System.Drawing.Point(10, 80);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.Size = new System.Drawing.Size(802, 360);
            this.dgvCatalog.EnableHeadersVisualStyles = false;
            this.dgvCatalog.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(66, 133, 244);
            this.dgvCatalog.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCatalog.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCatalog.RowHeadersVisible = false;
            this.dgvCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Поиск и фильтрация
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSearch.Location = new System.Drawing.Point(10, 50);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Поиск:";

            this.txtSearch.Location = new System.Drawing.Point(60, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);

            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(new object[] { "Все", "До 10000 ₽", "10000-20000 ₽", "20000-40000 ₽", "Более 40000 ₽" });
            this.cmbFilterType.Location = new System.Drawing.Point(270, 47);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(150, 21);
            this.cmbFilterType.TabIndex = 5;
            this.cmbFilterType.SelectedIndex = 0;

            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(430, 45);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(80, 25);
            this.btnApplyFilter.TabIndex = 6;
            this.btnApplyFilter.Text = "Применить";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);

            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(158, 158, 158);
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(520, 45);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(80, 25);
            this.btnResetFilter.TabIndex = 7;
            this.btnResetFilter.Text = "Сброс";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            // statusStrip1
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);

            // panelBuild
            this.panelBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuild.AutoScroll = true;
            this.panelBuild.Controls.Add(this.cmbCase);
            this.panelBuild.Controls.Add(this.lblCase);
            this.panelBuild.Controls.Add(this.cmbPSU);
            this.panelBuild.Controls.Add(this.lblPSU);
            this.panelBuild.Controls.Add(this.cmbStorage);
            this.panelBuild.Controls.Add(this.lblStorage);
            this.panelBuild.Controls.Add(this.cmbRAM);
            this.panelBuild.Controls.Add(this.lblRAM);
            this.panelBuild.Controls.Add(this.cmbMotherboard);
            this.panelBuild.Controls.Add(this.lblMotherboard);
            this.panelBuild.Controls.Add(this.cmbGPU);
            this.panelBuild.Controls.Add(this.lblGPU);
            this.panelBuild.Controls.Add(this.cmbCPU);
            this.panelBuild.Controls.Add(this.lblCPU);
            this.panelBuild.Location = new System.Drawing.Point(10, 10);
            this.panelBuild.Name = "panelBuild";
            this.panelBuild.Size = new System.Drawing.Size(802, 360);

            // panelPrice
            this.panelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrice.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelPrice.Controls.Add(this.lblCompatibilityStatus);
            this.panelPrice.Controls.Add(this.btnSaveBuild);
            this.panelPrice.Controls.Add(this.btnCheckCompatibility);
            this.panelPrice.Controls.Add(this.lblTotalPriceValue);
            this.panelPrice.Controls.Add(this.lblTotalPrice);
            this.panelPrice.Location = new System.Drawing.Point(10, 380);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(802, 65);

            // Элементы сборки (CPU, GPU и т.д.) - как было раньше
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCPU.Location = new System.Drawing.Point(20, 20);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Text = "Процессор:";
            this.cmbCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCPU.FormattingEnabled = true;
            this.cmbCPU.Location = new System.Drawing.Point(200, 17);
            this.cmbCPU.Name = "cmbCPU";
            this.cmbCPU.Size = new System.Drawing.Size(580, 23);

            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblGPU.Location = new System.Drawing.Point(20, 55);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Text = "Видеокарта:";
            this.cmbGPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbGPU.FormattingEnabled = true;
            this.cmbGPU.Location = new System.Drawing.Point(200, 52);
            this.cmbGPU.Name = "cmbGPU";
            this.cmbGPU.Size = new System.Drawing.Size(580, 23);

            this.lblMotherboard.AutoSize = true;
            this.lblMotherboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMotherboard.Location = new System.Drawing.Point(20, 90);
            this.lblMotherboard.Name = "lblMotherboard";
            this.lblMotherboard.Text = "Мат. плата:";
            this.cmbMotherboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMotherboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotherboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbMotherboard.FormattingEnabled = true;
            this.cmbMotherboard.Location = new System.Drawing.Point(200, 87);
            this.cmbMotherboard.Name = "cmbMotherboard";
            this.cmbMotherboard.Size = new System.Drawing.Size(580, 23);

            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblRAM.Location = new System.Drawing.Point(20, 125);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Text = "Оперативная память:";
            this.cmbRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Location = new System.Drawing.Point(200, 122);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(580, 23);

            this.lblStorage.AutoSize = true;
            this.lblStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStorage.Location = new System.Drawing.Point(20, 160);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Text = "Накопитель:";
            this.cmbStorage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbStorage.FormattingEnabled = true;
            this.cmbStorage.Location = new System.Drawing.Point(200, 157);
            this.cmbStorage.Name = "cmbStorage";
            this.cmbStorage.Size = new System.Drawing.Size(580, 23);

            this.lblPSU.AutoSize = true;
            this.lblPSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPSU.Location = new System.Drawing.Point(20, 195);
            this.lblPSU.Name = "lblPSU";
            this.lblPSU.Text = "Блок питания:";
            this.cmbPSU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPSU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbPSU.FormattingEnabled = true;
            this.cmbPSU.Location = new System.Drawing.Point(200, 192);
            this.cmbPSU.Name = "cmbPSU";
            this.cmbPSU.Size = new System.Drawing.Size(580, 23);

            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCase.Location = new System.Drawing.Point(20, 230);
            this.lblCase.Name = "lblCase";
            this.lblCase.Text = "Корпус:";
            this.cmbCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCase.FormattingEnabled = true;
            this.cmbCase.Location = new System.Drawing.Point(200, 227);
            this.cmbCase.Name = "cmbCase";
            this.cmbCase.Size = new System.Drawing.Size(580, 23);

            // lblTotalPrice, lblTotalPriceValue, кнопки
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.Location = new System.Drawing.Point(20, 15);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Text = "Итоговая цена:";

            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblTotalPriceValue.Location = new System.Drawing.Point(170, 13);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Text = "0 ₽";

            this.btnCheckCompatibility.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnCheckCompatibility.FlatAppearance.BorderSize = 0;
            this.btnCheckCompatibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCompatibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckCompatibility.ForeColor = System.Drawing.Color.White;
            this.btnCheckCompatibility.Location = new System.Drawing.Point(350, 10);
            this.btnCheckCompatibility.Name = "btnCheckCompatibility";
            this.btnCheckCompatibility.Size = new System.Drawing.Size(180, 35);
            this.btnCheckCompatibility.TabIndex = 2;
            this.btnCheckCompatibility.Text = "✓ Проверить";
            this.btnCheckCompatibility.UseVisualStyleBackColor = false;
            this.btnCheckCompatibility.Click += new System.EventHandler(this.btnCheckCompatibility_Click);

            this.btnSaveBuild.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.btnSaveBuild.FlatAppearance.BorderSize = 0;
            this.btnSaveBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveBuild.ForeColor = System.Drawing.Color.White;
            this.btnSaveBuild.Location = new System.Drawing.Point(540, 10);
            this.btnSaveBuild.Name = "btnSaveBuild";
            this.btnSaveBuild.Size = new System.Drawing.Size(180, 35);
            this.btnSaveBuild.TabIndex = 3;
            this.btnSaveBuild.Text = "💾 Сохранить";
            this.btnSaveBuild.UseVisualStyleBackColor = false;
            this.btnSaveBuild.Click += new System.EventHandler(this.btnSaveBuild_Click);

            this.lblCompatibilityStatus.AutoSize = true;
            this.lblCompatibilityStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCompatibilityStatus.Location = new System.Drawing.Point(20, 45);
            this.lblCompatibilityStatus.Name = "lblCompatibilityStatus";

            // === ЭЛЕМЕНТЫ ВКЛАДКИ "АНАЛИЗ" ===

            this.lblStatsTitle.AutoSize = true;
            this.lblStatsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Text = "📊 Анализ данных о комплектующих";

            this.btnRefreshStats.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefreshStats.FlatAppearance.BorderSize = 0;
            this.btnRefreshStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefreshStats.ForeColor = System.Drawing.Color.White;
            this.btnRefreshStats.Location = new System.Drawing.Point(650, 10);
            this.btnRefreshStats.Name = "btnRefreshStats";
            this.btnRefreshStats.Size = new System.Drawing.Size(150, 30);
            this.btnRefreshStats.TabIndex = 4;
            this.btnRefreshStats.Text = "🔄 Обновить";
            this.btnRefreshStats.UseVisualStyleBackColor = false;
            this.btnRefreshStats.Click += new System.EventHandler(this.btnRefreshStats_Click);

            // Группа статистики
            this.grpStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStats.Controls.Add(this.lblAvgCase);
            this.grpStats.Controls.Add(this.lblAvgPSU);
            this.grpStats.Controls.Add(this.lblAvgStorage);
            this.grpStats.Controls.Add(this.lblAvgRAM);
            this.grpStats.Controls.Add(this.lblAvgMB);
            this.grpStats.Controls.Add(this.lblAvgGPU);
            this.grpStats.Controls.Add(this.lblAvgCPU);
            this.grpStats.Controls.Add(this.lblTotalItems);
            this.grpStats.Controls.Add(this.lblMaxPrice);
            this.grpStats.Controls.Add(this.lblMinPrice);
            this.grpStats.Controls.Add(this.lblAvgPrice);
            this.grpStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpStats.Location = new System.Drawing.Point(10, 50);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(802, 130);
            this.grpStats.TabIndex = 0;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "  Общая статистика";

            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAvgPrice.Location = new System.Drawing.Point(10, 25);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Text = "Средняя цена по всем компонентам: —";

            this.lblMinPrice.AutoSize = true;
            this.lblMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMinPrice.ForeColor = System.Drawing.Color.Green;
            this.lblMinPrice.Location = new System.Drawing.Point(10, 45);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Text = "Минимальная цена: —";

            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMaxPrice.ForeColor = System.Drawing.Color.Red;
            this.lblMaxPrice.Location = new System.Drawing.Point(10, 65);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Text = "Максимальная цена: —";

            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalItems.Location = new System.Drawing.Point(10, 85);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Text = "Всего компонентов в каталоге: —";

            this.lblAvgCPU.AutoSize = true;
            this.lblAvgCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAvgCPU.Location = new System.Drawing.Point(400, 25);
            this.lblAvgCPU.Name = "lblAvgCPU";
            this.lblAvgCPU.Text = "CPU (средняя): —";

            this.lblAvgGPU.AutoSize = true;
            this.lblAvgGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAvgGPU.Location = new System.Drawing.Point(400, 45);
            this.lblAvgGPU.Name = "lblAvgGPU";
            this.lblAvgGPU.Text = "GPU (средняя): —";

            this.lblAvgMB.AutoSize = true;
            this.lblAvgMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAvgMB.Location = new System.Drawing.Point(400, 65);
            this.lblAvgMB.Name = "lblAvgMB";
            this.lblAvgMB.Text = "Мат. платы (средняя): —";

            this.lblAvgRAM.AutoSize = true;
            this.lblAvgRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAvgRAM.Location = new System.Drawing.Point(400, 85);
            this.lblAvgRAM.Name = "lblAvgRAM";
            this.lblAvgRAM.Text = "RAM (средняя): —";

            this.lblAvgStorage.AutoSize = true;
            this.lblAvgStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAvgStorage.Location = new System.Drawing.Point(400, 105);
            this.lblAvgStorage.Name = "lblAvgStorage";
            this.lblAvgStorage.Text = "Накопители (средняя): —";

            this.lblAvgPSU.AutoSize = true;
            this.lblAvgPSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAvgPSU.Location = new System.Drawing.Point(10, 105);
            this.lblAvgPSU.Name = "lblAvgPSU";
            this.lblAvgPSU.Text = "Блоки питания (средняя): —";

            this.lblAvgCase.AutoSize = true;
            this.lblAvgCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAvgCase.Location = new System.Drawing.Point(220, 105);
            this.lblAvgCase.Name = "lblAvgCase";
            this.lblAvgCase.Text = "Корпуса (средняя): —";

            // График цен по категориям
            this.chartPriceByCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPriceByCategory.Location = new System.Drawing.Point(10, 190);
            this.chartPriceByCategory.Name = "chartPriceByCategory";
            this.chartPriceByCategory.Size = new System.Drawing.Size(395, 250);
            this.chartPriceByCategory.TabIndex = 1;
            this.chartPriceByCategory.Text = "Средняя цена по категориям";

            // График распределения
            this.chartDistribution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right))));
            this.chartDistribution.Location = new System.Drawing.Point(415, 190);
            this.chartDistribution.Name = "chartDistribution";
            this.chartDistribution.Size = new System.Drawing.Size(397, 250);
            this.chartDistribution.TabIndex = 2;
            this.chartDistribution.Text = "Количество компонентов по категориям";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Builder - Конфигуратор ПК";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCatalog.ResumeLayout(false);
            this.tabPageCatalog.PerformLayout();
            this.tabPageBuild.ResumeLayout(false);
            this.tabPageAnalysis.ResumeLayout(false);
            this.tabPageAnalysis.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPriceByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCatalog;
        private System.Windows.Forms.TabPage tabPageBuild;
        private System.Windows.Forms.TabPage tabPageAnalysis;
        private System.Windows.Forms.ComboBox cmbComponentType;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelBuild;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ComboBox cmbCPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.ComboBox cmbGPU;
        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.ComboBox cmbMotherboard;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.ComboBox cmbRAM;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.ComboBox cmbStorage;
        private System.Windows.Forms.Label lblPSU;
        private System.Windows.Forms.ComboBox cmbPSU;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.ComboBox cmbCase;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Button btnCheckCompatibility;
        private System.Windows.Forms.Button btnSaveBuild;
        private System.Windows.Forms.Label lblCompatibilityStatus;

        // Поиск и фильтрация
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnResetFilter;

        // Анализ
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPriceByCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistribution;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblAvgCPU;
        private System.Windows.Forms.Label lblAvgGPU;
        private System.Windows.Forms.Label lblAvgMB;
        private System.Windows.Forms.Label lblAvgRAM;
        private System.Windows.Forms.Label lblAvgStorage;
        private System.Windows.Forms.Label lblAvgPSU;
        private System.Windows.Forms.Label lblAvgCase;
        private System.Windows.Forms.Button btnRefreshStats;
    }
}