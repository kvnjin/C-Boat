public class Passenger
{
    public string Nom { get; private set; }
    public int Age { get; private set; }

    public Passenger(string nom, int age) 
    {
        Nom = nom;
        Age = age;
    }
}