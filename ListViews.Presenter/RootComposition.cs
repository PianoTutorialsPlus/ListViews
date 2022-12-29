using ListViews.Model.Contracts;
using ListViews.Model.UI;
using ListViews.Presenter.Factories;
using ListViews.Presenter.UI;
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

        public RootComposition()
        {
            Main();
        }

        void Main()
        {
            SetupSettings();
            SetupSpawner();
            SetupListScreen();
            FormMainScreen mainScreen = new FormMainScreen();

           // Application.Run(mainScreen);
        }


        private void SetupSettings()
        {
            _settings = new Settings();
            _settings.ItemList = new List<IItem>();
            _settings.ItemCollectionList = new List<List<IItem>>
            {
                _settings.ItemList
            };
        }
        private void SetupSpawner()
        {
            _itemSpawner = new ItemSpawner();
        }

        private void SetupListScreen()
        {
            FormListScreen listScreenView = new FormListScreen();
            ListScreenModel listScreenModel = new ListScreenModel(_itemSpawner, _settings.ItemCollectionList);
            _listScreenPresenter = new ListScreenFacade(listScreenModel, listScreenView);

            Application.Run(listScreenView);
        }

        [Serializable]
        public class Settings
        {
            public List<IItem> ItemList { get; internal set; }
            public List<List<IItem>> ItemCollectionList { get; internal set; }
        }
    }
}