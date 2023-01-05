using ListViews.Model.Contracts;
using ListViews.View.Contracts;
using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ListViews.Presenter.UI
{
    public class ListScreenFacade
    {
        private IListScreenModel _listScreenModel;
        private IListScreenView _listScreenView;

        public ListScreenFacade(
            IListScreenModel listScreenModel, 
            IListScreenView listScreenView)
        {
            _listScreenModel = listScreenModel;
            _listScreenView = listScreenView;

            ConnectEvents();
        }

        private void ConnectEvents()
        {
            _listScreenView.OnAddedItem += _listScreenModel.AddItem;
            _listScreenView.OnDeletedItem += _listScreenModel.DeleteItem;
            _listScreenModel.OnRefreshedItemList += RefreshItemList;
        }

        private void RefreshItemList(List<string> itemList)
        {
            _listScreenView.ItemList = itemList;
            _listScreenView.TextboxItemCount = itemList.Count.ToString();
        }
    }
}
