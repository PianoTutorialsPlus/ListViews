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

        public ListScreenModel(IItemSpawner itemSpawner)
        {
            _itemSpawner = itemSpawner;


            _itemList = new List<IItem>();
        }

        public void AddItem()
        {
            _itemSpawner.Spawn(_itemList);
        }
    }
}
