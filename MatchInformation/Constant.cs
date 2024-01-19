using System.Runtime.Serialization;

namespace TTHV.MatchInformation;

public static class Constant
{
    public const int PLAYERS = 4;

    public enum Subject
    {
        [EnumMember(Value = "Khoa học tự nhiên")]
        NAT_SCI,
        [EnumMember(Value = "Khoa học xã hội")]
        SOC_SCI,
        [EnumMember(Value = "Nghệ thuật")]
        ART,
        [EnumMember(Value = "Thể thao")]
        SPORT,
        [EnumMember(Value = "Công nghệ Thông tin")]
        IT,
        [EnumMember(Value = "Tiếng Anh")]
        ENGLISH,
        [EnumMember(Value = "Lĩnh vực khác")]
        OTHERS
    }
}
public static class SubjectExtension
{
    public static Constant.Subject? toSubject(this string str) {
        var enumType = typeof(Constant.Subject);
        foreach (var name in Enum.GetNames(enumType))
        {
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
            if (enumMemberAttribute.Value == str) return (Constant.Subject)Enum.Parse(enumType, name);
        }
        return null;
    }

    public static string getValue(this Constant.Subject subject) {
        var enumType = typeof(Constant.Subject);
        return ((EnumMemberAttribute[])enumType.GetField(subject.ToString()).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single().Value;
    }
}