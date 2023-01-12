using ListViews.Model.Contracts;
using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Presenter.Factories
{
    public class ItemSpawner : IItemSpawner
    {
        public IItemList SpawnItem(IItemList itemList)
        {
            itemList?.Items.Add(new Item()
            { 
                Name = "item " + (itemList.Items.Count + 1) 
            });

            return itemList;
        }

        public List<IItemList> SpawnList(List<IItemList> itemCollectionList)
        {
            itemCollectionList?.Add(new ItemList() 
            { 
                Name = "List" + (itemCollectionList.Count + 1),
                Items = new List<IItem>()
            });
            return itemCollectionList;
        }
    }
}
