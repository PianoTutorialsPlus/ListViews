using ListViews.Model.Contracts;
using ListViews.Presenter;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure.Factories
{
    public class IItemSpawnerBuilder : TestDataBuilder<IItemSpawner>
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

        public override IItemSpawner Build()
        {
            var itemSpawner = Substitute.For<IItemSpawner>();

            itemSpawner.When(x => x.SpawnItem(Arg.Any<IItemList>()))
                .Do(Callback.Always(x => _itemList.Items.Add((Item)An.Item)));

            itemSpawner.SpawnItem(Arg.Any<ItemList>())
                .Returns(_itemList);

            itemSpawner.When(x => x.SpawnList(Arg.Any<List<IItemList>>()))
                .Do(Callback.Always(x => _itemCollection.Add((ItemList)An.ItemList)));

            itemSpawner.SpawnList(Arg.Any<List<IItemList>>())
                .Returns(_itemCollection);

            return itemSpawner;
        }

    }
}
