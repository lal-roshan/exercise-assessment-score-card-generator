using System;

namespace AssessmentScoreCardGenerator
{

    /* 
     * Declare enum AssessmentType with named constant for types of assessments
     * assessment types with the maximum score is:
     * QUIZ - 50
     * KBA - 100
     * CALIBRATION - 150
     * HACKATHON - 200

     * the maximum score can be set as value for enum constants
     */

     /*
      * Declare struct AssessmentCard
      * Structure members should be assessmentType, score and datetime
      */

    public class Program
    {
        static void Main(string[] args)
        {
            
            // this code is optional here however it wil help 
            // you to understand the requirements better    
        }
        // this method accepts assessment cards and calculates total percentage
        public static int GetOverallScore()
        {
            // the logic put here should use foreach loop to read 
            // card data and calculate percentage as mentioned.
            // the maximum score value for each assessment type can be retrieve
            // from enum constant            
        }

        // this method should generate score card from the details provided
        public static string GenerateScoreCard()
        {
            // the code here should build string with contents such as
            // cadet no, cadet name, calibration type, score obtained

            // the built string should be returned as string and not as StringBuilder
        }
    }

}