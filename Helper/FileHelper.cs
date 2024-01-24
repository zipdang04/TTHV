using System.Net.Mime;
using System.Reflection;
using System.Text.Json;
using Avalonia;
using Avalonia.Shared.PlatformSupport;
using TTHV.MatchInformation.Exam;

namespace TTHV.Helper;

public static class FileHelper
{
    private static readonly AssetLoader _assetLoader = new AssetLoader();
    // private static string PREFIX_DIRECTORY = "avares://{0}/Assets/{1}";

    private static string getFullPath(string filename) {
        return $"Resources/{filename}";
    }
    private static Stream getStream(string filename) {
        return new FileStream(getFullPath(filename), FileMode.Open);
    }
    public static WholeExam? getWholeExam(string filename) {
        try {
            string value = new StreamReader(getStream(filename)).ReadToEnd();
            return JsonSerializer.Deserialize<WholeExam>(value);
        }
        catch {
            return null;
        }
    }

    public static async void saveExam(string filename, WholeExam wholeExam) {
        await using var stream = getStream(filename);
        await JsonSerializer.SerializeAsync(stream, wholeExam);
    }
}