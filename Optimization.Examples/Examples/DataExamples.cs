using System.Collections;

namespace ConsoleApp1;

public static class DataExamples {
    public static readonly double CountData = 10e8;
    
    public static ArrayList CreateInefficientCollection() {
        var list = new ArrayList((int) CountData);
        for (var i = 0; i < CountData; i++) {
            list.Add(i);
        }

        return list;
    }
    
    public static List<object> CreateInefficientCollection2() {
        var list = new List<object>((int) CountData);
        for (var i = 0; i < CountData; i++) {
            list.Add(i);
        }

        return list;
    }
    
    public static List<int> CreateEfficientCollection() {
        var list = new List<int>((int)CountData);
        for (var i = 0; i < CountData; i++) {
            list.Add(i);
        }

        return list;
    }
    
    public static IEnumerable<string> CreateNames() {
        var names = new List<string>((int) CountData);
        for (var i = 0; i < 10e6; i++) {
            names.Add(i.ToString());
        }
        
        return names;
    }
}