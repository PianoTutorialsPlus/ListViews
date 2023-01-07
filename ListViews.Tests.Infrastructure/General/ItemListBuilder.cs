using ListViews.Model.Contracts;
using ListViews.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure.General
{
    public class ItemListBuilder : TestDataBuilder<ItemList>
    {
        private List<IItem> _itemList;

        public ItemListBuilder() : this(new List<IItem>())
        {
        }

        public ItemListBuilder(List<IItem> itemList)
        {
            _itemList = itemList;
        }
        public ItemListBuilder WithItems(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                _itemList.Add((Item)An.Item);
            }

            return this;
        }

        public override ItemList Build()
        {
            return new ItemList(_itemList);
        }
    }
}
