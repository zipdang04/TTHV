namespace TTHV.MatchInformation;


public abstract class Topic
{
    public abstract string value { get; }
}

public class WhTopic : Topic
{
    private const int LANGUAGE_OFFSET = 3;
    private const int QUESTION_OFFSET = 5;
    
    private const int NUMBER_OF_WHQS = 4;
    private const int NUMBER_OF_LANGUAGES = 2;
    public static readonly WhTopic
        WHO_VI = new WhTopic(5, 3),
        WHAT_VI = new WhTopic(6, 3),
        WHERE_VI = new WhTopic(7, 3),
        WHEN_VI = new WhTopic(9, 3),
        WHO_EN = new WhTopic(5, 4),
        WHAT_EN = new WhTopic(6, 4),
        WHERE_EN = new WhTopic(7, 4),
        WHEN_EN = new WhTopic(9, 4);
    private static readonly WhTopic[][] ENUM_LIST = {
        new WhTopic[] { WHO_VI, WHAT_VI, WHERE_VI, WHEN_VI }, 
        new WhTopic[] { WHO_EN, WHAT_EN, WHERE_EN, WHEN_EN }
    };
    private static readonly string[][] WH_QUESTIONS = {
        new string[] { "Ai?", "Cái gì?", "Ở đâu?", "Khi nào?" }, 
        new string[] { "Who?", "What?", "Where?", "When?" }
    };

    private readonly int questionCode, languageCode;
    public override string value => WH_QUESTIONS[languageCode][questionCode];

    private WhTopic(int questionCode, int languageCode) {
        if (questionCode is < 0 or >= NUMBER_OF_WHQS)
            throw new Exception($"Enum error: questionCode must be between {QUESTION_OFFSET + 0} and {QUESTION_OFFSET + NUMBER_OF_WHQS - 1}");
        if (languageCode is < 0 or >= NUMBER_OF_LANGUAGES)
            throw new Exception($"Enum error: languageCode must be between {LANGUAGE_OFFSET + 0} and {LANGUAGE_OFFSET + NUMBER_OF_LANGUAGES - 1}");
        
        this.questionCode = questionCode;
        this.languageCode = languageCode;
    }

    public static WhTopic? fromValue(string value) {
        for (int i = 0; i < NUMBER_OF_LANGUAGES; i++)
            for (int j = 0; j < NUMBER_OF_WHQS; j++)
                if (value == WH_QUESTIONS[i][j])
                    return ENUM_LIST[i][j];
        return null;
    }

    public static WhTopic? fromCode(int questionCode, int languageCode) {
        return new WhTopic(questionCode, languageCode);
    }
}

public class SubjectTopic : Topic
{
    private const int NUMBER_OF_SUBJECTS = 7;
    public static readonly SubjectTopic
        NAT_SCI = new SubjectTopic(0),
        SOC_SCI = new SubjectTopic(1),
        ART = new SubjectTopic(2),
        SPORT = new SubjectTopic(3),
        IT = new SubjectTopic(4),
        ENGLISH = new SubjectTopic(5),
        OTHERS = new SubjectTopic(6);
    private static readonly SubjectTopic[] ENUM_LIST = {
        NAT_SCI, SOC_SCI, ART, SPORT, IT, ENGLISH, OTHERS
    };
    private static readonly string[] SUBJECTS = {
        "Khoa học Tự nhiên",
        "Khoa học Xã hội",
        "Nghệ thuật",
        "Thể thao",
        "Công nghệ - Thông tin",
        "Tiếng Anh",
        "Lĩnh vực khác"
    };

    private readonly int code;
    public override string value => SUBJECTS[code];

    private SubjectTopic(int code) {
        if (code is < 0 or >= NUMBER_OF_SUBJECTS)
            throw new Exception($"Enum error: code must be between 0 and {NUMBER_OF_SUBJECTS - 1}");
        this.code = code;
    }
    
    public static SubjectTopic? fromValue(string value) {
        for (var i = 0; i < NUMBER_OF_SUBJECTS; i++)
            if (value == SUBJECTS[i])
                return ENUM_LIST[i];
        return null;
    }
}