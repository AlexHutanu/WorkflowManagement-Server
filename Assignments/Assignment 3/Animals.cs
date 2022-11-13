namespace Assignments.Assignment_3;

public abstract class Animals
{
    private  int _noOfLegs;

    private bool _canFly;

    public int NoOfLegs
    {
        get => _noOfLegs;
        set => _noOfLegs = value;
    }

    public bool CanFly
    {
        get => _canFly;
        set => _canFly = value;
    }
    
    public abstract void MakeSound();

}

public class Tiger : Animals
{

    public override void MakeSound()
    {
        Console.WriteLine("Roar");
    }

}
