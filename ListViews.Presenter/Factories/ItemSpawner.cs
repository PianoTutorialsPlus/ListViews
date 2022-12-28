using ListViews.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Presenter.Factories
{
    public class ItemSpawner : IItemSpawner
    {
        public List<IItem> Spawn(List<IItem> itemList)
        {
            itemList.Add(new Item() as IItem);

            return itemList;
        }
    }
}
