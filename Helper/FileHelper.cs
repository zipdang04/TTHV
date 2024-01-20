using System.Reflection;
using System.Text.Json;
using Avalonia.Shared.PlatformSupport;
using TTHV.MatchInformation.Exam;

namespace TTHV.Helper;

public static class FileHelper
{
    private static string ASSEMBLY_NAME = Assembly.GetExecutingAssembly().GetName().Name;
    private static AssetLoader assetLoader = new AssetLoader();
    private static string PREFIX_DIRECTORY = $@"avares://{ASSEMBLY_NAME}/Assets/";

    public static Uri getUri(string filename) {
        return new Uri(PREFIX_DIRECTORY + filename);
    }
    private static Stream getStream(string filename) {
        return assetLoader.Open(getUri(filename));
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
}