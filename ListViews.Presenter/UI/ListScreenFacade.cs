using ListViews.Model.Contracts;
using ListViews.View.Contracts;
using System.Collections.Generic;

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

        public void RefreshItemList()
        {

            _listScreenView.ItemList = _listScreenModel.ItemList;

            _listScreenView.TextboxItemCount = (_listScreenModel.ItemList.Count > 0) ? _listScreenModel.ItemList.Count.ToString(): 0.ToString();
        }
    }
}
