namespace TTHV.MatchInformation.Exam;

public class Question
{
    public Question(Constant.Subject? subject = null, string question = "", string answer = "", string attachment = "") {
        this.subject = subject;
        this.question = question;
        this.answer = answer;
        this.attachment = attachment;
    }

    public Constant.Subject? subject { set; get; }
    public string question { set; get; }
    public string answer { set; get; }
    public string attachment { set; get; }
}