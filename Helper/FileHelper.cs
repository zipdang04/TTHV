using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using TTHV.MatchInformation.Exam;

namespace TTHV.Helper;

public static class FileHelper
{
    private static string getFullPath(string filename) {
        return $"{Constant.PREFIX_DIRECTORY}{filename}";
    }
    private static Stream getStream(string filename) {
        return new FileStream(getFullPath(filename), FileMode.OpenOrCreate);
    }
    public static WholeExam? getWholeExam(string filename) {
        try {
            var value = File.ReadAllText(getFullPath(filename), Encoding.Unicode);
            return JsonConvert.DeserializeObject<WholeExam>(value);
        }
        catch {
            return null;
        }
    }

    public static async void saveExam(string filename, WholeExam wholeExam) {
        await using var stream = getStream(filename);
        stream.SetLength(0); await stream.FlushAsync();
        
        var value = JsonConvert.SerializeObject(wholeExam);
        var unicode = new UnicodeEncoding();
        var result = unicode.GetBytes(value);
        await stream.WriteAsync(result);
    }

    public static async void readExamFromExcel(string filename) {
        await using var stream = getStream(filename);
        SpreadsheetDocument spreadsheet = SpreadsheetDocument.Open(getFullPath(filename), false);
        SheetData sheetData = spreadsheet.WorkbookPart.WorksheetParts.First().Worksheet.Elements<SheetData>().First();
    }
}