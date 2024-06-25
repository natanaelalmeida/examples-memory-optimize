namespace ConsoleApp1;

/// <summary>
/// https://andresantarosa.medium.com/heap-stack-e-garbage-collector-a-practical-guide-to-net-memory-management-system-7e60bbadf199
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#88-unmanaged-types
/// 
/// </summary>

public struct PersonStruct {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public PersonStruct(string firstName, string lastName, int age) {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class PersonClass {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public PersonClass(string firstName, string lastName, int age) {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class ObjectInHeapVsStack {
    public static void Inefficient(double iterations) {
        var list = new List<PersonClass>();
        for (var i = 0; i < iterations; i++) {
            var person = new PersonClass("Natanael", "Almeida", 29);
            list.Add(person);
        }
    }
    
    public static void Efficient(double iterations) {
        var list = new List<PersonStruct>((int)iterations);
        for (var i = 0; i < iterations; i++) {
            var personCopy = new PersonStruct("Natanael", "Almeida", 29);
            list.Add(personCopy);
        }
    }
}