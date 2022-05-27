using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _038_EcgPpg
{
    public partial class Form1 : Form
    {
        private double[] ecg = new double[100000];
        private double[] ppg = new double[100000];
        private int ecgCount; //ecg데이터 개수를 의미
        private int ppgCount; //ppg데이터 개수를 의미
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.Text = "ECG/PPG";
            this.WindowState = FormWindowState.Maximized;

            EcgRead();
            PpgRead();
            ChartSetting();
            t.Interval = 10; // 0.01초
            t.Tick += T_Tick;
        }
        int cursorX = 0;  //display되는 데이터의 시작점
        bool scrolling = false;  //true일 때 스크롤

        private void T_Tick(object sender, EventArgs e)
        {
            //한 화면에 500개의 데이터를 보여줄 예정
            if (cursorX + 500 < ecgCount)
                ch.ChartAreas[0].AxisX.ScaleView.Zoom(cursorX, cursorX + 500);
            else
                t.Stop();
            cursorX += 2;
        }

        private void ChartSetting()
        {
            ch.ChartAreas[0].CursorX.IsUserEnabled = true;  //커서 사용 가능  -- 그래프에서 어떤 점 지정해서 사용 가능
            ch.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;  //zoom 범위 선택 가능

            // chart 영역
            ch.ChartAreas[0].BackColor = Color.Black;
            ch.ChartAreas[0].AxisX.Minimum = 0;
            ch.ChartAreas[0].AxisX.Maximum = ecgCount;
            ch.ChartAreas[0].AxisX.Interval = 50; //50개 간격으로 표시
            ch.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            ch.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ch.ChartAreas[0].AxisY.Minimum = -2;
            ch.ChartAreas[0].AxisY.Maximum = 6;
            ch.ChartAreas[0].AxisY.Interval = 0.5; //0.5개 간격으로 표시
            ch.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            ch.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            //series 2개 새로 만들기
            ch.Series.Clear();
            ch.Series.Add("ECG");
            ch.Series.Add("PPG");  //기존거 없애고 새로 두개 만듦

            ch.Series["ECG"].ChartType = SeriesChartType.Line;
            ch.Series["ECG"].Color = Color.Orange;
            ch.Series["ECG"].BorderWidth = 2;
            ch.Series["ECG"].LegendText = "ECG";


            ch.Series["PPG"].ChartType = SeriesChartType.Line;
            ch.Series["PPG"].Color = Color.LightGreen;
            ch.Series["PPG"].BorderWidth = 2;
            ch.Series["PPG"].LegendText = "PPG";

            

            //data를 series에 추가
            foreach(var v in ecg)
            {
                ch.Series["ECG"].Points.Add(v+3);
            }
            foreach (var v in ppg)
            {
                ch.Series["PPG"].Points.Add(v);
            }
            

        }

        private void PpgRead()
        {
            string fileName = "../../Data/PPG.txt";
            string[] lines = File.ReadAllLines(fileName);
            double min = double.MaxValue;
            double max = double.MinValue;
            int i = 0;
            foreach (var line in lines)
            {
                ppg[i] = double.Parse(line);
                if (ppg[i] < min) min = ppg[i];
                if (ppg[i] > max) max = ppg[i];
                i++;
            }
            ppgCount = i;
            string s = string.Format("PPG : Count = {0} , min = {1} , max = {2}", ppgCount, min, max);
            //MessageBox.Show(s);
        }

        private void EcgRead()
        {
            string fileName = "../../Data/ECG.txt";  //../는 상위폴더임 상위2번 올라가서 Data폴더 안
            string[] lines = File.ReadAllLines(fileName);

            double min = double.MaxValue;
            double max = double.MinValue;
            int i = 0;
            foreach(var line in lines)
            {
                ecg[i] = double.Parse(line);
                if(ecg[i]<min) min = ecg[i];
                if(ecg[i]>max) max = ecg[i];
                i++;
            }
            ecgCount = i;
            string s = string.Format("ECG : Count = {0} , min = {1} , max = {2}",ecgCount,min,max);
            //MessageBox.Show(s);
        }

        private void autoScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Start();
            scrolling = true;

        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ch.ChartAreas[0].AxisX.ScaleView.Zoom(0, ecgCount);
            t.Stop();
            scrolling = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool isTimerRunning = true;
        private void ch_Click(object sender, EventArgs e)
        {
            if(isTimerRunning == true)
            {
                t.Stop();
                isTimerRunning = false;
            }
            else
            {
                t.Start();
                isTimerRunning = true;
            }
        }

        private void ch_Mou(object sender, MouseEventArgs e)
        {
            HitTestResult htr = ch.HitTest(e.X, e.Y);  //마우스로 한 점을 찍었을 때 그 점의 데이터가 존재하는지 증명하는 방법
            if(htr.ChartElementType == ChartElementType.DataPoint)  //데이터가 있는 값이라면
            {
                t.Stop();
                string s = string.Format("Count: {0}. ECG: {1}, PPG: {2}", htr.PointIndex, ch.Series[0].Points[htr.PointIndex].YValues[0], ch.Series[1].Points[htr.PointIndex].YValues[0]);
                MessageBox.Show(s);
            }  
        }
    }
}
