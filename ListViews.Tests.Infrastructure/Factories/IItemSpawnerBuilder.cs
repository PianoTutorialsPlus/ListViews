using ListViews.Model;
using ListViews.Model.Contracts;
using ListViews.Service.Contracts;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure.Factories
{
    public class IItemSpawnerBuilder : TestDataBuilder<IItemsRepository>
    {
        private ItemList _itemList;
        private List<IItemList> _itemCollection;

        public IItemSpawnerBuilder() : this(An.ItemList, new List<IItemList>())
        {
        }

        public IItemSpawnerBuilder(ItemList itemList, List<IItemList> itemCollection)
        {
            _itemList = itemList;
            _itemCollection = itemCollection;
        }

        public IItemSpawnerBuilder WithItemlist(ItemList itemList)
        {
            _itemList = itemList;

            return this;
        }
        public IItemSpawnerBuilder WithItemListCollection(List<IItemList> itemCollection)
        {
            _itemCollection = itemCollection;
            return this;
        }

        public override IItemsRepository Build()
        {
            var itemSpawner = Substitute.For<IItemsRepository>();

            itemSpawner.When(x => x.AddItem())
                .Do(Callback.Always(x => _itemList.Items.Add((Item)An.Item)));

            //itemSpawner.AddItem(Arg.Any<ItemList>())
            //    .Returns(_itemList);

            itemSpawner.When(x => x.AddList())
                .Do(Callback.Always(x => _itemCollection.Add((ItemList)An.ItemList)));

            //itemSpawner.AddList(Arg.Any<List<IItemList>>())
            //    .Returns(_itemCollection);

            return itemSpawner;
        }

    }
}
