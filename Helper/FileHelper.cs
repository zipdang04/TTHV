using System.Text.Json;
using TTHV.MatchInformation.Exam;

namespace TTHV.Helper;

public static class FileHelper
{
    private static string getFullPath(string filename) {
        return $"{Constant.PREFIX_DIRECTORY}{filename}";
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