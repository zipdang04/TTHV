namespace TTHV.MatchInformation.Exam;

public class Obstacle
{
    public const int QUESTION_COUNT = 5;

    public const int HINTS_PER_Q = 3;
    public const int TIME_PER_Q = 45;
    public const int SECOND_TIME = 10; // giành quyền trả lời
    public const int STAR_THRESHOLD = 25;
    public const int WRONG_WITHOUT_STAR = 0;
    public const int WRONG_WITH_STAR = -STAR_THRESHOLD;

    public static readonly int[] CORRECT = new int[HINTS_PER_Q] { 50, 25, 10 };

    public Obstacle()
    {
        questions = new Question[QUESTION_COUNT];
        for (var i = 0; i < QUESTION_COUNT; i++) questions[i] = new Question();
    }

    public Question[] questions { set; get; }
}