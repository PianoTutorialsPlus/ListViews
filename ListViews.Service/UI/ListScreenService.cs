using ListViews.Model;
using ListViews.Model.Contracts;
using ListViews.Service.Common_Services;
using ListViews.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListViews.Service.UI
{
    public class ListScreenService : IListScreenService
    {
        private IItemsRepository _itemsRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public ListScreenService(
            IItemsRepository itemsRepository,
            IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _itemsRepository = itemsRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }
        public void AddList(IItemList itemList)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(itemList);
            _itemsRepository.AddList(itemList);
        }

        public void DeleteList(int listIndex) => _itemsRepository.DeleteList(listIndex);
        public void AddItem(IItem item)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(item);
            _itemsRepository.AddItem(item);
        }

        public void DeleteItem(int itemIndex) => _itemsRepository.DeleteItem(itemIndex);
        public void SetListFromColletionId(int listIndex) => _itemsRepository.SetListFromCollectionId(listIndex);
        public void SaveFile() => _itemsRepository.SaveFile();
        public void LoadFile() => _itemsRepository.LoadFile();
        public IEnumerable<IItemList> GetAllLists() => _itemsRepository.GetAllLists();
        public IEnumerable<IItem> GetAllItems() => _itemsRepository.GetAllItems();
        public Item CreateNewItem() => _itemsRepository.NewItem;
        public ItemList CreateNewItemList() => _itemsRepository.NewItemList;

        //[Serializable]
        //public class Settings
        //{
        //    public List<IItemList> ItemListCollection;
        //}
    }
}
