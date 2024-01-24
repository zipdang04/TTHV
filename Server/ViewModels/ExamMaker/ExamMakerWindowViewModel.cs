using TTHV.Helper;
using TTHV.MatchInformation.Exam;

namespace TTHV.Server.ViewModels.ExamMaker;

public class ExamMakerWindowViewModel : ViewModelBase
{
    private WholeExam wholeExam { set; get; }

    public ExamMakerWindowViewModel() {
        wholeExam = FileHelper.getWholeExam(Constant.EXAM_LOCATION) ?? new WholeExam();
    }

    public void importFromExcel() {
        // TODO: import from Excel
    } 
    public void saveExam() {
        FileHelper.saveExam(Constant.EXAM_LOCATION, wholeExam);
    }
}