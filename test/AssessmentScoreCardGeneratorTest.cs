using AssessmentScoreCardGenerator;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class AssessmentScoreCardGeneratorTest
    {
        readonly AssessmentCard[] cards;

        public AssessmentScoreCardGeneratorTest()
        {
            cards = new AssessmentCard[4];

            cards[0] = new AssessmentCard
            {
                score = 75,
                assessmentType = AssessmentType.CALIBRATION
            };
            cards[1] = new AssessmentCard
            {
                score = 25,
                assessmentType = AssessmentType.QUIZ
            };
            cards[2] = new AssessmentCard
            {
                score = 100,
                assessmentType = AssessmentType.HACKATHON
            };
            cards[3] = new AssessmentCard
            {
                score = 50,
                assessmentType = AssessmentType.KBA
            };
        }
        [Test]
        public void Should_GetOverallScore_Return_Integer()
        {
            var score = Program.GetOverallScore(cards);
            Assert.That(score, Is.EqualTo(50));
        }

        [TestCase(0, ExpectedResult = 150)]
        [TestCase(1, ExpectedResult = 50)]
        [TestCase(2, ExpectedResult = 200)]
        [TestCase(3, ExpectedResult = 100)]
        public int Should_AssessmentType_Be_Enum(int index)
        {
            Assert.That(cards[index].assessmentType, Is.TypeOf<AssessmentType>());
            return (int)cards[index].assessmentType;
        }

        [Test]
        public void Should_Cards_Be_AssessmentCard()
        {
            Assert.That(cards[0], Is.TypeOf<AssessmentCard>());
        }

        [Test]
        public void Should_GenerateScoreCard_Return_String()
        {
            var result = Program.GenerateScoreCard(100, "Shivay", cards, Program.GetOverallScore(cards));
            Assert.That(result, Is.TypeOf<string>());

            Assert.That(result, Does.Contain("100"));
            Assert.That(result, Does.Contain("Shivay"));

            Assert.That(result, Does.Contain("75"));
            Assert.That(result, Does.Contain("HACKATHON"));

            Assert.That(result, Does.Contain("50%"));
        }
    }
}
