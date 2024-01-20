using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using TTHV.Server.Views.ExamMaker;

namespace TTHV.Server.Views;

public partial class MainWindow : Window
{
    public MainWindow() {
        InitializeComponent();
    }

    private void btnExamMaker_OnClick(object? sender, RoutedEventArgs e) {
        ExamMakerWindow examMakerWindow = new ExamMakerWindow();
        examMakerWindow.Closed += (o, args) => {
            try {
                this.Show();
            }
            catch {
                this.Close();
            }
        };
        
        examMakerWindow.Show();
        Hide();
    }
}