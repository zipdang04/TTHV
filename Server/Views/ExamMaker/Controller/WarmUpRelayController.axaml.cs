using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TTHV.Server.Views.ExamMaker.Controller;

public partial class WarmUpRelayController : UserControl
{
    public WarmUpRelayController() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
    }
}