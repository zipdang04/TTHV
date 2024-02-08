using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TTHV.Server.Views.ExamMaker.Component;

public partial class QuestionControl : UserControl
{
    public QuestionControl() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
    }
}