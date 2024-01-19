namespace TTHV.MatchInformation.Exam;

public class WarmUpRelay
{
    public const int QUESTION_COUNT = 7;

    public const int CORRECT = 10;
    public const int WRONG = 0;

    public static readonly string[] SUBJECTS =
    {
        "Khoa học tự nhiên",
        "Khoa học xã hội",
        "Nghệ thuật",
        "Thể thao",
        "Công nghệ Thông tin",
        "Tiếng Anh",
        "Lĩnh vực khác"
    };

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