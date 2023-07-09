using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyFactory
{
    public class HobbyItem
    {

        public string itemName { get; set; }
        public int itemID { get; set; }
        public float itemCost { get; set; }
        public bool acquired { get; set; }
        public string currencySymbol { get; set; }
        public string linkToPurchase { get; set; }

        public HobbyItem(string itemName, int itemID, float itemCost, bool acquired, string currencySymbol, string linkToPurchase)
        {
            this.itemName = itemName;
            this.itemID = itemID;
            this.itemCost = itemCost;
            this.acquired = acquired;
            this.currencySymbol = currencySymbol;
            this.linkToPurchase = linkToPurchase;
        }
    }

}
