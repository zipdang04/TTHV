using TTHV.MatchInformation;
using TTHV.MatchInformation.Exam;

namespace TTHV.Server.ViewModels.ExamMaker.Component;

public class ObstacleQuestionControlViewModel: ViewModelBase
{
    private ObstacleQuestion question;

    public int _id;
    public int id { 
        get => _id + 1;
        set => _id = value;
    }

    public WhTopic[] ALL_TOPICS => WhTopic.ALL_ENUMS;
    
    public Topic? topic {
        get => question.topic;
        set => question.topic = value;
    }

    public string answer {
        get => question.answer;
        set => question.answer = value;
    }
    public ObstacleQuestion.Hint[] hints => question.hints;

    public ObstacleQuestionControlViewModel(ObstacleQuestion question, int id) {
        this.question = question;
        this.id = id;
    }
    
    /*
     * Do not use this at any circumstances
     * This is only for axaml
     */
    public ObstacleQuestionControlViewModel() : this(new ObstacleQuestion(), 0) { }
}