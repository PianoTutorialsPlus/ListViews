using ListViews.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Service.Contracts
{
    public interface IItemsRepository
    {
        void DeleteItem(int itemIndex);
        void DeleteList(int listIndex);
        IEnumerable<IItem> GetAllItems();
        IEnumerable<IItemList> GetAllLists();
        void SetListFromCollectionId(int listIndex);
        void AddItem();
        void AddList();
        void SaveFile();
        void LoadFile();
    }
}
