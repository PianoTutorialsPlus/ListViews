﻿using ListViews.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListViews.Model.UI
{
    public class ListScreenModel : IListScreenModel
    {
        private IItemSpawner _itemSpawner;
        private List<IItem> _itemList;
        private List<List<IItem>> _itemCollectionList; 

        public event Action<List<string>> OnRefreshedItemList;

        public ListScreenModel(
            IItemSpawner itemSpawner, 
            List<List<IItem>> itemCollectionList)
        {
            _itemSpawner = itemSpawner;
            _itemCollectionList = itemCollectionList;
            _itemList = itemCollectionList[0];
        }

        public void AddItem()
        {
            _itemList = _itemSpawner.Spawn(_itemList);

            AddItemNamesFromList();
        }

        public void DeleteItem(int itemIndex)
        {
            if(itemIndex < 0 || _itemList.Count < itemIndex)
                throw new ArgumentOutOfRangeException("index");

            _itemList.RemoveAt(itemIndex);
            AddItemNamesFromList();
        }

        private void AddItemNamesFromList()
        {
            OnRefreshedItemList?.Invoke(_itemList.Select(itemName => itemName.Name).ToList());
        }
    }
}
