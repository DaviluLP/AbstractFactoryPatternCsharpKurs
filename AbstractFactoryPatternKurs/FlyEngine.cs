namespace AbstractFactoryPatternKurs;

public class FlyEngine : Engine
{
    public FlyEngine()
    {
        Console.WriteLine("Die FlyEngine wurde erstellt!");
    }
    
    public override void RevCounter()
    {
        Console.WriteLine("Die Drehzahl beträgt 300 Umdrehungen/Minute!");
    }
}