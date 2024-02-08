using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TTHV.MatchInformation.Exam;
using TTHV.Server.ViewModels;
using TTHV.Server.ViewModels.ExamMaker.Component;
using TTHV.Server.Views.ExamMaker.Component;

namespace TTHV.Server.Views.ExamMaker.Controller;

public partial class WarmUpConfrontController : UserControl
{
    private ExamViewModel viewModel;
    
    public WarmUpConfrontController() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
        stackPanel = this.FindControl<StackPanel>("stackPanel");
        
        DataContextChanged += OnDataContextChanged;
    }

    private void OnDataContextChanged(object? sender, EventArgs e) {
        viewModel = (ExamViewModel)DataContext;
        updateExam();
    }

    private void updateExam() {
        var warmUpConfront = viewModel.wholeExam.warmUpConfront;
        stackPanel.Children.Clear();
        foreach (Question question in warmUpConfront.questions)
            stackPanel.Children.Add(
                new QuestionControl() {DataContext = new QuestionControlViewModel(question)}
            );
    }
}