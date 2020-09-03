using System;
using System.Text;

namespace AssessmentScoreCardGenerator
{

    public enum AssessmentType
    {
        QUIZ = 50,
        KBA = 100,
        CALIBRATION = 150,
        HACKATHON = 200
    }

    public struct AssessmentCard
    {
        public AssessmentType assessmentType;
        public int score;
        public DateTime dateTime;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
              
        }
        // this method accepts assessment cards and calculates total percentage
        public static int GetOverallScore(AssessmentCard[] cards)
        {
            int totalScore = 0, maxScore = 0;

            foreach(AssessmentCard card in cards)
            {
                maxScore += (int)card.assessmentType;
                totalScore += card.score;
            }
            return (totalScore * 100)/maxScore;
        }

        // this method should generate score card from the details provided
        public static string GenerateScoreCard(int cadetID, string cadetName, AssessmentCard[] cards, int overallPercentage)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cadet ID: " + cadetID);
            sb.AppendLine("Cadet Name: " + cadetName);
            foreach(AssessmentCard card in cards)
            {
                sb.AppendLine();
                if(card.dateTime > DateTime.MinValue)
                {
                    sb.Append("Date: " + card.dateTime + ", ");
                }
                sb.Append("Assessment type: " + card.assessmentType);
                sb.Append("( Max Score: " + (int)card.assessmentType + " ), ");
                sb.Append("Score Obtained: " + card.score);
            }
            sb.AppendLine("OverAll Percentage: " + overallPercentage + "%");
            return sb.ToString();
        }
    }

}
