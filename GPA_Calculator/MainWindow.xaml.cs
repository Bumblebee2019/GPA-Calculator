using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace GPA_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, double> MAPNonAPLetterToDecMapFourMax = new Dictionary<string, double>();
        Dictionary<string, double> MAPAPLetterToDec = new Dictionary<string, double>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            NonAPLetterToDecMapFourMax();
            APLetterToDec();
            //Calculate Scores
            MessageBox.Show($"Your GPA is {GetWeightedGPA()} ");
        }

        //Calculating total scores for each class=======================
        public double FirstClassScore()
        {
            double firstClassScore = 0;
            double firstClasstotalScore = 0;
            //consult different tables if AP
            if (IsAP1.IsChecked == true) //trying to go without IsAP1_Checked
            {
                firstClassScore = GetAPScoreDouble(firstPeriodLetterGradeText.Text); //must do ".Text" to get a string
            }
            else //in case first period is a non-AP class
            {
                firstClassScore = GetRegScoreDouble(secondPeriodLetterGradeText.Text);
            }
            //calculate score * credit = total_score for period 1
            firstClasstotalScore = Convert.ToDouble(firstPeriodCreditText.Text) * firstClassScore;
            return firstClasstotalScore;
        }
        public double SecondClassScore()
        {
            double secondClassScore = 0;
            double secondClasstotalScore = 0;
            //consult different tables if AP
            if (IsAP2.IsChecked == true) //trying to go without IsAP1_Checked
            {
                secondClassScore = GetAPScoreDouble(secondPeriodLetterGradeText.Text); //must do ".Text" to get a string
            }
            else //in case first period is a non-AP class
            {
                secondClassScore = GetRegScoreDouble(secondPeriodLetterGradeText.Text);
            }
            //calculate score * credit = total_score for period 1
            secondClasstotalScore = Convert.ToDouble(secondPeriodCreditText.Text) * secondClassScore;
            return secondClasstotalScore;
        }
        public double ThirdClassScore()
        {
            double thirdClassScore = 0;
            double thirdClasstotalScore = 0;
            //consult different tables if AP
            if (IsAP3.IsChecked == true) //trying to go without IsAP1_Checked
            {
                thirdClassScore = GetAPScoreDouble(thirdPeriodLetterGradeText.Text); //must do ".Text" to get a string
            }
            else //in case first period is a non-AP class
            {
                thirdClassScore = GetRegScoreDouble(thirdPeriodLetterGradeText.Text);
            }
            //calculate score * credit = total_score for period 1
            thirdClasstotalScore = Convert.ToDouble(thirdPeriodCreditText.Text) * thirdClassScore;
            return thirdClasstotalScore;
        }
        public double FourthClassScore()
        {
            double fourthClassScore = 0;
            double fourthClasstotalScore = 0;
            //consult different tables if AP
            if (IsAP4.IsChecked == true) //trying to go without IsAP1_Checked
            {
                fourthClassScore = GetAPScoreDouble(fourthPeriodLetterGradeText.Text); //must do ".Text" to get a string
            }
            else //in case first period is a non-AP class
            {
                fourthClassScore = GetRegScoreDouble(fourthPeriodLetterGradeText.Text);
            }
            //calculate score * credit = total_score for period 1
            fourthClasstotalScore = Convert.ToDouble(fourthPeriodCreditText.Text) * fourthClassScore;
            return fourthClasstotalScore;
        }
        public double FifthClassScore()
        {
            double fifthClassScore = 0;
            double fifthClasstotalScore = 0;
            //consult different tables if AP
            if (IsAP5.IsChecked == true) //trying to go without IsAP1_Checked
            {
                fifthClassScore = GetAPScoreDouble(fifthPeriodLetterGradeText.Text); //must do ".Text" to get a string
            }
            else //in case first period is a non-AP class
            {
                fifthClassScore = GetRegScoreDouble(fifthPeriodLetterGradeText.Text);
            }
            //calculate score * credit = total_score for period 1
            fifthClasstotalScore = Convert.ToDouble(fifthPeriodCreditText.Text) * fifthClassScore;
            return fifthClasstotalScore;
        }
        public double SixthClassScore()
        {
            double sixthClassScore = 0;
            double sixthClasstotalScore = 0;
            //consult different tables if AP
            if (IsAP6.IsChecked == true) //trying to go without IsAP1_Checked
            {
                sixthClassScore = GetAPScoreDouble(sixthPeriodLetterGradeText.Text); //must do ".Text" to get a string
            }
            else //in case first period is a non-AP class
            {
                sixthClassScore = GetRegScoreDouble(sixthPeriodLetterGradeText.Text);
            }
            //calculate score * credit = total_score for period 1
            sixthClasstotalScore = Convert.ToDouble(sixthPeriodCreditText.Text) * sixthClassScore;
            return sixthClasstotalScore;
        }
        //=======================================================================
        public void NonAPLetterToDecMapFourMax() //non AP GPA table, where both A and A+ are 4.0
        {
            MAPNonAPLetterToDecMapFourMax.Add("A+", 4.0);
            MAPNonAPLetterToDecMapFourMax.Add("A", 4.0);
            MAPNonAPLetterToDecMapFourMax.Add("A-", 3.7);
            MAPNonAPLetterToDecMapFourMax.Add("B+", 3.3);
            MAPNonAPLetterToDecMapFourMax.Add("B", 3.0);
            MAPNonAPLetterToDecMapFourMax.Add("B-", 2.7);
            MAPNonAPLetterToDecMapFourMax.Add("C+", 2.3);
            MAPNonAPLetterToDecMapFourMax.Add("C", 2.0);
            MAPNonAPLetterToDecMapFourMax.Add("C-", 1.7);
            MAPNonAPLetterToDecMapFourMax.Add("D+", 1.3);
            MAPNonAPLetterToDecMapFourMax.Add("D", 1.0);
            MAPNonAPLetterToDecMapFourMax.Add("D-", 0.7);
            MAPNonAPLetterToDecMapFourMax.Add("F", 0.0);
        }
        public void APLetterToDec() //AP GPA table, assuming there is only one scale used
        {
            MAPAPLetterToDec.Add("A+", 5.3);
            MAPAPLetterToDec.Add("A", 5.0);
            MAPAPLetterToDec.Add("A-", 4.7);
            MAPAPLetterToDec.Add("B+", 4.3);
            MAPAPLetterToDec.Add("B", 4.0);
            MAPAPLetterToDec.Add("B-", 3.7);
            MAPAPLetterToDec.Add("C+", 3.3);
            MAPAPLetterToDec.Add("C", 3.0);
            MAPAPLetterToDec.Add("C-", 2.7);
            MAPAPLetterToDec.Add("D+", 2.3);
            MAPAPLetterToDec.Add("D", 2.0);
            MAPAPLetterToDec.Add("D-", 1.7);
            MAPAPLetterToDec.Add("F", 0.0);
        }
        //Getters============================
        public int GetTotalCredits()
        {
            int totalCredits = 0;
            int firstPeriodCreditAsInt = Int32.Parse(firstPeriodCreditText.Text);
            totalCredits = totalCredits + firstPeriodCreditAsInt;
            int secondPeriodCreditAsInt = Int32.Parse(secondPeriodCreditText.Text);
            totalCredits = totalCredits + secondPeriodCreditAsInt;
            int thirdPeriodCreditAsInt = Int32.Parse(thirdPeriodCreditText.Text);
            totalCredits = totalCredits + thirdPeriodCreditAsInt;
            int fourthPeriodCreditAsInt = Int32.Parse(fourthPeriodCreditText.Text);
            totalCredits = totalCredits + fourthPeriodCreditAsInt;
            int fifthPeriodCreditAsInt = Int32.Parse(fifthPeriodCreditText.Text);
            totalCredits = totalCredits + fifthPeriodCreditAsInt;
            int sixthPeriodCreditAsInt = Int32.Parse(sixthPeriodCreditText.Text);
            totalCredits = totalCredits + sixthPeriodCreditAsInt;
            return totalCredits;
        }
        private double GetAPScoreDouble(string letter)
        {
            double score = -1;
            MAPAPLetterToDec.TryGetValue(letter, out score);
            return score;
        }
        private double GetRegScoreDouble(string letter)
        {
            double score = 0;
            MAPNonAPLetterToDecMapFourMax.TryGetValue(letter, out score);
            return score;
        }
        private double GetWeightedGPA()
        {
            double totalScore = 0;
            int totalCredit = 0;
            totalScore = FirstClassScore() + SecondClassScore() + ThirdClassScore() + FourthClassScore() + FifthClassScore() + SixthClassScore();
            totalCredit = Int32.Parse(firstPeriodCreditText.Text) + Int32.Parse(secondPeriodCreditText.Text) + Int32.Parse(thirdPeriodCreditText.Text) + Int32.Parse(fourthPeriodCreditText.Text) + Int32.Parse(fifthPeriodCreditText.Text) + Int32.Parse(sixthPeriodCreditText.Text);
            return totalScore / Convert.ToDouble(totalCredit);
        }
        //===================================
    }
}