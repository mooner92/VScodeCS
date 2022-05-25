using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _37_graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Graph using Chart Control";
            /*
            chart1.Series.Add("Cos");
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Color = Color.Orange;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[1].LegendText = "cos(x)/x";

            chart1.Series.Add("tan");
            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[2].Color = Color.HotPink;
            chart1.Series[2].BorderWidth = 2;
            chart1.Series[2].LegendText = "tan(x)/x";
            */
        }
        //어떤 이벤트가 생기면 거기에 대응하여(on족 함수) 이벤트처리함수 ex:)창에 변화가있을 때
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            chart1.ChartAreas[0].BackColor = Color.Black;
            //x,y축 설정
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 20;
            chart1.ChartAreas[0].AxisX.Interval = 1;//그리드간격은 2
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas[0].AxisY.Minimum = -0.4;
            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisY.Interval = 0.2;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            //series 설정
            

            if(chart1.Series.Count == 1)
            {
                chart1.Series[0]/*series["series1"]*/.ChartType = SeriesChartType.BoxPlot;
                chart1.Series[0].Color = Color.HotPink;
                chart1.Series[0].BorderWidth = 2;
                chart1.Series[0].LegendText = "sin(x)/x";
                /*
                chart1.Series.Add("Cos");
                chart1.Series[1].ChartType = SeriesChartType.Line;
                chart1.Series[1].Color = Color.Orange;
                chart1.Series[1].BorderWidth = 2;
                chart1.Series[1].LegendText = "cos(x)/x";
                
                chart1.Series.Add("tan");
                chart1.Series[2].ChartType = SeriesChartType.Line;
                chart1.Series[2].Color = Color.HotPink;
                chart1.Series[2].BorderWidth = 2;
                chart1.Series[2].LegendText = "tan(x)/x";
                */


            }
            

            //data insert to series
            for (double x = -20; x < 20; x += 0.1)
            {

                double y = Math.Sin(x) / x;
                chart1.Series[0].Points.AddXY(x, y);
                /*
                y = Math.Cos(x) / x;
                chart1.Series[1].Points.AddXY(x, y);
                y = Math.Tan(x) / x;
                chart1.Series[2].Points.AddXY(x, y);
                */

                
            }

        }
    }
}
