namespace TTHV.MatchInformation.Exam;

public class Question
{
    public Question(string question = "", string answer = "", string attachment = "")
    {
        this.question = question;
        this.answer = answer;
        this.attachment = attachment;
    }

    public string question { set; get; }
    public string answer { set; get; }
    public string attachment { set; get; }
}