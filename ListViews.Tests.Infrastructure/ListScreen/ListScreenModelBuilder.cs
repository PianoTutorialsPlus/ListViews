using ListViews.Model;
using ListViews.Model.Contracts;
using ListViews.Service.UI;
using System.Collections.Generic;

namespace ListViews.Tests.Infrastructure.ListScreen
{
    public class ListScreenModelBuilder : TestDataBuilder<ListScreenService>
    {
        private IItemSpawner _itemSpawner;
        private ListScreenService.Settings _settings = new ListScreenService.Settings();

        public ListScreenModelBuilder() : this(An.IItemSpawner.Build(),new List<IItemList>() { (ItemList)An.ItemList})
        {
        }

        public ListScreenModelBuilder(
            IItemSpawner itemSpawner, 
            List<IItemList> itemCollectionList)
        {
            _itemSpawner = itemSpawner;
            _settings.ItemListCollection = itemCollectionList;
        }

        public ListScreenModelBuilder WithIItemSpawner(IItemSpawner itemSpawner)
        {
            _itemSpawner = itemSpawner;
            return this;
        }
        public ListScreenModelBuilder WithItemCollectionList(List<IItemList> itemCollectionList)
        {
            _settings.ItemListCollection = itemCollectionList;
            _settings.ItemListCollection.Add((ItemList)An.ItemList);
            return this;
        }
        public ListScreenModelBuilder WithItemList(ItemList itemList)
        {
            _settings.ItemListCollection[0] = itemList;
            return this;
        }
        public ListScreenModelBuilder WithItemListCollection(List<IItemList> itemCollectionList)
        {
            _settings.ItemListCollection = itemCollectionList;
            return this;
        }

        public override ListScreenService Build()
        {
            return new ListScreenService(_settings,_itemSpawner);
        }

    }
}
