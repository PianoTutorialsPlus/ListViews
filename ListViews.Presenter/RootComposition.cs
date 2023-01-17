using ListViews.Model;
using ListViews.Model.Contracts;
using ListViews.Presenter.UI;
using ListViews.Repository;
using ListViews.Service.Common_Services;
using ListViews.Service.Contracts;
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
        private ItemsRepository _itemSpawner;
        private ListScreenPresenter _listScreenPresenter;
        private FormMainScreen _mainScreenView;
        private MainScreenFacade _mainScreenPresenter;
        private ListScreenView _listScreenView;
        private ModelDataAnnotationCheck _modelDataAnnotationCheck;

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
            //_settings.ListScreenModelHandler = new ListScreenService.Settings();
            //var listCollection = new ItemList();
            //_itemSpawner.AddList(listCollection);
            _modelDataAnnotationCheck = new ModelDataAnnotationCheck();
            //_settings.ListScreenModelHandler.ItemListCollection = listCollection;

        }
        private void SetupSpawner()
        {
            _itemSpawner = new ItemsRepository();
        }
        private void SetupListScreen()
        {
            _listScreenView = new ListScreenView();
            ListScreenService listScreenModel = new ListScreenService(_itemSpawner,_modelDataAnnotationCheck);
            _listScreenPresenter = new ListScreenPresenter(listScreenModel, _listScreenView);

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
            //public ListScreenService.Settings ListScreenModelHandler;
        }
    }
}