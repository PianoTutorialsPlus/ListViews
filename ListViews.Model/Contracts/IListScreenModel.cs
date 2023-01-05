using System;
using System.Collections.Generic;

namespace ListViews.Model.Contracts
{
    public interface IListScreenModel
    {
        event Action<List<string>> OnRefreshedItemList;

        void AddItem();
        void DeleteItem(int itemIndex);
    }
}
