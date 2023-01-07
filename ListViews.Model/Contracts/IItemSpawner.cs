using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Model.Contracts
{
    public interface IItemSpawner
    {
        IItemList SpawnItem(IItemList itemList);
        List<IItemList> SpawnList(List<IItemList> itemCollectionList);
    }
}
