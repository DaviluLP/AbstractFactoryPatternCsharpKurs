namespace AbstractFactoryPatternKurs;

public class ControllerBoard
{
    //Eigenschaften
    public Regulator MyRegulator { get; set; }
    public Engine MyEngine { get; set; }
    public QuadrocopterFactory UsedFactory { get; set; }
    
    public ControllerBoard(QuadrocopterFactory usedFactory)
    {
        UsedFactory = usedFactory;

        CreateParts();
    }

    public void CreateParts()
    {
        MyRegulator = UsedFactory.CreateRegulator();
        MyEngine = UsedFactory.CreateEngine();
    }
}