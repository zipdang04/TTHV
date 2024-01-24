using Avalonia.Controls;
using Avalonia.Interactivity;
using TTHV.Server.ViewModels.ExamMaker;
using TTHV.Server.Views.ExamMaker;

namespace TTHV.Server.Views;

public partial class MainWindow : Window
{
    public MainWindow() {
        InitializeComponent();
    }

    private void btnExamMaker_OnClick(object? sender, RoutedEventArgs e) {
        ExamMakerWindow examMakerWindow = new ExamMakerWindow {
            DataContext = new ExamMakerWindowViewModel(),
        };
        examMakerWindow.Closed += (o, args) => {
            try { Show(); }
            catch { Close(); }
        };
        
        examMakerWindow.Show(); Hide();
    }
}