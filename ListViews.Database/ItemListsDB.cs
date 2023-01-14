using ListViews.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Database.UI
{
    [Serializable]
    public class ItemListsDB
    {
        public List<IItemList> ItemListCollection { get; set; }
    }
}
