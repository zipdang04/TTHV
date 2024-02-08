using System.Runtime.Serialization;

namespace TTHV.MatchInformation;

public static class Constant
{
    public const int PLAYERS = 4;

    // work as an enum
    public class Subject
    {
        private const int NUMBER_OF_SUBJECTS = 7;
        public static readonly Subject
            NAT_SCI = new Subject(0),
            SOC_SCI = new Subject(1),
            ART = new Subject(2),
            SPORT = new Subject(3),
            IT = new Subject(4),
            ENGLISH = new Subject(5),
            OTHERS = new Subject(6);
        private static readonly Subject[] ENUM_LIST = {
            NAT_SCI, SOC_SCI, ART, SPORT, IT, ENGLISH, OTHERS
        };
        private static readonly string[] SUBJECTS = {
            "Khoa học Tự nhiên",
            "Khoa học Xã hội",
            "Nghệ thuật",
            "Thể thao",
            "Công nghệ - Thông tin",
            "Tiếng Anh",
            "Lĩnh vực khác"
        };
        
        protected int code;
        public string value => SUBJECTS[code];

        private Subject(int code) {
            if (code is < 0 or >= NUMBER_OF_SUBJECTS)
                throw new Exception($"Enum error: code must be between 0 and {NUMBER_OF_SUBJECTS - 1}");
            this.code = code;
        }

        public static Subject? fromValue(string value) {
            for (int i = 0; i < NUMBER_OF_SUBJECTS; i++)
                if (value == SUBJECTS[i])
                    return ENUM_LIST[i];
            return null;
        }
    }
}