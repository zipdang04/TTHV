namespace TTHV.MatchInformation.Exam;

public class Question
{
    public Question(Constant.Subject? subject = null, string question = "", string answer = "", string note = "", string attachment = "") {
        this.subject = subject;
        this.question = question;
        this.answer = answer;
        this.note = note;
        this.attachment = attachment;
    }

    public Constant.Subject? subject { set; get; }
    public string question { set; get; }
    public string answer { set; get; }
    public string note { set; get; }
    public string attachment { set; get; }
}