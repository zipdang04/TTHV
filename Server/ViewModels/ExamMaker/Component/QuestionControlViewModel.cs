using TTHV.MatchInformation;
using TTHV.MatchInformation.Exam;

namespace TTHV.Server.ViewModels.ExamMaker.Component;

public class QuestionControlViewModel: ViewModelBase
{
    private Question content;

    public Topic[] ALL_TOPICS => SubjectTopic.ENUM_LIST;

    public Topic? subject {
        set => content.topic = value;
        get => content.topic;
    }

    public string question {
        set => content.question = value;
        get => content.question;
    }
    public string answer {
        set => content.answer = value;
        get => content.answer;
    }

    public string note {
        set => content.note = value;
        get => content.note;
    }
    public string attachment {
        set => content.attachment = value;
        get => content.attachment;
    }

    public bool topicVisibility { get; }
    public bool labelVisibility => !topicVisibility;
    public string labelContent { get; }

    public QuestionControlViewModel(Question content, bool topicVisibility = false, string labelContent = "") {
        this.content = content;
        this.topicVisibility = topicVisibility;
        this.labelContent = labelContent;
    }
    
    /*
     * Do not use this at any circumstances
     * This is only for axaml
     */
    public QuestionControlViewModel(): this(new Question(), true) {}
}