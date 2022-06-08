using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _040_FormClock
{
  public partial class Form1 : Form
  {
    Graphics g;
    bool aClock_Flag = false;
    Point center;   // 시계의 중심점
    int radius;  // 시계의 반지름
    int hourHand;   // 시침의 길이
    int minHand;    // 분침
    int secHand;    // 초침
    Timer t = new Timer();
    public Form1()
    {
      InitializeComponent();

      this.Text = "FormClock";
      g = panel1.CreateGraphics();

      aClockSetting();
      TimerSetting();
    }

    private void TimerSetting()
    {
      t.Interval = 1000;  // 1초
      t.Tick += T_Tick;
      t.Start();
    }

    private void T_Tick(object sender, EventArgs e)
    {
      DateTime c = DateTime.Now;

      DrawClockFace();  // 시계판 그리기

      // 시침, 분침, 초침의 각도 구하기
      double degHr = (c.Hour % 12) * 30 + c.Minute * 0.5;
      double degMin = c.Minute * 6 + c.Second * 0.1;
      double degSec = c.Second * 6;

      // 라디안으로 변화
      double radHr = Math.PI * degHr / 180;
      double radMin = Math.PI * degMin / 180;
      double radSec = Math.PI * degSec / 180;

            DrawHands(radHr, radMin, radSec);

    }

        private void DrawHands(double radHr, double radMin, double radSec)
        {
            DrawLine((int)(hourHand * Math.Sin(radHr)), (int)(-hourHand * Math.Cos(radHr)),0,0,Brushes.RoyalBlue,8,center.X,center.Y); // x,y좌표
            DrawLine((int)(minHand * Math.Sin(radMin)), (int)(-minHand * Math.Cos(radMin)), 0, 0, Brushes.SkyBlue, 6, center.X, center.Y);
            DrawLine((int)(hourHand * Math.Sin(radSec)), (int)(-hourHand * Math.Cos(radSec)), 0, 0, Brushes.OrangeRed, 3, center.X, center.Y);
            int coreSize = 16;
            Rectangle r = new Rectangle(center.X - coreSize/2, center.Y - coreSize / 2, coreSize, coreSize);
            g.FillEllipse(Brushes.Gold, r);
            Pen pen = new Pen(Brushes.DarkRed, 3);
            g.DrawEllipse(pen, r);
        }

        private void DrawLine(int x1, int y1, int x2, int y2, Brush color, int thick, int Cx, int Cy)
        {
            Pen pen = new Pen(color, thick); // 8의굵기를 가지는 펜 생성
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            g.DrawLine(pen,x1+Cx,y1+Cy,x2+Cx,y2+Cy);
        }

        private void DrawClockFace()
    {
            Pen pen = new Pen(Brushes.LightSteelBlue, 30);
            g.DrawEllipse(pen, center.X - radius, center.Y - radius, radius, radius);
    }

    private void aClockSetting()
    {
      center = new Point(panel1.Width / 2, 
        panel1.Height / 2);
      radius = panel1.Height / 2;
      hourHand = (int)(radius * 0.45);
      minHand = (int)(radius * 0.55);
      secHand = (int)(radius * 0.65);
    }
  }
}
