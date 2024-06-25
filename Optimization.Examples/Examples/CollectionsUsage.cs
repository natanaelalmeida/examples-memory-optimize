using System.Collections;

namespace ConsoleApp1;
/// <summary>
/// https://www.jetbrains.com/help/rider/Fixing_Issues_Found_by_DPA.html#enumerating-collections
/// https://www.jetbrains.com/help/rider/Fixing_Issues_Found_by_DPA.html#resizing-collections
/// </summary>
public class CollectionsUsage {

    public static void InefficientProcessData(ArrayList collection) {
        foreach (var item in collection) {
            int value = (int) item;
        }
    }
    
    public static void InefficientProcessData2(List<object> collection) {
        foreach (var item in collection) {
            int value = (int) item;
        }
    }

    public static void EfficientProcessData(List<int> collection) {
        foreach (var item in collection) {
            int value = item;
        }
    }
}