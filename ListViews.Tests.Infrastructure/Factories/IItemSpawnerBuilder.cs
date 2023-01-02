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
        private List<IItem> _itemList;

        public IItemSpawnerBuilder()
        {
            _itemList = new List<IItem>();
        }

        public IItemSpawnerBuilder WithItemlist(List<IItem> itemList)
        {
            _itemList = itemList;

            return this;
        }

        public override IItemSpawner Build()
        {
            var itemSpawner = Substitute.For<IItemSpawner>();

            itemSpawner.When(x => x.Spawn(Arg.Any<List<IItem>>()))
                .Do(Callback.Always(x => _itemList.Add(new Item())));

            itemSpawner.Spawn(Arg.Any<List<IItem>>())
                .Returns(_itemList);

            return itemSpawner;
        }
    }
}
