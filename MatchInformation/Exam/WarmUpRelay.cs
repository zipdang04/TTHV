namespace TTHV.MatchInformation.Exam;

/*
 * 7 câu / 30s / thí sinh
 * đúng +10, sai 0
 */

public class WarmUpRelay
{
    public const int QUESTION_COUNT = 7;
    public const int TIME = 30;

    public const int CORRECT = 10;
    public const int WRONG = 0;

    public WarmUpRelay()
    {
        questions = new Question[Constant.PLAYERS][];
        for (var i = 0; i < Constant.PLAYERS; i++)
        {
            questions[i] = new Question[QUESTION_COUNT];
            for (var j = 0; j < QUESTION_COUNT; j++)
                questions[i][j] = new Question();
        }
    }

    public Question[][] questions { set; get; }
}