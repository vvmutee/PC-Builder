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
            this.tabControl1.SuspendLayout();
            this.tabPageCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCatalog);
            this.tabControl1.Controls.Add(this.tabPageBuild);
            this.tabControl1.Controls.Add(this.tabPageAnalysis);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCatalog
            // 
            this.tabPageCatalog.Controls.Add(this.dgvCatalog);
            this.tabPageCatalog.Controls.Add(this.btnLoad);
            this.tabPageCatalog.Controls.Add(this.cmbComponentType);
            this.tabPageCatalog.Location = new System.Drawing.Point(4, 22);
            this.tabPageCatalog.Name = "tabPageCatalog";
            this.tabPageCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCatalog.Size = new System.Drawing.Size(752, 354);
            this.tabPageCatalog.TabIndex = 0;
            this.tabPageCatalog.Text = "Каталог";
            this.tabPageCatalog.UseVisualStyleBackColor = true;
            // 
            // tabPageBuild
            // 
            this.tabPageBuild.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuild.Name = "tabPageBuild";
            this.tabPageBuild.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuild.Size = new System.Drawing.Size(752, 354);
            this.tabPageBuild.TabIndex = 1;
            this.tabPageBuild.Text = "Сборка ПК";
            this.tabPageBuild.UseVisualStyleBackColor = true;
            // 
            // tabPageAnalysis
            // 
            this.tabPageAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnalysis.Size = new System.Drawing.Size(752, 354);
            this.tabPageAnalysis.TabIndex = 2;
            this.tabPageAnalysis.Text = "Анализ";
            this.tabPageAnalysis.UseVisualStyleBackColor = true;
            // 
            // cmbComponentType
            // 
            this.cmbComponentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponentType.FormattingEnabled = true;
            this.cmbComponentType.Location = new System.Drawing.Point(6, 6);
            this.cmbComponentType.Name = "cmbComponentType";
            this.cmbComponentType.Size = new System.Drawing.Size(200, 21);
            this.cmbComponentType.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(212, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Location = new System.Drawing.Point(6, 33);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.Size = new System.Drawing.Size(740, 315);
            this.dgvCatalog.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PC Builder - Конфигуратор ПК";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCatalog.ResumeLayout(false);
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
    }
}