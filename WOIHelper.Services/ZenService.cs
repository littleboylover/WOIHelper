using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOIHelper.Data;

namespace WOIHelper.Services
{
    public class ZenService
    {
        public int CalculateZenRequirement(int gemAmount, string gemLevel)
        {
            var gemKey = $"LVL{gemLevel}";

            if (!GameData.ItemPrices.ContainsKey(gemKey))
            {
                return -1;
            }

            var gemPrice = GameData.ItemPrices[gemKey] * gemAmount;

            return gemPrice;
        }
    }
}
