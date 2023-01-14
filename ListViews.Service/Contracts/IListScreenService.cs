﻿using ListViews.Model.Contracts;
using System;
using System.Collections.Generic;

namespace ListViews.Service.Contracts
{
    public interface IListScreenService
    {
        void AddItem();
        void AddList();
        void DeleteItem(int itemIndex);
        void DeleteList(int listIndex);
        IEnumerable<IItem> GetAllItems();
        IEnumerable<IItemList> GetAllLists();
        void LoadFile();
        void SaveFile();
        void SetListFromColletionId(int listIndex);
    }
}
