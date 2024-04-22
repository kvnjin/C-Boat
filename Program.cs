Console.WriteLine("Bienvenue dans notre service de location");
Bateau bateau = Bateau.ChoisirBateau();
        if (bateau != null)
        {
            Console.WriteLine($"Vous avez choisi un {bateau.Nom} qui possède {bateau.MaxPassengers} places.");
            bateau.AddPassenger(new Passenger("Tom", 15));
            bateau.AddPassenger(new Passenger("Tomas", 20));
            bateau.AddPassenger(new Passenger("Timae", 22));
            // bateau.AddPassenger(new Passenger("Toto", 21));
            // bateau.AddPassenger(new Passenger("Trao", 30));

            bateau.StartEngine();
            bateau.AddInventory();
            bateau.CheckInventory();
        } else
        {
            Console.WriteLine($"Vous avez choisi aucun bateau.");
        }
