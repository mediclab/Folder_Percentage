namespace FolderPercentage
{
    partial class FolderPercentage
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderPercentage));
            this.Tchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Folder = new System.Windows.Forms.Label();
            this.TworkBack = new System.ComponentModel.BackgroundWorker();
            this.Done = new System.Windows.Forms.Label();
            this.TselectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.Tanalyze = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tchart)).BeginInit();
            this.SuspendLayout();
            // 
            // Tchart
            // 
            chartArea1.Name = "ChartArea1";
            this.Tchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Tchart.Legends.Add(legend1);
            this.Tchart.Location = new System.Drawing.Point(0, 0);
            this.Tchart.Name = "Tchart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Folders";
            this.Tchart.Series.Add(series1);
            this.Tchart.Size = new System.Drawing.Size(570, 406);
            this.Tchart.TabIndex = 0;
            this.Tchart.Text = "chart1";
            // 
            // Folder
            // 
            this.Folder.BackColor = System.Drawing.Color.White;
            this.Folder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Folder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Folder.Location = new System.Drawing.Point(404, 409);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(152, 23);
            this.Folder.TabIndex = 1;
            this.Folder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TworkBack
            // 
            this.TworkBack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Work_DoWork);
            // 
            // Done
            // 
            this.Done.AutoSize = true;
            this.Done.BackColor = System.Drawing.Color.White;
            this.Done.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Done.Location = new System.Drawing.Point(12, 414);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(0, 13);
            this.Done.TabIndex = 2;
            this.Done.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TselectFolder
            // 
            this.TselectFolder.Description = "Выберите папку:";
            this.TselectFolder.ShowNewFolderButton = false;
            // 
            // Tanalyze
            // 
            this.Tanalyze.AutoSize = true;
            this.Tanalyze.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tanalyze.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tanalyze.Location = new System.Drawing.Point(107, 414);
            this.Tanalyze.Name = "Tanalyze";
            this.Tanalyze.Size = new System.Drawing.Size(86, 13);
            this.Tanalyze.TabIndex = 3;
            this.Tanalyze.Text = "Анализ папки:";
            // 
            // FolderPercentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 432);
            this.Controls.Add(this.Tanalyze);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.Tchart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FolderPercentage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Размер папки: ";
            this.Load += new System.EventHandler(this.FolderPercentage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Tchart;
        private System.Windows.Forms.Label Folder;
        private System.ComponentModel.BackgroundWorker TworkBack;
        private System.Windows.Forms.Label Done;
        private System.Windows.Forms.FolderBrowserDialog TselectFolder;
        private System.Windows.Forms.Label Tanalyze;
    }
}

