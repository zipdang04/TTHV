namespace TTHV.MatchInformation.Exam;

/*
 * 8 câu, 5s/câu
 * đúng 10+5*(số tsinh sai), sai 0
 */

public class WarmUpConfront
{
    public const int QUESTION_COUNT = 8;
    public const int TIME_PER_Q = 5;
    public const int BELL_TIME = 5;

    public const int CORRECT = 10, BONUS = 5;
    public const int WRONG = 0;

    public WarmUpConfront()
    {
        questions = new Question[QUESTION_COUNT];
        for (var i = 0; i < QUESTION_COUNT; i++)
            questions[i] = new Question();
    }

    public Question[] questions { set; get; }
}