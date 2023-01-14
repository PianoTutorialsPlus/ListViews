using ListViews.View.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Presenter.UI
{
    public class MainScreenFacade
    {
        private IMainScreenView _mainScreenView;
        private ListScreenPresenter _listScreenPresenter;

        public MainScreenFacade(
            IMainScreenView mainScreenView, 
            ListScreenPresenter listScreenPresenter)
        {
            _mainScreenView = mainScreenView;
            _listScreenPresenter = listScreenPresenter;

            ConnectEvents();
        }

        private void ConnectEvents()
        {
            _mainScreenView.OnLoadedFile += LoadFile;
            _mainScreenView.OnNewListCreated += ActivateListScreen;
        }

        private void LoadFile()
        {
            _listScreenPresenter.LoadFile();
            ActivateListScreen();
            _listScreenPresenter.RefreshCollectionList();
        }

        public void ActivateListScreen()
        {
            _listScreenPresenter.Show();
            //_mainScreenView.Hide();
        }
    }
}
