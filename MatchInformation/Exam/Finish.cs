namespace TTHV.MatchInformation.Exam;

public class Finish
{
    public const int QUESTION_COUNT = 3;
    public const int TYPE_COUNT = 3;

    public const int TURNS_PER_PLAYER = 2;
    public const int Q_PER_TURN = 2;
    public static readonly int[] Q_TYPES = new int[TYPE_COUNT] { 10, 20, 30 };

    public Finish()
    {
        questions = new Question[Constant.PLAYERS][][];
        usage = new bool[Constant.PLAYERS][][];
        for (var i = 0; i < Constant.PLAYERS; i++)
        {
            questions[i] = new Question[TYPE_COUNT][];
            usage[i] = new bool[TYPE_COUNT][];
            for (var j = 0; j < TYPE_COUNT; j++)
            {
                questions[i][j] = new Question[QUESTION_COUNT];
                usage[i][j] = new bool[QUESTION_COUNT];
                for (var k = 0; k < QUESTION_COUNT; k++)
                {
                    questions[i][j][k] = new Question();
                    usage[i][j][k] = false;
                }
            }
        }
    }

    public Question[][][] questions { set; get; }
    public bool[][][] usage { set; get; }

    public void resetUsage()
    {
        for (var i = 0; i < Constant.PLAYERS; i++)
        for (var j = 0; j < TYPE_COUNT; j++)
        for (var k = 0; k < QUESTION_COUNT; k++)
            usage[i][j][k] = false;
    }
}