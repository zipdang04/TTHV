using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TTHV.Server.ViewModels.ExamMaker.Component;

namespace TTHV.Server.Views.ExamMaker.Component;

public partial class ObstacleQuestionControl : UserControl
{
    private ObstacleQuestionControlViewModel _viewModel;
    public ObstacleQuestionControl() {
        InitializeComponent();
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
        cbxTopic = this.FindControl<ComboBox>("cbxTopic");

        DataContextChanged += OnDataContextChanged;
    }

    private void OnDataContextChanged(object? sender, EventArgs e) {
        _viewModel = (ObstacleQuestionControlViewModel)DataContext;

        // for (var i = 0; i < _viewModel.ALL_TOPICS.Length; i++)
        //     if (_viewModel.ALL_TOPICS[i] == _viewModel.topic)
        //         cbxTopic.SelectedIndex = i;
    }
}