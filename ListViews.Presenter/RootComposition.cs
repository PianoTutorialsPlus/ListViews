using ListViews.Model.Contracts;
using ListViews.Presenter.Factories;
using ListViews.Presenter.UI;
using ListViews.Service.UI;
using ListViews.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListViews.Presenter
{
    public class RootComposition
    {
        private Settings _settings;
        private ItemSpawner _itemSpawner;
        private ListScreenFacade _listScreenPresenter;
        private FormMainScreen _mainScreenView;
        private MainScreenFacade _mainScreenPresenter;
        private FormListScreen _listScreenView;

        public RootComposition()
        {
            Main();
        }

        void Main()
        {
            SetupSpawner();
            SetupSettings();
            SetupListScreen();
            SetupMainScreen();

            Application.Run(_mainScreenView);
        }

        private void SetupSettings()
        {
            _settings = new Settings();
            _settings.ListScreenModelHandler = new ListScreenService.Settings();
            _settings.ListScreenModelHandler.ItemListCollection = _itemSpawner.SpawnList(new List<IItemList>());

        }
        private void SetupSpawner()
        {
            _itemSpawner = new ItemSpawner();
        }
        private void SetupListScreen()
        {
            _listScreenView = new FormListScreen();
            ListScreenService listScreenModel = new ListScreenService(_settings.ListScreenModelHandler,_itemSpawner);
            _listScreenPresenter = new ListScreenFacade(listScreenModel, _listScreenView);

            //Application.Run(listScreenView);
        }

        private void SetupMainScreen()
        {
            _mainScreenView = new FormMainScreen();
            _mainScreenPresenter = new MainScreenFacade(_mainScreenView, _listScreenPresenter);

        }

        [Serializable]
        public class Settings
        {
            public ListScreenService.Settings ListScreenModelHandler;
        }
    }
}