using System;
using System.Collections.Generic;

namespace ListViews.Service.Contracts
{
    public interface IListScreenService
    {
        List<string> ItemList { get; }
        List<string> CollectionList { get; }

        event Action OnRefreshedItemList;
        event Action OnRefreshedCollectionList;

        void AddItem();
        void AddList();
        void DeleteItem(int itemIndex);
        void DeleteList(int listIndex);
        void LoadFile();
        void SaveFile();
        void ShowItemList(int listIndex);
    }
}
