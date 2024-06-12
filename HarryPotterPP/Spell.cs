namespace HarryPotterPP
{
    internal class Spell
    {
        private string _action;
        private string _trigger;

        public string Action => _action;
        public string Trigger => _trigger;

        public Spell(string action, string trigger)
        {
            _action = action;
            _trigger = trigger;
        }
    }
}
