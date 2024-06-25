using System.Text;

namespace ConsoleApp1;

/// <summary>
/// https://www.jetbrains.com/help/rider/Fixing_Issues_Found_by_DPA.html#changing-string-contents
/// https://learn.microsoft.com/en-us/dotnet/standard/base-types/stringbuilder
/// </summary>
public class StringHandling {
    public static string InefficientCombineNames(IEnumerable<string> names) {
        var result = "";
        foreach (var name in names) {
            result += name + ", ";
        }

        return result.TrimEnd(',', ' ');
    }
    
    public static string EfficientCombineNames(IEnumerable<string> names) {
        var sb = new StringBuilder();
        foreach (var name in names) {
            sb.Append(name).Append(", ");
        }
        
        return sb.ToString().TrimEnd(',', ' ');
    }
}