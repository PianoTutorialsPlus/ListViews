using System;
using System.Collections.Generic;

namespace ListViews.Model.Contracts
{
    public interface IListScreenModel
    {
        List<string> ItemList { get; }

        event Action OnRefreshedItemList;

        void AddItem();
        void DeleteItem(int itemIndex);
    }
}
