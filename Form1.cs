using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Rate_Projector
{
    public partial class MainWindowForm : Form
    {
        double MatchWinsTracker;
        double MatchLossesTracker;
        double MatchDrawsTracker;
        int MatchCounter;

        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void WinButton_Click(object sender, EventArgs e)
        {
            MatchCounter++;
            MatchWinsTracker++;

            WinsCounterLabel.Text = ("Wins: " + MatchWinsTracker.ToString());


            MainChart.Series["Win / Loss Ratio"].Points.AddXY(MatchCounter, (MatchWinsTracker / MatchCounter) * 100);

            WinLossRatioLabel.Text = "Win / Loss Ratio: " + Math.Round((MatchWinsTracker/MatchCounter), 2);

           /*
            if (Math.Round((MatchWinsTracker / MatchCounter), 2) >= 0.55)
            {
                MainChart.Series["Win / Loss Ratio"].Color = Color.Green;
            }
            else if (Math.Round((MatchWinsTracker / MatchCounter), 2) <= 0.45)
            {
                MainChart.Series["Win / Loss Ratio"].Color = Color.Red;
            }
            else if (Math.Round((MatchWinsTracker / MatchCounter), 2) > 0.45 && (Math.Round((MatchWinsTracker / MatchCounter), 2) < 0.55))
            {
                MainChart.Series["Win / Loss Ratio"].Color = Color.Black;
            }
           */

         

            MainChart.Series["Win / Loss Ratio"].Color= Color.Green;
            
            Console.WriteLine("DEBUG FOR ROUND " + MatchCounter);
            Console.WriteLine("Ratio Calculator: " + (MatchWinsTracker / MatchCounter) * 100);
            Console.WriteLine("Wins Tracker: " + MatchWinsTracker);
            Console.WriteLine("Losses Tracker: " + MatchLossesTracker);
            Console.WriteLine();

        }

        private void LossButton_Click(object sender, EventArgs e)
        {
            MatchCounter++;
            MatchLossesTracker++;

            LossesCounterLabel.Text = ("Losses: " + MatchLossesTracker.ToString());

            MainChart.Series["Win / Loss Ratio"].Points.AddXY(MatchCounter, (MatchWinsTracker / MatchCounter) * 100);

            /*
            if (Math.Round((MatchWinsTracker / MatchCounter), 2) >= 0.55)
            {
                MainChart.Series["Win / Loss Ratio"].Color = Color.Green;
            }
            else if (Math.Round((MatchWinsTracker / MatchCounter), 2) <= 0.45)
            {
                MainChart.Series["Win / Loss Ratio"].Color = Color.Red;
            }
            else if (Math.Round((MatchWinsTracker / MatchCounter), 2) > 0.45 && (Math.Round((MatchWinsTracker / MatchCounter), 2) < 0.55))
            {
                MainChart.Series["Win / Loss Ratio"].Color = Color.Black;
            }
            */

            WinLossRatioLabel.Text = "Win / Loss Ratio: " + Math.Round((MatchWinsTracker / MatchCounter), 2);


            Console.WriteLine("DEBUG FOR ROUND " + MatchCounter);
            Console.WriteLine("Ratio Calculator: " + (MatchWinsTracker / MatchCounter) * 100);
            Console.WriteLine("Wins Tracker: " + MatchWinsTracker);
            Console.WriteLine("Losses Tracker: " + MatchLossesTracker);
            Console.WriteLine("Match Counter: " + MatchCounter);
            Console.WriteLine();
        }


        private void DrawButton_Click(object sender, EventArgs e)
        {
            MatchCounter++;
            MatchDrawsTracker++;

            DrawsCounterLabel.Text = ("Draws: " + MatchDrawsTracker.ToString());
            
            MainChart.Series["Win / Loss Ratio"].Points.AddXY(MatchCounter, (MatchWinsTracker / MatchCounter) * 100);

            WinLossRatioLabel.Text = "Win / Loss Ratio: " + Math.Round((MatchWinsTracker / MatchCounter), 2);

            Console.WriteLine("DEBUG FOR ROUND " + MatchCounter);
            Console.WriteLine("Ratio Calculator: " + (MatchWinsTracker / MatchCounter) * 100);
            Console.WriteLine("Wins Tracker: " + MatchWinsTracker);
            Console.WriteLine("Losses Tracker: " + MatchLossesTracker);
            Console.WriteLine("Match Counter: " + MatchCounter);
            Console.WriteLine();
        }

    }
}
