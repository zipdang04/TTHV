using ReactiveUI;
using TTHV.Helper;
using TTHV.MatchInformation.Exam;

namespace TTHV.Server.ViewModels.ExamMaker;

public class ExamMakerWindowViewModel : ViewModelBase
{
    private const string EXAM_LOCATION = "Exam/Exam.json";
    private WholeExam wholeExam { set; get; }
    private FileHelper helper;

    public ExamMakerWindowViewModel() {
        helper = FileHelper.getInstance();
        wholeExam = helper.getWholeExam(EXAM_LOCATION) ?? new WholeExam();
    }
}