namespace AbstractFactoryPatternKurs;

public abstract class QuadrocopterFactory
{
    //Methoden
    public abstract Engine CreateEngine();
    public abstract Regulator CreateRegulator();
}