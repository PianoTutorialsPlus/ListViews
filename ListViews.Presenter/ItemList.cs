using ListViews.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Presenter
{
    public class ItemList : IItemList
    {
		private List<IItem> _itemList;
        public string Name { get; set; }

        public ItemList(List<IItem> itemList)
        {
            _itemList = itemList;
        }

        public ItemList() : this(new List<IItem>())
        {
        }

        public List<IItem> Items
		{
			get { return _itemList; }
			set { _itemList = value; }
		}
	}
}
