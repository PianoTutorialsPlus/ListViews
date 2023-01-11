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
        private ListScreenFacade _listScreenPresenter;

        public MainScreenFacade(
            IMainScreenView mainScreenView, 
            ListScreenFacade listScreenPresenter)
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
        }

        public void ActivateListScreen()
        {
            _listScreenPresenter.Show();
            //_mainScreenView.Hide();
        }
    }
}
