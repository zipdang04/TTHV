namespace TTHV.MatchInformation.Exam;

public class Accelerate
{
    public const int QUESTION_COUNT = 4;
    public const int TIME_PER_Q = 30;

    public static readonly int[] CORRECT = new int[Constant.PLAYERS] { 40, 30, 20, 10 };

    public Accelerate()
    {
        questions = new Question[QUESTION_COUNT];
        for (var i = 0; i < QUESTION_COUNT; i++)
            questions[i] = new Question();
    }

    public Question[] questions { set; get; }
}