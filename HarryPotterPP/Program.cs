using HarryPotterPP;

Spell[] magics = {
        new Spell("A feather is now flying!", "vingardium leviosa"),
        new Spell("Fireworks!", "hokus pokus"),
};

void Main()
{
    Wizard harry = new Wizard("Harry Potter", "Gryffindoor");
    Store magicShop = new Store(new List<string>() { "owl", "rat", "cat", "Phoenix Wand", "Unicorn Wand", "Troll Wand" });

    Console.WriteLine($"This is {harry.Name}, he is housed in {harry.House}. He has {harry.GetInventoryStr()}");

    while (true)
    {
        Console.WriteLine("1. Go to store");
        Console.WriteLine("2. Do magic");
        Console.WriteLine("3. View inventory");

        char input = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (input)
        {
            case '1':
                magicShop.BuyMenu(harry);
                break;
            case '2':
                doMagic(Console.ReadLine());
                break;
            case '3':
                Console.WriteLine(harry.GetInventoryStr());
                break;
        }
    }
}

void doMagic(string input)
{
    foreach (Spell m in magics)
    {
        if (input == m.Trigger)
        {
            Console.WriteLine(m.Action);
            return;
        }
    }

    Console.WriteLine("Nothing happens");
}

Main();















/* Du skal starte med å lage en harrypotter character klasse med egenskaper som navn, house, inventory (ex wand eller pet)

Få applikasjonen til å printe ut en introduksjon for karakteren, som sier noe om hva de heter, hvilket hus de er medlem av og hvilke items de har

Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:  ugle,rotte eller en katt. De har også mulighet til å kjøpe en tryllestav: 
føniksstav, unikornstav eller trollstav. For å få til dette må du lage en egen klasse som er butikken, og presentere brukeren med en meny for hva personen skal kjøpe.

Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
trylleformler: 
vingardium leviosa (får en fjær til å fly)
hokus pokus (fyrer av fyrverkerier) */
