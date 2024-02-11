using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TTHV.MatchInformation;
using TTHV.MatchInformation.Exam;
using TTHV.Server.ViewModels;
using TTHV.Server.ViewModels.ExamMaker.Component;
using TTHV.Server.Views.ExamMaker.Component;

namespace TTHV.Server.Views.ExamMaker.Controller;

public partial class WarmUpRelayController : UserControl
{
    private ExamViewModel? _viewModel;

    private StackPanel[]? _questionStack;
    public WarmUpRelayController() {
        InitializeComponent();
        DataContextChanged += OnDataContextChanged;
        
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
        stackP1 = this.FindControl<StackPanel>("stackP1");
        stackP2 = this.FindControl<StackPanel>("stackP2");
        stackP3 = this.FindControl<StackPanel>("stackP3");
        stackP4 = this.FindControl<StackPanel>("stackP4");
        
        _questionStack = new[] {
            stackP1,
            stackP2,
            stackP3,
            stackP4
        };
    }
    
    private void OnDataContextChanged(object? sender, EventArgs e) {
        _viewModel = (ExamViewModel?)DataContext;
        updateExam();
    }

    private void updateExam() {  
        var wholeExam = _viewModel.wholeExam;
        for (int player = 0; player < Constant.PLAYERS; player++) {
            if (_questionStack[player] == null) continue;
            _questionStack[player].Children.Clear();
            foreach (Question question in wholeExam.warmUpRelay.questions[player])
                _questionStack[player].Children.Add(
                    new QuestionControl() { DataContext = new QuestionControlViewModel(question, true) }
                );
        }
    }
}