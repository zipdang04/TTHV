using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TTHV.Server.Views.ExamMaker.Component;

public partial class HintControl : UserControl
{
    public HintControl() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
    }
}