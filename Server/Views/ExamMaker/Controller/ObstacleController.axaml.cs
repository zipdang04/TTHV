using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TTHV.Server.ViewModels;
using TTHV.Server.ViewModels.ExamMaker.Component;
using TTHV.Server.Views.ExamMaker.Component;

namespace TTHV.Server.Views.ExamMaker.Controller;

public partial class ObstacleController : UserControl
{
    private ExamViewModel _viewModel;
    public ObstacleController() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
        DataContextChanged += OnDataContextChanged;
        stackPanel = this.FindControl<StackPanel>("stackPanel");
    }

    private void OnDataContextChanged(object? sender, EventArgs e) {
        _viewModel = (ExamViewModel)DataContext;
        updateExam();
    }

    private void updateExam() {
        var obstacle = _viewModel.wholeExam.obstacle;
        stackPanel.Children.Clear();
        for (var i = 0; i < obstacle.questions.Length; i++){
            stackPanel.Children.Add(
                new ObstacleQuestionControl() {
                    DataContext = new ObstacleQuestionControlViewModel(obstacle.questions[i], i)
                }
            );
        }
    }
}