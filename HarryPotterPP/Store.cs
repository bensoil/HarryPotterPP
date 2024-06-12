namespace HarryPotterPP
{
    internal class Store
    {
        List<string> _items;

        public Store(List<string> items)
        {
            _items = items;
        }

        public void BuyMenu(Wizard wizard)
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                Console.WriteLine($"{i}. {_items[i]}");
            }
            Console.WriteLine();

            int input = Console.ReadKey().KeyChar - '0';
            Console.WriteLine();

            if (input < 0 || input >= _items.Count())
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string item = _items[input];
            _items.RemoveAt(input);
            wizard.AddItem(item);

						Console.WriteLine(wizard.GetInventoryStr());
        }
    }
}
