using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using TTHV.Helper;
using TTHV.Server.ViewModels;
using TTHV.Server.Views;

namespace TTHV.Server;

public partial class App : Application
{
    public override void Initialize() {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted() {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            desktop.MainWindow = new MainWindow {
                DataContext = new MainWindowViewModel(),
            };
            FileHelper.setAssembly("Server");
        }

        base.OnFrameworkInitializationCompleted();
    }
}