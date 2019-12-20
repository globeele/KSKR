using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_rab_1
{
    public partial class FormResults : Form
    {
        private int countTime;
        private int countLength;
        private double dx;
        private double[,] matrix;
        private int size;

        public FormResults(int countTime, int countLength, double dx, double[,] temp)
        {
            this.countTime = countTime;
            this.countLength = countLength;
            this.dx = dx;
            InitializeComponent();
            Draw(temp);
        }

        public FormResults(int countTime, int countLength, double dx, double[,] matrix, int size)
        {
            this.countTime = countTime;
            this.countLength = countLength;
            this.dx = dx;
            this.matrix = matrix;
            this.size = size;
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            chart.ResetAutoValues();
            chart.Series.Clear();

            for (int i = 0; i < countTime; i++)
                for (int j = 0; j < countLength; j++)
                {
                    Series ser = new Series();

                    chart.Palette = ChartColorPalette.EarthTones;
                    ser.ChartType = SeriesChartType.Line;
                    ser.Points.Clear();
                    ser.IsVisibleInLegend = false;
                    chart.Series.Add(ser);

                    chart.Series[i].Points.AddXY(j * dx, matrix[i * countLength + j, size]);
                }
        }

        private void Draw(double[,] matrixTemp)
        {
            chart.ResetAutoValues();
            chart.Series.Clear();

            for (int i = 0; i < countLength; i++)
                for (int j = 0; j < countLength; j++)
                {
                    Series ser = new Series();

                    chart.Palette = ChartColorPalette.EarthTones;
                    ser.ChartType = SeriesChartType.Line;
                    ser.Points.Clear();
                    ser.IsVisibleInLegend = false;
                    chart.Series.Add(ser);

                    chart.Series[i].Points.AddXY(j * dx, matrixTemp[i, j]);
                }
        }
    }
}
