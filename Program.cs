using RPGDIO.src.entities;

class Program
{
    static void Main(string[] args)
    {   
       Knight arus = new Knight("Arus", 23, "Knight");
       Wizard lana = new Wizard("Lana", 18, "Black Wizard");
        
        Console.Write(arus.Attack());
        Console.Write(lana.Attack(1));
    }
}
