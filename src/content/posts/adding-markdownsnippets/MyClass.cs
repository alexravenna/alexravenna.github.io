namespace MyNamespace;

public class MyClass {
    public string Name => _name;
    private readonly string _name;

    public MyClass(string name) {
        _name = name;
    }
}