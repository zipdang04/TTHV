using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using TTHV.Server.ViewModels;
using TTHV.Server.Views.ExamMaker.Controller;

namespace TTHV.Server.Views.ExamMaker;

public partial class ExamMakerWindow : Window
{
    private ExamViewModel? viewModel;

    public ExamMakerWindow() {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent() {
        AvaloniaXamlLoader.Load(this);
        
        btnSave = this.FindControl<Button>("btnSave");
        btnExcel = this.FindControl<Button>("btnExcel");
        
        DataContextChanged += OnDataContextChanged;
    }
    
    private void OnDataContextChanged(object? sender, EventArgs e) {
        viewModel = (ExamViewModel)DataContext;
    }

    private void btnExcel_OnClick(object? sender, RoutedEventArgs e) {
        viewModel?.importFromExcel();
    }

    private void btnSave_OnClick(object? sender, RoutedEventArgs e) {
        viewModel?.saveExam();
    }
}