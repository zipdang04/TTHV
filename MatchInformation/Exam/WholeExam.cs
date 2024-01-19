namespace TTHV.MatchInformation.Exam;

public class WholeExam
{
    public WholeExam()
    {
        warmUpRelay = new WarmUpRelay();
        warmUpConfront = new WarmUpConfront();
        obstacle = new Obstacle();
        accelerate = new Accelerate();
        finish = new Finish();
    }

    public WarmUpRelay warmUpRelay { set; get; }
    public WarmUpConfront warmUpConfront { set; get; }
    public Obstacle obstacle { set; get; }
    public Accelerate accelerate { set; get; }
    public Finish finish { set; get; }
}