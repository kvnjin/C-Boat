public class BateauAMoteur : Bateau
{
    public BateauAMoteur(string nom, int maxPassengers) 
        : base(nom, maxPassengers)
    { 
    }

    public override void AddInventory()
    {
        Inventaire.Add(new Inventory("Moteur"));
        Inventaire.Add(new Inventory("Essence"));
        // Inventaire.Add(new Inventory("Ancre"));
    }

    public override void CheckInventory()
    {
        bool itemCheck = false;

        Console.WriteLine("Vérification de l'inventaire pour le bateau à voile...");
        foreach (var inventory in Inventaire)
        {
            Console.WriteLine($"{inventory.Name}: en stock");
            if (inventory.Name == "Ancre")
            {
                itemCheck = true;
            }
        }
         if (!itemCheck)
    {
        Console.WriteLine("Capitaine, nous avons perdu notre ancre en cours de route !");
    }
    }
 
}