using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using Avalonia;
using Avalonia.Platform;
using Avalonia.Shared.PlatformSupport;
using TTHV.MatchInformation.Exam;

namespace TTHV.Server.ViewModels.ExamMaker;

public class ExamMakerWindowViewModel : ViewModelBase
{
    public WholeExam wholeExam { set; get; }

    public ExamMakerWindowViewModel() {
        var assetLoader = AvaloniaLocator.Current.GetService<IAssetLoader>();
        try {
            var fs = new StreamReader(assetLoader.Open(new Uri(@"avares://Server/Assets/Exam/OExam.json")));
            string value = fs.ReadToEnd();
            wholeExam = JsonSerializer.Deserialize<WholeExam>(value);
        }
        catch {
            wholeExam = new WholeExam();
        }
    }
}