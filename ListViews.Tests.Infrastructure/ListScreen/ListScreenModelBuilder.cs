using ListViews.Model.Contracts;
using ListViews.Model.UI;
using ListViews.Presenter;
using System;
using System.Collections.Generic;

namespace ListViews.Tests.Infrastructure.ListScreen
{
    public class ListScreenModelBuilder : TestDataBuilder<ListScreenModel>
    {
        private IItemSpawner _itemSpawner;
        private ListScreenModel.Settings _settings = new ListScreenModel.Settings();

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

        public override ListScreenModel Build()
        {
            return new ListScreenModel(_settings,_itemSpawner);
        }

    }
}
