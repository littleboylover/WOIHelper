namespace WOIHelper.Data.Models
{
    public class Stardust : Item
    {
        public Requirement[] Requirements { get; set; }

        public Stardust(string name, Requirement[] requirements)
        {
            Name = name;
            Requirements = requirements;
        }
    }
}