using Microsoft.Extensions.ObjectPool;

namespace ConsoleApp1;

/// <summary>
/// https://learn.microsoft.com/en-us/aspnet/core/performance/objectpool?view=aspnetcore-8.0
/// </summary>

public class Connection {
}

public class InefficientConnectionManager {
    public Connection GetConnection() => new Connection();
}

public class EfficientConnectionManager {
    private readonly ObjectPool<Connection> _pool = 
        new DefaultObjectPool<Connection>(new DefaultPooledObjectPolicy<Connection>(), Environment.ProcessorCount * 2);
    
    public Connection GetConnection() => _pool.Get();
    public void ReturnConnection(Connection connection) => _pool.Return(connection);
}

public class MinimizingAllocations {
    public static void Inefficient(double traffic) {
        var manager = new InefficientConnectionManager();
        for (var i = 0; i < traffic; i++) {
            var connection = manager.GetConnection();
        }
    }
    
    public static void Efficient(double traffic) {
        var manager = new EfficientConnectionManager();
        for (var i = 0; i < traffic; i++) {
            var connection = manager.GetConnection();
            manager.ReturnConnection(connection);
        }
    }
}