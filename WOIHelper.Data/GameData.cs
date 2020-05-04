using System.Collections.Generic;
using WOIHelper.Data.Constants;

namespace WOIHelper.Data
{
    public class GameData
    {
        public static readonly Dictionary<string, int> ItemPrices = new Dictionary<string, int>
        {
            {GameConstants.LVL4, 1500},
            {GameConstants.LVL4_TALI, 175},
            {GameConstants.LVL5_TALI, 400},
            {GameConstants.EMBED_CHARM, 50},
            {GameConstants.DIVINE_GEM_POLISHER, 2500}
        };
    }
}