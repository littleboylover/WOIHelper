namespace WOIHelper.Data.Models
{
    public class Requirement : Item
    {
        public int Amount { get; set; }

        public bool IsGathered { get; set; }

        public Requirement(string name, int amount, bool isGathered = false)
        {
            Name = name;
            Amount = amount;
            IsGathered = isGathered;
        }
    }
}