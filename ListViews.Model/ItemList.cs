using ListViews.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Model
{
    [Serializable]
    public class ItemList : IItemList
    {
        public int ItemListID { get; set; }
        public string Name { get; set; }
        public List<IItem> Items { get; set; }
    }
}
