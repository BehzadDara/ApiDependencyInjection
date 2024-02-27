namespace ApiDependencyInjection;

public class MyClass : IMyClass
{
    private readonly int _MyProperty;

    public MyClass()
    {
        var random = new Random();
        _MyProperty = random.Next(1000000, 10000000);
    }

    public int GetMyProperty()
    {
        return _MyProperty;
    }
}
