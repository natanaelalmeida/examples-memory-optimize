using System.Collections;

namespace ConsoleApp1;

/// <summary>
/// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
/// https://www.jetbrains.com/help/rider/Fixing_Issues_Found_by_DPA.html#boxing
/// </summary>
public class AvoidingBoxingUnboxing {
    public static void InefficientSumNumbers(ArrayList collection) {
        var sum = 0;
        foreach (var item in collection) {
            sum += (int) item;
        }
    }
    
    public static void InefficientSumNumbers2(List<object> collection) {
        var sum = 0;
        foreach (var item in collection) {
            sum += (int) item;
        }
    }
    
    public static void EfficientSumNumbers(List<int> collection) {
        var sum = 0;
        foreach (var item in collection) {
            sum += item;
        }
    }
}