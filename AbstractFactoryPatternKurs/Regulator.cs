namespace AbstractFactoryPatternKurs;

public abstract class Regulator
{
    //Eigenschaften
    public double CurrentVoltage { get; set; }
    public double CurrentCurrent { get; set; }
    
    //Methoden
    public abstract void IncreaseVoltage();
}