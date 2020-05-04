namespace WOIHelper.Services
{
    public class GemService
    {
        public int CalculateGemRequirement(int startingLevel, int targetLevel)
        {
            var amount = 1;

            for (var i = startingLevel; i < targetLevel; i++)
            {
                amount *= 5;
            }

            return amount;
        }

    }
}