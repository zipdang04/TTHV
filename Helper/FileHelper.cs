using System.Reflection;
using System.Text.Json;
using Avalonia.Shared.PlatformSupport;
using TTHV.MatchInformation.Exam;

namespace TTHV.Helper;

public class FileHelper
{
    private static FileHelper helper;
    private static string ASSEMBLY_NAME;
    private static readonly AssetLoader _assetLoader = new AssetLoader();
    private static string PREFIX_DIRECTORY = "avares://{0}/Assets/{1}";

    private FileHelper() {}
    public static void setAssembly(string assembly) {
        ASSEMBLY_NAME = assembly;
        PREFIX_DIRECTORY = $"avares://{assembly}/Assets/";
    }
    public static FileHelper getInstance() {
        if (ASSEMBLY_NAME == null)
            throw new Exception("Did not set assembly before run");
        if (helper == null)
            helper = new FileHelper();
        return helper;
    }

    private Uri getUri(string filename) {
        return new Uri(PREFIX_DIRECTORY + filename);
    }
    private Stream getStream(string filename) {
        return _assetLoader.Open(getUri(filename));
    }
    
    public WholeExam? getWholeExam(string filename) {
        try {
            string value = new StreamReader(getStream(filename)).ReadToEnd();
            return JsonSerializer.Deserialize<WholeExam>(value);
        }
        catch {
            return null;
        }
    }
}