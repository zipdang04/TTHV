using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TTHV.Helper;
using TTHV.MatchInformation.Exam;
using TTHV.Server.ViewModels;
using TTHV.Server.ViewModels.ExamMaker.Component;
using TTHV.Server.Views.ExamMaker.Component;
using Constant = TTHV.MatchInformation.Constant;

namespace TTHV.Server.Views.ExamMaker.Controller;

public partial class FinishController : UserControl
{
    private StackPanel[] _stacks;
    private ExamViewModel? _viewModel;
    public FinishController() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
        _stacks = new[] {
            this.FindControl<StackPanel>("stack1"),
            this.FindControl<StackPanel>("stack2"),
            this.FindControl<StackPanel>("stack3"),
            this.FindControl<StackPanel>("stack4")
        };
        
        DataContextChanged += OnDataContextChanged;
    }

    private void OnDataContextChanged(object? sender, EventArgs e) {
        _viewModel = (ExamViewModel?)DataContext;

        updateExam();
    }

    private void updateExam() {
        var finish = _viewModel?.wholeExam.finish;
        if (finish == null) return;
        for (var player = 0; player < Constant.PLAYERS; player++) {
            for (var type = 0; type < Finish.TYPE_COUNT; type++) {
                for (var i = 0; i < Finish.QUESTION_COUNT; i++) {
                    _stacks[player].Children.Add(
                        new QuestionControl() {
                            DataContext = new QuestionControlViewModel(
                                finish.questions[player][type][i], labelContent: $"Câu {Finish.Q_TYPES[type]} điểm - {i + 1}"
                            )
                        }
                    );
                }
            }
        }
    }
}