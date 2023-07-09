using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyFactory
{
    internal class FactoryList
    {
        public int ListID { get; set; }
        private List<HobbyItem> hobbyItems;
        private int idCount { get; set; }

        public FactoryList(int ID)
        {
            this.ListID = ID;
            this.idCount = 0;
            this.hobbyItems = new List<HobbyItem>();
        }

        public void AddItem(string itemName, float itemCost, bool acquired, string currencySymbol, string linkToPurchase)
        {
            HobbyItem item = new HobbyItem(itemName, idCount, itemCost, acquired, currencySymbol, linkToPurchase);
            hobbyItems.Add(item);
            idCount++;
            //send update event
        }

        public void RemoveItem(int ID)
        {
            foreach (HobbyItem item in hobbyItems)
            {
                if (item.itemID == ID)
                {
                    hobbyItems.Remove(item);
                    //send update event
                }
            }
        }

    }
}
