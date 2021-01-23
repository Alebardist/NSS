namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.StatisticGroupBox = new System.Windows.Forms.GroupBox();
            this.labelEated = new System.Windows.Forms.Label();
            this.labelDaysPassed = new System.Windows.Forms.Label();
            this.labelTempMinResist = new System.Windows.Forms.Label();
            this.labelTempMaxResist = new System.Windows.Forms.Label();
            this.labelMaxPopulation = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.ValuesSetupGroupBox = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxStarttempResist = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStartPopulation = new System.Windows.Forms.MaskedTextBox();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPopulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelRadiation = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.StatisticGroupBox.SuspendLayout();
            this.ValuesSetupGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopulation)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 535);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StatisticGroupBox);
            this.tabPage1.Controls.Add(this.RunButton);
            this.tabPage1.Controls.Add(this.ValuesSetupGroupBox);
            this.tabPage1.Controls.Add(this.chartTemperature);
            this.tabPage1.Controls.Add(this.chartPopulation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // StatisticGroupBox
            // 
            this.StatisticGroupBox.Controls.Add(this.labelRadiation);
            this.StatisticGroupBox.Controls.Add(this.labelEated);
            this.StatisticGroupBox.Controls.Add(this.labelDaysPassed);
            this.StatisticGroupBox.Controls.Add(this.labelTempMinResist);
            this.StatisticGroupBox.Controls.Add(this.labelTempMaxResist);
            this.StatisticGroupBox.Controls.Add(this.labelMaxPopulation);
            this.StatisticGroupBox.Location = new System.Drawing.Point(561, 373);
            this.StatisticGroupBox.Name = "StatisticGroupBox";
            this.StatisticGroupBox.Size = new System.Drawing.Size(207, 130);
            this.StatisticGroupBox.TabIndex = 10;
            this.StatisticGroupBox.TabStop = false;
            this.StatisticGroupBox.Text = "Statistic info";
            // 
            // labelEated
            // 
            this.labelEated.AutoSize = true;
            this.labelEated.Location = new System.Drawing.Point(6, 95);
            this.labelEated.Name = "labelEated";
            this.labelEated.Size = new System.Drawing.Size(38, 13);
            this.labelEated.TabIndex = 7;
            this.labelEated.Text = "Eated:";
            // 
            // labelDaysPassed
            // 
            this.labelDaysPassed.AutoSize = true;
            this.labelDaysPassed.Location = new System.Drawing.Point(6, 16);
            this.labelDaysPassed.Name = "labelDaysPassed";
            this.labelDaysPassed.Size = new System.Drawing.Size(71, 13);
            this.labelDaysPassed.TabIndex = 6;
            this.labelDaysPassed.Text = "Days passed:";
            // 
            // labelTempMinResist
            // 
            this.labelTempMinResist.AutoSize = true;
            this.labelTempMinResist.Location = new System.Drawing.Point(6, 77);
            this.labelTempMinResist.Name = "labelTempMinResist";
            this.labelTempMinResist.Size = new System.Drawing.Size(83, 13);
            this.labelTempMinResist.TabIndex = 5;
            this.labelTempMinResist.Text = "Min temp resist -";
            // 
            // labelTempMaxResist
            // 
            this.labelTempMaxResist.AutoSize = true;
            this.labelTempMaxResist.Location = new System.Drawing.Point(6, 64);
            this.labelTempMaxResist.Name = "labelTempMaxResist";
            this.labelTempMaxResist.Size = new System.Drawing.Size(89, 13);
            this.labelTempMaxResist.TabIndex = 4;
            this.labelTempMaxResist.Text = "Max temp resist +";
            // 
            // labelMaxPopulation
            // 
            this.labelMaxPopulation.AutoSize = true;
            this.labelMaxPopulation.Location = new System.Drawing.Point(7, 51);
            this.labelMaxPopulation.Name = "labelMaxPopulation";
            this.labelMaxPopulation.Size = new System.Drawing.Size(82, 13);
            this.labelMaxPopulation.TabIndex = 3;
            this.labelMaxPopulation.Text = "Max population:";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(343, 437);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(120, 44);
            this.RunButton.TabIndex = 7;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click_1);
            // 
            // ValuesSetupGroupBox
            // 
            this.ValuesSetupGroupBox.Controls.Add(this.maskedTextBoxStarttempResist);
            this.ValuesSetupGroupBox.Controls.Add(this.label2);
            this.ValuesSetupGroupBox.Controls.Add(this.label1);
            this.ValuesSetupGroupBox.Controls.Add(this.textBoxStartPopulation);
            this.ValuesSetupGroupBox.Location = new System.Drawing.Point(3, 382);
            this.ValuesSetupGroupBox.Name = "ValuesSetupGroupBox";
            this.ValuesSetupGroupBox.Size = new System.Drawing.Size(229, 118);
            this.ValuesSetupGroupBox.TabIndex = 9;
            this.ValuesSetupGroupBox.TabStop = false;
            this.ValuesSetupGroupBox.Text = "Values setup";
            // 
            // maskedTextBoxStarttempResist
            // 
            this.maskedTextBoxStarttempResist.Location = new System.Drawing.Point(123, 42);
            this.maskedTextBoxStarttempResist.Mask = "0000";
            this.maskedTextBoxStarttempResist.Name = "maskedTextBoxStarttempResist";
            this.maskedTextBoxStarttempResist.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStarttempResist.TabIndex = 4;
            this.maskedTextBoxStarttempResist.Text = "10";
            this.maskedTextBoxStarttempResist.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start temperature resist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start population";
            // 
            // textBoxStartPopulation
            // 
            this.textBoxStartPopulation.Location = new System.Drawing.Point(123, 19);
            this.textBoxStartPopulation.Mask = "0000";
            this.textBoxStartPopulation.Name = "textBoxStartPopulation";
            this.textBoxStartPopulation.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartPopulation.TabIndex = 1;
            this.textBoxStartPopulation.Text = "20";
            this.textBoxStartPopulation.ValidatingType = typeof(int);
            // 
            // chartTemperature
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend4);
            this.chartTemperature.Location = new System.Drawing.Point(0, 173);
            this.chartTemperature.Name = "chartTemperature";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTemperature.Series.Add(series4);
            this.chartTemperature.Size = new System.Drawing.Size(768, 194);
            this.chartTemperature.TabIndex = 8;
            this.chartTemperature.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "Temperature";
            this.chartTemperature.Titles.Add(title4);
            // 
            // chartPopulation
            // 
            chartArea5.Name = "ChartArea1";
            this.chartPopulation.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartPopulation.Legends.Add(legend5);
            this.chartPopulation.Location = new System.Drawing.Point(0, 0);
            this.chartPopulation.Name = "chartPopulation";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.chartPopulation.Series.Add(series5);
            this.chartPopulation.Size = new System.Drawing.Size(768, 180);
            this.chartPopulation.TabIndex = 6;
            this.chartPopulation.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title5.Name = "Title1";
            title5.Text = "Population";
            this.chartPopulation.Titles.Add(title5);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartSpeed);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Графики 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartSpeed
            // 
            chartArea6.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend6);
            this.chartSpeed.Location = new System.Drawing.Point(8, 6);
            this.chartSpeed.Name = "chartSpeed";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.YValuesPerPoint = 2;
            this.chartSpeed.Series.Add(series6);
            this.chartSpeed.Size = new System.Drawing.Size(776, 180);
            this.chartSpeed.TabIndex = 7;
            this.chartSpeed.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title6.Name = "Title1";
            title6.Text = "Speed";
            this.chartSpeed.Titles.Add(title6);
            // 
            // labelRadiation
            // 
            this.labelRadiation.AutoSize = true;
            this.labelRadiation.Location = new System.Drawing.Point(6, 108);
            this.labelRadiation.Name = "labelRadiation";
            this.labelRadiation.Size = new System.Drawing.Size(58, 13);
            this.labelRadiation.TabIndex = 8;
            this.labelRadiation.Text = "Radiation: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "NSS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.StatisticGroupBox.ResumeLayout(false);
            this.StatisticGroupBox.PerformLayout();
            this.ValuesSetupGroupBox.ResumeLayout(false);
            this.ValuesSetupGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopulation)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox StatisticGroupBox;
        private System.Windows.Forms.Label labelMaxPopulation;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.GroupBox ValuesSetupGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxStartPopulation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopulation;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelTempMinResist;
        private System.Windows.Forms.Label labelTempMaxResist;
        private System.Windows.Forms.Label labelDaysPassed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
        private System.Windows.Forms.Label labelEated;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStarttempResist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRadiation;
    }
}

