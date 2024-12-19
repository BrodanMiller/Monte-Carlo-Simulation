using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*Brodan Miller
 * 5/3/2023
 * Program uses Monte Carlo Simulation to predict pi.... With a twist.
 * C# offers a way to use multiple threads from your CPU. I played
 * around with it and was able to get the max value of points over
 * 2 billion. It took over a minute to calculate and can in some 
 * cases get as accurate as the hundered thousends place in accuracy
 * to pi.
 * 
 *!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 * RUN AT OWN RISK. IT PUSHES CPU UTILIZATION TO 100% FOR CLOSE TO 3 MINUTES!!!!!
 * !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 * 
 * it is super cool if you open up task manager and watch CPU utilization ramp 
 * to 100% in milliseconds.
 */

namespace TestForDaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int NUMBEROFPOINTS = int.MaxValue;
        private const decimal RADIUS = 0.5m;
        private int sum = 0;
        private int finished = 0;
        private void calcpibtn_Click(object sender, EventArgs e)
        {
            Thread[] children = new Thread[12];

            decimal circleArea;
            decimal calcPi;

            for (int i = 0; i < 12; i++)
            {
                children[i] = new Thread(CalcPointsMethod);
                children[i].Start();
            }

            while (finished < 12)
            {
                Thread.Sleep(1000);
            }

            circleArea = sum * 1.0m / NUMBEROFPOINTS;

            calcPi = circleArea / (RADIUS * RADIUS);

            TotalNumPointslbl.Text = NUMBEROFPOINTS.ToString("n");
            NumPointsInCirclelbl.Text = sum.ToString("n");
            EstimatedPilbl.Text = calcPi.ToString();
        }
        public bool isInCircle(decimal x, decimal y)
        {
            decimal distanceFromCenter = (decimal)Math.Sqrt((double)(x * x + y * y));

            return distanceFromCenter <= 0.5m;
        }

        public void CalcPointsMethod()
        {
            int PointsinCircle = 0;
            decimal x, y;

            Random rand = new Random();

            for (int i = 0; i < (NUMBEROFPOINTS / 12); i++)
            {
                x = (decimal)rand.NextDouble() - 0.5m;
                y = (decimal)rand.NextDouble() - 0.5m;

                if (isInCircle(x, y))
                {
                    PointsinCircle++;
                }
            }
            sum += PointsinCircle;
            finished++;
        }
    }
}
