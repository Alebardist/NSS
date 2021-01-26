using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

using NSS_lib;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }

        private void RunButton_Click_1(object sender, EventArgs e)
        {
            Launcher launcher = new Launcher(Int32.Parse(textBoxStartPopulation.Text), Int32.Parse(maskedTextBoxStarttempResist.Text));

            chartPopulation.Series[0].Points.Clear();
            chartTemperature.Series[0].Points.Clear();
            chartSpeed.Series[0].Points.Clear();


            launcher.Main();

            // fill-in charts
            ChartAddPoints(chartTemperature, launcher.statisticCollector.Temperature);
            ChartAddPoints(chartPopulation, launcher.statisticCollector.PopulationList);
            ChartAddPoints(chartSpeed, launcher.statisticCollector.Speed);

            labelMaxPopulation.Text = $"Max population: {launcher.statisticCollector.MaxPopulation}";
            labelTempMaxResist.Text = $"Max temp resist { launcher.organism.MaxTempResist }";
            labelTempMinResist.Text = $"Min temp resist { launcher.organism.MinTempResist }";
            labelDaysPassed.Text = $"Days passed: { launcher.statisticCollector.DaysPassed }";
            labelEated.Text = $"Eated: { launcher.statisticCollector.EatedByPredators }";
            labelRadiation.Text = $"Radiation: { launcher.statisticCollector.Radiation }";

        }
        private void ChartAddPoints(Chart chartName, List<decimal> YlineDataList)
        {
            int Xdays = 1;
            foreach (decimal Yline in YlineDataList)
            {
                chartName.Series[0].Points.AddXY(Xdays, Yline);
                Xdays++;
            }
        }

    }
}
