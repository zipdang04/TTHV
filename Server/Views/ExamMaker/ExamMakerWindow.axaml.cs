using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace TTHV.Server.Views.ExamMaker;

public partial class ExamMakerWindow : Window
{
    public ExamMakerWindow() {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
    }

    private void btnExcel_OnClick(object? sender, RoutedEventArgs e) {
        // TODO: import from excel
    }
}