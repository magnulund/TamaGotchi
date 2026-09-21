

Tamagotchi pet = new Tamagotchi();
while (true)
{
    Console.WriteLine("What would you like to name your gochi");
    pet.start();

    while (true)
    {  
        Console.WriteLine("What would you like to do");
        Console.WriteLine("""
        1. Printstats:
        2. Feed:
        3. Hi:
        4. Do nothing: 
        5. Teach:
        """);
        string choice = Console.ReadLine();
        int choiceInt;
        while (!int.TryParse(choice, out choiceInt)|| choiceInt < 1 && choiceInt > 5)
        {
        Console.WriteLine("What would you like to do");
        Console.WriteLine("""
        1. Printstats:
        2. Feed:
        3. Hi:
        4. Do nothing: 
        5. Teach:
        """);
        choice = Console.ReadLine();
        }
        if (choiceInt == 1)
        {
            pet.PrintStats();
        }
        if (choiceInt == 2)
        {
            pet.Feed();
        }
        if (choiceInt == 3)
        {
            pet.Hi();
        }
        if (choiceInt == 4)
        {
            pet.Tick();
        }
        if (choiceInt == 5)
        {
            Console.WriteLine($"What would you like to teach {pet._name}");
            pet.Teach(Console.ReadLine());
        }
        
        Console.WriteLine("Press space to continue");
        while (true)
        {
            if(Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                break;
            }
        }
        if (pet.GetAlive() == false)
        {
            Console.WriteLine("Your");
            break;
        }
    
    }
}

