using TTHV.MatchInformation;
using TTHV.MatchInformation.Exam;

namespace TTHV.Server.ViewModels.ExamMaker.Component;

public class QuestionControlViewModel: ViewModelBase
{
    private Question content { set; get; }

    public string subject => content.topic?.value ?? "";

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

    public QuestionControlViewModel(Question content) {
        this.content = content;
    }
    
    /*
     * Do not use this at any circumstances
     * This is only for axaml
     */
    public QuestionControlViewModel(): this(new Question()) {}
}