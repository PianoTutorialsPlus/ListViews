using System;
using System.Collections.Generic;

namespace ListViews.Model.Contracts
{
    public interface IListScreenModel
    {
        List<string> ItemList { get; }
        List<string> CollectionList { get; }

        event Action OnRefreshedItemList;
        event Action OnRefreshedCollectionList;

        void AddItem();
        void AddList();
        void DeleteItem(int itemIndex);
        void DeleteList(int listIndex);
        void ShowItemList(int listIndex);
    }
}
