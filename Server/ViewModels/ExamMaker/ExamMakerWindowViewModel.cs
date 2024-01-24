using TTHV.Helper;
using TTHV.MatchInformation.Exam;

namespace TTHV.Server.ViewModels.ExamMaker;

public class ExamMakerWindowViewModel : ViewModelBase
{
    private const string EXAM_LOCATION = "Exam/Exam.json";
    private WholeExam wholeExam { set; get; }

    public ExamMakerWindowViewModel() {
        wholeExam = FileHelper.getWholeExam(EXAM_LOCATION) ?? new WholeExam();
    }

    public void importFromExcel() {
        // TODO: import from Excel
    } 
    public void saveExam() {
        FileHelper.saveExam(EXAM_LOCATION, wholeExam);
    }
}