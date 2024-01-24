using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using TTHV.Server.ViewModels.ExamMaker;

namespace TTHV.Server.Views.ExamMaker;

public partial class ExamMakerWindow : Window
{
    private ExamMakerWindowViewModel viewModel;

    public ExamMakerWindow() {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }
    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
    }
    private void assignViewModel() {
        if (viewModel == null)
            viewModel = (ExamMakerWindowViewModel)DataContext;
    }

    private void btnExcel_OnClick(object? sender, RoutedEventArgs e) {
        assignViewModel();
        viewModel.importFromExcel();
    }

    private void btnSave_OnClick(object? sender, RoutedEventArgs e) {
        assignViewModel();
        viewModel.saveExam();
    }
}