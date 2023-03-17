namespace ConsoleApp1;

public class Car<TEngine>
{
    private TEngine engine;

    public Car(TEngine engine)
    {
        this.engine = engine;
    }
    
    public string GetEngine()
    {
        return engine.ToString();
    }
}