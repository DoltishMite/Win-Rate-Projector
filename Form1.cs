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
        public MainWindowForm()
        {
            InitializeComponent();
        }

        double MatchCounter;

        double MatchWinsTracker;
        double MatchLossesTracker;

        //Total Wins/Total Matches * 100 = Percentage won


        private void WinButton_Click(object sender, EventArgs e)
        {
            MatchCounter = MatchCounter + 1;
            MatchWinsTracker = MatchWinsTracker + 1;
            
            MainChart.Series["Win / Loss Ratio"].Points.AddXY(MatchCounter, (MatchWinsTracker / MatchCounter) * 100);

            
            Console.WriteLine("DEBUG FOR ROUND " + MatchCounter);
            Console.WriteLine("Ratio Calculator: " + (MatchWinsTracker / MatchCounter) * 100);
            Console.WriteLine("Wins Tracker: " + MatchWinsTracker);
            Console.WriteLine("Losses Tracker: " + MatchLossesTracker);
            Console.WriteLine("Match Counter: " + MatchCounter);
            Console.WriteLine();
        }

        private void LossButton_Click(object sender, EventArgs e)
        {
            MatchCounter = MatchCounter + 1;
            MatchLossesTracker = MatchLossesTracker + 1;
           
            MainChart.Series["Win / Loss Ratio"].Points.AddXY(MatchCounter, (MatchWinsTracker / MatchCounter) * 100);


            Console.WriteLine("DEBUG FOR ROUND " + MatchCounter);
            Console.WriteLine("Ratio Calculator: " + (MatchWinsTracker / MatchCounter) * 100);
            Console.WriteLine("Wins Tracker: " + MatchWinsTracker);
            Console.WriteLine("Losses Tracker: " + MatchLossesTracker);
            Console.WriteLine("Match Counter: " + MatchCounter);
            Console.WriteLine();
        }
    }
}
