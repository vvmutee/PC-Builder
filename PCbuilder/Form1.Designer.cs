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

            // Элементы для вкладки "Сборка ПК"
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

            this.tabControl1.SuspendLayout();
            this.tabPageCatalog.SuspendLayout();
            this.tabPageBuild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl1
            // 
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

            // 
            // tabPageCatalog
            // 
            this.tabPageCatalog.Controls.Add(this.dgvCatalog);
            this.tabPageCatalog.Controls.Add(this.btnLoad);
            this.tabPageCatalog.Controls.Add(this.cmbComponentType);
            this.tabPageCatalog.Location = new System.Drawing.Point(4, 22);
            this.tabPageCatalog.Name = "tabPageCatalog";
            this.tabPageCatalog.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageCatalog.Size = new System.Drawing.Size(822, 454);
            this.tabPageCatalog.TabIndex = 0;
            this.tabPageCatalog.Text = " Каталог";
            this.tabPageCatalog.UseVisualStyleBackColor = true;

            // 
            // tabPageBuild
            // 
            this.tabPageBuild.Controls.Add(this.panelPrice);
            this.tabPageBuild.Controls.Add(this.panelBuild);
            this.tabPageBuild.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuild.Name = "tabPageBuild";
            this.tabPageBuild.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageBuild.Size = new System.Drawing.Size(822, 454);
            this.tabPageBuild.TabIndex = 1;
            this.tabPageBuild.Text = " Сборка ПК";
            this.tabPageBuild.UseVisualStyleBackColor = true;

            // 
            // tabPageAnalysis
            // 
            this.tabPageAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageAnalysis.Size = new System.Drawing.Size(822, 454);
            this.tabPageAnalysis.TabIndex = 2;
            this.tabPageAnalysis.Text = " Анализ";
            this.tabPageAnalysis.UseVisualStyleBackColor = true;

            // 
            // cmbComponentType
            // 
            this.cmbComponentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbComponentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbComponentType.FormattingEnabled = true;
            this.cmbComponentType.Location = new System.Drawing.Point(10, 10);
            this.cmbComponentType.Name = "cmbComponentType";
            this.cmbComponentType.Size = new System.Drawing.Size(250, 24);
            this.cmbComponentType.TabIndex = 0;

            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(270, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 30);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // 
            // dgvCatalog
            // 
            this.dgvCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Location = new System.Drawing.Point(10, 45);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.Size = new System.Drawing.Size(802, 400);
            this.dgvCatalog.TabIndex = 2;
            this.dgvCatalog.EnableHeadersVisualStyles = false;
            this.dgvCatalog.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.dgvCatalog.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCatalog.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCatalog.RowHeadersVisible = false;
            this.dgvCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";

            // 
            // panelBuild
            // 
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
            this.panelBuild.TabIndex = 0;

            // 
            // panelPrice
            // 
            this.panelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelPrice.Controls.Add(this.lblCompatibilityStatus);
            this.panelPrice.Controls.Add(this.btnSaveBuild);
            this.panelPrice.Controls.Add(this.btnCheckCompatibility);
            this.panelPrice.Controls.Add(this.lblTotalPriceValue);
            this.panelPrice.Controls.Add(this.lblTotalPrice);
            this.panelPrice.Location = new System.Drawing.Point(10, 380);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(802, 65);
            this.panelPrice.TabIndex = 1;

            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCPU.Location = new System.Drawing.Point(20, 20);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(90, 17);
            this.lblCPU.TabIndex = 0;
            this.lblCPU.Text = "Процессор:";

            // 
            // cmbCPU
            // 
            this.cmbCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCPU.FormattingEnabled = true;
            this.cmbCPU.Location = new System.Drawing.Point(200, 17);
            this.cmbCPU.Name = "cmbCPU";
            this.cmbCPU.Size = new System.Drawing.Size(580, 23);
            this.cmbCPU.TabIndex = 1;

            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblGPU.Location = new System.Drawing.Point(20, 55);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(95, 17);
            this.lblGPU.TabIndex = 2;
            this.lblGPU.Text = "Видеокарта:";

            // 
            // cmbGPU
            // 
            this.cmbGPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbGPU.FormattingEnabled = true;
            this.cmbGPU.Location = new System.Drawing.Point(200, 52);
            this.cmbGPU.Name = "cmbGPU";
            this.cmbGPU.Size = new System.Drawing.Size(580, 23);
            this.cmbGPU.TabIndex = 3;

            // 
            // lblMotherboard
            // 
            this.lblMotherboard.AutoSize = true;
            this.lblMotherboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMotherboard.Location = new System.Drawing.Point(20, 90);
            this.lblMotherboard.Name = "lblMotherboard";
            this.lblMotherboard.Size = new System.Drawing.Size(100, 17);
            this.lblMotherboard.TabIndex = 4;
            this.lblMotherboard.Text = "Мат. плата:";

            // 
            // cmbMotherboard
            // 
            this.cmbMotherboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMotherboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotherboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbMotherboard.FormattingEnabled = true;
            this.cmbMotherboard.Location = new System.Drawing.Point(200, 87);
            this.cmbMotherboard.Name = "cmbMotherboard";
            this.cmbMotherboard.Size = new System.Drawing.Size(580, 23);
            this.cmbMotherboard.TabIndex = 5;

            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblRAM.Location = new System.Drawing.Point(20, 125);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(160, 17);
            this.lblRAM.TabIndex = 6;
            this.lblRAM.Text = "Оперативная память:";

            // 
            // cmbRAM
            // 
            this.cmbRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Location = new System.Drawing.Point(200, 122);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(580, 23);
            this.cmbRAM.TabIndex = 7;

            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStorage.Location = new System.Drawing.Point(20, 160);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(95, 17);
            this.lblStorage.TabIndex = 8;
            this.lblStorage.Text = "Накопитель:";

            // 
            // cmbStorage
            // 
            this.cmbStorage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbStorage.FormattingEnabled = true;
            this.cmbStorage.Location = new System.Drawing.Point(200, 157);
            this.cmbStorage.Name = "cmbStorage";
            this.cmbStorage.Size = new System.Drawing.Size(580, 23);
            this.cmbStorage.TabIndex = 9;

            // 
            // lblPSU
            // 
            this.lblPSU.AutoSize = true;
            this.lblPSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPSU.Location = new System.Drawing.Point(20, 195);
            this.lblPSU.Name = "lblPSU";
            this.lblPSU.Size = new System.Drawing.Size(115, 17);
            this.lblPSU.TabIndex = 10;
            this.lblPSU.Text = "Блок питания:";

            // 
            // cmbPSU
            // 
            this.cmbPSU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPSU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbPSU.FormattingEnabled = true;
            this.cmbPSU.Location = new System.Drawing.Point(200, 192);
            this.cmbPSU.Name = "cmbPSU";
            this.cmbPSU.Size = new System.Drawing.Size(580, 23);
            this.cmbPSU.TabIndex = 11;

            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCase.Location = new System.Drawing.Point(20, 230);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(60, 17);
            this.lblCase.TabIndex = 12;
            this.lblCase.Text = "Корпус:";

            // 
            // cmbCase
            // 
            this.cmbCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCase.FormattingEnabled = true;
            this.cmbCase.Location = new System.Drawing.Point(200, 227);
            this.cmbCase.Name = "cmbCase";
            this.cmbCase.Size = new System.Drawing.Size(580, 23);
            this.cmbCase.TabIndex = 13;

            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.Location = new System.Drawing.Point(20, 15);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(140, 20);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Итоговая цена:";

            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(170, 13);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(45, 24);
            this.lblTotalPriceValue.TabIndex = 1;
            this.lblTotalPriceValue.Text = "0 ₽";

            // 
            // btnCheckCompatibility
            // 
            this.btnCheckCompatibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
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

            // 
            // btnSaveBuild
            // 
            this.btnSaveBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
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

            // 
            // lblCompatibilityStatus
            // 
            this.lblCompatibilityStatus.AutoSize = true;
            this.lblCompatibilityStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCompatibilityStatus.Location = new System.Drawing.Point(20, 45);
            this.lblCompatibilityStatus.Name = "lblCompatibilityStatus";
            this.lblCompatibilityStatus.Size = new System.Drawing.Size(0, 15);
            this.lblCompatibilityStatus.TabIndex = 4;

            // 
            // Form1
            // 
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
            this.tabPageBuild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
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
    }
}