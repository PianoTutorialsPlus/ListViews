using ListViews.Model;
using ListViews.Model.Contracts;
using ListViews.Service.Contracts;
using ListViews.Service.UI;
using ListViews.View.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListViews.Presenter.UI
{
    public class ListScreenPresenter
    {
        private IListScreenService _listScreenService;
        private IListScreenView _listScreenView;

        public ListScreenPresenter(
            IListScreenService listScreenService, 
            IListScreenView listScreenView)
        {
            _listScreenService = listScreenService;
            _listScreenView = listScreenView;

            ConnectEvents();

            RefreshItemList();
            RefreshCollectionList();
        }

        private void ConnectEvents()
        {
            _listScreenView.OnAddedList += AddList;
            _listScreenView.OnDeletedList += DeleteList;

            _listScreenView.OnAddedItem += AddItem;
            _listScreenView.OnDeletedItem += DeleteItem;

            _listScreenView.OnShowedItemList += ShowItemList;
            _listScreenView.OnSavedFile += _listScreenService.SaveFile;

        }

        private void ShowItemList(int index)
        {
            _listScreenService.SetListFromColletionId(index);
            RefreshItemList();
        }

        private void DeleteItem(int index)
        {
            _listScreenService.DeleteItem(index);
            RefreshItemList();
        }

        private void AddItem()
        {
            _listScreenService.AddItem();
            RefreshItemList();
        }

        private void DeleteList(int index)
        {
            _listScreenService.DeleteList(index);
            RefreshItemList();
            RefreshCollectionList();
        }

        private void AddList()
        {
            _listScreenService.AddList();
            RefreshCollectionList();
        }

        public void RefreshCollectionList()
        {
             var itemCollectionList = _listScreenService.GetAllLists();
            _listScreenView.CollectionList = itemCollectionList != null
                ? itemCollectionList.Select(itemList => itemList.Name).ToList()
                : new List<string>();
    }

        public void RefreshItemList()
        {
            var itemList = (List<IItem>)_listScreenService.GetAllItems();
            _listScreenView.ItemList = itemList != null
            ? itemList.Select(itemName => itemName.Name).ToList()
            : new List<string>();

            //_listScreenView.TextboxItemCount = (itemList.Count > 0) ? itemList.Count.ToString(): 0.ToString();
        }

        public void Show()
        {
            _listScreenView.Show();
        }
        public void LoadFile()
        {
            _listScreenService.LoadFile();
        }
       
    }
}
