namespace TTHV.MatchInformation.Exam;

public class Question
{
    public Question(Topic? topic = null, string question = "", string answer = "", string note = "", string attachment = "") {
        this.topic = topic;
        this.question = question;
        this.answer = answer;
        this.note = note;
        this.attachment = attachment;
    }

    public Topic? topic { set; get; }
    public string question { set; get; }
    public string answer { set; get; }
    public string note { set; get; }
    public string attachment { set; get; }
}