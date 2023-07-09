using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyFactory
{
    public  class Factory
    {

        List<FactoryList> factoryLists = new List<FactoryList>();
        int factoryListCount;

        public Factory()
        {
            this.factoryLists = new List<FactoryList>();
            this.factoryListCount = 0;
        }

        public void AddList()
        {
            FactoryList list = new FactoryList(factoryListCount);
            factoryLists.Add(list);
            factoryListCount++;
            //update event
        }

        public void RemoveList(int ID)
        {
            foreach(FactoryList list in factoryLists)
            {
                if(list.ListID == ID)
                {
                    factoryLists.Remove(list);
                    //update event
                }
            }
        }

    }
}
