using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TTHV.MatchInformation.Exam;
using TTHV.Server.ViewModels;
using TTHV.Server.ViewModels.ExamMaker.Component;
using TTHV.Server.Views.ExamMaker.Component;

namespace TTHV.Server.Views.ExamMaker.Controller;

public partial class AccelerationController : UserControl
{
    private ExamViewModel? _viewModel;
    public AccelerationController() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
        stackPanel = this.FindControl<StackPanel>("stackPanel");
        
        DataContextChanged += OnDataContextChanged;
    }

    private void OnDataContextChanged(object? sender, EventArgs e) {
        _viewModel = (ExamViewModel?)DataContext;
        updateExam();
    }

    private void updateExam() {
        var questions = _viewModel?.wholeExam.accelerate.questions;
        for (int i = 0; i < questions.Length; i++){
            stackPanel.Children.Add(
                new QuestionControl() {DataContext = new QuestionControlViewModel(questions[i], labelContent: $"Câu {i + 1}")}
            );
        }
    }
}