namespace AbstractFactoryPatternKurs;

public abstract class Engine
{
    //Eigenschaften
    public double EngineSpeed { get; set; }
    
    //Methoden
    public abstract void RevCounter();
}