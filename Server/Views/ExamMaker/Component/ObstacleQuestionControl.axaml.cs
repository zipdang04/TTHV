using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TTHV.Server.ViewModels.ExamMaker.Component;

namespace TTHV.Server.Views.ExamMaker.Component;

public partial class ObstacleQuestionControl : UserControl
{
    public ObstacleQuestionControl() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
    }
}