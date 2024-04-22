using System;
using System.Collections.Generic;

public abstract class Bateau
{
    public string Nom { get; private set; }
    public int MaxPassengers { get; private set; }
    public List<Inventory> Inventaire { get; protected set; }
    public List<Passenger> Passengers { get; private set; }

    public Bateau(string nom, int maxPassengers)
    {
        Nom = nom;
        MaxPassengers = maxPassengers;
        Inventaire = new List<Inventory>();
        Passengers = new List<Passenger>();
    }

    public static Bateau ChoisirBateau()
    {
        Console.WriteLine("Choisissez un type de bateau (1: Voile, 2: Moteur):");
        string choix = Console.ReadLine();
        switch (choix)
        {
            case "1":
                return new BateauAVoile("Voilier", 3);
            case "2":
                return new BateauAMoteur("Bateau à moteur", 5);
            default:
                Console.WriteLine("Choix invalide.");
            return null;
        }
    }

    public void AddPassenger(Passenger passenger)
    {
        Passengers.Add(passenger);
        Console.WriteLine($"Passager {passenger.Nom} ajouté.");
        return;
    }

    public void StartEngine()
    {
        if (Passengers.Count > MaxPassengers)
        {
            Console.WriteLine("Il y a une surchage de passager a bord du bateau, le bateau est dans l'incapacité de démarrer.");
        }
        else
        {
            Console.WriteLine("Tuuut Tuuuuut, le bateau quitte le port");
        }
    }

    public abstract void AddInventory();
    public abstract void CheckInventory();
}