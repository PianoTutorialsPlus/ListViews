﻿using ListViews.Model.Contracts;
using ListViews.Model.UI;
using System;
using System.Collections.Generic;

namespace ListViews.Tests.Infrastructure.ListScreen
{
    public class ListScreenModelBuilder : TestDataBuilder<ListScreenModel>
    {
        private IItemSpawner _itemSpawner;
        private List<List<IItem>> _itemCollectionList;

        public ListScreenModelBuilder() : this(An.IItemSpawner.Build(),new List<List<IItem>>())
        {
        }

        public ListScreenModelBuilder(
            IItemSpawner itemSpawner, 
            List<List<IItem>> itemCollectionList)
        {
            _itemSpawner = itemSpawner;
            _itemCollectionList = itemCollectionList;
        }

        public ListScreenModelBuilder WithIItemSpawner(IItemSpawner itemSpawner)
        {
            _itemSpawner = itemSpawner;
            return this;
        }
        public ListScreenModelBuilder WithItemCollectionList(List<List<IItem>> itemCollectionList)
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
