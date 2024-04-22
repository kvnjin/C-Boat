public class BateauAVoile : Bateau
{
    public BateauAVoile(string nom, int maxPassengers)
        : base(nom, maxPassengers) 
    {
    }

    public override void AddInventory()
    {
        Inventaire.Add(new Inventory("Voile"));
        Inventaire.Add(new Inventory("Cable"));
        Inventaire.Add(new Inventory("Ancre"));
    }

    public override void CheckInventory()
    {
        Console.WriteLine("Vérification de l'inventaire pour le bateau à voile...");
        foreach (var inventory in Inventaire)
        {
            Console.WriteLine($"{inventory.Name}: en stock");
        }
    }
}