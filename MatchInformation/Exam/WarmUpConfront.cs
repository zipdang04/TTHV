namespace TTHV.MatchInformation.Exam;

public class WarmUpConfront
{
    public const int QUESTION_COUNT = 15; // per turn
    public const int TIME_PER_Q = 3;
    public const int MAX_CONSECUTIVE_WRONG = 2; // 3 => temporarily out for one question

    public const int CORRECT = 10;
    public const int WRONG = -5;

    public WarmUpConfront()
    {
        questions = new Question[QUESTION_COUNT];
        for (var i = 0; i < QUESTION_COUNT; i++)
            questions[i] = new Question();
    }

    public Question[] questions { set; get; }
}