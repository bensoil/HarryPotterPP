namespace HarryPotterPP
{
    internal class Wizard
    {
        string _name;
        string _house;
        List<string> _inventory;

        public string Name => _name;
        public string House => _house;


        public string GetInventoryStr()
        {
            if (_inventory.Count() == 0)
            {
                return "nothing";
            }

            return string.Join(",", _inventory.ToArray());
        }

        public void AddItem(string item)
        {
            _inventory.Add(item);
        }

        public Wizard(string name, string house)
        {
            _name = name;
            _house = house;
            _inventory = new List<string>();
        }
    }
}
