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
        private List<IItemList> _itemCollectionList;

        public ListScreenModelBuilder() : this(An.IItemSpawner.Build(),new List<IItemList>() { new ItemList()})
        {
        }

        public ListScreenModelBuilder(
            IItemSpawner itemSpawner, 
            List<IItemList> itemCollectionList)
        {
            _itemSpawner = itemSpawner;
            _itemCollectionList = itemCollectionList;
        }

        public ListScreenModelBuilder WithIItemSpawner(IItemSpawner itemSpawner)
        {
            _itemSpawner = itemSpawner;
            return this;
        }
        public ListScreenModelBuilder WithItemCollectionList(List<IItemList> itemCollectionList)
        {
            _itemCollectionList = itemCollectionList;
            _itemCollectionList.Add(new ItemList());
            return this;
        }
        public ListScreenModelBuilder WithItemList(ItemList itemList)
        {
            _itemCollectionList[0] = itemList;
            return this;
        }
        public ListScreenModel WithItemListCollection(List<IItemList> itemCollectionList)
        {
            _itemCollectionList = itemCollectionList;
            return this;
        }

        public override ListScreenModel Build()
        {
            return new ListScreenModel(_itemSpawner, _itemCollectionList);
        }

    }
}
