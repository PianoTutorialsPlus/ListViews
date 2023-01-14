using ListViews.Model.Contracts;
using ListViews.Service.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ListViews.Service.UI
{
    public class ListScreenService : IListScreenService
    {
        private Settings _settings;
        private IItemsRepository _itemsRepository;
      
        public ListScreenService(
            Settings settings,
            IItemsRepository itemsRepository
            )
        {
            _settings = settings;
            _itemsRepository = itemsRepository;
            //_itemCollectionList = _settings.ItemListCollection;
            //_itemList = _itemCollectionList[0];
        }
        public void AddList() => _itemsRepository.AddList();
        public void DeleteList(int listIndex) => _itemsRepository.DeleteList(listIndex);
        public void AddItem() => _itemsRepository.AddItem();
        public void DeleteItem(int itemIndex) => _itemsRepository.DeleteItem(itemIndex);
        public void SetListFromColletionId(int listIndex) => _itemsRepository.SetListFromCollectionId(listIndex);

        public void SaveFile() => _itemsRepository.SaveFile();

        public void LoadFile() => _itemsRepository.LoadFile();

        public IEnumerable<IItemList> GetAllLists() => _itemsRepository.GetAllLists();

        public IEnumerable<IItem> GetAllItems() => _itemsRepository.GetAllItems();

        [Serializable]
        public class Settings
        {
            public List<IItemList> ItemListCollection;
        }
    }
}
