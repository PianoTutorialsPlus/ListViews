using ListViews.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Model.UI
{
    public class ListScreenModel
    {
        private IItemSpawner _itemSpawner;
        private List<IItem> _itemList;
        private List<List<IItem>> _itemCollectionList; 

        public event Action<List<object>> OnRefreshedItemList;

        public ListScreenModel(
            IItemSpawner itemSpawner, 
            List<List<IItem>> itemCollectionList)
        {
            _itemSpawner = itemSpawner;
            _itemCollectionList = itemCollectionList;
            _itemList = itemCollectionList[0];
        }

        public void AddItem()
        {
            _itemList = _itemSpawner.Spawn(_itemList);

            AddItemNamesFromList();
        }

        public void DeleteItem(int itemIndex)
        {
            if(itemIndex < 0 || _itemList.Count < itemIndex)
                throw new ArgumentOutOfRangeException("index");

            _itemList.RemoveAt(itemIndex);
            AddItemNamesFromList();
        }

        private void AddItemNamesFromList()
        {
            List<object> itemNames = new List<object>();
            
            foreach (IItem itemName in _itemList)
            {
                itemNames.Add(itemName.Name);
            }

            OnRefreshedItemList?.Invoke(itemNames);
        }
    }
}
