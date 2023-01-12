using ListViews.Model.Contracts;
using ListViews.Service.Contracts;
using ListViews.View.Contracts;
using System;
using System.Collections.Generic;

namespace ListViews.Presenter.UI
{
    public class ListScreenFacade
    {
        private IListScreenService _listScreenModel;
        private IListScreenView _listScreenView;

        public ListScreenFacade(
            IListScreenService listScreenModel, 
            IListScreenView listScreenView)
        {
            _listScreenModel = listScreenModel;
            _listScreenView = listScreenView;

            ConnectEvents();

            RefreshItemList();
            RefreshCollectionList();
        }

        private void ConnectEvents()
        {
            _listScreenView.OnAddedList += _listScreenModel.AddList;
            _listScreenView.OnDeletedList += _listScreenModel.DeleteList;
            _listScreenModel.OnRefreshedCollectionList += RefreshCollectionList;

            _listScreenView.OnAddedItem += _listScreenModel.AddItem;
            _listScreenView.OnDeletedItem += _listScreenModel.DeleteItem;
            _listScreenModel.OnRefreshedItemList += RefreshItemList;

            _listScreenView.OnShowedItemList += _listScreenModel.ShowItemList;
            _listScreenView.OnSavedFile += _listScreenModel.SaveFile;

        }


        private void RefreshCollectionList()
        {
            _listScreenView.CollectionList = _listScreenModel.CollectionList;
        }

        public void RefreshItemList()
        {
            _listScreenView.ItemList = _listScreenModel.ItemList;

            _listScreenView.TextboxItemCount = (_listScreenModel.ItemList.Count > 0) ? _listScreenModel.ItemList.Count.ToString(): 0.ToString();
        }

        public void Show()
        {
            _listScreenView.Show();
        }
        public void LoadFile()
        {
            _listScreenModel.LoadFile();
        }
       
    }
}
