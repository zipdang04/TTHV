using TTHV.MatchInformation;
using TTHV.MatchInformation.Exam;

namespace TTHV.UnitTest.MatchInformation.Exam;

// using ExamMaker = ;
// using MatchInformation;

public class ExamMakingTest
{
    private WholeExam wholeExam;

    [SetUp]
    public void Initialize()
    {
        wholeExam = new WholeExam();
    }

    private void checkFinish(Finish finish)
    {
        Assert.That(finish.usage.Length, Is.EqualTo(Constant.PLAYERS));
        for (var player = 0; player < Constant.PLAYERS; player++)
        {
            Assert.That(finish.usage[player].Length, Is.EqualTo(Finish.TYPE_COUNT));
            for (var type = 0; type < Finish.TYPE_COUNT; type++)
            {
                Assert.That(finish.usage[player][type].Length, Is.EqualTo(Finish.QUESTION_COUNT));
                for (var i = 0; i < Finish.QUESTION_COUNT; i++)
                    Assert.IsFalse(finish.usage[player][type][i]);
            }
        }
    }

    [Test]
    public void TestInitializationOfExam()
    {
        Assert.NotNull(wholeExam.warmUpRelay);
        Assert.NotNull(wholeExam.warmUpConfront);
        Assert.NotNull(wholeExam.obstacle);
        Assert.NotNull(wholeExam.accelerate);
        Assert.NotNull(wholeExam.finish);

        checkFinish(wholeExam.finish);
    }

    [Test]
    public void TestFinishUsage()
    {
        wholeExam.finish.usage[0][0][0] = true;
        wholeExam.finish.usage[0][2][1] = true;

        wholeExam.finish.resetUsage();
        checkFinish(wholeExam.finish);
    }
}