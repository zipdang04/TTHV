using System.Text.Json.Serialization;

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
        questions = new ObstacleQuestion[QUESTION_COUNT];
        for (var i = 0; i < QUESTION_COUNT; i++) questions[i] = new ObstacleQuestion();
    }

    public ObstacleQuestion[] questions { set; get; }
}

public class ObstacleQuestion
{
    public class Hint
    {
        public string hint { set; get; }
        public string media { set; get; }
        public string note { set; get; }

        public Hint(string hint = "", string media = "", string note = "") {
            this.hint = hint;
            this.media = media;
            this.note = note;
        }
    }
    
    public Topic? topic { get; set; }
    public string answer { get; set; }
    public Hint[] hints { get; set; }

    public ObstacleQuestion() {
        topic = null;
        answer = "";
        hints = new Hint[Obstacle.HINTS_PER_Q];
        
        for (var i = 0; i < Obstacle.HINTS_PER_Q; i++) {
            hints[i] = new Hint();
        }
    }

    [JsonConstructor]
    public ObstacleQuestion(string topic, string answer, Hint[] hints) {
        this.topic = WhTopic.fromValue(topic);
        this.answer = answer;
        this.hints = hints;
    }
}